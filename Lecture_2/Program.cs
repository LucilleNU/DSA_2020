using System;
using System.Collections;
using System.Collections.Generic;

namespace Lecture_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HW_quest1();
            HW_quest2();
            HW_quest3();
            HW_quest4();
            //Task01();
            //Task02();
            //Task03();
        }

        static void HW_quest1()
        {
            float[] Array = new float[10];
            Random r = new Random();
            bool b = false;
            for (int i = 0; i < 10; i++)
            {
                Array[i] = r.Next(1, 10);
            }
            Console.WriteLine("Please, type the number to check is it in array: ");
            int a = int.Parse(Console.ReadLine());
            for (int j = 0; j < 10; j++)
            {
                if (Array[j] == a)
                {
                    b = true;
                }
            }
            if (b)
            {
                Console.WriteLine($"Your number is in array");
            }
            else { Console.WriteLine($"Your number isn't in array"); }
            Console.Write("Array: ");
            foreach (int elem in Array)
            {
                Console.Write(+elem + " ");
            }

        }

        static void HW_quest2()
        {
            Stack<int> stack = new Stack<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(r.Next(1, 10));
            }
            Console.WriteLine("Please, type the number to check is it in stack:");
            int a = int.Parse(Console.ReadLine());
            if (stack.Contains(a))
            {
                Console.WriteLine($"Your number is in stack");
            }
            else
            {
                Console.WriteLine($"Your number isn't in stack");
            }
            Console.Write("Stack: ");
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }

        static void HW_quest3()
        {
            Queue<int> Q = new Queue<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Q.Enqueue(r.Next(1, 10));
            }
            Console.WriteLine("Please, type the number to check is it in queue:");
            int a = int.Parse(Console.ReadLine());
            if (Q.Contains(a))
            {
                Console.WriteLine($"Your number is in queue");
            }
            else
            {
                Console.WriteLine($"Your number isn't in queue");
            }
            Console.Write("Queue: ");
            foreach (int id in Q)
            {
                Console.Write(id + " ");
            }
        }

        static void HW_quest4()
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(r.Next(1, 10));
            }
            Console.WriteLine("Please, type the number to check is it in list:");
            int a = int.Parse(Console.ReadLine());
            if (list.Contains(a))
            {
                Console.WriteLine($"Your number is in list");
            }
            else
            {
                Console.WriteLine($"Your number isn't in list");
            }
            Console.Write("List: ");
            foreach (int id in list)
            {
                Console.Write(id + " ");
            }
        }

        private static void Task01()
        {
            // Initialization
            string[] names = { "Ivan", "Peter", "John", "Jane", "Maria" };

            DateTime[] bdays = new DateTime[names.Length];
            bdays[0] = new DateTime(2000, 01, 22);
            bdays[1] = new DateTime(2001, 01, 02);
            bdays[2] = new DateTime(2002, 01, 02);
            bdays[3] = new DateTime(2003, 01, 02);
            bdays[4] = new DateTime(2004, 01, 02);

            // User input
            Console.Write("Please enter index (0-4): ");
            int index = int.Parse(Console.ReadLine());

            // Program logic
            string periodOfMonth = GetPeriodOfMonth(bdays, index);
            string monthName = GetNameOfMonth(bdays[index].Month);

            // Output
            Console.WriteLine($"{names[index]}'s is born in the {periodOfMonth} in {monthName} ");
        }

        private static string GetPeriodOfMonth(DateTime[] bdays, int index)
        {
            int day = bdays[index].Day;
            string periodOfMonth = "beginning";

            if (day > 10)
            {
                periodOfMonth = "middle";
            }

            if (day > 20)
            {
                periodOfMonth = "end";
            }

            return periodOfMonth;
        }

        private static string GetNameOfMonth(int month)
        {
            if (month == 1) return "January";
            if (month == 2) return "February";
            if (month == 3) return "March";
            if (month == 4) return "April";
            if (month == 5) return "May";
            if (month == 6) return "Juny";
            if (month == 7) return "July";
            if (month == 8) return "August";
            if (month == 9) return "September";
            if (month == 10) return "October";
            if (month == 11) return "November";
            if (month == 12) return "December";

            return "Unknown";
        }


        private static void Task02()
        {
            // Initialization and Input
            string sentence = "Write a C# Sharp Program to display the following pattern using the alphabet.";

            // Program logic
            string[] words = sentence.Split(" ");

            string longest = "";
            foreach (string word in words)
            {
                if (longest.Length < CleanWord(word).Length)
                {
                    longest = word;
                }
            }

            // Output
            Console.WriteLine($"The longes word is '{longest}' ");

            Console.ReadKey();
        }

        private static string CleanWord(string word)
        {
            return word.Replace(".", "").Replace(",", "");
        }

        private static void Task03()
        {
            // Initialization
            string sentence = "Display the pattern like pyramid using the alphabet";

            // Program logic
            string[] words = sentence.Split(" ");
            Stack<string> stack = new Stack<string>();

            foreach (string word in words)
            {
                stack.Push(word);
            }

            // Output
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.ReadKey();
        }


    }
}



