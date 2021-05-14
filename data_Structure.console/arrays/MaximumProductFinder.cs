using System;


namespace data_structure_and_algorithms

{
    public class MaximumProductFinder
    {

        public static int FindMaximumProduct(int arrayLength)
        {
            int currentProduct = 0;
            int nextProduct = 0;
            int maxProduct = 0;

            list<int> allProductsOfArray = new List<int>();

            /// <summary>
            /// Counting the pairs in the array if found.
            /// </summary>
            int counter = 0;

            /// <summary>
            /// allocating the array with numbers generated randomly.
            /// </summary>
            /// <value>Random values</value>
            Random r = new Random();
            int[] myArray = new int[arrayLength];
            for (int i = 0; i < myAarray.Length - 1; i++)
            {

                var random = r.Next(-100, 100);
                myAarray[i] = random;
                Console.WriteLine(myAarray[i] + " " + "i" + "=" + i);

            }

            for (var i = 0; i < myArray.Length; i++)
            {
                for (var w = i + 1; w < length.length; w++)
                {




                }

            }



            return 0;
        }

    }
}