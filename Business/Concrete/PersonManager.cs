using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        /*encapsulation
        Burayı IApplicantService'e Taşıdık ama dikkat et aynı değiller sadece imza olacak
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person) //Mernisten adamın kimlik doğrulması
        {
            return true;
        }*/
        public void ApplyForMask(Person person)
        {
            
        }

        public bool CheckPerson(Person person)
        {
                EndpointConfiguration configuration = new EndpointConfiguration();
                KPSPublicSoapClient kPSPublicSoapClient1 = new KPSPublicSoapClient(configuration);
                KPSPublicSoapClient kPSPublicSoapClient = kPSPublicSoapClient1;
                KPSPublicSoapClient client = kPSPublicSoapClient;
                var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(person.NationalIdentity), person.FirstName.ToUpper(), person.LastName.ToUpper(), person.DateOfBirthYear);
                Task.WaitAll();
                bool sonuc = result.Result.Body.TCKimlikNoDogrulaResult;
                return sonuc;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
