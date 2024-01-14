using SpreadEx.Interfaces;
using SpreadEx.Models;
namespace SpreadEx;
class Program
{
    static void Main()
    {
        var widgets = new List<IWidget>
        {
            new Rectangle(10, 10, 30, 40),
            new Square(15, 30, 35),
            new Ellipse(100, 150, 300, 200),
            new Circle(1, 1, 300),
            new TextBox(5, 5, 200, 100, "sample text")
        };
        
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Requested Drawing");
        Console.WriteLine("----------------------------------------------------------------");
        foreach (var widget in widgets)
        {
            widget.Draw();
        }
        Console.WriteLine("----------------------------------------------------------------");
    }
}