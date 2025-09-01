namespace CSharpLearning.DataStructure;

public static class ListExample
{
    public static void Run()
    {
        Util.RunExample("Vector/List", () =>
        {
            // C++: std::vector<int> v {1, 2, 3};
            var v = new List<int> { 1, 2, 3 };

            // C++: v.emplace_back(4);
            v.Add(4);
            foreach (var element in v)
            {
                Console.WriteLine(element);
            }
        });
    }
}