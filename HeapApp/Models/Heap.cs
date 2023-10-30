namespace HeapApp.Models;

public abstract class Heap
{
    protected Heap()
    {
        Data = new List<int>();
    }

    protected List<int> Data { get; set; }
    public int Count=>Data.Count; 

    public void Insert(int value)
    {
        Data.Add(value);
    }


    public abstract int Extract();
}
