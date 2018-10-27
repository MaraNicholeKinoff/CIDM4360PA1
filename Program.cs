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
                Console.WriteLine("\nMenu: \n\t1-Add Grad Student\n\t2-Add Undergrad Student\n\t3-List All Grad Student\n\t4-List All Undergrad Students\n\t5-Exit Menu");
                string userChoice = Console.ReadLine();
                switch (userChoice) {
                    case "1":
                        Console.Write("\nEnter the graduate student's name: ");
                        string newStudentName = Console.ReadLine();
                        
                        Console.Write("\nEnter the graduate student's ID number: ");
                        long newStudentID = long.Parse(Console.ReadLine());

                        Console.Write("\nEnter the graduate student's date of birth: ");
                        string newStudentDateofBirth = Console.ReadLine();

                        Console.Write("\nEnter the graduate student's major: ");
                        string newStudentMajor = Console.ReadLine();

                        Console.Write("\nEnter the graduate student's GPA: ");
                        float newStudentGPA = float.Parse(Console.ReadLine());

                        Console.Write("\nEnter the graduate student's previous degree: ");
                        string newStudentPreviousDegree = Console.ReadLine();

                        Console.Write("\nEnter the graduate student's previous university: ");
                        string newStudentPreviousUniversity = Console.ReadLine();

                        Console.Write("\nEnter the graduate student's undergraduate major: ");
                        string newStudentUndergradMajor = Console.ReadLine();

                        Console.Write("\nEnter the graduate student's undergraduate GPA: ");
                        float newStudentUndergradGPA = float.Parse(Console.ReadLine());

                        grads.Add(
                            new GradStudent () {
                                StudentName = newStudentName,
                                StudentID = newStudentID,
                                DateofBirth = newStudentDateofBirth,
                                Major = newStudentMajor,
                                GPA = newStudentGPA,
                                previousDegree = newStudentPreviousDegree,
                                previousUniversity = newStudentPreviousUniversity,
                                undergradMajor = newStudentUndergradMajor,
                                undergradGPA = newStudentUndergradGPA
                            }
                        );

                        break;
                    case "2":
                        Console.Write("\nEnter the undergraduate student's name: ");
                        string newUStudentName = Console.ReadLine();
                        
                        Console.Write("\nEnter the undergraduate student's ID number: ");
                        long newUStudentID = long.Parse(Console.ReadLine());

                        Console.Write("\nEnter the undergraduate student's date of birth: ");
                        string newUStudentDateofBirth = Console.ReadLine();

                        Console.Write("\nEnter the undergraduate student's major: ");
                        string newUStudentMajor = Console.ReadLine();

                        Console.Write("\nEnter the undergraduate student's GPA: ");
                        float newUStudentGPA = float.Parse(Console.ReadLine());

                        Console.Write("\nEnter the undergraduate student's previous high school: ");
                        string newUStudentPreviousHighSchool = Console.ReadLine();

                        Console.Write("\nEnter the undergraduate student's classification (0 - Freshman, 1 - Sophomore, 2 - Junior, 3 - Senior): ");
                        int newUStudentClassification = Convert.ToInt32(Console.ReadLine());

                        undergradst.Add(
                            new UndergradStudent () {
                                StudentName = newUStudentName,
                                StudentID = newUStudentID,
                                DateofBirth = newUStudentDateofBirth,
                                Major = newUStudentMajor,
                                GPA = newUStudentGPA,
                                previousHSchool = newUStudentPreviousHighSchool,
                                studentClass = (Classification)Convert.ToInt32(newUStudentClassification)
                            }
                        );

                        break;
                    case "3":
                        foreach (GradStudent g in grads) {
                            Console.WriteLine($"{g.StudentName}: \n\tStudent ID - {g.StudentID}\n\tStudent DOB - {g.DateofBirth}\n\tStudent Major - {g.Major}\n\tStudent GPA - {g.GPA}\n\tPrevious Degree - {g.previousDegree}\n\tPrevious University - {g.previousUniversity}\n\tUndergradMajor - {g.undergradMajor}\n\tUndergrad GPA - {g.undergradGPA}");
                        }
                        break;
                    case "4":
                        foreach (UndergradStudent u in undergradst) {
                            Console.WriteLine($"{u.StudentName}: \n\tStudent ID - {u.StudentID}\n\tStudent DOB - {u.DateofBirth}\n\tStudent Major - {u.Major}\n\tStudent GPA - {u.GPA}\n\tPrevious High School - {u.previousHSchool}\n\tClassification - {u.studentClass}");
                        }
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
    }
}
