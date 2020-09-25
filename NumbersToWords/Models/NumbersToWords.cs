using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Number
  {
    public string WordCounter(string inputString)
    {
      // char[] input = inputString.ToCharArray();
      string[] onesPlaces = { "", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine " };
      string[] teensPlaces = { "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen ", "nineteen " };
      string[] tensPlaces = { "", "", "twenty ", "thirty ", "forty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety " };
      string[] tensPowers = { "", "hundred ", "thousand ", "million ", "billion ", "trillion " };

      string FinalOutput = ""; //if longer than 3 numbers // 345
      int Counter = 1;
      for (int i = 0; i < inputString.Length; i = 0)
      {
        char[] input = inputString.ToCharArray();

        string Output = "";
        string TempOutput = "";

        if (input.Length == 1)
        {
          Output = onesPlaces[int.Parse(inputString)].ToString();
        }
        else if (input.Length >= 2)
        {
          int onesPlaceValue = int.Parse(input[input.Length - 1].ToString());
          int tensPlaceValue = int.Parse(input[input.Length - 2].ToString());
          if (tensPlaceValue == 1)
          {
            Output = teensPlaces[onesPlaceValue];
          }
          else
          {
            Output = tensPlaces[tensPlaceValue].ToString();
            Output = Output + onesPlaces[onesPlaceValue].ToString();
          }

        }
        if (input.Length >= 3)
        {
          int hundPlaceValue = int.Parse(input[input.Length - 3].ToString());
          TempOutput = onesPlaces[hundPlaceValue].ToString();
          string CounterWord = tensPowers[1];
          if (hundPlaceValue == 0)
          {
            Output = TempOutput + Output;
          }
          else
          {
            Output = TempOutput + CounterWord + Output;
          }

        }
        if (Counter > 1 && (int.Parse(inputString) % 100) != 0) // >thousands 
        {
          string CounterWord = tensPowers[Counter];
          Output = Output + CounterWord;
        }

        if (inputString.Length > 3)
        {
          inputString = inputString.Remove(inputString.Length - 3, 3); //if/else statement needs to account for if there aren't 
        }
        else
        {
          inputString = "";
        }
        FinalOutput = Output + FinalOutput;
        Counter++;
      }
      return FinalOutput;
    }
  }
}
