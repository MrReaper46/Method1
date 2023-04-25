using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        public static void DeleteValue(int[] array,int InputIndex)
        {
            int Index = InputIndex - 1;
            if(Index <0 || Index >= array.Length)
            {
                Console.WriteLine("Invalid Input");
            }
            int[] NewArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (i >= Index && i < array.Length - 1)
                {
                    NewArray[i] = array[i + 1];
                }
                else if (i >= Index && i == array.Length - 1)
                {
                    NewArray[i] = 0;
                }
                else if (i < Index)
                {
                    NewArray[i] = array[i];
                }
                else { NewArray[i] = 0; }
                Console.WriteLine($"Index [{i+1}]: \n Old = {array[i]} - New = {NewArray[i]}");
            }
            Console.WriteLine("==========================");

            Console.Write("Old Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.Write("New Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(NewArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==========================");
        }
        static void Main(string[] args)
        {
            Console.Write("Input Array Length: ");
            int Length = Int32.Parse(Console.ReadLine());
            int[] Arr01 = new int[Length];
            for (int i =0; i < Length; i++)
            {
                Console.Write($"Input Value {i+1} : ");
                Arr01[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("==========================");
            
            Console.Write("Input Index: ");
            int Index = Int32.Parse(Console.ReadLine());
            DeleteValue(Arr01, Index);
        }
    }
}
