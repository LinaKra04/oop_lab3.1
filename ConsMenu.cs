using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using People;

namespace IO_stream
{
    class ConsMenu :  ReGex
    {
        public bool Menu()
        {
            bool showMenu = true;
            while (showMenu == true)
            {
                showMenu = MainMenu();
            }
            return true;
        }

        // console Menu method:

        public bool MainMenu() 
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add a student");
            Console.WriteLine("2) Add a doctor");
            Console.WriteLine("3) Add a mechanic");
            Console.WriteLine("4) Remove an entity");
            Console.WriteLine("5) Show list of entities");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Student entity1 = new Student(" ", " ", " ", " ", " ", " " ," ", " ", " "); 

                    //calling methods for adding Student entity:

                    string a;
                    Console.WriteLine("Enter student`s last name:");
                    a = Console.ReadLine();
                    LastNamePattern(a);
                    entity1.SetFirstName(a);

                    string b;
                    Console.WriteLine("Enter student`s first name:");
                    b = Console.ReadLine();
                    FirstNamePattern(b);
                    entity1.SetLastName(b);

                    string c;
                    Console.WriteLine("Enter student`s age:");
                    c = Console.ReadLine();
                    AgePattern(c);
                    entity1.SetAge(c);

                    string d;
                    Console.WriteLine("Enter student`s making up stories skill(true/false):");
                    d = Console.ReadLine();
                    MakeUpStoriesPattern(d);
                    entity1.SetMakeUpStories(d);

                    string e;
                    Console.WriteLine("Enter student`s study year:");
                    e = Console.ReadLine();
                    entity1.SetStudyYear(e);

                    string f;
                    Console.WriteLine("Enter student`s ID:");
                    f = Console.ReadLine();
                    StudentsIDPattern(f);
                    entity1.SetStudentID(f);

                    string g;
                    Console.WriteLine("Enter student`s gender:");
                    g = Console.ReadLine();
                    GenderPattern(g);
                    entity1.SetGender(g);

                    string h;
                    Console.WriteLine("Enter student`s average score:");
                    h =Console.ReadLine();
                    entity1.SetAverageScore(h);

                    string i;
                    Console.WriteLine("Enter student`s academic record group number:");
                    i = Console.ReadLine();
                    RecGrNumPattern(i);
                    entity1.SetAcademRecordGroupNum(i);

                    AddAStudent(entity1);
                    Console.WriteLine("You added a new student.\n");
                    return true;

                //calling methods for adding Doctor entity:

                case "2":
                    Doctor entity2 = new Doctor(" ", " ", " ", " ", " ", " ", " ");

                    string A;
                    Console.WriteLine("Enter doctor`s last name:");
                    A = Console.ReadLine();
                    LastNamePattern(A);
                    entity2.SetFirstName(A);

                    string B;
                    Console.WriteLine("Enter doctor`s first name:");
                    B = Console.ReadLine();
                    FirstNamePattern(B);
                    entity2.SetLastName(B);

                    string C;
                    Console.WriteLine("Enter doctor`s age:");
                    C = Console.ReadLine();
                    AgePattern(C);
                    entity2.SetAge(C);

                    string D;
                    Console.WriteLine("Enter doctor`s making up stories skill(true/false):");
                    D = Console.ReadLine();
                    MakeUpStoriesPattern(D);
                    entity2.SetMakeUpStories(D);

                    string E;
                    Console.WriteLine("Enter doctor`s work year:");
                    E = Console.ReadLine();
                    entity2.SetWorkYear(E);

                    string F;
                    Console.WriteLine("Enter doctor`s quantity of patients:");
                    F = Console.ReadLine();
                    entity2.SetQuantOfPatients(F);

                    string G;
                    Console.WriteLine("Enter doctor`s rating:");
                    G = Console.ReadLine();
                    entity2.SetRating(G);

                    AddADoctor(entity2);
                    Console.WriteLine("You added a new doctor.\n");
                    return true;

                //calling methods for adding Mechanic entity:

                case "3":
                    Mechanic entity3 = new Mechanic(" ", " ", " ", " ", " ", " ", " ");

                    string A1;
                    Console.WriteLine("Enter mechanic`s last name:");
                    A1 = Console.ReadLine();
                    LastNamePattern(A1);
                    entity3.SetFirstName(A1);

                    string B1;
                    Console.WriteLine("Enter mechanic`s first name:");
                    B1 = Console.ReadLine();
                    FirstNamePattern(B1);
                    entity3.SetLastName(B1);

                    string C1;
                    Console.WriteLine("Enter mechanic`s age:");
                    C1 = Console.ReadLine();
                    AgePattern(C1);
                    entity3.SetAge(C1);

                    string D1;
                    Console.WriteLine("Enter mechanic`s making up stories skill(true/false):");
                    D1 = Console.ReadLine();
                    MakeUpStoriesPattern(D1);
                    entity3.SetMakeUpStories(D1);

                    string E1;
                    Console.WriteLine("Enter mechanic`s work year:");
                    E1 = Console.ReadLine();
                    entity3.SetWorkYear(E1);

                    string F1;
                    Console.WriteLine("Enter mechanic`s quantity of clients:");
                    F1 = Console.ReadLine();
                    entity3.SetQuantOfClients(F1);

                    string G1;
                    Console.WriteLine("Enter mechanic`s rating:");
                    G1 = Console.ReadLine();
                    entity3.SetRating(G1);

                    AddAMechanic(entity3);
                    Console.WriteLine("You added a new mechanic.\n");
                    return true;

                    //calling the method for removing an entity

                case "4":
                    if (count >= 1)
                    {
                        Console.WriteLine("Enter an index of entity from 0 to " + (count - 1));
                    }

                    else if (count == 0)
                    {
                        Console.WriteLine("Available index is 0");
                    }

                    int remove = Convert.ToInt32(Console.ReadLine());
                    RemoveEntity(remove);
                    Console.WriteLine("The entity has been removed\n");
                    return true;

                    //calling show DB method:

                case "5":
                    ShowDataBase();
                    return true;

                case "6":
                    return false;

                default:
                    return true;
            }
        }
    }
}


