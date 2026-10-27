using System;
using System.Collections.Generic;
using System.Text;

namespace cs7_practice
{
    internal interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
