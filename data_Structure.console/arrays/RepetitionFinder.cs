using System;
namespace data_Structure.console.Arrays
{
    public static class RepetitionFinder
    {

        // Constrains: 
        // 1. Maximum size of array is 100.
        // 2. array values should be from 0-9.

        public static void FindRepeatedElements(byte[] MyArray)
        {
            byte[] result = new byte[10];

            if (MyArray.Length > 100)
            {
                Console.WriteLine("Array size cant be greater than 100");
            }
            else
            {
                for (byte i = 0; i < MyArray.Length; i++)
                {
                    byte temp = MyArray[i];
                    result[temp]++;
                }
            }
            for (byte i = 0; i < result.Length; i++)
            {
                Console.WriteLine(i + " " + result[i]);
            }
        }

    }
}