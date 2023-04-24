using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        public static void DeleteValue(int[] array,int Index)
        {
            //Console.WriteLine(array.Length);
            //Console.WriteLine(Index);
            if(Index <0 || Index >= array.Length)
            {
                Console.WriteLine("Invalid Input");
            }
            int[] NewArray = new int[array.Length];

            //Console.WriteLine(NewArray.Length);

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
                Console.WriteLine($"Index [{i}]: \n Old = {array[i]} - New = {NewArray[i]}");
            }

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
        }
        static void Main(string[] args)
        {
            Console.Write("Input Index: ");
            int Index = Int32.Parse(Console.ReadLine());
            int[] Arr01 = new int[10];
            Arr01.SetValue(10, 0);
            Arr01.SetValue(4, 1);
            Arr01.SetValue(6, 2);
            Arr01.SetValue(7, 3);
            Arr01.SetValue(8, 4);
            Arr01.SetValue(6, 5);
            
            DeleteValue(Arr01, Index);
        }
    }
}
