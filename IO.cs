namespace CSharpLearning;

public static class IO
{
    public static void Example()
    {
        Util.RunExample("Basic IO", () =>
        {
            // Basic IO in C# and C++
            // C++: std::cout << "Hello, World!" << std::endl;
            Console.WriteLine("Hello, World!(from WriteLine)");

            // C++: std:: cout << "Hello, World!";
            Console.Write("Hello, World!(from Write)");

            Console.WriteLine();
        });
    }
}