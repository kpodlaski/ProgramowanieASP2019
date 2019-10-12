using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaPierwsza
{
    class Person : IComparable<Person>
    {
        public String Name;
        public String Surname;
        public long Pesel { get; private set; }

        public Person(String name, String sname, long pesel)
        {
            this.Name = name;
            this.Surname = sname;
            this.Pesel = pesel;
        }

        public override String ToString()
        {
            return Name + " " + Surname + " -- "+this.GetHashCode();
        }

        public int CompareTo(Person other)
        {
            return Math.Sign(Pesel/10000 - other.Pesel/10000);
        }

        public override int GetHashCode()
        {
            return (int) (Pesel / 10000 + Pesel % 10000);
        }
        public override bool Equals(object obj)
        {
            return Pesel==((Person) obj).Pesel;
        }
    }
}
