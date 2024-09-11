using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate; //jab humprivate sy karty to main thinh hum underscore use karty or camel case sy karty means pehla word chota rakhty or class name pascal case pehla word bra

        public void SetBirthdate(DateTime birthdate)
        { 
             _birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person=new Person();
            person.SetBirthdate(new DateTime(2004, 12, 12));
            Console.WriteLine(person.GetBirthDate());
            Console.ReadLine();
        }
    }
}
