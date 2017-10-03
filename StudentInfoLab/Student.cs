using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoLab
{
    //This class represents the blueprint for building us a car 
    class Student
    {
        //Note that 
        private string name
        { get; set; }
        private int studentNumber
        { get; set; }
        private string hometown
        { get; set; }
        private string favoriteFood
        { get; set; }
        public static string requested { get; internal set; }

        //this is a special method called the constructor  
        //Whenever we want to build an object we call this method
        //The car constructor builds and then returns a car object
        public Student(String n, int i, String hT, String fF)
        {
            name = n;
            studentNumber = i;
            hometown = hT;
            favoriteFood = fF;

            Console.WriteLine(name + " has been created!");
        }
        
        public string GetStudentName()
        {
            return name;
        }

        public int GetStudentNumber()
        {
            return studentNumber;
        }

        public void GetHometown()
        {
            Console.WriteLine(name+"'s hometown is " + hometown);
        }

        public void GetFavoriteFood()
        {
            Console.WriteLine(name + "'s favorite food is " + favoriteFood);
        }
    }
}
