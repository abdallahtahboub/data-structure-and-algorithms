using System;



namespace data_structure_and_algorithms
{
    public static class BinaryArraySorter
    {



        /// <summary>
        /// Sorting a binary array in a linear time o(n)  Linear Complexity.
        /// </summary>
        /// <param name="arrayLength"></param>
        public static int SortBinaryArray(int arrayLength)
        {
            // todo: create binary array allocator.
            int[] myArray = ArrayAllocator.AllocateArrayRandomly(arrayLength);

            int zeroCounter = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 0)
                {
                    zeroCounter++;

                }

            }



            int Ones = myArray.Length - zeroCounter;

            // Writing zeroncounter and onesCounter on console.
            Console.WriteLine(zeroCounter + " " + "Zeros");
            Console.WriteLine(Ones + " " + "Ones");

            int counter = 0;
            if (zeroCounter != 0)
            {
                while (zeroCounter-- != 0)
                {
                    myArray[counter++] = 0;

                }

            }

            // Writing zeroncounter on console.
            Console.WriteLine(zeroCounter + " " + "Zero Counter");
            while (Ones-- != 0)
            {
                myArray[counter++] = 1;

            }

            //Writing sorted array on console

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);

            }

            int sorted_Array_Length = myArray.Length;

            return sorted_Array_Length;

        }

    }
}
