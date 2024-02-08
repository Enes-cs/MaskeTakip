using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISuplierService
    {
        //dependency injection
        //Sonar Cube -- Yazılım Kalite Ölçüm Programı
        private IApplicantService _applicantservice; //Ctor içindekine ulaşmak için globale tanım yaptık
        //interfaceler belirli metot imzalarını barındırırlar.
        //İnterfaceler Birbirinin Alternatifi olan sistemlerin farklı implamentasyon yapmalarını sağlarlar.
        //Aşağıdaki sebeplerden ötürü interfaceleri kullanıyoruz. 
        // Bir iş sınıfı başka bir iş sınıfını kullanıyorsa
        // ileriye dönük güncelleme istendiğinde direnç gösterir
        // PersonManager'a şuan bağımlı, mesela mernisten check ettik
        // vatandaş olmayana ileride maske verilmek istendiğinde sorun çıkacaktır.
        public PttManager(IApplicantService applicantService) //ctor
        {
            _applicantservice = applicantService; 
            //fieldlarda  alt çizgi ile başlamasının sebebi constructurlarda set etmektir.
        }
        public void GiveMask(Person person) 
       
        {
            //interfaceler referans tutucudur newlenemez hem person hem foreign referansı tutabilir.
            //PttManager pttManager = new PttManager(new PersonManager()); ya da PttManager pttManager = new PttManager(new ForeignerManager());
            if (_applicantservice.CheckPerson(person) )
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi. (Kimlik Bilgileri Yanlış!) ");
            }

        }
    }
}
