using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 23, 44, 66, 76, 98, 11, 3, 9, 7 };
            Console.WriteLine("需要排序的数组为：");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                //Console.Write(arr[i] + "\t"); Tab分隔               
            }
            Console.WriteLine();

            #region//冒泡排序：大数上浮(向后移动)            
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    //else
                    //{
                    //    continue;
                    //}
                    
                }
                //for (int z = 0; z < arr.Length; z++)
                //{
                //    Console.Write(arr[z] + " ");
                //}
                //Console.WriteLine();
            }
            #endregion

            Console.WriteLine("排序后的数组为：");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
