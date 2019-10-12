using System;
using System.Collections.Generic;

namespace AplikacjaPierwsza
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Jan", "Kowalski", 95011285436);
            Console.WriteLine(p);
            Console.WriteLine(p.Pesel);
            List<Person> persons = new List<Person>();
            persons.Add(p);
            persons.Add(new Person("Maria", "Mariawicka", 99052537654));
            persons.Add(new Person("Sefania", "Stefańska", 81082537654));
            Console.WriteLine(persons);                                 
            persons.Sort();
            foreach (Person p1 in persons) {
                Console.WriteLine(p1);
            }
            HashSet<Person> set_persons = new HashSet<Person>(persons);
            set_persons.Add(new Person("Jan", "Kowalski", 95011285436));
            set_persons.Add(p);
            Console.WriteLine(set_persons.Count);
            foreach (Person p1 in set_persons)
            {
                Console.WriteLine(p1);
            }
        }
    }
}
