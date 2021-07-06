using System;
using System.Collections.Generic;

namespace PGA
{
    public class Lights : List<Light>
    {
    }

    public class Light
    {
        public Vector Position { get; set; }
        public Color Color { get; set; }
        public double strength { get; set; }

        public Light(Vector pos, Color color)
        {
            Position = pos;
            Color = color;
            strength = 10;
        }

        public double Strength(double distance)
        {
            if (distance >= strength) return 0;

            return Math.Pow((strength - distance) / strength, .7);
        }
        public override string ToString()
        {
            return $"Light ({Position.x},{Position.y},{Position.z})";
        }
    }
}
