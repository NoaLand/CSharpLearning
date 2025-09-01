namespace CSharpLearning;

public abstract class DataStructure
{
    public abstract class List
    {
        public static void Example()
        {
            Console.WriteLine("Vector/List");
            // C++: std::vector<int> v {1, 2, 3};
            var v = new List<int> { 1, 2, 3 };

            // C++: v.emplace_back(4);
            v.Add(4);
            foreach (var element in v)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("---------------");
            Console.WriteLine();
        }
    }

    public abstract class Array
    {
        public static void Example()
        {
            Console.WriteLine("Array");
            // C++: std::array<int, 3> a {1, 2, 3};
            var a = new int[3] { 1, 2, 3 };
            foreach (var element in a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("---------------");
            Console.WriteLine();
        }
    }

    public abstract class Queue
    {
        public static void Example()
        {
            Console.WriteLine("Queue");
            // C++: std::queue<int> q {1, 2, 3};
            Console.WriteLine("---------------");
        }
    }
}