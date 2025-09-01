namespace CSharpLearning.MemoryManagement;

public struct Point
{
    public int X;
    public int Y;
}

public class PassByRefAndValueExample
{
    private void PassByValue(Point p)
    {
        p.X = 10;
        p.Y = 20;
    }
    
    private void PassByRef(ref Point p)
    {
        p.X = 10;
        p.Y = 20;
    }

    public void RunWithPassByValue()
    {
        ExampleRunner.RunExample("Pass by Value", () =>
        {
            var p = new Point { X = 1, Y = 2 };
            Console.WriteLine($"before, X: {p.X}, Y: {p.Y}");
            PassByValue(p);
            Console.WriteLine($"after, X: {p.X}, Y: {p.Y}");
        });
    }

    public void RunWithPassByRef()
    {
        ExampleRunner.RunExample("Pass by Ref", () =>
        {
            var p = new Point { X = 1, Y = 2 };
            Console.WriteLine($"before, X: {p.X}, Y: {p.Y}");
            PassByRef(ref p);
            Console.WriteLine($"after, X: {p.X}, Y: {p.Y}");
        });   
    }
}