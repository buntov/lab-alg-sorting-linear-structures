
using System;
using System.Collections.Generic;
//Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
//var enc1251 = Encoding.GetEncoding(1251);

//System.Console.OutputEncoding = System.Text.Encoding.UTF8;
//System.Console.InputEncoding = enc1251;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            int counter = 0;
            do
            {
                Console.WriteLine("Enter length array:");
            } while (!int.TryParse(Console.ReadLine(), out l));

            int[] arr = new int[l];

            foreach (int ar in arr)
                do
                {
                    Console.WriteLine("Enter value to array element");
                } while (!int.TryParse(Console.ReadLine(), out arr[counter++]));

            // int[] arForShell = new int[l];
            int[] arForQuickSort = new int[l];

            // Array.Copy(arr, arForShell, l);
            Array.Copy(arr, arForQuickSort, l);

            ShowArr(arr, "      Array:  Index:", "\n-------------------------Quick sort-----------------------\n");

            Console.WriteLine("\n      Sequence of operations:");

            QuickSort(arForQuickSort, 0, arr.Length - 1, arr);

            ShowResult(arForQuickSort, arr);

            /*  ShowArr(arr, "      Array: Index:", "\n--------------------------Shell sort------------------------\n");

              Console.WriteLine("\n      Sequence of operations:");

              ShellSort(arForShell, arr);

              ShowResult(arForShell, arr);*/

            Console.ReadKey();
        }

        static void ShowArr(int[] arr, string s, string message)
        {
            Console.WriteLine(message);
            int i = 0;
            Console.WriteLine(s);
            foreach (int ar in arr)
                Console.WriteLine("\t " + ar + "\t" + i++);
        }

        static void ShowResult(int[] arrChanged, int[] arr)
        {
            Console.WriteLine("      Result:");
            //int i = 0;
            foreach (int ar in arrChanged)
            {
                int x = Array.IndexOf(arr, ar);

                Console.WriteLine("\t" + ar + "\t" + x);
            }
            Console.WriteLine();
        }

        static void QuickSort(int[] arr, int l, int r, int[] arr1)
        {
            int i = l;
            int j = r;
            int x = arr[(l + r) / 2];

            while (i <= j)
            {
                while (arr[i] < x)
                    i++;
                while (arr[j] > x)
                    j--;

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    Console.Write("\n\t" + x + "\n\t" + i + "\t" + j + "\n");
                    foreach (int ar in arr)
                    {
                        Console.Write(ar + "  ");
                    }
                    i++;
                    j--;
                }

                Console.WriteLine();
            }

            if (l < j) QuickSort(arr, l, j, arr1);
            if (i < r) QuickSort(arr, i, r, arr1);
        }

        /* static void ShellSort(int[] mass, int[] arr)
         {
             int n = mass.Length;
             int i, j, step;
             int tmp;
             for (step = n / 2; step > 0; step /= 2)
             {
                 for (i = step; i < n; i++)
                 {
                     tmp = mass[i];
                     for (j = i; j >= step; j -= step)
                     {
                         if (tmp < mass[j - step])
                         {
                             mass[j] = mass[j - step];
                         }
                         else
                             break;
                     }
                     if (i != j)
                     {
                         Console.Write("\n\t" + i + "\t" + j + "\n");
                         foreach (int ar in mass)
                         {
                             Console.Write(ar + "  ");
                         }
                     }
                     mass[j] = tmp;
                 }
                 Console.WriteLine();
             }
         }*/

    }
}

