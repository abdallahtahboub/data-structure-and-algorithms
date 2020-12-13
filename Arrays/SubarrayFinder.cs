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
            int[] test_1 = { 6, 6, 8, 9, 5, 5, 8, 4, 5, 6 };
            int[] test_2 = { 4, 2, 2, 6, 9, 9, 0, 7, 0, 9 };
            int[] test_3 = { 5, 3, 0, 4, 5, 0, 6, 9, 8, 6 };
            int[] test_4 = { 1, 7, 0, 2, 2, 1, 1, 2, 2, 6 };
            int[] test_5 = { 8, 5, 1, 3, 6, 7, 6, 6, 3, 1 };


            Random r = new Random();
            int[] myArray = new int[arrayLength];
            for (int i = 0; i < myArray.Length; i++)
            {

                var random = r.Next(0, 10);
                myArray[i] = random;
                Console.WriteLine(myArray[i] + " " + "i" + "=" + i);

            }

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
