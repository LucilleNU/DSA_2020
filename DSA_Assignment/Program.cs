using System;


namespace DSA_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment_2();
        }

        static void Assignment_2()
        {
            bool forever = true;
            object[] Average_scores;
            CustomDataList Test = new CustomDataList(); // Create an instance of CustomDataList
            
            while (forever)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("THIS MAIN MENU HELPS YOU NAVIGATE");
                Console.WriteLine("-----------------------------------------------------");

                Console.WriteLine("1. TO POPULATE WITH SAMPLE DATA.");
                Console.WriteLine("2. TO INPUT NEW ELEMENT.");
                Console.WriteLine("3. TO GET AN ELEMENT BY INDEX.");
                Console.WriteLine("4. TO DELETE AN ELEMENT BY INDEX.");
                Console.WriteLine("5. TO REMOVE FIRST ELEMENT.");
                Console.WriteLine("6. TO REMOVE LAST ELEMENT.");
                Console.WriteLine("7. TO DISPLAY ALL ELEMENTS IN DATA STRUCTURE.");
                Console.WriteLine("8. TO SORT ELEMENT BY DIRECTION(Ascending & Decending Order Of Average Score).");
                Console.WriteLine("9. TO VIEW STUDENT WITH HIGHEST AVERAGE SCORE.");
                Console.WriteLine("10. TO VIEW STUDENT WITH LOWEST AVERAGE SCORE.");
                Console.WriteLine("11. TO EXIT. \n ");

                Console.Write("Input the number corresponding to the desired operation: ");
                int response = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (response > 0 && response <= 12) {

                    switch (response)
                    {
                        case 1://Populate With Sample Data
                            Test.PopulateWithSampleData();
                            Console.ReadKey();
                            break;

                        case 2: //input New Element
                            Console.Write("Please Input Student First Name:");
                            string FirstName = Console.ReadLine();
                            Console.Write("Please Input Student Last Name:");
                            string LastName = Console.ReadLine();
                            Console.Write("Please Input Student Number:");
                            string StudentNumber = Console.ReadLine();
                            Console.Write("Please Input Student Average Score:");
                            float AverageScore = (float)Convert.ToDouble(Console.ReadLine());

                            Test.Add(FirstName, LastName, StudentNumber, AverageScore);
                            break;

                        case 3: //Get Element By Index
                            Console.WriteLine("Please enter the index of the element you want (note that your index begins with 0):");
                            int Index = Convert.ToInt32(Console.ReadLine());

                            object[] Student = Test.GetElement(Index);
                            Console.WriteLine();
                            Console.WriteLine("Fist Name: " + Student[0]);
                            Console.WriteLine("Last Name: " + Student[1]);
                            Console.WriteLine("Student Number: " + Student[2]);
                            Console.WriteLine("Average Score: " + Student[3]);
                            break;

                        case 4: //Delete Element By Index
                            Console.WriteLine("Please enter the index of the element you wish to delete (note that your index begins with 0):");
                            int index = Convert.ToInt32(Console.ReadLine());
                            Test.RemoveByIndex(index);
                            break;

                        case 5: //Remove First Element
                            Test.RemoveFirst();
                            Console.ReadKey();
                            break;

                        case 6: //Remove Last Element
                            Test.RemoveLast();
                            Console.ReadKey();
                            break;

                        case 7: //Display all Elements
                            Test.DisplayList();
                            Console.ReadKey();
                            break;

                        case 8:
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("1. TO VIEW ALL ELEMENT IN ACENDING ORDER OF AVERAGE SCORE.");
                            Console.WriteLine("2. TO VIEW ALL ELEMENT IN DECENDING ORDER OF AVERAGE SCORE.");
                            Console.WriteLine("-----------------------------------------------------------");
                            int request = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            float[] accend = new float[Test.Length]; // We create an array of float same size as my dictionary

                            switch (request)
                            {
                                case 1: //View Element In Acending Order
                                    int counter = 0;
                                    while (counter < accend.Length)//browse all data in the array
                                    {
                                        Student = Test.GetElement(counter);
                                        accend[counter] = (float)Student[3];
                                        counter++;
                                    }
                                    Array.Sort(accend);
                                    Console.WriteLine();
                                    Console.WriteLine("See Below all saved elements in ascending order of average score");
                                    foreach (float average in accend)
                                    {
                                        Student = Test.GetElementByAverage(average);
                                        Console.WriteLine("Fist Name: " + Student[0]);
                                        Console.WriteLine("Last Name: " + Student[1]);
                                        Console.WriteLine("Student Number: " + Student[2]);
                                        Console.WriteLine("Average Score: " + Student[3]);
                                        Console.WriteLine();
                                    }
                                    break;

                                case 2: //View Element In Decending Order
                                    Array.Reverse(accend);
                                    Console.WriteLine();
                                    Console.WriteLine("See Below all saved elements in ascending order of average score");
                                    foreach (float average in accend)
                                    {
                                        Student = Test.GetElementByAverage(average);
                                        Console.WriteLine("Fist Name: " + Student[0]);
                                        Console.WriteLine("Last Name: " + Student[1]);
                                        Console.WriteLine("Student Number: " + Student[2]);
                                        Console.WriteLine("Average Score: " + Student[3]);
                                        Console.WriteLine();
                                    }
                                    break;
                            }
                            break;

                        case 9: //View Student with Highest Average Score
                            Average_scores = Test.Highest_Score;
                            Console.WriteLine("Find Below Details Of Student With Highest Score");
                            Console.WriteLine("First Name: " + Average_scores[0]);
                            Console.WriteLine("Last Name: " + Average_scores[1]);
                            Console.WriteLine("Student Id: " + Average_scores[2]);
                            Console.WriteLine("Average Score: " + Average_scores[3]);
                            break;

                        case 10: //View Student with Lowest Average Score
                            Average_scores = Test.Lowest_Score;
                            Console.WriteLine("Find Below Details Of Student With Lowest Score");
                            Console.WriteLine("First Name: " + Average_scores[0]);
                            Console.WriteLine("Last Name: " + Average_scores[1]);
                            Console.WriteLine("Student Id: " + Average_scores[2]);
                            Console.WriteLine("Average Score: " + Average_scores[3]);
                            break;

                        case 11: // Exit the program
                            goto breakOut; // Goes outside the huge while loop

                        default: //returning to main menu
                            forever = false;
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("enter a random key to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                    Console.WriteLine("This is not a correct choice, please enter 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 or 11.");
            }
        breakOut:;
        }
    }
}

 

 





