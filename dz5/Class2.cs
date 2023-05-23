using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    class Store
    {
        private string name;
        private string address;
        private string phone;
        private string email;
        private double square;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }


        public void SetPhoneNumber(string phone)
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

        public string GetAddress()
        {
            return address;
        }


        public string GetPhoneNumber()
        {
            return phone;
        }

        public string GetEmail()
        {
            return email;
        }


        public void GetSquare(double square)
        {
            this.square = square;
        }
        public double GetSquare()
        {
            return square;
        }

        public static Store operator +(Store store, double amount)
        {
            store.square += amount;
            return store;
        }

        public static Store operator -(Store store, double amount)
        {
            store.square -= amount;
            return store;
        }

        public static bool operator ==(Store store1, Store store2)
        {
            if (ReferenceEquals(store1, store2))
            {
                return true;
            }

            if ((object)store1 == null || (object)store2 == null)
            {
                return false;
            }

            return store1.square == store2.square;
        }

        public static bool operator !=(Store store1, Store store2)
        {
            return !(store1 == store2);
        }

        public static bool operator <(Store store1, Store store2)
        {
            return store1.square < store2.square;
        }

        public static bool operator >(Store store1, Store store2)
        {
            return store1.square > store2.square;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Store store = obj as Store;

            if ((object)store == null)
            {
                return false;
            }

            return square == store.square;
        }

        public void ShowSquare()
        {
            Console.WriteLine($"\nSquare: {square}");
        }

        public void Input()
        {
            Console.Write("Enter name of store: ");
            SetName(Console.ReadLine());

            Console.Write("Enter address: ");
            SetAddress(Console.ReadLine());

            Console.Write("Enter phone: ");
            SetPhoneNumber(Console.ReadLine());

            Console.Write("Enter email: ");
            SetEmail(Console.ReadLine());
        }
        public void Show()
        {

            Console.WriteLine($"Name of store: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}