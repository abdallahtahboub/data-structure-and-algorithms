using System;
using System.Collections.Generic;

namespace data_structure_and_algorithms
{
    public static class BinaryArraySort
    {

        public static void SortBinaryArray(int arrayLength)
        {

            //int counter = 0;
            int[] myArray = new int[arrayLength];
            Random r = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {

                var random = r.Next(0, 2);
                myArray[i] = random;
                Console.WriteLine(myArray[i] + " " + "i" + "=" + i);

            }

            int zeroCounter = 0;
            int OnesCounter = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 0)
                {
                    zeroCounter++;

                }

            }

            int rest = myArray.Length - zeroCounter;


            Console.WriteLine(zeroCounter);
            Console.WriteLine(OnesCounter);


            int counter = 0;

            while (zeroCounter-- != 0)
            {
                myArray[counter++] = 0;

            }

            while (rest-- != 0)
            {
                myArray[counter++] = 1;

            }



            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);

            }

            return;

        }

    }
}
