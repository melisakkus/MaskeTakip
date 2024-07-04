using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelamVer(name : "Melisa");
            SelamVer();

            //diziler : arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Melisa";
            ogrenciler[1] = "Ali";
            ogrenciler[2] = "Ayşe";


            for (int i = 0; i < ogrenciler.Length; i++) //Length : eleman sayısı
            {
                Console.WriteLine(ogrenciler[i]);
            }

            //generic collection 
            List<string> yeniSehirler1 = new List<string> {"Ankara","Adana","İstanbul"};
            yeniSehirler1.Add("İzmir");
            foreach (string yeni in yeniSehirler1)
            {
                Console.WriteLine(yeni);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }


        static void SelamVer(string name = "isimsiz") // default  parametre tanımladık, default parametreler en son yazılır
        {
            Console.WriteLine("Merhaba " + name);
        }

        private static void Degiskenler()
        {
            double tutar = 10000;
            int sayi = 1000;
            bool girisYapmisMi = false;


            string mesaj = "Selam";

            string ad = "Melisa";
            string soyad = "Akkuş";
            int dogumYili = 2001;
            long tcNo = 12345678910;

            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
        }
    }

    public class Vatandas
    {//bir class'ın içerisinde değşken tanımlarsak sadece o class da kullanılabilir,
     //diğer classlarda da kullanılabilsin diye public ekliyoruz
     //classların defaultu internal, değşikenlerin defaultu private !
     //değişkenin (Melisanın) devamına Hanım / Bey getirsin istersem propertyler (prop) ile get set kullanabilirim !
     //classlar, propertyler, metotlar kelime harfleri büyük yazılır : Pascal Casing !
        public string Ad { get; set; }
        public string Soyad { get; set;}
        
        public int DogumYili { get; set;}
        public long TcNo { get; set;}

    }
}
 