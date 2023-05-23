using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    class Magazine
    {
        private string name;
        private int year;
        private string phone;
        private string email;
        private int workers;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetFoundedYear(int year)
        {
            this.year = year;
        }



        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetName()
        {
            return name;
        }

        public int GetFoundedYear()
        {
            return year;
        }

        public string GetPhoneNumber()
        {
            return phone;
        }

        public string GetEmail()
        {
            return email;
        }


        public void GetWorkers(int workers)
        {
            this.workers = workers;
        }
        public int GetWorkers()
        {
            return workers;
        }

        public static Magazine operator +(Magazine magazine, int amount)
        {
            magazine.workers += amount;
            return magazine;
        }

        public static Magazine operator -(Magazine magazine, int amount)
        {
            magazine.workers -= amount;
            return magazine;
        }

        public static bool operator ==(Magazine magazine1, Magazine magazine2)
        {
            if (ReferenceEquals(magazine1, magazine2))
            {
                return true;
            }

            if ((object)magazine1 == null || (object)magazine2 == null)
            {
                return false;
            }

            return magazine1.workers == magazine2.workers;
        }

        public static bool operator !=(Magazine magazine1, Magazine magazine2)
        {
            return !(magazine1 == magazine2);
        }

        public static bool operator <(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.workers < magazine2.workers;
        }

        public static bool operator >(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.workers > magazine2.workers;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Magazine magazine = obj as Magazine;

            if ((object)magazine == null)
            {
                return false;
            }

            return workers == magazine.workers;
        }

        public void ShowWorkers()
        {
            Console.WriteLine($"\nWorkers: {workers}");
        }

        public void Input()
        {
            Console.Write("Enter name of magazine: ");
            SetName(Console.ReadLine());

            Console.Write("Enter year: ");
            SetFoundedYear(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter phone: ");
            SetPhone(Console.ReadLine());

            Console.Write("Enter email: ");
            SetEmail(Console.ReadLine());
        }

        public void Show()
        {

            Console.WriteLine($"Name of magazine: {name}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Phone Number: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
