using System.Diagnostics;
using System.Drawing;
using PGA.Filters;

namespace PGA
{
    public  class ImageProcess
    {
        public Scene TargetScene { get; set; }
        public RayTracer TargetRayTracer { get; set; }


        public ImageProcess( Scene scene,RayTracer rayTracer)
        {
            TargetScene = scene;
            TargetRayTracer = rayTracer;
        }

        public void Execute(Graphics image, Rectangle viewport,IFilter[] filters)
        {
            image.FillRectangle(Brushes.Black, viewport);
            Color[,] buffer = new Color[viewport.Width + 2, viewport.Height + 2];

            Color[,] filterbuffer = new Color[viewport.Width + 2, viewport.Height + 2];
            
            // to draw image correctly
            if (filters.Length == 0)
                 filterbuffer = buffer;
            
            RenderImage(buffer);

            foreach (var filter in filters)
            {
                ApplyFilters(buffer, filterbuffer, filter);
            }

            Draw(image,viewport,filterbuffer);
        }

        public void RenderImage(Color[,] buffer)
        {
            int height = buffer.GetLength(1);
            int width = buffer.GetLength(0);
            for (int y = 0; y < height ; y++)
            {
                for (int x = 0; x < width ; x++)
                {
                    double yp = y * 1.0f / height * 2 - 1;
                    double xp = x * 1.0f / width * 2 - 1;
                    Ray ray = TargetScene.Camera.GetRay(xp, yp);
                    //raytracing Execute
                    buffer[x, y] = TargetRayTracer.CalculateColor(ray, TargetScene);
                }
            }
        }

        public void ApplyFilters(Color[,] inBuffer,Color[,] outBuffer,IFilter filter)
        {
            int height = inBuffer.GetLength(1);
            int width = inBuffer.GetLength(0);
            for (int y = 0; y < height ; y++)
            {
                for (int x = 0; x < width ; x++)
                {
                    if ((x > filter.Width - 1) && (y > filter.Heigth - 1))
                        outBuffer[x - 1, y - 1] = filter.Render(x - 1, y - 1, inBuffer,this);
                }
            }
        }

        public void Draw(Graphics image,Rectangle viewport,Color[,] buffer)
        {
            for (int y = 0; y < viewport.Height + 2; y++)
            {
                for (int x = 0; x < viewport.Width + 2; x++)
                {
                    if ((x > 1) && (y > 1))
                    {
                        //Draw
                        Brush br = new SolidBrush(buffer[x - 1, y - 1].ToArgb());
                        image.FillRectangle(br, viewport.Left + x - 2, viewport.Top + y - 2, 1, 1);
                        br.Dispose();
                    }
                }
            }
        }
    }
}