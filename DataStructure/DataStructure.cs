namespace CSharpLearning.DataStructure;

public abstract class DataStructure
{
    public abstract class Array
    {
        public static void Example()
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
                var nonGenericQueue = new System.Collections.Queue();
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
                var genericQueue = new Queue<int>();
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