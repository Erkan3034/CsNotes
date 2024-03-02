using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor bir clası yenilediğimizde çalışan bloktur


            Customer customer1 = new Customer{Id = 1,FirstName= "Erkan",LastName= "Turgut",City="Y.OVA" };
            Console.WriteLine(customer1.FirstName);


            //Metotlara parametre gönderiyormuş gibi bir yazım şekli de mevcuttur. (bunun için yapılandırıcı constructor içerisine parametre tanımlamamız lazım)
            Customer customer2 = new Customer ( 2, "Serkan","Turgut","İstanbul"); 

            Console.WriteLine(customer2.FirstName);
            
            Console.ReadLine();
        }
    }

     class Customer 
    {
        //Default constructor(constructor'lar method mantığıyla çalışır)
        public Customer(int id, string firstName, string lastName, string city) //Constructor. (class gibi herhanngi bir void falan dönmüyor)
        {
            Console.WriteLine("Yapıcı blok çalıştı !");
            //Yani aslında biz Main metodunda Customer clasını yenilediğimizde bu Constructor çalışıyor.
        
            Id = id;
            FirstName = firstName; // bunu yapmamızın sebebi yapıcı constructor'dan set ettiğimiz ve gelen değerleri Customer class parametrelerine eşlemiş oluyoruz.
            LastName = lastName;
            City = city;
        }

        //Bu constructoru paramatreleriyle birlikte verdiğimiz için dafault constructoru ezmiş oluruz. Bu da Class Customer İçindeki paramatrelerin kullanılmasını engeller. Bunu engellemek için Metotlarda olan overloading ksımnıa benzer bir işlem yapacağız. Yani paramatrersi olan default constructoru oluşturacağız.
        public Customer()
        {
        }



        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }

}

//Constructor, bir sınıfın başlatılmasını ve başlatılmasını sağlayan bir yapıcıdır. Bir sınıf birden fazla constructor içerebilir.