using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      //ask the user for a secret message and store the result in a variable.
      Console.WriteLine("Enter your secret message");
      string msgString = Console.ReadLine();
      //Convert the captured string to an array of characters. Store the result in a new variable
      char[] secretMessage = msgString.ToCharArray();
      //Create a new, empty array of characters to hold the encrypted message
      //let it have a length equal to the length of secretMessage
      char[] encryptedMessage = new char[secretMessage.Length];
      //encryption begins here
      //for loop that loops through each character of secretMessage
      for (int i=0; i<secretMessage.Length; i++) {
      //within the loop access the character at position i in the secretMessage array and store it in a variable
      char letter = secretMessage[i];
      //Find the position of the character in the alphabet array using the method Array.IndexOf(). Store the value in a variable.
      int letterPosition = Array.IndexOf(alphabet,letter);
      //Add 3 to the letter position and store the value in a variable
      // % 26 will continue the alphabet 
      int newLetterPosition = (letterPosition + 3) % 26;
      //Find the new encrypted character by getting the character in the alphabet array with that new position
      char letterEncoded = alphabet[newLetterPosition];
      //Add the encrypted character to the array encryptedMessage
      //Store the character at the index i (the iterator variable)
      encryptedMessage[i] = letterEncoded;
    }
      //Convert the character array to a string
      string encodedString = String.Join("", encryptedMessage);
      Console.WriteLine($"Your encoded message is {encodedString}");
    }
    
  }
}
