using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {

        //İnterfaceler sadece metot imzalarını barındır dolayısıyla boş olup bir işlem içermedikleri için new'lenemezler
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World !");

            //Person person = new Person();

            //Customer customer = new Customer();
            //customer.Add();

            //IPersonManager customerManager = new CustomerManager();   // referans tip. İnterfaceler refenrans tiplidir. İmplemente edilien sınıfın referansını tutar.
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager customerManager2 = new ProjectManager();
            customerManager2.Add(new CustomerManager());

            ProjectManager ınternManager = new ProjectManager();
            ınternManager.Add(new InternManager());


            Console.ReadLine();
        }
    }

    //İnterfacelerde üyelerin içi boş
    //class PersonManager
    //{

    //    //implemented operation(tamamlanmış operasyon)
    //    public void Add()
    //    {
    //        Console.WriteLine(" Customer Addedd !");
    //    }

    //}


    //Interface ---(interfaceler metotların imzalarını taşır  ve implemente edildikleri classlarda o metotları bulundurmak zorunda )

    interface IPersonManager
    {

        //Bir arayüz, bir sınıfın belirli bir davranışı nasıl gerçekleştireceğini tanımlar, ancak nasıl gerçekleştireceğini değil.
        //Unimplemented operation
        void Add();
        void Update();

    }


    // inherits - class  -------------> implements - interfaces
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları 

            Console.WriteLine("Customer Added !");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated !");
        }
    }


    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Çalışsan  ekleme kodları 

            Console.WriteLine("Employee Added !");
        }

        public void Update()
        {
            Console.WriteLine("Employee  Updated !");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            //Çalışsan  ekleme kodları 

            Console.WriteLine("Intern Added !");
        }

        public void Update()
        {
            Console.WriteLine("Intern  Updated !");
        }
    }

    //YÖNETİM
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

    }
}
