using System;
using Xunit;
using data_structure_and_algorithms;

namespace Tests
{
    public class NewBaseType
    {
        /// <summary>
        /// Testing the length of a sorted Array
        /// </summary>
        /// <param name="arrayToTest"></param>
        [Theory]
        [InlineData(new int[] { 1, 0, 0, 0, 1, 1 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 })]
        [InlineData(new int[] { 1, 0, 1, 0, 1, 1 })]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0 })]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 1 })]
        public void Sorted_Array_Lenght(int[] arrayToTest)
        {

            // Arrange
            int expected = 6;

            // Act

            int actual = BinaryArraySort.SortBinaryArray(arrayToTest, 10);

            // Assert
              Assert.Equal(expected, actual);

        }
    }


}
