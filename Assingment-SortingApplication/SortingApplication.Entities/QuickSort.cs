using SortingApplication.Business;

namespace SortingApplication.Entities
{
    public class QuickSort : Swapper
    {
        public void SortQuick(int[] array)
        {
            SortQuick(array, 0, array.Length - 1);
        }

        public void SortQuick(int[] array, int Left, int Right)
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
                SortQuick(array, Left, R);
            }
            if (L < Right)
            {
                SortQuick(array, L, Right);
            }
        }
    }
}