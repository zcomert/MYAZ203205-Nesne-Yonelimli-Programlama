using Stack.Contracts;

namespace Stack;

public class LinkedListStack<T> : IStack<T>
{
    private LinkedList<T> collection;
    public LinkedListStack()
    {
        collection = new LinkedList<T>();
    }
    public T Peek()
    {
        return collection.First.Value;
    }

    public T Pop()
    {
        if(collection.Count>0)
        {
            var item = collection.First.Value;
            collection.RemoveFirst();
            return item;
        }
        return default(T);
    }

    public void Push(T item)
    {
        collection.AddFirst(item);
    }
}