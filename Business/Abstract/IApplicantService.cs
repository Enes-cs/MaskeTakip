using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //PersonManager'dan interface'e aldık çünkü bağımlılık çözeceğiz
    public interface IApplicantService 
        
    {
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person); //Mernisten adamın kimlik doğrulması
    }
}
