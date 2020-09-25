using System;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace NumbersToWords.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine(@"
      
      Enter an integer to have it translated back:
      
      ---------------------
      
      ");

      string inputNum = Console.ReadLine();
      Number newNumber = new Number();
      Console.WriteLine(newNumber.WordCounter(inputNum));
    }
  }
}
