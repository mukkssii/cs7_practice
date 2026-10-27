using System;
using System.Collections.Generic;
using System.Text;

namespace cs7_practice
{
    internal interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
}
