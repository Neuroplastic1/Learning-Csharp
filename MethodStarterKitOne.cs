using System;

namespace DefineAMethod
{
  class Program
  {
    //The basic structure of a method definition looks like this:
    //static void YourMethodName() {}
    //Main() is a method. Every time we run the code, the Main() method is executed.
    
    static void Main(string[] args)
     {
       //Call the external methods in Main() with appropriate param and run the code
       VisitPlanets(3);
       VisitPlanets(4);
       VisitPlanets(5);
       //testing default parameters
       YourMethodName("I'm hungry", "!"); // prints "I'm hungry!"
       YourMethodName("I'm hungry");  // prints "I'm hungry."
     }
    //Define a method named VisitPlanets() outside of the Main() method and run the code.
    //Since Main() is already a method, we’ll define our own methods outside of Main().
    static void VisitPlanets(int numberOfPlanets)
     {
       Console.WriteLine($"You visited {numberOfPlanets} new planets...");
     }
    //Default parameters for 
    static void YourMethodName(string message, string punctuation = ".")
     {
       Console.WriteLine(message + punctuation);
     }
  }
}
