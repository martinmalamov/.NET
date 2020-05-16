using System;

namespace ManKind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string firstName = tokens[0];
                string lastName = tokens[1];
                string facultyNumber = tokens[2];
                Student student;
                student = new Student(firstName, lastName, facultyNumber);

               

                input = Console.ReadLine();
                tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                firstName = tokens[0];
                lastName = tokens[1];
                double weekSalary = double.Parse(tokens[2]);
                double workHoursPerDay = double.Parse(tokens[3]);
                Worker worker;

                worker = new Worker(firstName, lastName, weekSalary, workHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine(worker);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                
                //try
                //{
                //     student = new Student(firstName,lastName,facultyNumber);
                //    Console.WriteLine(student);

                //}
                //catch (ArgumentException ex)
                //{

                //    Console.WriteLine(ex.Message);
                //    //Environment.Exit(0);
                //  //  return;
                //}

                //  Console.WriteLine();

                //input = Console.ReadLine();
                //tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //firstName = tokens[0];
                //lastName = tokens[1];
                //double weekSalary = double.Parse(tokens[2]);
                //double workHoursPerDay = double.Parse(tokens[3]);
                //Worker worker;
                //try
                //{
                //    worker = new Worker(firstName, lastName, weekSalary, workHoursPerDay);

                //    Console.WriteLine(worker);

                //}
                //catch (ArgumentException ex)
                //{

                //    Console.WriteLine(ex.Message);
                //    Environment.Exit(0);

                //}
                // Console.WriteLine(student);
                // Console.WriteLine();
            }
        }
    }
}
