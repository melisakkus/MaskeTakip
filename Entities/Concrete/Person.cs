using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Person class'ı maske takibindeki vatandaşları temsil eder
    public class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }

    //özellikleri bir sınıfta toplamak, değişiklikleri tek tek kullanım üzerinden değil de
    //doğrudan o sınıf üzerinde yapmak; encapsulation

    // SOLID 
    // S : single responsibility : her katman her class her if blogu yalnız bir iş yapar, katmanlara bölüyoruz
    // YAZILIM GÜNLÜK HAYATIN PROGRAMLANMASIDIR
    // abstract soyut nesneleri tutar, concrete somut nesneleri
}
