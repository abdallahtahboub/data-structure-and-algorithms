using System;
using data_Structure.console.Arrays;

namespace data_structure_and_algorithms
{
    static class Startup
    {

        public static void Run()
        {

            Console.WriteLine("Hello linked google List!");
            //PairFinder.FindPair(4, 10000000);
            //BinaryArraySorter.SortBinaryArray(100);
            //Console.WriteLine();
            //SubarrayFinder.FindSubarray(0,100);
            // BuubleArraySorter.SortBubbleArray(1000000);

            // LinkedList LS = new LinkedList();
            // LS.AddLast(10);
            // LS.AddLast(20);
            // LS.AddLast(500);
            // LS.AddLast(40);
            // LS.AddLast(50);
            // LS.AddLast(60);
            // LS.AddLast(70);
            // LS.AddLast(80);
            // LS.Print();
            // Console.WriteLine();
            // var x = LS.Find(70);
            // Console.WriteLine(x.Data);
            // Console.WriteLine(x.next.Data);
            // LS.AddAfterElement(10,40);
            // LS.AddAfterElement(10000,40);
            // LS.Print();
            //MaximumProductFinder.FindMaximumProduct(10000);
            //ArrayAllocator.AllocateArrayRandomly(1000);
             
             byte[] testArray = {1,2,3,4,5,6,1,1,1,5,6,5,5,9,6,5,4,3,2,0,0,0,0};
             RepetitionFinder.FindRepeatedElements(testArray);

            

        }

    }

    
}
