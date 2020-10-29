using System;
using System.Collections.Generic;

namespace data_structure_and_algorithms {

    /// <summary>
    /// Exercise 2 Subbarray
    /// https://blog.usejournal.com/500-data-structures-and-algorithms-practice-problems-35afe8a1e222
    /// </summary>
    class SubarrayFinder {

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
             
            List<int> val = new List<int> ();

            Random r = new Random();
            int[] myArray = new int[arrayLength];
            for (int i = 0; i < myArray.Length; i++) {

                var random = r.Next(0, 10);
                myArray[i] = random;
                Console.WriteLine(myArray[i] + " " + "i" + "=" + i);

            }
            

            /// For testting.
            //int[] test = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = 0;

            for (int i = 0; i < myArray.Length ; i++)
            {

                for (int f = i; f < myArray.Length ; f++)
                {
                    
                    int x = myArray[f];
                    result += x;
                    val.Add(f);
                    if (result == sum)
                    {
                        counter++;
                       
                    }

                    if (myArray[i] == sum)
                    {
                        counter++;
                    }
                 

                }
                result = 0;
                

            }
            Console.WriteLine(counter + " " + "Ssubarrays were found in the root array with the sum" + " " + sum + ".");


            return;

        }

    }
}
