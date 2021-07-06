namespace PGA
{
    public abstract class BaseShape : IShape
    {

        public IMaterial Material { get; set; }

        public Vector Position { get; set; }

        public BaseShape()
        {
            Position = new Vector(0,0,0);
            Material = new SolidMaterial(new Color(1, 0, 1), 0, 0, 0);
        }

        public abstract IntersectInfo Intersect(Ray ray);
    }
}
