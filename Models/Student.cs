using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Student
    {
            //Variables
            public string StudentName;
            public string DateofBirth;
            public long StudentID;
            public string Major;
            public float GPA;

            //Constructors
            public Student() {

            }
            public Student(string eStudentName, string eDateofBirth, long eStudentID, string eMajor, float eGPA){
                this.StudentName = eStudentName;
                this.DateofBirth = eDateofBirth;
                this.StudentID =eStudentID; 
                this.Major = eMajor;
                this.GPA = eGPA;
            }

            //Methods
            void addStudentInfo() {

            }
            void updateStudentInfo() {
                
            }
            void displayStudentInfo() {

            }
        }
    }
