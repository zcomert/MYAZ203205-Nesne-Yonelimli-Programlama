namespace HeapApp.Models;

public class MaxHeap : Heap
{
    public override int Extract()
    {
        var value=Data.Max();
        Data.Remove(value);
        return value;
    }
}