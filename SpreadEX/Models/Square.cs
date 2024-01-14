using SpreadEx.Interfaces;

namespace SpreadEx.Models;
public class Square(int x, int y, int size) : BaseWidget(x, y),IWidget
{
    private int Size { get; set; } = size;

    public override void Draw()
    {
        var res = $"Square ({X},{Y}) size={Size}";
        Console.WriteLine(res);
    }
}