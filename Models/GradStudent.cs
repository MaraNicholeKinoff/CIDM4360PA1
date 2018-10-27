using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class GradStudent : Student
    {
        //Variables
        public string previousDegree;
        public string previousUniversity;
        public string undergradMajor;
        public float undergradGPA;
        
        //Constructors
        public GradStudent() {

        }
        public GradStudent(string epreviousDegree, string epreviousUniversity, string eundergradMajor, float eundergradGPA){
            this.previousDegree = epreviousDegree;
            this.previousUniversity = epreviousUniversity;
            this.undergradMajor =eundergradMajor; 
            this.undergradGPA = eundergradGPA;
        }

        //Methods
        // void addStudentInfo() {

        // }
        // void updateStudentInfo() {

        // }
        // void displayStudentInfo() {

        }        
    }
}