using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      //difference in hours between 2:00pm and 6:00pm
     double timeToDinner = 4;
     double distance = 95;
     double rate = 30;
     
     //calculate how long it will take us by dividing the distance variable by the rate variable.
     double tripDuration = distance/rate;
     
     //checks if tripDuration is less than or equal to timeToDinner
     bool answer = (tripDuration <= timeToDinner);
     
     //print the answer
    Console.WriteLine(answer);
    }
  }
}
