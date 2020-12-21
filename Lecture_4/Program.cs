using System;
using System.Collections.Generic;


namespace Lesson_04
{
    internal class Program
    {
        private static List<int> listItems = new List<int>();

        private static void Main(string[] args)
        {
            //RemoveOdds();
            //CountArrayElements();
            //MenuList();
            //SortedDict();
            //StudentMarks();

            //Homework 1 & 2
            HW_1();
            HW_2();
        }

        private static void RemoveOdds()
        {
            int[] numbers = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            IDictionary<int, int> occurances = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                int count = 1;
                if (occurances.ContainsKey(number))
                {
                    count = occurances[number] + 1;
                }
                occurances[number] = count;
            }

            List<int> list = new List<int>();

            foreach (var number in numbers)
            {
                if (occurances[number] % 2 == 0)
                {
                    list.Add(number);
                }
            }

            foreach (var w in list)
            {
                Console.WriteLine($"Number {w} ");
            }
        }

        private static void CountArrayElements()
        {
            int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            IDictionary<int, int> numbersCount = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                int count = 1;
                if (numbersCount.ContainsKey(number))
                {
                    count = numbersCount[number] + 1;
                }
                numbersCount[number] = count;
            }

            foreach (var w in numbersCount)
            {
                Console.WriteLine($"Number {w.Key}, count={w.Value} ");
            }
        }

        private static void MenuList()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. List all items");
                Console.WriteLine("4. Exit");

                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItem();
                        break;

                    case "2":
                        RemoveItem();
                        break;

                    case "3":
                        DisplayItems();
                        break;

                    case "4":
                        return;
                }
            }
        }

        private static void AddItem()
        {
            Console.Write("Item to add =");
            int item = int.Parse(Console.ReadLine());
            listItems.Add(item);
        }

        private static void RemoveItem()
        {
            Console.Write("Item to remove =");
            int item = int.Parse(Console.ReadLine());
            listItems.Remove(item);
        }

        private static void DisplayItems()
        {
            foreach (var item in listItems)
            {
                Console.WriteLine($"Item = {item}");
            }
            Console.Write("Press Enter to continue ...");
            Console.ReadLine();
        }

        private static void SortedDict()
        {
            string text = " text some a text just some text";
            IDictionary<string, int> wordsCount = new SortedDictionary<string, int>();

            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }

            foreach (var w in wordsCount)
            {
                Console.WriteLine($"Word {w.Key}, count={w.Value} ");
            }
        }

        private static void StudentMarks()
        {
            Dictionary<string, int> studentMarks = new Dictionary<string, int>();

            studentMarks.Add("Jane", 90);
            studentMarks.Add("John", 80);
            studentMarks.Add("Ivan", 70);
            studentMarks.Add("Peter", 60);
            studentMarks.Add("Maria", 50);

            while (true)
            {
                foreach (KeyValuePair<string, int> studentMark in studentMarks)
                {
                    Console.WriteLine($"Student {studentMark.Key}, mark={studentMark.Value} ");
                }
                Console.WriteLine("------------------------------- ");

                Console.Write("Student name (type exit to exit): ");
                string name = Console.ReadLine();

                if (name == "exit")
                {
                    break;
                }

                if (studentMarks.TryGetValue(name, out int value))
                {
                    Console.WriteLine($"Student '{name}' score is {value}.");
                }
                else
                {
                    Console.WriteLine($"Student '{name}' does not exists.");
                }
            }
        }
        static void HW_1()
        {
            Console.WriteLine("\t-----------Minesweeper Game-----------\n");
            int n = 0;
            int m = 0;
            while (true)
            {
                Console.Write("Define the size of the battlefield: ");

                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    n = x;
                    m = x;
                    break;
                }
                else
                {
                    Console.WriteLine("Not integer vallue can`t be the size.");
                }

            }
            int[,] battlefield = new int[n, m];
            int w = 0;
            int h = 0;
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    battlefield[i, j] = ran.Next(0, 2);
                }
            }

            Console.WriteLine();
            Console.WriteLine("\t(Press 'ex' if you want to end a game)\n");
            bool b = true;
            while (b)
            {
                bool col = false;
                bool row = false;


                do
                {
                    Console.Write("Enter the vertical coordinate:  ");
                    string str = Console.ReadLine();
                    if (str != "ex")
                    {
                        if (int.TryParse(str, out int y))
                        {
                            if (y < n)
                            {
                                h = y - 1;
                                col = true;
                            }
                            else
                            {
                                Console.WriteLine("Vallue which is larger than size can`t be the coordinate. Please, try again.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Not integer vallue can`t be the coordinate. Please, try again.");
                        }
                    }
                    else
                    {
                        goto breakOut;
                    }
                } while (col == false);


                do
                {
                    Console.Write("Enter the horizontal coordinate: ");
                    string str = Console.ReadLine();
                    if (str != "ex")
                    {
                        if (int.TryParse(str, out int x))
                        {
                            if (x < m)
                            {
                                w = x - 1;
                                row = true;
                            }
                            else
                            {
                                Console.WriteLine("Vallue which is larger than size can`t be the coordinate. Please, try again.");

                            }

                        }
                        else
                        {
                            Console.WriteLine("Not integer vallue can`t be the coordinate. Please, try again.");
                        }
                    }
                    else
                    {
                        goto breakOut;
                    }
                }
                while (row == false);

                if (battlefield[h, w] == 0)
                {
                    Console.WriteLine("YEAH!");
                }
                else
                {
                    Console.WriteLine("BOOM!");
                    goto breakOut;
                }

            breakOut:
                Console.WriteLine("\n\t ------End of the game------");
                Console.WriteLine("\nYour battlefield: \n");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (battlefield[i, j] == 1)
                        {
                            Console.Write("X ");
                        }
                        else
                        {
                            Console.Write("O ");
                        }
                    }
                    Console.WriteLine();
                }
                b = false;


            }
        }
        static void HW_2()
        {
            
        }
    }
}