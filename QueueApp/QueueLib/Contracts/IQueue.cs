namespace QueueLib.Contracts;

public interface IQueue<T>
{
    void EnQueue(T item);
    T DeQeue();
    T Peek();
}