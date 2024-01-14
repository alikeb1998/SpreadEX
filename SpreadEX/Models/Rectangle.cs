using SpreadEx.Interfaces;

namespace SpreadEx.Models;
public class Rectangle(int x, int y, int width, int height): BaseWidget(x, y), IWidget
{
    private int Width { get; set; } = width;
    private int Height { get; set; } = height;

    public override void Draw()
    {
        var res = $"Rectangle ({X},{Y}) width={Width} height={Height}";
        Console.WriteLine(res);
    }
}