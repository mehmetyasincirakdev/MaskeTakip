using Business.Concrete;
using Entities.Concrete;

PttManager pttManager = new PttManager(new PersonManager());
PttManager foreignerPttManager = new PttManager(new ForeignerManager());

Person person1 = new Person();
person1.FirstName = "Mehmet Yasin";
person1.LastName = "Çirak";
person1.DateOfBirthYear = 1996;
person1.NationalIdentity = 25;

pttManager.GiveMask(person1);