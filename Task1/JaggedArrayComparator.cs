using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class CompareBySum:IArrayCompare
    {
        private bool isPositive;
        public bool IsPositive
        {
            get { return isPositive; }
            set { isPositive = value; }
        }
        public bool Compare(int[] a, int[] b)
        {
            if (a == null && b == null)
                return false;
            if (a == null)
                return true;
            if (b == null)
                return false;
            int aSum = a.Sum();
            int bSum = b.Sum();
            if (IsPositive)
            {
                if (aSum > bSum)
                    return true;
                return false;
            }
            if (aSum < bSum)
                return true;
            return false;
        }


        public class CompareByMaxElement : IArrayCompare
        {
            private bool isPositive;
            public bool IsPositive
            {
                get { return isPositive; }
                set { isPositive = value; }
            }
            public bool Compare(int[] a, int[] b)
            {
                if (a == null && b == null)
                    return false;
                if (a == null)
                    return true;
                if (b == null)
                    return false;
                int aMax = a.Max();
                int bMax = b.Max();
                if (IsPositive)
                {
                    if (aMax > bMax)
                        return true;
                    return false;
                }
                if (aMax < bMax)
                    return true;
                return false;
            }
 
        }

    }


}
