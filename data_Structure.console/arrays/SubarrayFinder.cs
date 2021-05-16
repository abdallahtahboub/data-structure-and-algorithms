using System;
using System.Collections.Generic;

namespace data_structure_and_algorithms
{

    /// <summary>
    /// Exercise 2 Subbarray
    /// https://blog.usejournal.com/500-data-structures-and-algorithms-practice-problems-35afe8a1e222
    /// </summary>
    class SubarrayFinder
    {

        /// <summary>
        /// Finding subarrays in an array.
        ///  Still could be optimized.
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="arrayLength"></param>
        /// <returns></returns>
        public static void FindSubarray(int sum, int arrayLength)
        {
            int counter = 0;

            List<int> val = new List<int>();

            int[] myArray = ArrayAllocator.AllocateArrayRandomly(arrayLength);

            int result = 0;


            for (int i = 0; i < myArray.Length; i++)
            {

                for (int f = i; f < myArray.Length;)
                {

                    int x = myArray[f];
                    result += x;
                    val.Add(f);
                    if (result == sum)
                    {
                        counter++;

                        break;

                    }

                    if (myArray[i] == sum)
                    {
                        counter++;
                    }

                    break;

                }
                result = 0;


            }
            Console.WriteLine(counter + " " + "Ssubarrays were found in the root array with the sum" + " " + sum + ".");


            return;

        }

    }
}
