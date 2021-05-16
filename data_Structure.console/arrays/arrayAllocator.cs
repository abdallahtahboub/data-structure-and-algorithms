using System;


namespace data_structure_and_algorithms
{
    public class ArrayAllocator
    {

        public static int[] AllocateArrayRandomly(int arrayLength)
        {
            /// <summary>
            /// allocating the array with numbers generated randomly.
            /// </summary>
            /// <value>Random values</value>

            Random randomNumberGenerator = new Random();
            int[] myArray = new int[arrayLength];
            for (int i = 0; i < myArray.Length; i++)
            {
                var random = randomNumberGenerator.Next(-100, 100);
                myArray[i] = random;
                Console.WriteLine(myArray[i] + " " + "i" + "=" + i);

            }

            return myArray;
        }

        public static int[] AllocateBinaryArrayRandomly(int arrayLength)
        {
            /// <summary>
            /// allocating the array with numbers generated randomly.
            /// </summary>
            /// <value>Random values</value>

            Random randomNumberGenerator = new Random();
            int[] myArray = new int[arrayLength];
            for (int i = 0; i < myArray.Length; i++)
            {
                var random = randomNumberGenerator.Next(-1, 1);
                myArray[i] = random;
                Console.WriteLine(myArray[i] + " " + "i" + "=" + i);

            }

            return myArray;
        }

    }
}