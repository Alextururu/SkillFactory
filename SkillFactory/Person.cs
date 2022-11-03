using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    class Person
    {
        public string namePerson;
        public int agePerson;
        public string mailPerson;
        public string phonePerson;
        public int Age
        {
            get
            {
                return agePerson;
            }
            set
            {
                if(value >= 18)
                {
                    agePerson = value;
                }
            }
        }

        public Person(string namePerson, string mailPerson, string phonePerson)
        {
            this.namePerson = namePerson;
            this.mailPerson = mailPerson;  
            this.phonePerson = phonePerson;
        }
    }
}
