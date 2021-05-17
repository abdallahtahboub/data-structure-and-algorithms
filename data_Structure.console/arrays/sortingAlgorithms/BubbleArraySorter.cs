using System;



namespace data_structure_and_algorithms
{
    public static class BuubleArraySorter
    {



        /// <summary>
        /// Sorting a binary array in a linear time o(n)  Linear Complexity.
        /// </summary>
        /// <param name="arrayLength"></param>


        public static void swap(int[] array, int number_1, int number_2)
        {

            int temp = array[number_1];
            array[number_1] = array[number_2];
            array[number_2] = temp;


        }
        public static int SortBubbleArray(int arrayLength)
        {

            int[] myArray = ArrayAllocator.AllocateArrayRandomly(arrayLength, 0, 10);


            for (var x = 0; x < myArray.Length - 1; x++)
            {
                for (var y = x + 1; y < myArray.Length - 1; y++)
                {

                    if (myArray[x] > myArray[y])
                    {
                        swap(myArray, x, y);

                    }


                }

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);

            }



            return 0;

        }

    }
}
