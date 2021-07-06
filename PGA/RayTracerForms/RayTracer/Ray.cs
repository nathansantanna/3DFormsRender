namespace PGA
{
    public class IntersectInfo
    {
        public bool IsHit; 
        public int HitCount; 
        public IShape Element; 
        public Vector Position; 
        public Vector Normal; 
        public Color Color; 
        public double Distance; 
    }

    public class Ray
    {
        public readonly Vector Position;
        public readonly Vector Direction;

        public Ray(Vector position, Vector direction)
        {
            Position = position;
            Direction = direction;
        }
    }
}
