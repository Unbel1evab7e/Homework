using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            Array array = new Array(n);
            //array.AppendSelected(0, 1);
            //array.Search(1);
            //array.GetInfo();
            //array.RandomAppend(1, 10);
            //array.Search(1);
            //array.BubbleSort();
            //issorted check
            array.AppendAll(1);
            array.GetInfo();
            array.BubbleSort();
        }
    }
}
