using SortingApplication.Business;

namespace SortingApplication.Entities
{
    public class QuickSort : Swapper
    {
        protected void SortQuick(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(int[] array, int Left, int Right)
        {
            int L = Left;
            int R = Right;
            int pivotValue = array[(Left + Right) / 2];

            do
            {
                while (array[L] < pivotValue)
                {
                    L++;
                }
                while (pivotValue < array[R])
                {
                    R--;
                }

                if (L <= R)
                {
                    Swap(L, R, array);
                    L++;
                    R--;
                }
            } while (L < R);

            if (Left < R)
            {
                QuickSort(array, Left, R);
            }
            if (L < Right)
            {
                QuickSort(array, L, Right);
            }
        }
    }
}