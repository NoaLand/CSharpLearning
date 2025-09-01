namespace CSharpLearning.DataStructure;

public static class QueueExample
{
    public static void RunNonGenericExample()
    {
        ExampleRunner.RunExample("Non Generic Queue", () =>
        {
            // C++ does not support non-generic queue, but can use tuple, or customized template or class to simulate it, but this operation is not safe.
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

    public static void RunGenericExample()
    {
        ExampleRunner.RunExample("Generic Queue", () =>
        {
            // C++: std::queue<int> q;
            // q.push(1);
            // q.push(2);
            // q.push(3);
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