namespace PGA
{
    public class PlaneShape : BaseShape
    {
        public double D;
        public Color OddColor;

        public PlaneShape(Vector pos, double d, IMaterial material)
        {
            Position = pos;
            D = d;
            Material = material;
            
        }
        public PlaneShape(Vector pos, double d, Color color, Color oddcolor, double reflection, double transparency)
        {
            Position = pos;
            D = d;
            OddColor = oddcolor;
        }

        public override IntersectInfo Intersect(Ray ray)
        {

            IntersectInfo info = new IntersectInfo();
            double Vd = Position.Dot(ray.Direction);
            if (Vd == 0) return info;

            double t = -(Position.Dot(ray.Position) + D) / Vd;

            if (t <= 0) return info;

            info.Element = this;
            info.IsHit = true;
            info.Position = ray.Position + ray.Direction * t;
            info.Normal = Position;
            info.Distance = t;

            if (Material.HasTexture)
            {
                Vector vecU = new Vector(Position.y, Position.z, -Position.x);
                Vector vecV = vecU.Cross(Position);

                double u = info.Position.Dot(vecU);
                double v = info.Position.Dot(vecV);
                info.Color = Material.GetColor(u, v);
            }
            else
                info.Color = Material.GetColor(0, 0);

            return info;
        }

        public override string ToString()
        {
            return $"Sphere {Position.x}x+{Position.y}y+{Position.z}z+{D}=0)";
        }
    }
}
