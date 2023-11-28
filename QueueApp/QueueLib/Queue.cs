using QueueLib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    public class Queue<T> : IQueue<T>
    {
        private IQueue<T> collection;
        public Queue(IQueue<T> x)
        {
            //collection = new ListQueue<T>();
            collection = new LinkedListQueue<T>();
        }
        public T DeQeue()
        {
            return collection.DeQeue();
        }

        public void EnQueue(T item)
        {
           collection.EnQueue(item);
        }

        public T Peek()
        {
            return collection.Peek();
        }
    }
}
