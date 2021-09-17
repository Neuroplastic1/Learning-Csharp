using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            //store questions and answers in variable
            string[] questions = { "Obama is a mama", "you're cute!", "tiggy loves you" };

            bool[] answers = { true, true, false };
          //user responses will be saved in this array
            bool[] responses = new bool[3];

            //create warning if user submits answer other than bool
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("WARNING: Questions and Answers amount doesn't match");
            }

            //to keep track of the currently asked question.
            int askingIndex = 0;

            //loop through the questions and take user input. 
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();
                //let’s check if the user’s input can be converted to a boolean
                isBool = Boolean.TryParse(input, out inputBool);
                
                while (!isBool)
                {
                    Console.WriteLine("Type 'true' or 'false' to respond");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;

            }
            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }
            //loop through answers, add to score and scoring index
            int scoringIndex = 0;
            int score = 0;
            
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ". ");
                Console.WriteLine($"Input: {response} | Answer: {answer}");
          //for each correct response adding a score
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            
            Console.WriteLine($"You got {score} out of {scoringIndex} correct!");

        }
    }
}
