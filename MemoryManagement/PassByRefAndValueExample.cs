using System.Runtime.CompilerServices;

namespace CSharpLearning.MemoryManagement;

public struct Point
{
    public int X;
    public int Y;
}

public unsafe class PassByRefAndValueExample
{
    private void PassByValue(Point p)
    {
        Console.WriteLine($"When pass by value, p's address: 0x{((long)&p):x}");
        p.X = 10;
        p.Y = 20;
    }
    
    private void PassByRef(ref Point p)
    {
        void* ptr = Unsafe.AsPointer(ref p);
        Console.WriteLine($"When pass by ref, p's address: 0x{((long)ptr):x}");
        p.X = 10;
        p.Y = 20;
    }

    public void RunWithPassByValue()
    {
        ExampleRunner.RunExample("Pass by Value", () =>
        {
            var p = new Point { X = 1, Y = 2 };
            Console.WriteLine($"before, X: {p.X}, Y: {p.Y}");
            Console.WriteLine($"caller p address: 0x{((long)&p):x}");
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
            Console.WriteLine($"caller p address: 0x{((long)&p):x}");
            PassByRef(ref p);
            Console.WriteLine($"after, X: {p.X}, Y: {p.Y}");
        });   
    }
}