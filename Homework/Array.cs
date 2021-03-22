using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public class Array
    {
        public int _size;
        public int[] _array;
        public Array(int size)
        {
            _size = size;
            _array = new int[_size];
        }
        public void GetInfo()
        {
            string str = "";
            foreach (int i in _array)
                str = str + (i + " ");
            Console.WriteLine(str);
        }
        public void AppendSelected(int k, int n)
        {
            /* foreach(int i in _array)
             {
                 if (i==k)
                   //  i = n;
             }*/
            for (int i = 0; i < _size; i++)
            {
                if (_array[i] == k)
                    _array[i] = n;
            }
        }
        public void AppendAll(int n)
        {
            for (int i = 0; i < _size; i++)
            {
                _array[i] = n;
            }
        }
        public void RandomAppend(int a, int b)
        {
            Random random = new Random();
            /*foreach(int i in _array)
            {
                _array[i] = random.Next(a, b);
            }*/
            for (int i = 0; i < _size; i++)
            {
                _array[i] = random.Next(a, b);
            }
        }
        public void BubbleSort()
        {
            bool flag = true;
            do
            {
                for (int i = 0; i < _size - 1; i++)
                {
                    if (_array[i] > _array[i + 1])
                        flag = false;
                }
                if (flag == true)
                {
                    Console.WriteLine("Массив уже упорядочен, перемешиваю числа");
                    RandomAppend(0, 100);
                    GetInfo();
                }
            } while (flag == true);
            //Sort difficult is O(n^2).
            for (int k = 0; k < _size; k++)
            {
                for (int i = 0; i < _size - 1; i++)
                {
                    if (_array[i] > _array[i + 1])
                    {
                        int n;
                        n = _array[i];
                        _array[i] = _array[i + 1];
                        _array[i + 1] = n;
                    }
                }
            }
            GetInfo();
        }
        public void Search(int n)
        {
            int count = 0;
            for (int i = 0; i < _size; i++)
                if (_array[i] == n)
                    count++;
            if (count == 0)
                Console.WriteLine("Такого числа нет");
            else if (count == 1)
                Console.WriteLine($"Число {n} найдено");
            else if (count > 1)
                Console.WriteLine($"Число {n} найдено {count} раз");
        }

    }
}

