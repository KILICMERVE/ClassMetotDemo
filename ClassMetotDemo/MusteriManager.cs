using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
      
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("--------------Yeni Müşteri Bilgilerini Giriniz------------------");
            Console.WriteLine("Müşteri No: " );
            musteri.MusteriNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri Tc: " );
            musteri.Tc = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Müşteri Ad: " );
            musteri.Ad = Console.ReadLine();
            Console.WriteLine("Müşteri Soyad: " );
            musteri.Soyad = Console.ReadLine();
            Console.WriteLine("Müşteri Telefon: ") ;
            musteri.Telefon = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Müşteri Mail: " );
            musteri.Mail = Console.ReadLine();
            musteriler.Add(musteri);

            Console.WriteLine("Musteri ekleme işlemi başarı ile gerçekleşmiştir.");

            

            
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Bilgi: " + musteri.MusteriNo + " nolu müşteri kaydı silinmiştir");
            musteriler.Remove(musteri);
            //musteri.MusteriNo = 0;
            //musteri.Tc = "";
            //musteri.Ad = "";
            //musteri.Soyad = "";
            //musteri.Telefon = "";
            //musteri.Mail = "";
          
        }

        public void MusteriListele(Musteri musteri)
        {

            foreach (var x in musteriler)
            {
                Console.WriteLine("----------------------" + musteri.MusteriNo + " nolu müşteri kaydı Listeleniyor" + "----------------------");
                Console.WriteLine("Musteri No: " + x.MusteriNo);
                Console.WriteLine("Musteri Tc: " + x.Tc);
                Console.WriteLine("Musteri Ad: " + x.MusteriNo);
                Console.WriteLine("Musteri Soyad: " + x.Ad);
                Console.WriteLine("Musteri Soyad: " + x.Soyad);
                Console.WriteLine("Musteri Telefon: " + x.Telefon);
                Console.WriteLine("Musteri Mail: " + x.Mail);
              

            }
        }
    }
}
