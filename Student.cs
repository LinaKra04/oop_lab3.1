using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace People
{
    public class Student : Person
    {
        string LastName;
        string FirstName;
        string Age;// using string for numbers because the user will input it to a string then it will be checked by regular expressions
        string MakeUpStories;
        string StudyYear;// it`s more convenient to not convert input to int, double, bool etc because of regular expressions
        string StudentID;
        string Gender;
        string AverageScore;
        string AcademRecordGroupNum;

        public Student(string lastName, string firstName, string age, string stories,
            string studyYear, string studentID, string gender, string averScore, string acRecGroupNum)
        {
            SetLastName(lastName);
            SetFirstName(firstName);
            SetAge(age);
            SetMakeUpStories(stories);
            SetLastName(lastName);
            SetStudyYear(studyYear);
            SetStudentID(studentID);
            SetGender(gender);
            SetAverageScore(averScore);
            SetAcademRecordGroupNum(acRecGroupNum);
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

        public void SetStudyYear(string studyYear)
        {
            StudyYear = studyYear;
        }

        public void SetStudentID(string studentID)
        {
            StudentID = studentID;
        }

        public void SetGender(string gender)
        {
            Gender = gender;
        }
        public void SetAverageScore(string averScore)
        {
            AverageScore = averScore;
        }
        public void SetAcademRecordGroupNum(string acRecGroupNum)
        {
            AcademRecordGroupNum = acRecGroupNum;
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

        public override string ToString()
        {
            if (MakeUpStories=="true")
                return "Surname: " + LastName + "\nName: " + FirstName + "\nAge: " + Age + "\nPerson can make up stories" +
                     "\nStudy year: " + StudyYear + "\nStudent ID: " + StudentID + "\nGender: " + Gender +
                     "\nAverageScore: " + AverageScore + "\nAcademic record book number: " + AcademRecordGroupNum + "\n--------------------------";
            else
                return "Surname: " + LastName + "\nName: " + FirstName + "\nAge: " + Age + "\nPerson can not make up stories" +
                   "\nStudy year: " + StudyYear + "\nStudent ID: " + StudentID + "\nGender: " + Gender +
                    "\nAverageScore: " + AverageScore + "\nAcademic record book number: " + AcademRecordGroupNum + "\n--------------------------";
        }
    }
}
