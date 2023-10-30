using System.Diagnostics.CodeAnalysis;

namespace HeapApp.Models;

public class MaxHeap : Heap
{
    public override int Extract()
    {
        // if(this.Count==0)
        //     return 0;
        var max = list.Max();
        list.Remove(max);
        return max;
    }
}