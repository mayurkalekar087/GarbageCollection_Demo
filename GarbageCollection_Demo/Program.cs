using System;

namespace GarbageCollection_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[50000]; //allocating array
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect(); //collecting garbage
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }


            Console.WriteLine("++++++++++++++++++++++++++++");

            long bytes1 = GC.GetTotalMemory(false); //getting memory in bytes

            byte[] memory = new byte[1000 * 1000 * 10];//ten million bytes
            memory[0] = 1; //set memory (prevent allocation from being optimized out)

            long bytes2 = GC.GetTotalMemory(false);
            long bytes3 = GC.GetTotalMemory(true);

            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 - bytes1); //giving difference
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2);//giving differene
            Console.ReadLine();
        }
    }
}