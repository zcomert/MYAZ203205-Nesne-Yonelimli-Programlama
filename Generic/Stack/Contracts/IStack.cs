namespace Stack.Contracts;

public interface IStack<T>
{
    void Push(T item);
    T Pop();
    T Peek();
}