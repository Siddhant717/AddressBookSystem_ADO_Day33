using System;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new();
            addressbook.CreateAddressBookTable();
        }
    }
}
