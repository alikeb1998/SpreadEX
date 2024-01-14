using SpreadEx.Interfaces;

namespace SpreadEx.Models;
public class TextBox(int x, int y, int width, int height, string text) : BaseWidget(x, y), IWidget
{
    private int Width { get; set; } = width;
    private int Height { get; set; } = height;
    private string Text { get; set; } = text;

    public override void Draw()
    {
        var res = $"TextBox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"";
        Console.WriteLine(res);
    }
}
