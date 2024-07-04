using Business.Absract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService; // field olarak verdik 
        public PttManager(IApplicantService applicantService) //vonstructor : class oluştuğunda bu blok önce çalışsın
        {
            _applicantService = applicantService;
        }
        //bu sistem çalıştığında bana parametre olarak bir aday servisi ver 

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
        }
    }
}

// ptt manager bir kişiye maske verebilmek için kişinin bilgileri doğru mu diye kontrol etmeli
// CheckPerson () kullanması lazım - bir sınıf başka bir sınıfa ihtiyaç duyarsa
// entitiler hariç - bir iş sınıfı başka bir iş sınıfını kullanırken newlerse o sınıfa bağımlı kalır
// PersonManager personmanager = new PersonManager(); personmanager'a bağımlı kaldı 
// ptt managerın bağımlı olduğu sınıflar yerine o sınıfın interfacei yazılır

//interfaceler belirli metot imzalarını barındırırlar,
//birbirlerinin alternatifi olan sistemlerin farklı implemantasyon yapmalarını sağlar

// sonarqube : yazılım kalitesini ölçer