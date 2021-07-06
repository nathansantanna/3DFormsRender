using System;
using System.Drawing;

namespace PGA
{
    public class Texture
    {
        public int Width;
        public int Height;
        public Color[,] ColorMap;

        public Texture(Color[,] colormap)
        {
            Width = colormap.GetLength(0);
            Height = colormap.GetLength(1);
            ColorMap = colormap;
        }

        //creates a 'ColorMap' of the bitmap
        // lookuptable, used to enhance the performance
        public static Texture FromBitmap(Bitmap bm)
        {

            Color[,] colormap = new Color[bm.Width, bm.Height];
            Texture texture = new Texture(colormap);

            for (int y = 0; y < texture.Height; y++)
            {
                for (int x = 0; x < texture.Width; x++)
                {
                    System.Drawing.Color pix = bm.GetPixel(x, y); 
                    Color c = new Color(pix.R / 255.0, pix.G / 255.0, pix.B / 255.0);
                    colormap[x, y] = c;
                }
            }
            return texture;
        }

        public static Texture FromFile(string filename)
        {
            Image image = Image.FromFile(filename);
            Bitmap bm = new Bitmap(image);
            return FromBitmap(bm);
        }
    }

    public class TextureMaterial : BaseMaterial
    {
        public readonly Texture Texture;
        public readonly double Density;

        public TextureMaterial(Texture texture, double reflection, double transparency, double gloss, double density)
        {
            Reflection = reflection;
            Transparency = transparency;
            Gloss = gloss;
            Density = density;
            Texture = texture;
        }

        public override bool HasTexture
        {
            get { return true; }
        }

        public override Color GetColor(double u, double v)
        {
            // map u, v to [0,2];
            u = WrapUp(u * Density) + 1;
            v = WrapUp(v * Density) + 1;

            // calculate exact position in texture
            double nu1 = u * Texture.Width / 2;
            double nv1 = v * Texture.Width / 2;

            // calculate fractions
            double fu = nu1 - Math.Floor(nu1);
            double fv = nv1 - Math.Floor(nv1);
            double w1 = (1 - fu) * (1 - fv);
            double w2 = fu * (1 - fv);
            double w3 = (1 - fu) * fv;
            double w4 = fu * fv;

            int nu2 = (int)(Math.Floor(nu1)) % Texture.Width;
            int nv2 = (int)(Math.Floor(nv1)) % Texture.Height;
            int nu3 = (int)(Math.Floor(nu1+1)) % Texture.Width;
            int nv3 = (int)(Math.Floor(nv1+1)) % Texture.Height;

            Color c1 = Texture.ColorMap[nu2, nv2];
            Color c2 = Texture.ColorMap[nu3, nv2];
            Color c3 = Texture.ColorMap[nu2, nv3];
            Color c4 = Texture.ColorMap[nu3, nv3];
            return c1 * w1 + c2 * w2 + c3 * w3 + c4 * w4;
        }
    }
}
