namespace AlgorithmPractice.LinkedList;

public class NodeTest
{
    public object Value { get; set; }
    public NodeTest? Next { get; set; }

    public NodeTest(object value)
    {
        Value = value;
    }
}