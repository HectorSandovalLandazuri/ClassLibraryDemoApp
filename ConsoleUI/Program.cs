// See https://aka.ms/new-console-template for more information

using CoreLibrary;

Generators generators = new Generators();
PersonModel person =new PersonModel
{
    Prefix="Mr.",
    FirstName="Héctor",
    LastName="Sandoval"
};
string message = generators.WelcomeMessage(person.Prefix, person.LastName);

Console.WriteLine(message);

