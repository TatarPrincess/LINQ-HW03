using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            var sortedPhoneBook = phoneBook.OrderBy(c => c.Name).ThenBy(c => c.LastName);

            while (true)
            {
                Console.WriteLine("Введите число от 1 до 3");
                var keyChar = Console.ReadKey().KeyChar; // получаем символ с консоли
                Console.Clear();  //  очистка консоли от введенного текста

                switch (keyChar)
                {
                    case '1':

                        foreach (var c in sortedPhoneBook.Take(2))
                        {
                            Console.WriteLine(c.Name + ' ' + c.LastName + ' ' + c.PhoneNumber + ' ' + c.Email);
                        }
                        break;

                    case '2':
                        foreach (var c in sortedPhoneBook.Skip(2).Take(2))
                        {
                            Console.WriteLine(c.Name + ' ' + c.LastName + ' ' + c.PhoneNumber + ' ' + c.Email);
                        }
                        break;

                    case '3':
                        foreach (var c in sortedPhoneBook.Skip(4).Take(2))
                        {
                            Console.WriteLine(c.Name + ' ' + c.LastName + ' ' + c.PhoneNumber + ' ' + c.Email);
                        }
                        break;
                    default:

                        foreach (var c in sortedPhoneBook)
                        {
                            Console.WriteLine(c.Name + ' ' + c.LastName + ' ' + c.PhoneNumber + ' ' + c.Email);
                        }
                        break;
                }
            }

        }        
    }

    public class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}

