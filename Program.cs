using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();

      // Type your code below
      string[] questions = {"Merab is the current UFC BW Champion", "I currently go to Watermark", "Umar is the current UFC BW Champion", "I currently go to Christ Church", "Ilia is the current UFC FW Champion"};
      
      bool[] answers = {true, false, false, true, true};

      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length){
        Console.WriteLine("Warning: Lengths are not equal");
      }

      int askingIndex = 0;

      foreach (string question in questions){
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        input = Console.ReadLine();

        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex++;
      
      }

    int scoringIndex = 0;
    int score = 0;

    foreach (bool answer in answers){
      bool response = responses[scoringIndex];
      Console.Write(scoringIndex + 1 + ". ");
      Console.WriteLine($"Input: {response} | Answer: {answer}");

      if (response == answer){
        score++;
      }

      scoringIndex++;
    }

    Console.WriteLine($"You got {score} out of {questions.Length} correct!");

    }
  }
}
