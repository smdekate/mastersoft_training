using System;

namespace Assignment11
{
    // Abstract class defining the blueprint for a Student
    abstract class Student
    {
        protected string Name, Branch, Subject, Grade;
        protected int Roll, Total;

        // Abstract methods to be implemented by derived classes
        public abstract void Input(int roll, string name, string branch, string subject, int m1, int m2, int m3, int m4, int m5);
        public abstract void CalculateGrade();
        public abstract void Display();
    }

    // Concrete implementation of Student
    class ConcreteStudent : Student
    {
        private int M1, M2, M3, M4, M5;

        // Method to take input values and compute the total marks if all subjects are passed
        public override void Input(int roll, string name, string branch, string subject, int m1, int m2, int m3, int m4, int m5)
        {
            Roll = roll;
            Name = name;
            Branch = branch;
            Subject = subject;
            M1 = m1;
            M2 = m2;
            M3 = m3;
            M4 = m4;
            M5 = m5;

            // Ensure the student has passed all subjects before calculating total marks
            if (M1 >= 40 && M2 >= 40 && M3 >= 40 && M4 >= 40 && M5 >= 40)
                Total = M1 + M2 + M3 + M4 + M5;
            else
                Total = 0;
        }

        // Method to calculate the grade based on the total marks
        public override void CalculateGrade()
        {
            if (Total >= 250)
            {
                Grade = "A";
                Total += 150;
            }
            else if (Total >= 150 && Total < 250)
            {
                Grade = "B";
                Total += 50;
            }
            else
            {
                Grade = "Failed";
            }
        }

        // Method to display student details
        public override void Display()
        {
            Console.WriteLine("Roll: " + Roll);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Branch: " + Branch);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Marks: " + Total);
            Console.WriteLine("Grade: " + Grade);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of ConcreteStudent
            ConcreteStudent student = new ConcreteStudent();

            // Taking input from the user
            Console.Write("Roll Number: ");
            int roll = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Branch: ");
            string branch = Console.ReadLine();

            Console.Write("Subject: ");
            string subject = Console.ReadLine();

            Console.Write("m1: ");
            int m1 = int.Parse(Console.ReadLine());

            Console.Write("m2: ");
            int m2 = int.Parse(Console.ReadLine());

            Console.Write("m3: ");
            int m3 = int.Parse(Console.ReadLine());

            Console.Write("m4: ");
            int m4 = int.Parse(Console.ReadLine());

            Console.Write("m5: ");
            int m5 = int.Parse(Console.ReadLine());

            // Call methods to process the student data
            student.Input(roll, name, branch, subject, m1, m2, m3, m4, m5);
            student.CalculateGrade();
            student.Display();

            // Pause the console to view output
            Console.ReadKey();
        }
    }
}
