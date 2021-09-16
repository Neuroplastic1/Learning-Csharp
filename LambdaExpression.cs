using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      //A Lambda Expression
      //Looks like an expression-bodied definition except that it is an anonymous method: it has no name.
      //lamba expressions with one expression uses    
      //fat arrow, no curly braces & no semicolon:
      //(input-parameters) => expression
      //Lambda expressions with more than one expression use curly braces and semicolon:
      //(input-parameters) => { statement; }
      
      bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");
      
      //even shorter version of the above lambda Expression
      //no parantheses
      bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");

      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
    
    static bool HitGround(string s)
    {
      return s == "meteorite";
    }
  }
}
