
namespace PGA
{
    public class SolidMaterial : BaseMaterial
    {
        private readonly Color color;
        public SolidMaterial(Color color, double reflection, double transparency, double gloss)
        {
            this.color = color;
            Reflection = reflection;
            Transparency = transparency;
            Gloss = gloss;

        }

        public override bool HasTexture => false;

        public override Color GetColor(double u, double v)
        {
            return color;
        }
    }
}
