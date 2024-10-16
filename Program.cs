using AlgorithmPractice.AlgorithmPractice.QueueTest;
using AlgorithmPractice.QueueTest;

namespace AlgorithmPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new QueueType();

            var response = queue.QueueDescription();
            queue.ReverseQueue(response);

            //var arrayQueue = new CreateQueueWithArray(5);
            //arrayQueue.Enqueue(5);
            //arrayQueue.Enqueue(6);
            //arrayQueue.Enqueue(7);

            //var tt = arrayQueue.Dequeue();

            //arrayQueue.ToString();

            //Console.WriteLine(arrayQueue);

            var arrayStack = new CreateQueueWithStack();

            arrayStack.Enqueue(5);
            arrayStack.Enqueue(6);
            arrayStack.Enqueue(7);

            var r1 = arrayStack.Dequeue();
            var r2 = arrayStack.Dequeue();

            //#region Stack

            //var stack = new StackTest();

            //var reversed = stack.InverseString("ghazaleh");

            //bool balanced = stack.IsBalanced("({}2(1");

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);


            //stack.Pop();
            //var ee = stack.Peek();

            //Console.WriteLine(reversed);
            //Console.WriteLine(balanced);
            //#endregion

            //#region HashTable

            //var hash = new HashTable.HashTable();
            //var description = hash.HashTableDescription();

            //foreach (var item in description)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //var algorithm = hash.HashTableAlgorithm("programmer");
            //Console.WriteLine(algorithm);

            //var algorithmSet = hash.HashSetAlgorithm("programmer");
            //Console.WriteLine(algorithmSet);

            //#endregion

            //#region Array

            //var arr = new ArrayTest.Array(3);

            //arr.Insert(3);
            //arr.Insert(4);
            //arr.Insert(5);
            //arr.Insert(6);

            //arr.Insert(7);

            //arr.Print();

            //#endregion

            //#region LinkedList

            //var linkedList = new LinkedListTest();

            //linkedList.LinkedListDescription();

            //linkedList.AddLast(3);
            //linkedList.AddLast(4);
            //linkedList.AddLast(5);

            //linkedList.AddFirst("g");
            //linkedList.Reverse();
            //linkedList.RemoveFirst();
            //linkedList.RemoveLast();

            //foreach (var item in linkedList.ToArray())
            //{
            //    Console.WriteLine(item);
            //}

            //#endregion

        }

    }
}