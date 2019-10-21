using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /* 5 types of constraints
     where T : Icomparible - applying a constraint to an interface
     where T : product - means it is a subclass
     where T : struct - means T is a value type
     where T : class - means T is a reference type
     where T : new() - means T has a public parameterless constructor
     */
    public class Utilities<T> where T : IComparable
    {

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}


