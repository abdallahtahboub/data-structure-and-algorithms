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


            /// <summary>
            /// allocating the array with numbers generated randomly.
            /// </summary>
            /// <value>Random values</value>
            Random randomNumberGenerator = new Random();
            int[] myArray = new int[arrayLength];
            for (int i = 0; i < myArray.Length; i++)
            {

                var random = randomNumberGenerator.Next(-100, 100);
                myArray[i] = random;
                Console.WriteLine(myArray[i] + " " + "i" + "=" + i);

            }

            for (var x = 0; x < myArray.Length; x++)
            {
                for (var y = x + 1; y < myArray.Length; y++)
                {

                    currentProduct = myArray[x] * myArray[y];


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