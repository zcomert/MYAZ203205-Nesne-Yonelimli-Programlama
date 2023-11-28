namespace QueueLib;
using QueueLib.Contracts;

public class ListQueue<T> : IQueue<T>
{
    private List<T> collection;
    public ListQueue()
    {
        collection = new List<T>();
    }
    public T DeQeue()
    {
        var item = Peek();
        collection.RemoveAt(0);
        return item;    
    }

    public void EnQueue(T item)
    {
        collection.Add(item);
    }

    public T Peek()
    {
        return collection[0];
    }
}