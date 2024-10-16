namespace AlgorithmPractice.QueueTest
{
    public class CreateQueueWithArray
    {
        private int[] items;
        private int rear;
        private int front;
        private int Count;

        public CreateQueueWithArray(int capacity)
        {
            items = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if (Count == items.Length)
                throw new Exception("ظرفیت کم میباشد");
            items[rear] = item;
            rear = (rear + 1) % items.Length;
            Count++;
        }
        public int Dequeue()
        {
            var response = items[front];
            items[front] = 0;
            Count--;
            front++;
            return response;
        }
        public string ToString() => items.ToString();
    }
}