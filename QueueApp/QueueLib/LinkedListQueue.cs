namespace QueueLib;
using QueueLib.Contracts;

public class LinkedListQueue<T> : IQueue<T>
{
    private LinkedList<T> collection;
    public LinkedListQueue()
    {
        collection = new LinkedList<T>();
    }
    
    public T DeQeue()
    {
        var item = Peek();
        collection.RemoveLast();
        return item;
    }

    public void EnQueue(T item)
    {
        collection.AddFirst(item);
    }

    public T Peek()
    {
        return collection.Last.Value;
    }
}