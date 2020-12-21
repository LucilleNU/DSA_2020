using System.Collections.Generic;
using System;

namespace Lecture_6
{

    class Program
    {
        static void Main(string[] args)
        {
            Exercise_3();
        }
        static void Exercise_3()
        {
            double price;
            string title;
            string barcode;
            string vendor;
            Dictionary<double, string[]> dict = new Dictionary<double, string[]>();
            string[] store = new string[3];

            bool forever = true;
            bool ask = false;

            while (forever)
            {
                Console.WriteLine("1. Input component");
                Console.WriteLine("2. Retrieve component");
                Console.WriteLine("3. Exit");
                Console.Write("Input the number corresponding to the desired operation: ");
                int response = Convert.ToInt32(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        Console.Write("Input Price: ");
                        price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input Vendor: ");
                        vendor = Console.ReadLine();
                        Console.Write("Input Barcode: ");
                        barcode = Console.ReadLine();
                        Console.Write("Input Title: ");
                        title = Console.ReadLine();
                        store[0] = vendor;
                        store[1] = barcode;
                        store[2] = title;

                        dict.Add(price, store);

                        ask = true;
                        break;

                    case 2:
                        if (ask)
                        {
                            Console.Write("Input price: ");
                            double price_input = Convert.ToDouble(Console.ReadLine());
                            if (dict.ContainsKey(price_input))
                            {
                                string[] toPrint = dict[price_input];
                                Console.WriteLine("Your vendor is: " + toPrint[0]);
                                Console.WriteLine("Your barcode is: " + toPrint[1]);
                                Console.WriteLine("Your title is: " + toPrint[2]);
                            }
                            else
                            {
                                Console.WriteLine("Product doesn't exist");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please input component first. ");
                        }
                        break;
                    case 3:
                        forever = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input. Please write an integer between 1 and 3. " +
                            "");
                        break;

                }
            }
        }
    }
}