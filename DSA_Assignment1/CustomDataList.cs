using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Assignment
{
    class CustomDataList
    {
        public object[] student = new object[4];
        public int Length = 0;
        public object[] First = new object[4];
        public object[] Last = new object[4];


        public float MaxElement = 0;
        public float MinElement = 0;


        public Dictionary<int, object[]> Nan = new Dictionary<int, object[]>();

        public CustomDataList(string FirstName, string LastName, string StudentNumber, double AverageScore)
        {
            student[0] = FirstName;
            student[1] = LastName;
            student[2] = StudentNumber;
            student[3] = AverageScore;

            Nan.Add(Length, student);

            First[0] = FirstName;
            First[1] = LastName;
            First[2] = StudentNumber;
            First[3] = AverageScore;

            Last[0] = FirstName;
            Last[1] = LastName;
            Last[2] = StudentNumber;
            Last[3] = AverageScore;

            Length++;
        }

        public void PopulateWithSampleData()
        {
            object[] Student1 = new object[4];
            Student1[0] = "Danail";
            Student1[1] = "Dimitrov";
            Student1[2] = "12dsgeq";
            Student1[3] = 99;
            Nan.Add(Length, Student1);
            Length++;

            object[] Student2 = new object[4];
            Student2[0] = "Lucille";
            Student2[1] = "Nawa";
            Student2[2] = "34uherw";
            Student2[3] = 33.7;
            Nan.Add(Length, Student2);
            Length++;

            object[] Student3 = new object[4];
            Student3[0] = "Kim";
            Student3[1] = "Namjoon";
            Student3[2] = "56bdo";
            Student3[3] = 79.1;
            Nan.Add(Length, Student3);
            Length++;

            object[] Student4 = new object[4];
            Student4[0] = "Jackson";
            Student4[1] = "Wang";
            Student4[2] = "78bvjh";
            Student4[3] = 85;
            Nan.Add(Length, Student4);
            Length++;

            object[] Student5 = new object[4];
            Student5[0] = "Jay";
            Student5[1] = "Park";
            Student5[2] = "90bhu";
            Student5[3] = 84.2;
            Nan.Add(Length, Student5);
            Length++;

            Last[0] = Student5[0];
            Last[1] = Student5[1];
            Last[2] = Student5[2];
            Last[3] = Student5[3];


        }

        public void Add(string FirstName, string LastName, string StudentNumber, double AverageScore)
        {
            object[] Student = new object[4];
            Student[0] = FirstName;
            Student[1] = LastName;
            Student[2] = StudentNumber;
            Student[3] = AverageScore;

            Last[0] = FirstName;
            Last[1] = LastName;
            Last[2] = StudentNumber;
            Last[3] = AverageScore;

            Nan.Add(Length, Student);

            Length++;
        }

        public object[] GetElement(int Index)
        {
            if (Nan.ContainsKey(Index))
            {
                return (Nan[Index]);
            }
            else
            {
                object[] error = new object[4];

                student[0] = "";
                student[1] = "";
                student[2] = "";
                student[3] = 0;
                return error;
            }

        }

        public void RemoveByIndex(int Index)
        {
            if (Index == 0)
            {
                First = Nan[1];

            }
            Nan.Remove(Index);

            while (Index + 1 < Length)
            {
                Nan.Add(Index, Nan[Index + 1]);
                Nan.Remove(Index + 1);
                Index = Index + 1;
            }

            if (Index == Length - 1)
            {
                Last = Nan[Length - 2];
            }
            Length = Length - 1;
        }

        public void RemoveFirst()
        {
            int Index = 0;
            Nan.Remove(Index);

            while (Index + 1 < Length)
            {
                Nan.Add(Index, Nan[Index + 1]);
                Nan.Remove(Index + 1);
                Index = Index + 1;
            }
            First = Nan[0];

            Length = Length - 1;

        }

        public void RemoveLast()
        {
            Nan.Remove(Length);
            Length = Length - 1;

            Last = Nan[Length - 1];
        }

        public void DisplayList()
        {
            object[] Student = new object[4];
            int count = 0;
            while (count < Length)
            {
                Student = Nan[count];
                Console.WriteLine(count + ") First Name: " + Student[0]);
                Console.WriteLine("   Last Name: " + Student[1]);
                Console.WriteLine("   Student Id: " + Student[2]);
                Console.WriteLine("   Average: " + Student[3]);
                Console.WriteLine();

                count++;
            }
        }

    }
}
