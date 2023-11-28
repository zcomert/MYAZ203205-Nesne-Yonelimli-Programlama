using Stack.Contracts;

namespace Stack;
public class Stack<T> : IStack<T>
{
    private IStack<T> collection;
    public Stack()
    {
        collection = new LinkedListStack<T>();
    }
    public T Peek()
    {
        return collection.Peek();
    }

    public T Pop()
    {
        return collection.Pop();
    }

    public void Push(T item)
    {
        collection.Push(item);
    }
}