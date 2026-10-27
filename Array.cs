using System;
using System.Collections.Generic;
using System.Text;

namespace cs7_practice
{
    internal class Arrayy : IOutput, IMath, ISort
    {
        private int[] _arr;
        public Arrayy(int[] arr)
        {
            _arr = arr;
        }

        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                sum += _arr[i];
            }
            return sum / _arr.Length;

        }

        public int Max()
        {
            int max = _arr[0];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] > max)
                {
                    max = _arr[i];
                }
            }
            return max;
        }

        public int Min()
        {
            int min = _arr[0];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] < min)
                {
                    min = _arr[i];
                }
            }
            return min;
        }

        public bool Search(int valueToSearch)
        {
            bool found = false;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] > valueToSearch)
                {
                    found = true;
                }
            }
            return found;
        }

        public void Show()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.Write(_arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }

        public void SortAsc()
        {
            Array.Sort(_arr);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void SortDesc()
        {
            Array.Sort(_arr);
            Array.Reverse(_arr);
        }
    }
}
