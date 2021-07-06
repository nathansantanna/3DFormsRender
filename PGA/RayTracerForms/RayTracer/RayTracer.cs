using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using PGA.Filters;

namespace PGA
{
    public delegate void RenderUpdateDelegate(int scanline);

    public class RayTracer
    {
        private readonly ImageProcess _imageProcess;
        public bool RenderDiffuse { get; set; }
        public bool RenderHighlights { get; set; }
        public bool RenderShadow { get; set; }
        public bool RenderReflection { get; set; }
        public bool RenderRefraction { get; set; }
        public bool RenderCellShading { get; set; }

        public RayTracer() : this(true, true, true, true, true, true)
        {
        }

        public RayTracer(bool renderDiffuse, bool renderHighlights, bool renderShadow, bool renderReflection, bool renderRefraction,bool renderCellShading)
        {
            //_imageProcess = new ImageProcess();
            RenderDiffuse = renderDiffuse;
            RenderHighlights = renderHighlights;
            RenderShadow = renderShadow;
            RenderReflection = renderReflection;
            RenderRefraction = renderRefraction;
            RenderCellShading = renderCellShading;
        }

        public Color CalculateColor(Ray ray, Scene scene)
        {
            IntersectInfo info = TestIntersection(ray, scene, null);
            if (info.IsHit)
            {
                // execute the actual raytrace algorithm
                Color c = RayTrace(info, ray, scene, 0);
                return c;
            }

            return scene.Background.Color;

        }

        private Color RayTrace(IntersectInfo info, Ray ray, Scene scene, int depth)
        {
            // calculate ambient light
            Color color = info.Color * scene.Background.Ambience;
            double shininess = Math.Pow(10, info.Element.Material.Gloss + 1);

            foreach (Light light in scene.Lights)
            {

                // calculate diffuse lighting
                Vector v = (light.Position - info.Position).Normalize();
                double intensity = v.Dot(info.Normal);
                if (RenderDiffuse)
                {
                   
                    if (intensity > 0.0f)
                    {
                        var DiffuseColor = info.Color * light.Color ;
                        if (RenderCellShading)
                            color += color.Normalize(DiffuseColor, intensity);
                        else
                            color += DiffuseColor * intensity;
                    }
                }

                // Depth
                if (depth < 50)
                {

                    // reflection ray
                    if (RenderReflection && info.Element.Material.Reflection > 0)
                    {
                        Ray reflectionray = GetReflectionRay(info.Position, info.Normal, ray.Direction);
                        IntersectInfo refl = TestIntersection(reflectionray, scene, info.Element);
                        if (refl.IsHit && refl.Distance > 0)
                        {
                            refl.Color = RayTrace(refl, reflectionray, scene, depth + 1);
                        }
                        else //reflect background 
                            refl.Color = scene.Background.Color;
                        color = color.Blend(refl.Color, info.Element.Material.Reflection);
                    }

                    //calculate refraction ray
                    if (RenderRefraction && info.Element.Material.Transparency > 0)
                    {
                        Ray refractionray = GetRefractionRay(info.Position, info.Normal, ray.Direction, info.Element.Material.Refraction);
                        IntersectInfo refr = info.Element.Intersect(refractionray);
                        if (refr.IsHit)
                        {
                            //refractionray = new Ray(refr.Position, ray.Direction);
                            refractionray = GetRefractionRay(refr.Position, refr.Normal, refractionray.Direction, refr.Element.Material.Refraction);
                            refr = TestIntersection(refractionray, scene, info.Element);
                            if (refr.IsHit && refr.Distance > 0)
                            {
                                // recursive call, this makes refractions expensive
                                refr.Color = RayTrace(refr, refractionray, scene, depth + 1);
                            }
                            else
                                refr.Color = scene.Background.Color;
                        }
                        else
                            refr.Color = scene.Background.Color;
                        color = color.Blend(refr.Color, info.Element.Material.Transparency);
                    }
                }

                IntersectInfo shadow = new IntersectInfo();
                if (RenderShadow)
                {
                    // calculate shadow, create ray from intersection point to light
                    Ray shadowray = new Ray(info.Position, v);

                    // find any element in between intersection point and light
                    shadow = TestIntersection(shadowray, scene, info.Element);
                    // verifies if the element is itself
                    if (shadow.IsHit && shadow.Element != info.Element)
                    {

                        //shadow with transparency
                        double transparencyContribution = Math.Pow(shadow.Element.Material.Transparency, 0.5);
                       
                        
                        //soft shadow finding the distance between the element and the shadow
                        double d = (shadow.Position - info.Position).Magnitude();

                        double linearMitigation = 1 / (d * d);
                        //var centerDistance = (info.Position - info.Element.Position).Magnitude();
                        double totalMitigation = linearMitigation * intensity;
                        color *= 0.5 + (0.5 * transparencyContribution);
                        color *= 1 - (totalMitigation);

                    }
                }

                // show highlights if it is not in the shadow of another object
                if (RenderHighlights && !shadow.IsHit && info.Element.Material.Gloss > 0)
                {
                    // Phong
                    Vector lv = (info.Element.Position - light.Position).Normalize();
                    Vector e = (scene.Camera.Position - info.Element.Position).Normalize();
                    Vector h = (e - lv).Normalize();

                    double Glossweight = 0.0;
                    Glossweight = Math.Pow(Math.Max(info.Normal.Dot(h), 0), shininess);
                    color += light.Color * (Glossweight);
                }
            }

            color.Limit();
            return color;
        }

        private IntersectInfo TestIntersection(Ray ray, Scene scene, IShape exclude)
        {
            int hitcount = 0;
            IntersectInfo best = new IntersectInfo { Distance = double.MaxValue };

            foreach (IShape elt in scene.Shapes)
            {
                if (elt == exclude)
                    continue;

                IntersectInfo info = elt.Intersect(ray);
                if (info.IsHit && info.Distance < best.Distance && info.Distance >= 0)
                {
                    best = info;
                    hitcount++;
                }
            }
            best.HitCount = hitcount;
            return best;
        }

        private Ray GetReflectionRay(Vector position, Vector normal, Vector direction)
        {
            double c1 = -normal.Dot(direction);
            Vector Rl = direction + (normal * 2 * c1);
            return new Ray(position, Rl);
        }

        private Ray GetRefractionRay(Vector position, Vector Normal, Vector direction, double refraction)
        {
            double c1 = Normal.Dot(direction);
            double c2 = 1 - refraction * refraction * (1 - c1 * c1);

            if (c2 < 0)
                c2 = Math.Sqrt(c2);

            Vector T = (Normal * (refraction * c1 - c2) - direction * refraction) * -1;
            T.Normalize();

            return new Ray(position, T);
        }
    }
}
