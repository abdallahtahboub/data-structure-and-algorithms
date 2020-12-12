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
        public static void FindSubarray(int sum)
        {
            int counter = 0;

            List<int> val = new List<int>();
            int[] test = { 6, 6, 8, 9, 5, 5, 8, 4, 5, 6 };

            Random r = new Random();
           // int[] test = new int[arrayLength];
            for (int i = 0; i < test.Length; i++)
            {

                var random = r.Next(0, 10);
               // test[i] = random;
                Console.WriteLine(test[i] + " " + "i" + "=" + i);
 
            }

            int result = 0;
           

            for (int i = 0; i < test.Length; i++)
            {

                for (int f = i; f < test.Length; f++)
                {

                    int x = test[f];
                    result += x;
                    val.Add(f);
                    if (result == sum)
                    {
                        counter++;

                        break;

                    }

                    if (test[i] == sum)
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
