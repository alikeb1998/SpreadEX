using SpreadEx.Interfaces;

namespace SpreadEx.Models;
public class Circle(int x, int y, int size) : BaseWidget(x, y)
{
    private int Size { get; set; } = size;

    public override void Draw()
    {
        var res = $"Circle ({X},{Y}) size={Size}";
        Console.WriteLine(res);
    }
}