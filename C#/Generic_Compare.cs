using System;
using System.Collections.Generic;

namespace Generic_Compare
{
    class Compare<ItemType> where ItemType : IComparable<ItemType>
    {
        public ItemType Larger (ItemType data1, ItemType data2)
        {
            return (data1.CompareTo(data2) > 0) ? data1 : data2;
        }

        public ItemType Smaller (ItemType data1, ItemType data2)
        {
            return (data1.CompareTo(data2) > 0) ? data2 : data1;
        }
    }
}

// Compare <int> intCompare = new Compare<int>();
// int MyInt = intCompare.Larger(3, 5);