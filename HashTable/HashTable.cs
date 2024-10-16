
namespace AlgorithmPractice.HashTable;

public class HashTable
{
    public IDictionary<int, string> HashTableDescription()
    {
        //per input,always just one output (deterministic)
        IDictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(1, "1"); //O(1)
        dictionary.Add(2, "2");
        dictionary.Add(3, "3");

        dictionary.Remove(2);

        var keys = dictionary.Keys;

        return dictionary;
    }

    public string HashTableAlgorithm(string input)
    {
        IDictionary<string, int> dictionary = new Dictionary<string, int>();

        foreach (var item in input)
        {
            if (dictionary.ContainsKey(item.ToString()))
            {
                dictionary[item.ToString()] += 1;
            }
            else
            {
                dictionary.Add(item.ToString(), 1);
            }
        }

        return dictionary.First(c => c.Value == 1).Key;
    }

    public string HashSetAlgorithm(string input)
    {
        ISet<string> set = new HashSet<string>();

        foreach (var item in input)
        {
            if (set.Contains(item.ToString()))
                return item.ToString();
            set.Add(item.ToString());
        }

        return "all char is uniq";
    }

}