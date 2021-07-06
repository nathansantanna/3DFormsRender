namespace PGA.Filters
{
    public interface IFilter
    {
        uint Width { get; set; }
        uint Heigth { get; set; }
        Color Render(int x, int y, Color[,] image, ImageProcess imageProcess = null);
    }
}
