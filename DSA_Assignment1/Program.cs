using System;

namespace DSA_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEST

            CustomDataList please_work = new CustomDataList("Bob", "Clay", "123hhh", 13.5);

            please_work.PopulateWithSampleData();
            please_work.DisplayList();

            object[] test = please_work.GetElement(3);
            Console.WriteLine(test[1]);
            Console.ReadLine();
        }



    }
}