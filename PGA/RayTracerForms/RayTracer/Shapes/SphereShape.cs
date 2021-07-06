using System;

namespace PGA
{
    public class SphereShape : BaseShape
    {
        public double R;
        public SphereShape(Vector pos, double r, IMaterial material)
        {
            R = r;
            Position = pos;
            Material = material;
        }

        #region IShape Members


        public override IntersectInfo Intersect(Ray ray)
        {
            IntersectInfo info = new IntersectInfo();
            info.Element = this;

            Vector dst = ray.Position - Position;
            double B = dst.Dot(ray.Direction);
            double C = dst.Dot(dst) - (R * R);
            double D = B * B - C;

            if (D > 0)
            {
                info.IsHit = true;
                info.Distance = -B - Math.Sqrt(D);
                info.Position = ray.Position + ray.Direction * info.Distance;
                info.Normal = (info.Position - Position).Normalize();

                if (Material.HasTexture)
                {
                    Vector vn = new Vector(0, 1, 0).Normalize(); 
                    Vector ve = new Vector(0, 0, 1).Normalize(); 
                    Vector vp = (info.Position - Position).Normalize() ; 
                    
                    double phi = Math.Acos(-vp.Dot(vn));
                    double v = (phi*2 / Math.PI)-1;

                    double sinPhi = ve.Dot(vp) / Math.Sin(phi);
                    sinPhi = sinPhi < -1 ? -1 : sinPhi > 1 ? 1 : sinPhi;
                    double theta = Math.Acos(sinPhi)*2 / Math.PI;

                    double u;

                    if (vn.Cross(ve).Dot(vp) > 0)
                        u = theta;
                    else
                        u = 1 - theta;

                    info.Color = Material.GetColor(u, v);
                }
                else
                {
                    info.Color = Material.GetColor(0, 0);
                }
            }
            else
            {
                info.IsHit = false;
            }
            return info;
        }
        #endregion

        public override string ToString()
        {
            return $"Sphere ({Position.x},{Position.y},{Position.z}) Radius: {R}";
        }

    }
}
