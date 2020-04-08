using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class main
    {
        static void Main(string[] args)
        {
            List list = new List();
            Console.WriteLine("1");
            list.Add(10);
            list.Add(134);
            list.Add(-10);
            list.Sort();
            for (int i = 0; i < list.Length(); i++)
            {
                Console.WriteLine(list.Get(i));
            }
        }

    }

    class List
        {
            private int listLength;
            private int[] listArray;

            public List()
            {
                listLength = 0;
            }

            public void Add(int a)
            {
                int[] arr = new int[listLength + 1];
                arr[listLength++] = a;
                listArray = arr;
            }

            public void Clear()
            {
                int[] arr = new int[0];
                listArray = arr;
            }

            public bool Equals(List list)
            {
                if (list.Length() == 0 && listLength == 0)
                {
                    return true;
                }

                if (list.Length() != listLength)
                {
                    return false;
                }

                for (int i = 0; i < list.Length(); i++)
                {
                    if (list.listArray[i] == listArray[i])
                    {
                        return false;
                    }
                }

                return true;

            }

            public int Length()
            {
                return listLength;
            }

            public int Find(int a)
            {
                for (int i = 0; i < listLength; i++)
                {
                    if (listArray[i] == a)
                    {
                        return i;
                    }
                }

                return -1;
            }

            public void Sort()
            {
                for (int i = 0; i < listLength - 1; i++)
                {
                    for (int j = i + 1; j < listLength; j++)
                    {
                        if (listArray[j] < listArray[i])
                        {
                            int t = listArray[i];
                            listArray[i] = listArray[j];
                            listArray[j] = t;
                        }
                    }
                }
            }

            public void RemoveAt(int a)
            {
                listArray[listLength--] = 0;
            }

            public int Get(int a)
            {
                return listArray[a];
            }
    } 

}
