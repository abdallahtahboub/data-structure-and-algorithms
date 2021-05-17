using System;


namespace data_structure_and_algorithms
{
    public class ArrayAllocator
    {
        /// <summary>
        /// allocating the array with numbers generated randomly.
        /// </summary>
        /// <param name="arrayLength"></param>
        /// <param name="rangeBetween"></param>
        /// <param name="rangeTo"></param>
        /// <returns>myArray</returns>
        public static int[] AllocateArrayRandomly(int arrayLength, int rangeBetween, int rangeTo)
        {

            Random randomNumberGenerator = new Random();
            int[] myArray = new int[arrayLength];
            for (int i = 0; i < myArray.Length; i++)
            {
                var random = randomNumberGenerator.Next(rangeBetween, rangeTo);
                myArray[i] = random;
                // Console.WriteLine(myArray[i] + " " + "i" + "=" + i);

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