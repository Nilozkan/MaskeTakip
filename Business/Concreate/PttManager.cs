using Business.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class PttManager
    {
        private IApplicantService _applicantService; //field
        public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır
        { 
            _applicantService = applicantService;
        
        }
        public void GiveMask(Person person) {
            PersonManager personManager = new PersonManager();
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + "için maske verilemedi");
            }

        }
    }
}

