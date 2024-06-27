using System.Drawing;

namespace AreaCalculate
{
    public enum ColorType
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Yellow =3
    }
    public static class ColorExtensions
{
    public static Color ToColor(this ColorType colorType)
    {
        switch (colorType)
        {
            case ColorType.Red:
                return Color.Red;
            case ColorType.Green:
                return Color.Green;
            case ColorType.Blue:
                return Color.Blue;
            case ColorType.Yellow:
                return Color.Yellow;
            default:
                throw new ArgumentException("İnvalid color type!", nameof(colorType));
        }
    }
}
    class Program 
{
        static void Main(string[] args)
        {
             ColorType colorType = ColorType.Green;
             Color color = colorType.ToColor();

             Console.WriteLine($"Selected color: {color}");
        }

}

}
