namespace HeapApp.Models;

public class MinHeap : Heap
{


    public override int Extract()
    {
        var value=Data.Min();
        Data.Remove(value);
        return value;
    }
}