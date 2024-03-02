using LinqProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisyar"},
                new Category{CategoryId=2, CategoryName="Telefon"},
            };


            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop",    QuantityPerUnit="16 GBRam",      UnitPrice=25000, UnitsInStock=5},
                new Product{ProductId=1, CategoryId=1, ProductName="Macbook Laptop",          QuantityPerUnit="32 GBRam",      UnitPrice=45000, UnitsInStock=5},
                new Product{ProductId=1, CategoryId=1, ProductName="Huawei Laptop",   QuantityPerUnit="64 GBRam",      UnitPrice=28000, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=2, ProductName="Samsung Telefon",   QuantityPerUnit="32 Gb hafıza" , UnitPrice=8000 ,UnitsInStock=15 },
                new Product{ProductId=2, CategoryId=2, ProductName="Apple Telefon",  QuantityPerUnit="64 Gb hafıza" , UnitPrice=13000 ,UnitsInStock=15 }
            };



            Console.WriteLine("*************Algoritmik Çözüm****************");
            Console.WriteLine();
            Console.WriteLine("Fiyatı 20.000 TL'den fazla olan ürünler : ");
            foreach (var product in products)
            {
                if (product.UnitPrice > 20000 && product.UnitsInStock > 4)
                {
                    Console.WriteLine(product.ProductName);

                }
            }


            Console.WriteLine(" ******************Linq İle çözüm******************");
            Console.WriteLine();
            var result = products.Where(product => product.UnitPrice > 24000 && product.UnitsInStock > 3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }


            GetProducts(products);

            Console.ReadLine();

        }

        static List<Product> GetProducts(List<Product> products)
        {

            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 20000 && product.UnitsInStock > 4)
                {
                    filteredProduct.Add(product);
                }
            }
            return filteredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 24000 && product.UnitsInStock > 3).ToList();
        }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}

//Bu kod parçası LINQ (Language Integrated Query) kullanarak bir koleksiyon üzerinde filtreleme işlemi gerçekleştiriyor. İsterseniz adım adım açıklayayım:

//products koleksiyonu üzerinde bir sorgu yapılıyor.
//Where metodu, belirli bir koşulu sağlayan öğeleri seçer. Burada iki koşul var:
//p.UnitPrice > 5000: Ürün birim fiyatı 5000’den büyük olmalı.
//p.UnitsInStock > 3: Stokta en az 3 birim ürün bulunmalı.
//Sonuç olarak, result adlı yeni bir koleksiyon oluşturulur ve bu koleksiyon, yukarıdaki iki koşulu sağlayan ürünleri içerir.
//Bu kod parçası, veritabanı sorgularında kullanılan LINQ ifadelerine benzer bir şekilde çalışır. Eğer sorgunun sonucunu kullanmak isterseniz, result koleksiyonunu daha sonra başka işlemlerde kullanabilirsiniz. Örneğin, bu ürünleri bir liste olarak görüntüleyebilir veya başka bir hesaplama yapabilirsiniz 1.