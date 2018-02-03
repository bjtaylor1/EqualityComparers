using System;
using System.Collections.Generic;

namespace EqualityComparers
{
    public class ExpressionEqualityComparer<T> : IEqualityComparer<T>
    {
        private readonly Func<T, T, bool> equal;
        private readonly Func<T, int> getHashCode;

        private ExpressionEqualityComparer()
        {

        }

        public static IEqualityComparer<T> Create(Func<T,T,bool> equal)
        {
            return new ExpressionEqualityComparer<T>(equal, t => t.GetHashCode());
        }

        public static IEqualityComparer<T> Create(Func<T, T, bool> equal, Func<T,int> getHashCode)
        {
            return new ExpressionEqualityComparer<T>(equal, getHashCode);
        }

        private ExpressionEqualityComparer(Func<T, T, bool> equal, Func<T,int> getHashCode)
        {
            this.equal = equal;
            this.getHashCode = getHashCode;
        }

        public bool Equals(T x, T y)
        {
            return equal(x, y);
        }

        public int GetHashCode(T obj)
        {
            return getHashCode(obj);
        }
    }
}
