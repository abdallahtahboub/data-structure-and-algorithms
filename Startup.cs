using System;

namespace data_structure_and_algorithms
{
    static class Startup
    {

        public static void Run()
        {

            Console.WriteLine("Hello World!");
            //PairFinder.FindPair(4, 10000000);
            BinaryArraySort.SortBinaryArray(new int[] { 0, 0, 0, 0, 0, 0 }, 10);
            Console.WriteLine();
            //SubarrayFinder.FindSubarray(6,10);
            Console.ReadLine();

        }

    }
}
