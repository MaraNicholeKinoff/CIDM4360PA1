using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class UndergradStudent : Student
    {
               
            //Variables
            public string previousHSchool;
            public Classification studentClass;

            //Constructors
            public UndergradStudent() {
            
            }
            public UndergradStudent(string epreviousHSchool, Classification estudentClass){
                this.previousHSchool = epreviousHSchool;
                this.studentClass = estudentClass;
            }
    }
    public enum Classification {Freshman, Sophomore, Junior, Senior}
}
