using Business.Concreate;
using Entities.Concreate;


class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "NİLSU";
        person.Lastname = "ÖZKAN";
        person.DateOfBirth = 2000;
        person.NationalIdentity = 123;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
    }
}


