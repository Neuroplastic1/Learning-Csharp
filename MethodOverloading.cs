using System;
//Method overloading allows programmers to use multiple methods with the same name. 
//Though they have the same name, the overloads are different because they have either (i) different parameter types or (ii) different number of parameters. This is useful if we want the same method to have different behavior based on its inputs.
//Method overloading is an example of the polymorphism feature of an object oriented programming language.
namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      //calling the methods
      NamePets("Laika", "Albert");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();
      //output:
      //Your pets Laika and Albert will be joining your voyage across space!
      //Your pets Mango, Puddy, and Bucket will be joining your voyage across space!
      //Aw, you have no spacefaring pets :(
    }
    
    static void NamePets(string pet1, string pet2)
    {
      Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
    }  
    
    static void NamePets(string pet1, string pet2, string pet3)
    {
      Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
    }  
    
    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
  }
}
