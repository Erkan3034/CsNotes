using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
             
            ////ValueType {int,decimal,float,enum,boolean}
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayı1 = "+sayi1);

            ////Reference Types { array, interfaces, class,string abstract...}

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 50, 60, 70 };
            //sayilar1= sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayılar1[0] = " + sayilar1[0]); // sayilar1'in adresinin 0. elemanı 


            Person person1 = new Person(); // Class newleyip kullanma (Person clasından person1 nesne üretimi)
            Person person2 = new Person();

            person1.Firstame = "Erkan";
            person2 = person1;         //Değer eşlemesi değildir, adres eşlemesidir.
            person2.Firstame = "Necip";

           // Console.WriteLine(person1.Firstame);


            Customer customer = new Customer();
            customer.Firstame = "Salih";
            customer.CreditCardNumber = "123456789";


            Employee employee = new Employee();

            Person person3 = customer;  //Adres atama( yani customer bir personDur
            customer.Firstame = "Ahmet";


            //Console.WriteLine(person3.Firstame);
           // Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();

            personManager.Add(customer);
            
            Console.ReadLine();
        }
    }


    //Base class
    class Person
    {
        public int Id { get; set; }
        public string Firstame { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }  // Customer'da persondan farklı olarak CreditCardNumber ögesi var. Fakat temelde bir Customer bir Persondur. Yani Personu inherit(miras almış) etmiştir
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    
    class PersonManager
    {
        public void Add(Person person) // base class inherit edilir( parametre olarak person verildiğinde otomatikmen Person'un inherit edildiği(Customer,Employe) nesneleri de kullanılabilir.
        {
            Console.WriteLine("All services added!");
            Console.WriteLine(person.Firstame);
        }
    }
}
