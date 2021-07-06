using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PGA.Filters
{
    public class HDR : IFilter
    {
        public HDR()
        {
            Width = 2;
            Heigth = 2;
        }

        public double[,] XMatrix { get; set; }
        public double[,] YMatrix { get; set; }
        public uint Width { get; set; }
        public uint Heigth { get; set; }


        public Color Render(int x, int y, Color[,] image, ImageProcess imageProcess)
        {
           
            double  sumRegion = 0;
            for (int filterY = 0; filterY <= Heigth; filterY++)
            {
                for (int filterX = 0; filterX <= Width; filterX++)
                {
                    int imageX = x + (filterX - 1);
                    int imageY = y + (filterY - 1);
                    var pixelColor = ToGrayScale(image[imageX, imageY]);
                    sumRegion += pixelColor.Blue;
                } 
            }
            double averageIntensity = sumRegion / 9;
            Color returnColor = new Color(image[x, y]);
            return  returnColor *= (1/averageIntensity) * ToGrayScale(image[x, y]).Red ;
        }

        public Color ToGrayScale(Color pixel)
        {
            var grey = pixel.Red  * 0.27 +
                      pixel.Green * 0.66 +
                      pixel.Blue * 0.06;
            return(new Color(grey,grey,grey));
        }
    }
}
