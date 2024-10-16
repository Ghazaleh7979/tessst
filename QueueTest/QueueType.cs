namespace AlgorithmPractice.AlgorithmPractice.QueueTest
{
    public class QueueType
    {
        Queue<int> queue = new Queue<int>();

        public Queue<int> QueueDescription()
        {
            // FIFO
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            var ttt = queue.Peek();
            var tt = queue.Dequeue();

            //Priority Queue
            //اولویت بر اساس ضرورت
            return queue;
        }

        public void ReverseQueue(Queue<int> queue)
        {
            var stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue((int)stack.Pop());
            }
        }
    }
}
