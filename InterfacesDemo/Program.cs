using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AnaYönetim'den proje yönetimi gerçekleştirilir.


            //İşçi İşlemleri
            AnaYönetim iscimanager = new AnaYönetim();
            iscimanager.Add(new İsciManager());
            iscimanager.Update(new İsciManager());


            Console.WriteLine(".");
            //Musteri İşlemleri
            AnaYönetim musteriManager = new AnaYönetim();
            musteriManager.Add(new MusteriManager());
            musteriManager.Update(new MusteriManager());



            Console.WriteLine(".");
            //Stajyer işlemleri

            AnaYönetim stajyerManager = new AnaYönetim();
            stajyerManager.Add(new StajyerManager());
            stajyerManager.Update(new StajyerManager());

            Console.ReadLine();
        }
    }

    interface IKisiManager
    {
        void Add();
        void Update();
    }

    class MusteriManager : IKisiManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri eklendi !");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi !");
        }
    }

    class StajyerManager : IKisiManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi !");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Guncellendi !");
        }
    }

    class İsciManager : IKisiManager
    {
        public void Add()
        {
            Console.WriteLine("İşçi Eklendi !");
        }

        public void Update()
        {
            Console.WriteLine("İşçi Güncellendi !");
        }
    }


    class AnaYönetim
    {
        public void Add(IKisiManager kisiManager)
        {
            kisiManager.Add();
        }
        public void Update(IKisiManager kisiManager)
        {
            kisiManager.Update();
        }
    }
}
