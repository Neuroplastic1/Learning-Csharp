using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
     int minLength = 8;
     string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
     string lowercase = "abcdefghijklmnopqrstuvwxyz";
     string digits = "0123456789";
     string specialChars = "!@#$%^&*()-_+=\\/':,{}[]~.";
     //ask user to enter a password
     Console.WriteLine("Please enter the password");
     string password = Console.ReadLine();

     int score = 0;
     if (password.Length >= minLength)
            {
                score++;
            }
     if (Tools.Contains(password,uppercase)) 
            {
                score++;
            }
     if (Tools.Contains(password,lowercase)) 
            {
                score++;
            }
     if (Tools.Contains(password,digits)) 
            {
                score++;
            }
     if (Tools.Contains(password,specialChars)) 
            {
                score++;
            }
    //if the password is password then set the score to zero
     if (Tools.Contains(password,"password")) 
            {
                score = 0;
            }

     Console.WriteLine("Your password score is: " + score);

     switch(score)
            {
                case 5:
                    Console.WriteLine("Congratulations! Your password is extrememly strong.");
                    break;
                case 4:
                    Console.WriteLine("Congratualations! Your password is extremely strong.");
                    break;
                case 3:
                    Console.WriteLine("Congratulations! Your password is strong.");
                    break;
                case 2:
                    Console.WriteLine("Your password is medium.");
                    break;
                case 1:
                    Console.WriteLine("Your password is weak.");
                    break;
                default:
                    Console.WriteLine("Your password does not meet the requirements. Please try again.");
                    break;
            }
    }
  }
}
