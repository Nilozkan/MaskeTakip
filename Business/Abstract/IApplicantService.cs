using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();
        bool CheckPerson(Person person);
    }
}
//interfaceler birbirinin alternatifi olan sistemlerin farklı implementesyon yapmasını sağlar
