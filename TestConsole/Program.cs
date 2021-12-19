using DataStructures.Collections;
using DataStructures.Collections.Matrices;

var deq = new Deque<int>();

deq.PushHead(0);
Out(deq.Head, deq.Tail);
deq.PushHead(1);
Out(deq.Head, deq.Tail);
deq.PushTail(2);
Out(deq.Head, deq.Tail);


deq.PopHead();
Out(deq.Head, deq.Tail);
Console.ReadKey();

static void Out(int firsr, int second)
{
    Console.WriteLine($"Head = {firsr}");
    Console.WriteLine($"Tail = {second}");
    Console.WriteLine("");
}