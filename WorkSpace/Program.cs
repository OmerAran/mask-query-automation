using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkSpace
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Ömer";
            person1.LastName = "Aran";
            person1.NationalIdentity = 3535;
            person1.DateOfBirthYear = 2001;
            
            
            PttManager pttManager = new PttManager(new PersonManager() );
            pttManager.GiveMask(person1);


        }
    }
}
