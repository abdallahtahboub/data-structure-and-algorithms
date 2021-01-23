using System;



namespace data_structure_and_algorithms
{
    public static class BinaryArraySort
    {

        static int[] MyArray;

        /// <summary>
        /// Sorting a binary array in a linear time o(n)  Linear Complexity.
        /// </summary>
        /// <param name="arrayLength"></param>
        public static int SortBinaryArray(int[] MyArray, int length)
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
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] == 0)
                {
                    zeroCounter++;

                }

            }



            int Ones = MyArray.Length - zeroCounter;

            // Writing zeroncounter and onesCounter on console.
            // Console.WriteLine(zeroCounter + " " + "Zeros");
            // Console.WriteLine(Ones + " " + "Ones");

            int counter = 0;
            if (zeroCounter != 0)
            {
                while (zeroCounter-- != 0)
                {
                    MyArray[counter++] = 0;

                }

            }

            // Writing zeroncounter on console.
            // Console.WriteLine(zeroCounter + " " + "Zero Counter");
            while (Ones-- != 0)
            {
                MyArray[counter++] = 1;

            }

            // Writing sorted array on console

            // for (int i = 0; i < MyArray.Length; i++)
            // {
            //     Console.WriteLine(MyArray[i]);

            // }

            int sorted_Array_Length = MyArray.Length;

            return sorted_Array_Length;

        }

    }
}
