using System;
using System.Collections.Generic;

namespace data_structure_and_algorithms
{
    public static class BinaryArraySort
    {


        /// <summary>
        /// Sorting a binary array in a linear time o(n)  Linear Complexity.
        /// </summary>
        /// <param name="arrayLength"></param>
        public static int SortBinaryArray(int[] myArray)
        {

            

             //int[] myArray = new int[arrayLength];
            // Random r = new Random();

        //     for (int i = 0; i<myArray.Length; i++)
        //     {

        //         var random = r.Next(0, 2);
        // myArray[i] = random;
        //         Console.WriteLine(myArray[i] + " " + "i" + "=" + i);

        //     }
           
           
            int zeroCounter = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 0)
                {
                    zeroCounter++;

                }

            }

            int Ones = myArray.Length - zeroCounter;


            Console.WriteLine(zeroCounter);
            Console.WriteLine(Ones);


            int counter = 0;

            while (zeroCounter-- != 0)
            {
                myArray[counter++] = 0;

            }

            while (Ones-- != 0)
            {
                myArray[counter++] = 1;

            }



            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);

            }

            return zeroCounter + Ones;

        }

    }
}
