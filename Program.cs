using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitiy
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunContext context = new UrunContext();
            List<Urun> uruns = new List<Urun>()
            {
                new Urun(){ Urunad ="tablet",Fiyat = 5002,Satistami = true},
                new Urun(){ Urunad ="monitör",Fiyat = 5030,Satistami = true},
                new Urun(){ Urunad ="pbc",Fiyat = 5040,Satistami = false},
                new Urun(){ Urunad ="a",Fiyat = 5005,Satistami = true},
                new Urun(){ Urunad ="pbbc",Fiyat = 5030,Satistami = false},
                new Urun(){ Urunad ="aaa",Fiyat = 5005,Satistami = true}
            };


            foreach (var urunekle in uruns)
            {
                context.urunler.Add(urunekle);

            }

            context.SaveChanges();
            Console.WriteLine("yeni kayıt");
            Console.ReadLine();
        }
    }
}
