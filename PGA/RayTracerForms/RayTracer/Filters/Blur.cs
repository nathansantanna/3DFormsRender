namespace PGA.Filters 
{
    public class Blur : IFilter
    {
        public Blur()
        {
            Matrix = new[,]{
                { 0, 0.2, 0 }, 
                { 0.2, 0.2, 0.2 }, 
                {0, 0.2, 0 }
            };
            Width = 2;
            Heigth = 2;
        }

        public double[,] Matrix { get; set; }
        public uint Width { get; set; }
        public uint Heigth { get; set; }

        public Color Render(int x, int y, Color[,] image, ImageProcess imageProcess)
        {
            double red = 0.0, green = 0.0, blue = 0.0;
            int count = 0;
            for (int filterY = 0; filterY <= Heigth; filterY++)
            {
                for (int filterX = 0; filterX <= Width; filterX++)
                {
                    int imageX = x + (filterX - 1);
                    int imageY = y + (filterY - 1);
                    var pixelColor = image[imageX, imageY];
                    var MatrixColor = Matrix[ filterX,filterY];
                    red +=   pixelColor.Red * MatrixColor;//image[imageX, imageY].Red * Matrix[filterY, filterX];
                    green += pixelColor.Green * MatrixColor;//image[imageX, imageY].Green * Matrix[filterY, filterX];
                    blue +=  pixelColor.Blue * MatrixColor;//image[imageX, imageY].Blue * Matrix[filterY, filterX];
                    count++;
                }
            }

            return new Color(red,green,blue);
        }
    }
}
