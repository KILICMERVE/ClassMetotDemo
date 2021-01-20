using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteri = new MusteriManager();
            Musteri Musteri = new Musteri();
           
            musteri.MusteriEkle(Musteri);
            Console.WriteLine();
            musteri.MusteriListele(Musteri);
            Console.WriteLine();
            musteri.MusteriSil(Musteri);
            

            Console.ReadKey();
                
        }
    }
}
