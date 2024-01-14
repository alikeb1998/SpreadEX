using SpreadEx.Interfaces;

namespace SpreadEx.Models;

public abstract class BaseWidget(int x, int y) : IWidget
{
    protected int X = x;
    protected int Y = y;

    public abstract void Draw();
}