using HeapApp.Models;

Heap heap1 = new MaxHeap();
var list = new List<int>() { 23, 44, 06, 34, 35, 61, 19 };
foreach (var item in list)
{
    heap1.Insert(item);
}
int i=0;
do
{
    Console
    .WriteLine($"{heap1.Extract()} - {heap1.Count}");
    i+=1;
} while (i<list.Count);
