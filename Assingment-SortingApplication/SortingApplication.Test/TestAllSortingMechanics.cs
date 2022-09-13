using Xunit;

namespace SortingApplication.Test
{
    public class TestAllSortingMechanics
    {
        [Theory]
        public void Test()
        {
            var expected = 0;
            var actual =
            var values = (SortingAlgorithm[])Enum.GetValues(typeof(SortingAlgorithm));
            foreach (var algorithm in values)
            {
                swapped = 0;
                int[] actual = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
                Sort(algorithm, actual);
                Console.WriteLine($"sorting done using {algorithm}, needed {swapped} swaps to sort the array");
            }

            Console.ReadKey();
        }
    }