using SortingApplication.Entities;

namespace SortingApplication.Common
{
    public class Menu
    {
        public BubbleSort Bubble { get; set; } = new BubbleSort();
        public QuickSort Quick { get; set; } = new QuickSort();
        public ShakerSort Shaker { get; set; } = new ShakerSort();
        public ZipSort Zip { get; set; } = new ZipSort();

        public void Sort(SortingMechanic algorithm, int[] array)
        {
            switch (algorithm)
            {
                case SortingMechanic.Bubble:
                    Bubble.SortBubble(array);
                    break;

                case SortingMechanic.Shaker:
                    Shaker.SortShaker(array);
                    break;

                case SortingMechanic.Quick:
                    Quick.SortQuick(array);
                    break;

                case SortingMechanic.Zip:
                    Zip.SortZip(array);
                    break;
            }
        }
    }
}