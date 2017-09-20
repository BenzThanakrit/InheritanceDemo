using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sp1 = new Student("dsa","dasda") ;
            Person sp2 = new Teacher("rwete","324532");
            Console.WriteLine(sp1);
            Console.WriteLine(sp2);

            Person[] p = new Person[3];
            p[0] = new Teacher("dsdsd", "dsadasd");

            Console.WriteLine(p[0]);
            object o1 = new Student("fdsgfd","safsag");
            Console.WriteLine(o1 is Student);
            Console.ReadLine();
        }
    }

    class Teacher : Person
    {
        public Teacher(string name, string nationalID) : base(name, nationalID)
        {

        }
    }

    class Student : Person
    {
        public Student(string name, string nationalID) :base(name, nationalID)
        {

        }
    }

    class Person
    {
        public override string ToString()
        {
            return string.Format("Name : {0}, ID : {1}", name, nationalID);
        }
        public Person(string name, string nationalID)
        {
            this.name = name;
            this.nationalID = nationalID;
        }

        private string name;

        public string Name
        {
            get { return name; }
            //set { name = value; }
        }

        private string nationalID;

        public string NationalID
        {
            get { return nationalID; }
            //set { nationalID = value; }
        }
    }
}
