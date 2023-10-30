using HeapApp.Models;

Heap heap = new MaxHeap();
heap.Insert(23);
heap.Insert(55);
heap.Insert(8);
heap.Insert(12);
heap.Insert(44);
heap.Insert(41);

var number=heap.Count;
for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine(heap.Extract());
}

