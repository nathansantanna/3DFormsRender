
namespace PGA
{
    public interface IMaterial
    {

        double Gloss { get; set; }

        // between 0 (opaque) and 1 (fully transparent);
        double Transparency { get; set; }

        //between 0 (no reflection) to 1 (total reflection/mirror)
        double Reflection { get; set; }


        // value must be between [0,1] (total reflection/)
        double Refraction { get; set; } 

        // u,v coordinates are to be by the element
        // and passed on in the GetColor function
        bool HasTexture { get; }

        //retrieves the actual color of the material the color can change depending on the u,v coordinates in the texture map
        Color GetColor(double u, double v);
    }

    public abstract class BaseMaterial : IMaterial
    {
        private double gloss;
        private double transparency;
        private double reflection;
        private double refraction;

        public double Reflection
        {
            get { return reflection; }
            set { reflection = value; }
        }

        public double Refraction
        {
            get { return refraction; }
            set { refraction = value; }
        }

        public double Transparency
        {
            get { return transparency; }
            set { transparency = value; }
        }

        public double Gloss
        {
            get { return gloss; }
            set { gloss = value; }
        }

        public abstract bool HasTexture { get; }
        public abstract Color GetColor(double u, double v);

        public BaseMaterial()
        {
            gloss = 2;
            transparency = 0;
            reflection = 0; 
            refraction = 0.50; 
        }

        // ex. -2.3 -> -0.3
        // <returns></returns>
        protected double WrapUp(double t)
        {
            t = t % 2.0;
            if (t < -1) t = t + 2.0;
            if (t >= 1) t -= 2.0;
            return t;
        }
    }
}
