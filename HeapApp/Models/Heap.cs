namespace HeapApp.Models;
public abstract class Heap 
{
    public int Count => list.Count;
    protected List<int> list;
    public Heap()
    {
        list = new List<int>();
    }

    public void Insert(int value)
    {
        list.Add(value);
    }

    public abstract int Extract();
}