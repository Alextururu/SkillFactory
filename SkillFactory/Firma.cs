using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    class Firma
    {
        public string nameFirma;
    }
    class PickPointFirma : Firma
    {
        public DateTime workTime;
        public string adressFirma;
        public PickPointFirma(string adressFirma, DateTime workTime, string nameFirma)
        {
            this.workTime = workTime;
            this.adressFirma = adressFirma;
            this.nameFirma = nameFirma;
        }
    }

    class HomeDeliveryFirma : Firma
    {
        public DateTime workTime;
        public Person deliveryPerson;
        public HomeDeliveryFirma(string namePerson, string mailPerson, string phonePerson, DateTime workTime)
        {
            deliveryPerson = new Person(namePerson, mailPerson, phonePerson);
            this.workTime = workTime;
            this.nameFirma = nameFirma;
        }
    }
}
