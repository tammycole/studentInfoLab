using System;
using System.Collections.Generic;

namespace StudentInfoLab
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                //create list of students, student numbers, hometown and favorite food
                Student Molly = new Student("Molly", 1, "Rockford", "Noodles");
                Student Michelle = new Student("Michelle", 2, "Ecuador", "Spaghetti");
                Student Rebecca = new Student("Rebecca", 3, "Charlevoix", "Pizza");
                Student Brianna = new Student("Brianna", 4, "Fairfield", "Gumbo");
                Student Tammy = new Student("Tammy", 5, "Grand Rapids", "Maru Sushi");
                Student Lauren = new Student("Lauren", 6, "Plainwell", "Cheeseburgers");
                Student Karina = new Student("Karina", 7, "Holland", "Tacos");
                Student Anel = new Student("Anel", 8, "Grand Rapids", "Pizza");
                Student Lisa = new Student("Lisa", 9, "Los Angeles", "Mushroom Masala Dosa");
                Student Jonaca = new Student("Jonaca", 10, "Lansing", "Sushi");
                Student Tanvi = new Student("Tanvi", 11, "India", "Chicken Biryani");

                List<Student> students = new List<Student>();
                students.Add(Molly);
                students.Add(Michelle);
                students.Add(Rebecca);
                students.Add(Brianna);
                students.Add(Tammy);
                students.Add(Lauren);
                students.Add(Karina);
                students.Add(Anel);
                students.Add(Lisa);
                students.Add(Jonaca);
                students.Add(Tanvi);

                Console.WriteLine("Welcome to our C# class.");

                bool run = true;
                while (run == true)
                {

                    //prompt the user to ask about a particular student
                    Console.WriteLine("Which student would you like to learn more about? (enter a number 1-11 ).");
                    int userRequest =0;

                    try
                    {
                        userRequest = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a valid numerical value.");
                        userRequest = int.Parse(Console.ReadLine());
                    }

                    /*try
                    {
                        if (userRequest <= 11)
                        {

                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e);
                    }*/
                    
                    
                    /*try
                    {
                        userRequest <= 11;
                    }
                    catch(ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }*/

                    Student requested = students[userRequest - 1];
                    Console.WriteLine("Student " + userRequest + " is " + requested.GetStudentName());

                    Console.WriteLine("What would you like to know about " + requested.GetStudentName() + " ?");
                    Console.WriteLine("Choose hometown or favorite food");

                    string choice = Console.ReadLine();

                    try
                    //Return the proper responses according to user-submitted information
                    {
                        if (choice == "hometown")
                        {
                            requested.GetHometown();
                        }
                        else if (choice == "favorite food")
                        {
                            requested.GetFavoriteFood();
                        }
                        else
                        {
                            Console.WriteLine("I do not understand your request. Please enter 'hometown' or 'favorite food' next time.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    run = Continue();
                }

                Console.ReadKey();
            }
        }

            public static bool Continue()
        {
            Console.WriteLine("Would you like to learn about another student? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }
    }
}