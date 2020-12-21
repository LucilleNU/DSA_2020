using System;
using System.Diagnostics;

namespace Lecture_7
{

    internal class Program
    {

        static void Main(string[] args)
        {

            var unsorted = new Students[] {
            new Students("Vlad", 4),
            new Students("Peter", 1),
            new Students("Ivan", 6),
            new Students("Maria", 2),
            new Students("Robert", 5),
            new Students("Bob", 3)
            };


            Console.WriteLine("Unsorted:");
            foreach (var s in unsorted)
            {
                Console.Write($"Student: {s.Name}   № {s.StudentNumber}\n");
            }
            Console.WriteLine("\n-----------------------\n");

            Console.WriteLine("Sorted by Bubble sort:");

            foreach (var s in SortedByBubble(unsorted))
            {
                Console.Write($"Student: {s.Name}   № {s.StudentNumber}\n");
            }
            Console.WriteLine("\n-----------------------\n");

            Console.WriteLine("Sorted by Selection sort:");

            foreach (var s in SortedBySelection(unsorted))
            {
                Console.Write($"Student: {s.Name}   № {s.StudentNumber}\n");
            }
            Console.WriteLine("\n-----------------------\n");

            Console.WriteLine("Sorted by Insertion sort:");
            foreach (var s in SortedByInsertion(unsorted))
            {
                Console.Write($"Student: {s.Name}   № {s.StudentNumber}\n");
            }
            Console.WriteLine("\n-----------------------\n");
            Console.WriteLine("Enter any button to continue...");
            Console.ReadLine();
            Console.Clear();

            foreach (var s in SortedBySelection(unsorted))
            {
                Console.Write($"Student: {s.Name}   № {s.StudentNumber}\n");
            }

            Console.WriteLine("\n-----------------------");
            Console.Write("Enter student number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-----------------------\n");
            Console.WriteLine("Lineary Search:");
            Console.WriteLine($"Student № {unsorted[LinearSearch(unsorted, num)].StudentNumber} is {unsorted[LinearSearch(unsorted, num)].Name}");
            Console.WriteLine("Binary Search:");
            if (num == 1)
            {
                Console.WriteLine($"Student № {BinarySearch(SortedByBubble(unsorted), num) + 2} is {SortedByBubble(unsorted)[BinarySearch(SortedByBubble(unsorted), num) + 1].Name}");
            }
            else
            {
                Console.WriteLine($"Student № {BinarySearch(SortedByBubble(unsorted), num) + 1} is {SortedByBubble(unsorted)[BinarySearch(SortedByBubble(unsorted), num)].Name}");
            }

        }

        public static Students[] SortedByBubble(Students[] unsorted)
        {
            Students[] sortedByBubble = unsorted;


            for (int i = sortedByBubble.Length - 1; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {
                    if (sortedByBubble[j].StudentNumber > sortedByBubble[j + 1].StudentNumber)
                    {
                        int temp = sortedByBubble[j].StudentNumber;
                        sortedByBubble[j].StudentNumber = sortedByBubble[j + 1].StudentNumber;
                        sortedByBubble[j + 1].StudentNumber = temp;
                    }
                }
            }
            return sortedByBubble;


        }

        public static Students[] SortedBySelection(Students[] unsorted)
        {
            Students[] sortedBySelection = unsorted;
            int min = 0;
            for (int i = 0; i < sortedBySelection.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < sortedBySelection.Length; j++)
                {
                    if (sortedBySelection[j].StudentNumber < sortedBySelection[min].StudentNumber)
                    {
                        min = j;
                    }
                }
                int temp = sortedBySelection[min].StudentNumber;
                sortedBySelection[i].StudentNumber = sortedBySelection[min].StudentNumber;
                sortedBySelection[min].StudentNumber = temp;
            }

            return sortedBySelection;
        }
        public static Students[] SortedByInsertion(Students[] unsorted)
        {
            Students[] sortedByInsertion = unsorted;
            for (int i = 0; i < sortedByInsertion.Length; i++)
            {
                int temp = sortedByInsertion[i].StudentNumber;
                int j = i;
                while (j > 0 && temp < sortedByInsertion[j - 1].StudentNumber)
                {
                    sortedByInsertion[j].StudentNumber = sortedByInsertion[j - 1].StudentNumber;
                    j = j - 1;
                }
                sortedByInsertion[j].StudentNumber = temp;
            }

            return sortedByInsertion;
        }
        public static int BinarySearch(Students[] SortedByBubble, int key)
        {
            int low = SortedByBubble[0].StudentNumber;
            int high = SortedByBubble[SortedByBubble.Length - 1].StudentNumber;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (SortedByBubble[mid].StudentNumber < key)
                {
                    low = mid + 1;
                }
                else if (SortedByBubble[mid].StudentNumber > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }


            return -1;
        }
        public static int LinearSearch(Students[] unsorted, int key)
        {

            for (int i = 0; i < unsorted.Length; i++)
            {
                if (unsorted[i].StudentNumber == key)
                {
                    return i;
                }

            }
            return -1;
        }

    }

}     

