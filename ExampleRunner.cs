namespace CSharpLearning;

public static class ExampleRunner
{
    public static void RunExample(string title, Action example)
    {
        Console.WriteLine("***************");
        Console.WriteLine(title);
        Console.WriteLine("***************");
        
        example();
        
        Console.WriteLine("---------------");
        Console.WriteLine();
    }
}