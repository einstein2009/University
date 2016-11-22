using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick_Ackors_University
{
    //There is a DEAN, PROFESSORs, ADMINISTRATORs and RESEARCHERs
    //Deans, Professors and Researchers should implement an  ITeachable interface which contains the Teach() method
    //Deans and Administrators should implement an IAdmin interface which contains the Administrate() method

    class Staff
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public string Name
        {
            get { return $"{FirstName} {LastName}"; }
            set
            {
                string[] names;
                names = value.Split(new char[] { ' ' });
                if (names.Length == 2)
                {
                    FirstName = names[0];
                    LastName = names[1];
                }
                else
                {
                    throw new ArgumentException($"Assigned value '{value}' is invalid", "value");
                }
            }
        }

        //Your constructors should have reasonable parameters to set up the type where you cannot simply use constants.
        public Staff(string title, string name, double salary)
        {
            this.Title = title;
            this.Name = name;
            this.Salary = salary;
        }
        public Staff()
        {
            this.Title = "Default Title";
            this.Name = "Default Name";
            this.Salary = 0;
        }


        protected class Dean : ITeachable, IAdmin
        {

            public void Teach()
            {
                Console.WriteLine("Teach has been called on Dean.");
            }

            public void Administrate()
            {
                Console.WriteLine("Administrate has been called on Dean.");
            }
        }
        //Professors should have a Class
        protected class Professor : ITeachable
        {
            public string Course { get; set; } = "101";

            public void Teach()
            {
                Console.WriteLine($"{Course} + has been called on Professor.");
            }

        }

        protected class Administrator : IAdmin
        {
            public void Administrate()
            {
                Console.WriteLine("Administrate has been called on Admin.");
            }
        }
        //Researchers should have a ResearchSpeciality which is a fixed set of research areas represented by an enumeration
        protected class Researcher : ITeachable
        {

            public void Teach()
            {
                Console.WriteLine("Teach has been called on Researcher.");
            }

        }
    }
}
