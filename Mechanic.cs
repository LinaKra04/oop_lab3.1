using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace People
{
    public class Mechanic : Person
    {
        string LastName;
        string FirstName;
        string Age;// using string for numbers because the user will input it to a string then it will be checked by regular expressions
        string MakeUpStories;
        string WorkYear;// it`s more convenient to not convert input to int, double, bool etc because of regular expressions
        string QuantOfClients;
        string Rating;

        public Mechanic(string lastName, string firstName, string age, string stories,
            string workYear, string quantOfClients, string rating)
        {
            SetLastName(lastName);
            SetFirstName(firstName);
            SetAge(age);
            SetMakeUpStories(stories);
            SetWorkYear(workYear);
            SetQuantOfClients(quantOfClients);
            SetRating(rating);
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void SetAge(string age)
        {
            Age = age;
        }

        public void SetMakeUpStories(string stories)
        {
            MakeUpStories = stories;
        }

        public void SetWorkYear(string workYear)
        {
            WorkYear = workYear;
        }

        public void SetQuantOfClients(string quantOfClients)
        {
            QuantOfClients = quantOfClients;
        }

        public void SetRating(string rating)
        {
            Rating = rating;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetAge()
        {
            return Age;
        }

        public string GetMakingUpStories()
        {
            if (MakeUpStories=="true")
                return "I can make up stories!";
            else
                return "I cannot make up stories!";
        }

        public string GetWorkYear()
        {
            return WorkYear;
        }

        public string GetQuantOfClients()
        {
            return QuantOfClients;
        }

        public string GetRating()
        {
            return Rating;
        }

        public override string ToString()
        {
            if (MakeUpStories=="true")
            {
                return "Surname: " + LastName + "\nName: " + FirstName + "\nAge: " + Age +
                    "\nPerson can make up stories" + "\nWork year: " + WorkYear + "\nQuantity of clients: " + QuantOfClients +
                    "\nRating: " + Rating + "\n--------------------------";
            }
            else
                return "Surname: " + LastName + "\nName: " + FirstName + "\nAge: " + Age +
                    "\nPerson can not make up stories" + "\nWork year: " + WorkYear + "\nQuantity of clients: " + QuantOfClients +
                    "\nRating: " + Rating + "\n--------------------------";
        }
    }
}
