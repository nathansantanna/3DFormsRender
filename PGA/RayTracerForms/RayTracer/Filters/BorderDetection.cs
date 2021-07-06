using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PGA;
using PGA.Filters;

namespace PGA.Filters
{
    public class BorderDetection : IFilter
    {
        public double[,] XMatrix { get; set; }
        public double[,] YMatrix { get; set; }
        public uint Width { get; set; }
        public uint Heigth { get; set; }
        private Color[,] _sobelImage;

        public BorderDetection()
        {
            Width = 2;
            Heigth = 2;
        }

        public Color Render(int x, int y, Color[,] image, ImageProcess imageProcess)
        {
            if (_sobelImage == null)
            {
                //image sobel without only with ambience 
                _sobelImage = new Color[image.GetLength(0), image.GetLength(1)];
                RayTracer r = new RayTracer(true, false, false, false, false, false);
                imageProcess.TargetRayTracer = r;
                Color[,] tempBuffer = new Color[image.GetLength(0), image.GetLength(1)];
                imageProcess.RenderImage(tempBuffer);
                imageProcess.ApplyFilters(tempBuffer,_sobelImage,new Sobel());
            }

            if (_sobelImage[x, y].Red == 1)
                return new Color(0, 0, 0);
                
            return image[x, y];
    
        }

    }
}
