using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        public Person()
        {

        }
        public Person(int _age, string  _fname, string _lname, string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }

        public void PersonDetails()
        {
            Console.WriteLine("Age:{0} Person Name:{1} {2} city{3}: "+ age, fname, lname, city);
        }

    }
    class ArrayList
    {
        static void Main(string[] args)
        {
            List<Person> PersonL = new List<Person>();
            PersonL.Add(new Person(22, "Sayantan", "Chatterjee", "Kolkata"));
            PersonL.Add(new Person(23, "Akash", "Das", "Kolkata"));
            PersonL.Add(new Person(22, "Sobhandip", "Samanta", "Kolkata"));
            PersonL.Add(new Person(23, "Soumyajit", "Pal", "Kolkata"));
            PersonL.Add(new Person(22, "Dipanjan", "Das", "Kolkata"));
            
            foreach(var it in PersonL)
            {
                Console.WriteLine("Person: Age:{0} Person Name:{1} {2} city{3}: ", i._age, i._fname, i._lname, i._city);
            }

        }
    }
}
