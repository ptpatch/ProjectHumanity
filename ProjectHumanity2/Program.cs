using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHumanity2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stdList = new List<Student>();
            var wrkList = new List<Worker>();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("How many students you want to create?");
                int.TryParse(Console.ReadLine(), out int numOfStudents);
                while (numOfStudents == 0)
                {
                    Console.WriteLine("Please write a number");
                    int.TryParse(Console.ReadLine(), out numOfStudents);
                }

                for (int i = 0; i < numOfStudents; i++)
                {
                    Console.WriteLine("Please enter name of student. Should start with capital letter and be minimum 2 chars:");
                    string inputName = CheckName(Console.ReadLine());

                    Console.WriteLine("Please enter lastname of student. Should start with capital letter and be minimum 3 chars:");
                    string inputLastName = CheckLastName(Console.ReadLine());

                    Console.WriteLine("Please enter gender of student");
                    string inputGender = CheckGender(Console.ReadLine());

                    Console.WriteLine("Please enter faculty number  of student between 5 - 10");
                    int.TryParse(Console.ReadLine(), out int faculty);
                    while (faculty < 5 || faculty > 10)
                    {
                        Console.WriteLine("Please enter faculty number  of student between 5 - 10");
                        int.TryParse(Console.ReadLine(), out faculty);
                    }

                    var student = new Student(inputName, inputLastName, faculty, inputGender);
                    stdList.Add(student);
                }
                
                //-----------------------------------------Worker---------------------------------------------\\
                Console.WriteLine("How many workers you want to create?");
                int.TryParse(Console.ReadLine(), out int numOfWorkers);
                while (numOfWorkers == 0)
                {
                    Console.WriteLine("Please write a number");
                    int.TryParse(Console.ReadLine(), out numOfWorkers);
                }

                for (int i = 0; i < numOfWorkers; i++)
                {
                    Console.WriteLine("Please enter name of worker. Should start with capital letter and be minimum 2 chars:");
                    string inputName = CheckName(Console.ReadLine());

                    Console.WriteLine("Please enter lastname of worker. Should start with capital letter and be minimum 3 chars:");
                    string inputLastName = CheckLastName(Console.ReadLine());

                    Console.WriteLine("Please enter gender of worker");
                    string inputgender = CheckGender(Console.ReadLine());

                    Console.WriteLine("Please enter week salary of worker");
                    double.TryParse(Console.ReadLine(), out double salary);
                    while (salary == 0)
                    {
                        Console.WriteLine("Please enter a salary. No one works for free!");
                        double.TryParse(Console.ReadLine(), out salary);
                    }

                    Console.WriteLine("Please enter hours per day");
                    int.TryParse(Console.ReadLine(), out int hours);
                    while (hours == 0)
                    {
                        Console.WriteLine("Please enter hours per day");
                        int.TryParse(Console.ReadLine(), out hours);
                    }
                    double salaryPerHour = Math.Round((salary / hours), 2);

                    var worker = new Worker(inputName, inputLastName, inputgender, salary, hours, salaryPerHour);
                    wrkList.Add(worker);
                }

                foreach (var item in stdList)
                {
                    Console.WriteLine(item);   
                }

                foreach (var item in wrkList)
                {
                    Console.WriteLine(item);
                }

                isRunning = false;
            }
        }

        static string CheckGender(string inputGender)
        {
            while (inputGender.ToLower() != "male" && inputGender.ToLower() != "female")
            {
                Console.WriteLine("Please enter your gender. Nature gave only male or female.");
                inputGender = Console.ReadLine();
            }
            return inputGender;
        }

        static string CheckName(string inputName)
        {
            
                while (char.IsLower(inputName[0]) || inputName.Length < 2)
                {
                    Console.WriteLine("Please enter name of student. Should start with capital letter and be minimum 2 chars:");
                    inputName = Console.ReadLine();
                }

                return inputName;
            
        }

        static string CheckLastName(string inputName)
        {
            while (char.IsLower(inputName[0]) || inputName.Length < 3)
            {
                Console.WriteLine("Please enter Lastname of student. Should start with capital letter and be minimum 3 chars:");
                inputName = Console.ReadLine();
            }
            return inputName;
        }

        //Regex rgx = new Regex("[a-zA-Z0-9]+");
        //if (!rgx.IsMatch(TextBox_EntityType.Text))
        //{
        //}

//        ConsoleKeyInfo keyInfo = Console.ReadKey();
//while(keyInfo.Key != ConsoleKey.Enter)
//    keyInfo = Console.ReadKey();
    }
}
