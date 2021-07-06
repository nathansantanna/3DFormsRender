namespace PGA
{
    public class ChessboardMaterial : BaseMaterial
    {

        public Color ColorEven;
        public Color ColorOdd;
        public double Density;

        public ChessboardMaterial(Color coloreven, Color colorodd, double reflection, double transparency, double gloss, double density)
        {
            ColorEven = coloreven;
            ColorOdd = colorodd;
            Reflection = reflection;
            Transparency = transparency;
            Gloss = gloss;
            Density = density;
        }

        public override bool HasTexture
        {
            get { return true; }
        }

        public override Color GetColor(double u, double v)
        {
            double t = WrapUp(u) * WrapUp(v);

            if (t < 0.0)
                return ColorEven;
            return ColorOdd;
        }
    }
}
