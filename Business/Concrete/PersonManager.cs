using Business.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{ // çıplak class kalmasın 
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
        }
        public List<Person> GetList() //bu metot person listesi döndürsün
        {
            return null;
        }

        public bool CheckPerson(Person person) // kişilerin bilgileri doğru mu diye kontrol ediyoruz
        {
            return true;
        }

    }
}


// metot : maskebaşvurusu - kim başvuracak Person - personı parametre olarak verdik
//void metotlar sadece işi yapar ve herhangi bir bilgi vermez, emir kipiyle çalışır, şunu yap bunu yap
//List yapısı içerisine konulan veri tipini listeler        