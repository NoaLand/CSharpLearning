namespace CSharpLearning;

public abstract class DataStructure
{
    public abstract class List
    {
        public static void Example()
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

    public abstract class Array
    {
        public static void Example()
        {
            Util.RunExample("Array", () =>
            {
                // C++: std::array<int, 3> a {1, 2, 3};
                var a = new int[3] { 1, 2, 3 };
                foreach (var element in a)
                {
                    Console.WriteLine(element);
                }
            });
        }
    }

    public abstract class Queue
    {
        public static void NonGenericExample()
        {
            Util.RunExample("Non Generic Queue", () =>
            {
                // C++: std::queue<int> q;
                // q.push(1);
                // q.push(2);
                // q.push(3);
                System.Collections.Queue nonGenericQueue = new System.Collections.Queue();
                nonGenericQueue.Enqueue(1);
                nonGenericQueue.Enqueue("xxxx");
                nonGenericQueue.Enqueue(3.14);

                foreach (var element in nonGenericQueue)
                {
                    Console.WriteLine(element);
                }
            });
        }

        public static void GenericExample()
        {
            Util.RunExample("Generic Queue", () =>
            {
                Queue<int> genericQueue = new Queue<int>();
                genericQueue.Enqueue(1);
                genericQueue.Enqueue(2);
                genericQueue.Enqueue(3);

                foreach (var element in genericQueue)
                {
                    Console.WriteLine(element);
                }
            });
        }
    }
}