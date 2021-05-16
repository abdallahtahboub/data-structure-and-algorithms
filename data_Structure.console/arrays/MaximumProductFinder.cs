using System;


namespace data_structure_and_algorithms

{
    public class MaximumProductFinder
    {

        public static int FindMaximumProduct(int arrayLength)
        {
            int currentProduct = 0;
            int maxProduct = 0;
            int index_x = 0;
            int index_y = 0;

            // To do: to find multiple max product if exist. ex: [-3*-2] und [3*2]

            // To do: Optimoze the problem: ex: by sorting the array and then find the max.

            int[] myArray = ArrayAllocator.AllocateArray(arrayLength);


            for (var x = 0; x < myArray.Length; x++)
            {
                for (var y = x + 1; y < myArray.Length; y++)
                {

                    currentProduct = myArray[x] * myArray[y];

                    Console.WriteLine(x + " " + y + ": " + currentProduct);


                    if (maxProduct < currentProduct)
                    {
                        maxProduct = currentProduct;
                        index_x = x;
                        index_y = y;


                    }


                }

            }
            Console.WriteLine("Max product is:" + " " + maxProduct + " " + " at index:" + " " + index_x + " " + "and index: " + " " + index_y);


            return 0;
        }

    }
}