using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace PA1_Mara_Kinoff
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<GradStudent> grads = new List<GradStudent>()
            {
                //Seeding the Graduate Student data into the lists
                new GradStudent () {
                    StudentName = "John",
                    StudentID = 12234,
                    DateofBirth = "01/01/1981",
                    Major = "CIS",
                    GPA = 3.00f,
                    previousDegree = "BSc",
                    previousUniversity = "WTAMU",
                    undergradMajor = "CS",
                    undergradGPA = 3.33f
                },
                new GradStudent () {
                    StudentName = "Doe",
                    StudentID = 12448,
                    DateofBirth = "05/22/1971",
                    Major = "CIDM",
                    GPA = 3.25f,
                    previousDegree = "BlT",
                    previousUniversity = "CSU",
                    undergradMajor = "CIS",
                    undergradGPA = 3.5f
                },
                new GradStudent () {
                    StudentName = "Alice",
                    StudentID = 32558,
                    DateofBirth = "10/15/1991",
                    Major = "BA",
                    GPA = 3.8f,
                    previousDegree = "BAcc",
                    previousUniversity = "UCSD",
                    undergradMajor = "ACC",
                    undergradGPA = 4.0f
                }
            };
            List<UndergradStudent> undergradst = new List<UndergradStudent>()
            {
                //Seeding the Graduate Student data into the lists
                new UndergradStudent () {
                    StudentName = "Bob",
                    StudentID = 547857,
                    DateofBirth = "03/01/1999",
                    Major = "CIDM",
                    GPA = 4.00f,
                    previousHSchool = "PHS",
                    studentClass = Classification.Sophomore
                },
                new UndergradStudent () {
                    StudentName = "Charley",
                    StudentID = 65888,
                    DateofBirth = "07/02/2001",
                    Major = "CIDM",
                    GPA = 3.50f,
                    previousHSchool = "LHS",
                    studentClass = Classification.Freshman
                },
                new UndergradStudent () {
                    StudentName = "Eve",
                    StudentID = 87785,
                    DateofBirth = "12/01/1995",
                    Major = "CIDM",
                    GPA = 3.70f,
                    previousHSchool = "AHS",
                    studentClass = Classification.Junior
                }
            };      

            string exit = "no";
            while (exit != "yes") {
                Console.Write("Menu: 1-Add Grad Student, 2-Add Undergrad Student, 3-List All Grad Student, 4-List All Undergrad Students, 5-Exit Menu");
                string userChoice = Console.ReadLine();
                switch (userChoice) {
                    case "1":
                        AddGradStudent();
                        break;
                    case "2":
                        AddUndergradStudent();
                        break;
                    case "3":
                        displayStudentInfo();
                        break;
                    case "4":
                        ListUndergradStudent();
                        break;
                    case "5":
                        exit = "yes";
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        break;
                }
            }
        }

        static void AddGradStudent() {

        }
        static void AddUndergradStudent() {

        }
        static void ListGradStudent() {

        }
        static void ListUndergradStudent() {

        
        }
    }
}
