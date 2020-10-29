using System;

namespace data_structure_and_algorithms

{   
    
    /// <summary>
    /// Exercise 2 Subbarray
    /// https://blog.usejournal.com/500-data-structures-and-algorithms-practice-problems-35afe8a1e222
    /// </summary>
     class PairFinder {
        /// <summary>
        /// Finds pairs in an array with a specefic sum
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="arrayLength"></param>
        public static void FindPair(int sum, int arrayLength)

        {
            /// <summary>
            /// Counting the pairs in the array if found.
            /// </summary>
            int counter = 0;

            /// <summary>
            /// allocating the array with numbers generated randomly.
            /// </summary>
            /// <value>Random values</value>
             Random r = new Random ();
            int[] myAarray = new int[arrayLength];
            for (int i = 0; i < myAarray.Length - 1; i++) {

                var random = r.Next(-100, 100);
                myAarray[i] = random;
                Console.WriteLine (myAarray[i] + " " + "i" + "=" + i);

            }

            for (int i = 0; i < myAarray.Length - 1; i++)
            {
                // i+1 for no replications. //Optimaization.

                for (int s = i + 1; s < myAarray.Length;s++) {

                    if (myAarray[i] + myAarray[s] == sum) {

                        counter++;

                        Console.WriteLine ("Pair found at " + i + "" + "and" + "" + s + ":");
                        /// <summary>
                        /// Break for optimization. Otherwise it would take for ever. 
                        /// </summary>
                        break;

                    } else {
                        Console.WriteLine("No Pair found at " + i + "" + "and" + "" + s + ":");
                        /// <summary>
                        /// Break for optimization. Otherwise it would take for ever. 
                        /// </summary>

                        break;

                    }


                }

            }

            Console.WriteLine(counter + " " + "pairs found with the sum" + "" + " " + sum);

        }
    }
}
