namespace HeapApp.Models;

public class MinHeap : Heap
{
    public override int Extract()
    {
        var min = list.Min();
        // foreach (var item in list)
        // {
        //     if(item<min)
        //         min = item;
            
        // }
        list.Remove(min);
        return min;
    }
}
