namespace CSharpLearning.DataStructure;

public static class ArrayExample
{
    public static void Run()
    {
        Util.RunExample("Array", () =>
        {
            // C++: std::array<int, 3> a {1, 2, 3};
            var a = new[] { 1, 2, 3 };
            foreach (var element in a)
            {
                Console.WriteLine(element);
            }
        });
    }
}