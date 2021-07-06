namespace PGA
{
    public interface IShape
    {

        Vector Position { get; set; }

        IMaterial Material { get; set; }

        IntersectInfo Intersect(Ray ray);
    }
}