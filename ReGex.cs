using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using People;

namespace IO_stream
{
    class ReGex : FileStreaming
    {
        public static void WrongInput()
        {
            Console.WriteLine("You entered unavailable symbols, please enter again");
        }

        public static void FirstNamePattern(string firstName) //regex for the first name
        {
            while (!Regex.IsMatch(firstName, @"^[A-Za-z]+$"))
            {
                ConsMenu.WrongInput();
                Console.Write("Enter the first name (only English alphabet): ");
                firstName = Console.ReadLine();
            }
        }

        public static void LastNamePattern(string lastName) //regex for the last name
        {
            while (!Regex.IsMatch(lastName, @"^[A-Za-z]+$"))
            {
                ConsMenu.WrongInput();
                Console.Write("Enter the last name (only English alphabet): ");
                lastName = Console.ReadLine();
            }
        }

        public static void AgePattern(string age) //regex for age
        {
            while (!Regex.IsMatch(age, @"^[0-9]+$"))
            {
                ConsMenu.WrongInput();
                Console.Write("Enter the age (only integer): ");
                age = Console.ReadLine();
            }
        }

        public static void MakeUpStoriesPattern(string storiesSkill) //regex for making uo stories skill
        {
            while (!Regex.IsMatch(storiesSkill, @"true|false"))
            {
                ConsMenu.WrongInput();
                Console.Write("Enter the make up stories skill (true/false): ");
                storiesSkill = Console.ReadLine();
            }
        }

        public static void GenderPattern(string gender) //regex for gender
        {
            while (!Regex.IsMatch(gender, @"male|female"))
            {
                ConsMenu.WrongInput();
                Console.Write("Enter the gender (male/female): ");
                gender = Console.ReadLine();
            }
        }

        public static void StudentsIDPattern(string id) //regex for student`s ID
        {
            while (!Regex.IsMatch(id, @"^[0-9]+$"))
            {
                ConsMenu.WrongInput();
                Console.Write("Enter the student`s ID (only integer): ");
                id = Console.ReadLine();
            }
        }

        public static void RecGrNumPattern(string  groupNum) //regex for academic record group namber
        {
            while (!Regex.IsMatch(groupNum, @"^[0-9]+$"))
            {
                ConsMenu.WrongInput();
                Console.Write("Enter the academic record group number (only integer): ");
                groupNum = Console.ReadLine();
            }
        }
    }
}
