using System;

namespace PGA
{
    public class Color
    {
        public double Red;
        public double Green;
        public double Blue;

        public Color()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        public Color(double r, double g, double b)
        {
            Red = r;
            Green = g;
            Blue = b;
        }

        public Color(Color col)
        {
            Red = col.Red;
            Green = col.Green;
            Blue = col.Blue;
        }

        public static Color operator +(Color c1, Color c2)
        {
            Color result = new Color();

            result.Red = c1.Red + c2.Red;
            result.Green = c1.Green + c2.Green;
            result.Blue = c1.Blue + c2.Blue;

            return result;
        }

        public static Color operator -(Color c1, Color c2)
        {
            Color result = new Color();

            result.Red = c1.Red - c2.Red;
            result.Green = c1.Green - c2.Green;
            result.Blue = c1.Blue - c2.Blue;

            return result;
        }

        public static Color operator *(Color c1, Color c2)
        {
            Color result = new Color();

            result.Red = c1.Red * c2.Red;
            result.Green = c1.Green * c2.Green;
            result.Blue = c1.Blue * c2.Blue;

            return result;
        }

        public static Color operator *(Color col, double f)
        {
            Color result = new Color
            {
                Red = col.Red * f,
                Green = col.Green * f,
                Blue = col.Blue * f
            };


            return result;
        }

        public static Color operator /(Color col, double f)
        {
            Color result = new Color
            {
                Red = col.Red / f,
                Green = col.Green / f,
                Blue = col.Blue / f
            };


            return result;
        }

        public void Limit()
        {
            Red = (Red > 0.0) ? ((Red > 1.0) ? 1.0f : Red) : 0.0f;
            Green = (Green > 0.0) ? ((Green > 1.0) ? 1.0f : Green) : 0.0f;
            Blue = (Blue > 0.0) ? ((Blue > 1.0) ? 1.0f : Blue) : 0.0f;
        }

        public void Limit(int minLimit, int maxLimit)
        {
            Red = (Red > minLimit) ? ((Red > maxLimit) ? maxLimit : Red) : minLimit;
            Green = (Green > minLimit) ? ((Green > maxLimit) ? maxLimit : Green) : minLimit;
            Blue = (Blue > minLimit) ? ((Blue > maxLimit) ? maxLimit : Blue) : minLimit;
        }

        public void ToBlack()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        public double Distance(Color color)
        {
            double dist = Math.Abs(Red - color.Red) + Math.Abs(Green - color.Green) + Math.Abs(Blue - color.Blue);
            return dist;
        }

        public Color Blend(Color other, double weight)
        {
            Color result = new Color(this);
            result = this * (1 - weight) + other * weight;
            return result;
        }

        public System.Drawing.Color ToArgb()
        {
            this.Limit();
            return System.Drawing.Color.FromArgb((int)(Red * 255), 
                (int)(Green * 255), 
                (int)(Blue * 255));
        }



        public Color Normalize(Color color,double intensity)
        {
            if (intensity > 0.95)
                color = new Color(1,1,1) * color;
            else if (intensity > 0.5)
                color = new Color(0.7,0.7,0.7) * color;
            else if (intensity > 0.05)
                color = new Color(0.35,0.35,0.35) * color;
            else
                color = new Color(0.1,0.1,0.1) * color;
            return color;
        }

        public override string ToString()
        {
            return $"r:{Red},g:{Green},b:{Blue}";
        }
    }
}
