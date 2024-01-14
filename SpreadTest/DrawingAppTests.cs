using SpreadEx.Models;

namespace SpreadTest;

[TestFixture]
public class DrawingAppTests
{
    [Test]
    public void Rectangle_Draw_ShouldPrintCorrectDetails()
    {
        // Arrange
        var rectangle = new Rectangle(10, 10, 30, 40);

        // Act
        var output = CaptureConsoleOutput(() => rectangle.Draw());

        // Assert
        const string expectedOutput = "Rectangle (10,10) width=30 height=40";
        Assert.That(output.Trim(), Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Square_Draw_ShouldPrintCorrectDetails()
    {
        // Arrange
        var square = new Square(15, 30, 35);

        // Act
        var output = CaptureConsoleOutput(() => square.Draw());

        // Assert
        const string expectedOutput = "Square (15,30) size=35";
        Assert.That(output.Trim(), Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Ellipse_Draw_ShouldPrintCorrectDetails()
    {
        // Arrange
        var ellipse = new Ellipse(100, 150, 300, 200);

        // Act
        var output = CaptureConsoleOutput(() => ellipse.Draw());

        // Assert
        const string expectedOutput = "Ellipse (100,150) diameterH = 300 diameterV = 200";
        Assert.That(output.Trim(), Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Circle_Draw_ShouldPrintCorrectDetails()
    {
        // Arrange
        var circle = new Circle(1, 1, 300);

        // Act
        var output = CaptureConsoleOutput(() => circle.Draw());

        // Assert
        const string expectedOutput = "Circle (1,1) size=300";
        Assert.That(output.Trim(), Is.EqualTo(expectedOutput));
    }

    [Test]
    public void TextBox_Draw_ShouldPrintCorrectDetails()
    {
        // Arrange
        var textBox = new TextBox(5, 5, 200, 100, "sample text");

        // Act
        var output = CaptureConsoleOutput(() => textBox.Draw());

        // Assert
        const string expectedOutput = "TextBox (5,5) width=200 height=100 Text=\"sample text\"";
        Assert.That(output.Trim(), Is.EqualTo(expectedOutput));
    }
    
    // Helper method to capture console output
    private static string CaptureConsoleOutput(Action action)
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        action.Invoke();
        return sw.ToString();
    }
}