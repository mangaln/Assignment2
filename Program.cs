using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher Teacher = new Teacher { firstName = "John", lastName = "Doe" };
            Console.WriteLine(Teacher.getInfo());
        }
    }
    class Person
    { public string firstName;
        public string lastName;
        public string getName()
        {
            return firstName + " " + lastName;
        }
    }
    class Teacher:Person
    {
        public string IDnumber;
        public string action;
        public string subject;
        public Teacher() : base()
        {
            IDnumber = "T12345";
            action = "Teaches";
            subject = "DIS";
            
        }
        public string getInfo()
        {
            return IDnumber +" "+action+" "+subject+" " + base.getName();
        }

    }
     
}

