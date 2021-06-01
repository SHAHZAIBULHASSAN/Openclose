


using System;
using System.Collections.Generic;

namespace Openclose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<IApplication> list = new List<IApplication>
            {
                new  Person{name="SHAHZAIB",lastname="Safdar"},
                new  employee{name="SHAHZAIB",lastname="Safdar"},
                new  staff{name="SHAHZAIB",lastname="Safdar"},
                new super{name="ali", lastname="safadra"} ,
                new Exective{name="shahzaib", lastname="saadr"}
            };
            List<Person> pers = new List<Person>(); 
           // Account account = new Account();
            foreach (var item in list)
            {
                pers.Add(item.account.Create(item));
       
            }

            foreach (var item in pers)
            {
                Console.WriteLine($"Name==={item.name} and lastname={item.lastname} employee=={item.IsManager}");
            }
          
        }
    }
}
