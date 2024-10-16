namespace AlgorithmPractice.QueueTest
{
    public class CreateQueueWithStack
    {
        private Stack<int> queue = new Stack<int>();

        public void Enqueue(int item)
        {
            queue.Push(item);
        }
        public int Dequeue()
        {
            var stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Pop());
            }

            var response = stack.Pop();

            foreach (int i in stack)
            {
                queue.Push(i);
            }
            return response;
        }
    }
}
