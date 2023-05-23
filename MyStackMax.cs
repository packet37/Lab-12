using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStackMax<T>: MyStack<T> where T : IComparable<T>

    {
        public T[] maxs;
        public MyStackMax(): base()
        {
            this.maxs = new T[n];
        }
        public MyStackMax(int length): base (length)
        {
            this.maxs = new T[length];
        }
        public override void Push(T item)
        {
            base.Push(item);
            if (Count < 2)
                maxs[Count - 1] = item;
            else
                maxs[Count - 1] = (item.CompareTo(maxs[Count - 2]) > 0 ? item : maxs[Count - 2]); //gjvtyzq vtcnfvb lkz vby
        }
        public T GetMax
        {
            get
            {
                if (IsEmpty) throw new InvalidOperationException();
                return maxs[Count - 1];
            }
        }

    }
}
