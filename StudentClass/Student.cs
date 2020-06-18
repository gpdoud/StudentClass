using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClass {

    class Student {
        public double GPA;
        public int SAT;
        public int TimesTardy;
        public string Name;
        public int Id;

        private double SecretNumberCalculation(double Bnumber, int SecretNumber) {
            return Bnumber / SecretNumber;
        }

        public double BC(int SecretNumber) {
            var dblSAT = SAT * 2;
            var b = dblSAT * GPA;
            var bc = SecretNumberCalculation(b, SecretNumber);
            return bc;
        }

        public string GetValues() {
            return $"{Id}|{Name}|{SAT}|{GPA}|{TimesTardy}";
        }

        public Student() { // default constructor
            this.Id = 0;
            this.GPA = 2.0;
            this.SAT = 1000;
        }
        public Student(string Name, int Id, int SAT, double GPA, int Tardy) {
            this.Name = Name;
            this.Id = Id;
            this.SAT = SAT;
            this.GPA = GPA;
            this.TimesTardy = Tardy;
        }
    }
}
