using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList(); //bu metot person listesi döndürsün

        bool CheckPerson(Person person);
    }
}


// interfaceler metotun imzasıyla yazılır
