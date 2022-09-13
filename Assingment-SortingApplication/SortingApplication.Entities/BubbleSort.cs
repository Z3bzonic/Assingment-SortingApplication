using SortingApplication.Business;

namespace SortingApplication.Entities
{
    public class BubbleSort : Swapper
    {
        public void SortBubble(int[] array)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        Swap(i, i + 1, array);
                    }
                }
            }
        }
    }
}