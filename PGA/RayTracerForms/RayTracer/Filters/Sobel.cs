using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PGA.Filters
{
    public class Sobel : IFilter
    {
        public Sobel()
        {
            double minFactor =1;
            double maxFactor =2;
            XMatrix = new[,]{
                { -minFactor, 0.0, minFactor },
                { -maxFactor, 0.0, maxFactor },
                { -minFactor, 0.0, minFactor }
            };
            YMatrix = new[,]{
                { minFactor, maxFactor, minFactor },
                {  0.0,  0.0,  0.0 },
                {  -minFactor,  -maxFactor,  -minFactor }
            };
            Width = 2;
            Heigth = 2;
        }

        public double[,] XMatrix { get; set; }
        public double[,] YMatrix { get; set; }
        public uint Width { get; set; }
        public uint Heigth { get; set; }

        public Color Render(int x, int y, Color[,] image, ImageProcess imageProcess)
        {
            double xComponent = 0.0,yComponent = 0.0;
            for (int filterY = 0; filterY <= Heigth; filterY++)
            {
                for (int filterX = 0; filterX <= Width; filterX++)
                {
                    int imageX = x + (filterX - 1);
                    int imageY = y + (filterY - 1);

                    var pixelColor = ToGrayScale(image[imageX, imageY]);

                    xComponent +=   pixelColor.Red * XMatrix[filterX,filterY];
                    yComponent += pixelColor.Red * YMatrix[filterX,filterY];
                }
            }

            var baselResult = Math.Sqrt((xComponent*xComponent) + (yComponent*yComponent) );
            var returnColor = new Color(baselResult, baselResult, baselResult);

            returnColor.Limit();
            return returnColor;
        }

        public Color ToGrayScale(Color pixel)
        {
            var grey =pixel.Red  * 0.27 +
                      pixel.Green * 0.66 +
                      pixel.Blue * 0.06;
            return(new Color(grey,grey,grey));
        }
    }
    
}
