using SortingApplication.Common.Enums;
using SortingApplication.Entities;
using System.Diagnostics.Metrics;

namespace SortingApplication.Common
{
    public class Presentation
    {
        public BubbleSort Bubble { get; set; } = new BubbleSort();
        public QuickSort Quick { get; set; } = new QuickSort();
        public ShakerSort Shaker { get; set; } = new ShakerSort();
        public ZipSort Zip { get; set; } = new ZipSort();

        public void SelectDataAndSorting()
        {
            var inputSelect = DisplayMenu(Enum.GetNames(typeof(SortingMechanic)));
            var sortSelect = DisplayMenu(Enum.GetNames(typeof(DataSource)));
        }

        public string DisplayMenu(params string[] choice)
        {
            SetItemColor();
            Console.Write("Select your desired sorting option");
            Console.Clear();
            int counter = 0;
            foreach (var item in choice)
            {
                SetMenuCursor(counter);
                Console.Write($"[ ] {item}");
                counter++;
            }
            SelectItem(counter, choice);
            Console.ResetColor();
            return " ";
        }

        public void SelectItem(int counter, string[] choice)
        {
            counter = 0;
            SetMenuCursor();
            ConsoleKey input = Console.ReadKey().Key;
            while (input != ConsoleKey.Enter)
            {
                if (input != ConsoleKey.Spacebar)
                {
                }
                if (input == ConsoleKey.DownArrow)
                {
                    if (counter + 1 <= choice.Length)
                    {
                        SetMenuCursor(counter);
                        SetItemColor('n');
                        Console.Write($"[ ] {choice[counter]}");
                        counter++;
                        SetMenuCursor(counter);
                        SetItemColor();
                        Console.Write($"[ ] {choice[counter]}");
                    }
                }
                if (input == ConsoleKey.UpArrow)
                {
                    if (counter - 1 < -1)
                    {
                        SetMenuCursor(counter);
                        SetItemColor('n');
                        Console.Write($"[ ] {choice[counter]}");
                        counter--;
                        SetMenuCursor(counter);
                        SetItemColor();
                        Console.Write($"[ ] {choice[counter]}");
                    }
                }
            }
        }

        private void SetItemColor(char option = ' ')
        {
            ConsoleColor backgroundColor = ConsoleColor.White;
            ConsoleColor textColor = ConsoleColor.Cyan;
            if (option == 'n')
            {
                Console.BackgroundColor = textColor;
                Console.ForegroundColor = backgroundColor;
            }
            else
            {
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = textColor;
            }
        }

        public void SetMenuCursor(int increaseVerticalPosition, int horizontalCursorPosition = 55)
        {
            var verticalCursorPosition = 5 + increaseVerticalPosition;
            Console.SetCursorPosition(horizontalCursorPosition, verticalCursorPosition);
        }

        public void SetMenuCursor()
        {
            var verticalCursorPosition = 5;
            var horizontalCursorPosition = 55;
            Console.SetCursorPosition(horizontalCursorPosition, verticalCursorPosition);
        }

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