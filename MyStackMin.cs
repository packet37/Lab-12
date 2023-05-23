using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStackMin<T> : MyStack<T> where T : IComparable<T>

    {
        public T[] mins;
        public MyStackMin() : base()
        {
            this.mins = new T[n];
        }
        public MyStackMin(int length) : base(length)
        {
            this.mins = new T[length];
        }
        public override void Push(T item)
        {
            base.Push(item);
            if (Count < 2)
                mins[Count - 1] = item;
            else
                mins[Count - 1] = (item.CompareTo(mins[Count - 2]) > 0 ? mins[Count - 2] : item); 
        }
        public T GetMin
        {
            get
            {
                if (IsEmpty) throw new InvalidOperationException();
                return mins[Count - 1];
            }
        }

    }
}
