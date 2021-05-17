using System;



namespace data_structure_and_algorithms
{
    public static class BuubleArraySorter
    {
        /// <summary>
        /// swaping two number in an array 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        public static void swap(int[] array, int number_1, int number_2)
        {

            int temp = array[number_1];
            array[number_1] = array[number_2];
            array[number_2] = temp;


        }

        /// <summary>
        /// Bubble sorting
        /// </summary>
        /// <param name="arrayLength"></param>
        /// <returns></returns>
        public static int SortBubbleArray(int arrayLength)
        {

            Console.WriteLine("array is beeing sorted using buuble sort algorithm.....");

            int[] myArray = ArrayAllocator.AllocateArrayRandomly(arrayLength, 0, 2);


            for (var x = 0; x < myArray.Length; x++)
            {
                for (var y = x + 1; y < myArray.Length; y++)
                {

                    if (myArray[x] > myArray[y])
                    {
                        swap(myArray, x, y);
                        //break;

                    }

                }

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);

            }
            Console.WriteLine("Done");


            return 0;

        }

    }
}
