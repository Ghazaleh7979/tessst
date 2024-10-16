namespace AlgorithmPractice.AlgorithmPractice.Stack
{
    public class StackTest
    {
        string[] Openexpression = { "{", "[", "(", "<" };
        string[] Closeexpression = { "}", "]", ")", ">" };
        int count = 0;
        object[] array = new object[0];


        //Last in First out     LIFO
        public Stack<int> StackDescription()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Pop();

            var peek = stack.Peek();

            return stack;
        }

        //Inverse, Undo, Go to back , ... => stack
        public string? InverseString(string str)
        {
            var InverseStack = new Stack<char>();
            foreach (char c in str)
            {
                InverseStack.Push(c);
            }
            var rr = string.Join("", InverseStack);

            return rr;
        }

        public bool IsBalanced(string str) // (3{1 + 2}<>)
        {
            var stack = new Stack<string>();

            foreach (var item in str.ToArray())
            {
                if (Openexpression.Contains(item.ToString()))
                {
                    stack.Push(item.ToString());
                }
                if (Closeexpression.Contains(item.ToString()))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (Array.IndexOf(Openexpression, stack.Peek()) == Array.IndexOf(Closeexpression, item.ToString()))
                    {
                        stack.Pop();
                    }
                }
            }
            return stack.Count == 0;
        }

        public void Push(object input)
        {

            array = new object[count + 1];

            array.SetValue(input, count);

            count++;
        }

        public void Pop()
        {
            array = array.SkipLast(1).ToArray();

            count--;
        }

        public object Peek()
        {
            return array.GetValue(count) ?? "stack is empty";
        }
    }
}
