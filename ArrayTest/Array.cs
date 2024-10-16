namespace AlgorithmPractice.ArrayTest;

public class Array
{
    // not good for delete and add
    private int[] arr;
    private int count;
    public Array(int lenght)
    {
        arr = new int[lenght];
    }

    public void Insert(int number)
    {
        if (count == arr.Length)
        {
            var newArray = new int[count * 2];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = arr[i];
            }

            arr = newArray;
        }
        arr[count++] = number;

    }

    public void Print()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}