using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {

        //Genericlere hangi paramaetre verirsen ona eklediğin metotlar/operasyonlar o tipte  çalışır.
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");


            Console.WriteLine(sehirler.Count); // eleman sayısı


            // T = string ....
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            Console.WriteLine(sehirler2.Count);

            // T = int ....
            MyList<int> sehirlerplaka = new MyList<int>();
            sehirlerplaka.Add(65);
            Console.WriteLine(sehirlerplaka.Count);



            Console.ReadLine();

        }
    }

    // T = Type
    class MyList<T>  //Generic Class (verilen tipe göre parametre alır)
    {

        T[] _array; //_array adında bir generic dizi alanı tanımlaması.Bu dizi, sınıfın içinde depolanan öğeleri tutar.
        T[] _tempArray; //_tempArray adında başka bir generic dizi alanı tanımlaması. Bu geçici bir dizi olarak kullanılır.

        public MyList()  //constructor (kurucu metot).Bu, sınıf örneği oluşturulduğunda çağrılır ve _array ve _tempArray dizilerini başlatır.
        {
            _array = new T[0];
            _tempArray = new T[0];
        }
        public void Add(T item) //  Bu sınıf, farklı tiplerde veri içeren koleksiyonlar oluşturmak için kullanılabilir.
        {
            //Add metodu, listede yeni bir öğe eklemek için kullanılır. Yeni bir öğe eklenmeden önce, mevcut elemanlar _tempArray dizisine kopyalanır, ardından _array dizisinin boyutu bir artırılarak yeniden oluşturulur ve önceki öğeler geri kopyalanır.
            //Count özellik olarak tanımlanır. Bu, koleksiyondaki öğelerin sayısını döndürür.
            _tempArray = _array; // ref tutma
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }



        public int Count
        {
            get { return _array.Length; }
        }



    }
}
