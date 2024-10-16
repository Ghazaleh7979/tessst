namespace AlgorithmPractice.QueueTest
{
    public class PriorityQueueTest
    {
        private int[] items = new int[5];
        private int count;

        public void Add(int item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i] > item)
                {
                    items[i + 1] = items[i];
                }
                else
                    break;
            }
            items[i + 1] = item;
            count++;
        }

        public int Remove()
        {
            if (count == 0)
                throw new Exception("");
            return items[--count];
        }
    }
}
