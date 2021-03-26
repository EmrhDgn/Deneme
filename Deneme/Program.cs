using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Product k = new Product();
            Product k1 = new Product();

            k.Isim = "Hobbit";
            k.Tur = "Roman";
            k.Yazar = "J.R.R.Tolkien";

            k1.Isim = "Harry Potter";
            k1.Tur = "Roman";
            k1.Yazar = "J.K. Rowling";

            Product[] books = new Product[] { k, k1 };
            //for each kısmı

            foreach (var dizi in books)
            {
                Console.WriteLine(" " + dizi.Isim + " " + dizi.Tur + " " + dizi.Yazar);
            }
            //for bölümü

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(" " + books[i].Isim + " " + books[i].Tur + " " + books[i].Yazar);
            }

            int j = 0;
            while (j != books.Length)
            {
                Console.WriteLine(" " + books[j].Isim + " " + books[j].Tur + " " + books[j].Yazar);
                j++;
            }
        }

        class Product
        {
            public string Isim { get; set; }
            public string Tur { get; set; }
            public string Yazar { get; set; }

        }

    }
}