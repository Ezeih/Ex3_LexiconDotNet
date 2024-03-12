// See https://aka.ms/new-console-template for more information
using Ex3_LexiconDotNet;
using LibNoise.Combiner;
using MiNET.Entities.Passive;
using System;
using System.Xml.Linq;
using static Ex3_LexiconDotNet.Animal;
using Horse = Ex3_LexiconDotNet.Animal.Horse;





try
{
    PersonHandler handler = new PersonHandler();
    UserError error = new NumericInputError();


    //Skapa Person
    Console.WriteLine("Person skapad med följande värden:");
    Person person1 = handler.CreatePerson(30, "Tom", "Gill", 177, 75.5);
    Person person2 = handler.CreatePerson(27, "Alex", "Kalle", 190, 95);
    Person person3 = handler.CreatePerson(30, "Liza", "Gustaf", 167, 59);



    // Console.WriteLine($"Ålder: {person.Age}");
    // Console.WriteLine($"Förnamn: {person.FName}");
    //  Console.WriteLine($"Efternamn: {person.LName}");
    //  Console.WriteLine($"Höjd: {person.Height} cm");
    //  Console.WriteLine($"Vikt: {person.Weight} kg");
    //  handler.DisplayPersonInfo(person)


    //Ändra ålder
    handler.ChangeAge(person1, 25);
    handler.DisplayPersonInfo("person1:", person1);
    handler.DisplayPersonInfo("person2:", person2);
    handler.DisplayPersonInfo("person3:", person3);

}
catch (ArgumentException ex)
{
    Console.WriteLine("Fel vid skapande av person: " + ex.Message);
}


//Lägg till user error
Console.WriteLine("-----------------User Error Message------------------------");
List<UserError> errors = new List<UserError>();
errors.Add(new NumericInputError());
errors.Add(new TextInputError());
errors.Add(new CustomError1());
errors.Add(new CustomError2());


foreach (UserError error in errors)
{
    Console.WriteLine(error.UEMessage());
}


Console.WriteLine("--------------------Animals-------------------------------");

//Lägg till Animal sound i listan


//Horse horse = new("Sady", 400, 5);
//Dog dog = new("Max", 27, 8);

List<Animal> animals = new List<Animal>();

 Horse horse = new Horse("Sady", 400, 5);
 Dog dog = new Dog("Max", 27, 8);
 Worm worm = new("Slither", 10, 2);
Hedgehog hedgehog = new("kwaka", 3, 2);
Bird bird = new("Sasa", 1.5, 1);
Animal.Wolf wolf = new("PAX", 36, 7);

 animals.Add(horse);
 animals.Add(dog);
 animals.Add(worm);
animals.Add(hedgehog);
animals.Add(bird);
animals.Add(new Wolfman("PAX", 36, 7));
 
Console.WriteLine("<<<<Animal sound>>>>");
    foreach (Animal animal in animals)
{
    animal.DoSound();
}

Console.WriteLine("--------------------------------------------------------------");


Console.WriteLine("<<<<Animal List>>>>");
foreach (Animal animal in animals)
{
    Console.WriteLine($" Name: {animal.Name},Age: {animal.Age}, Weight: {animal.Weight}");
    animal.DoSound();

}







