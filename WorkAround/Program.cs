// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

PttManager pttManager = new PttManager(new PersonManager());
Person person = new Person();

person.NationalIdentity = 12345678901;
person.FirstName ="Test";
person.LastName = "Test";
person.DateOfBirthYear = 1994;

pttManager.GiveMask(person);

