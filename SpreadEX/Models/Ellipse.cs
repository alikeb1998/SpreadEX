using SpreadEx.Interfaces;

namespace SpreadEx.Models;
public class Ellipse(int x, int y, int diameterH, int diameterV) : BaseWidget(x, y), IWidget
{
    private int DiameterH { get; set; } = diameterH;
    private int DiameterV { get; set; } = diameterV;

    public override void Draw()
    {
        var res = $"Ellipse ({X},{Y}) diameterH = {DiameterH} diameterV = {DiameterV}";
        Console.WriteLine(res);
    }
}