using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        /*static void Main(string[] args)
        {
            //2
            Console.WriteLine("Number М");
            var Nambur_M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number N");
            var Number_N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int count = 0;
            int[] A = new int[Nambur_M];
            int[] B = new int[Number_N];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(10);
            }
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rand.Next(10);
                for (int j = 0; j < A.Length; j++)
                {
                    if (B[i] == A[j])
                    {
                        count++;
                    }
                }
            }
            PrintArr("Array A", A);
            PrintArr("Array B", B);
            if (count != 0)
            {
                int[] AB = new int[count];
                int z = 0;
                for (int i = 0; i < B.Length; i++)
                {
                    for (int j = 0; j < A.Length; j++)
                    {
                        if ((B[i] == A[j]) && (!AB.Contains(B[i])))
                        {
                            AB[z] = B[i];
                            z++;
                        }
                    }
                }
                Array.Resize(ref AB, z);
                PrintArr("common array", AB);
            }
            else
            {
                Console.WriteLine("no common item");
            }
            Console.ReadLine();
        }
        static void PrintArr(string text, int[] arr)
        {
            Console.WriteLine(text + ": ");
            for (int A = 0; A < arr.Length; A++)
            {
                Console.Write(arr[A] + " ");
            }
            Console.WriteLine();
        }
        */

        static void Main(string[] args)
        {
            //4
            /*string[] Text;
            string array = Console.ReadLine();
            Text = array.Split(' ');
            Console.WriteLine(Text.Length);
            Console.ReadLine();
            */


            //5
            /*
            const int size = 10; 
            int[] array = new int[size]; 
            Random rand = new Random(); 
            for (int n = 0; n < size; n++)
                array[n] = rand.Next(10, 100); 

            foreach (int a in array)
                Console.Write("{0} ", a);

            int max = array[0]; 
            int min = array[0]; 

            foreach (int a in array)
                if (a > max) max = a; 

            foreach (int b in array)
                if (b < min) min = b; 

            Console.WriteLine();
            Console.Write(" Max = {0} ", max); 
            Console.Write(" \n\r Min = {0}  ", min); 
            Console.ReadKey();
            */

            //3

            string Text;
            Console.WriteLine("Write the text");
            Text = Console.ReadLine();
            for (int i = 0, j = Text.Length - 1; i < j; i++, j--)
            {
                if (Text[i] != Text[j])
                {
                    Console.WriteLine("no polindrom");
                    break;
                }
                Console.WriteLine("its polindrom");
            }
            Console.ReadKey();

        }


    }

}



