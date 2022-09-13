using System.ComponentModel;

namespace SortingApplication.Entities
{
    public class ZipSort
    {
        [Description("Sorting for numbers with no gaps")]
        public void SortZip(int[] array)
        {
            var tmp = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                tmp[i] = i;
            }
        }
    }
}