﻿using Business.Abstract;
using Entities.Concreate;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    //Çıplak class kalmasın
    public class PersonManager: IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList() {
            return null;
        }
        public bool CheckPerson(Person person) 
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.Lastname,person.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
