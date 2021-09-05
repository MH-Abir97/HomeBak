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
            //int []array=new int[25];

            //int n, i, j, temp;

            //Console.WriteLine("Enter The Number:");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Array Element");

            //for (i = 0; i <n; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (i = 0; i <(n-1) ; i++)
            //{
            //    for ( j = 0; j < n-i-1; j++)
            //    {
            //        if (array[j] > array[j+1])
            //        {
            //            temp = array[j]; 
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("The Sorted Array Element:");
            //for ( i = 0; i <n ; i++)
            //    Console.WriteLine(array[i] +" ");

            // BubbleSort();

            //Sort();

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            Console.WriteLine(list);
           // Arraylist();

            Console.ReadKey();
        }

        private static void Arraylist()
        {
            int n ,i;

            int[] array = new int[3];

            Console.WriteLine("Enter Item:");

            n = Convert.ToInt32(Console.ReadLine());


         

        }
        private static void Sort()
        {
            int i, j, temp,n;
            int[] array = new int[10];

            Console.WriteLine("Enter Number Element:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Array Element:");
            for ( i = 0; i<n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for ( i = 0; i < (n-1); i++)
            {
                for (j = 0; j <n-i-1 ; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Element:");
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }


        }

        private static void BubbleSort()
        { 
            int i ,j,temp,n;
            int[] array = new int[10];

            Console.WriteLine("Enter Number Of Sort");

            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Array Element:");

            for ( i = 0; i < n ; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i <(n-1); i++)
            {
                for (j = 0; j < n-i-1; j++)
                {
                    if (array[j] >array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("The Sorted Array Element:");
            for ( i = 0; i <n ; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
