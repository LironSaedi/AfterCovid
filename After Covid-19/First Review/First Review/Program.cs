using System;
using System.Collections.Generic;

namespace First_Review
{
    class Program
    {


        static void Main(string[] args)
        {
            Person p = new Person("stuff", 10, 6.2);
            Console.WriteLine(p.GetAge());

            //negative number
            p.SetAge(-1);
            Console.WriteLine(p.GetAge());
            //positive number
            p.SetAge(5);
            Console.WriteLine(p.GetAge());

            //Array of people
            Person[] people = new Person[3];
            people[0] = new Person("sff", 11, 6.5); ;
            people[1] = new Person("hello", 52, 8.5);
            people[2] = new Person("goodybye", 41, 5.5);
            //Print out the information
            //Name: {Name} Age....

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Name: {people[i].GetName()} Age: {people[i].GetAge()} Height: {people[i].GetHeight()}");
                
            }


            List<Person> list = new List<Person>();
            list.Add(new Person("someone", 43,12));
            //print out the list

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Name {list[i].GetName()} Age {list[i].GetAge()} Height {list[i].GetHeight()}");
            }
        }
    }
}
