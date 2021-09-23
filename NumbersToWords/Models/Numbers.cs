using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Number
  {
    public static Dictionary<string, string> digit1 = new Dictionary<string, string>()
    {
      {"0", ""},
      {"1", "one"},
      {"2", "two"},
      {"3", "three"},
      {"4", "four"},
      {"5", "five"},
      {"6", "six"},
      {"7", "seven"},
      {"8", "eight"},
      {"9", "nine"},
      {"10", "ten"},
      {"11", "eleven"},
      {"12", "twelve"},
      {"13", "thirteen"},
      {"14", "fourteen"},
      {"15", "fifteen"},
      {"16", "sixteen"},
      {"17", "seventeen"},
      {"18", "eightteen"},
      {"19", "nineteen"}, 
    };

        public static Dictionary<string, string> digit2 = new Dictionary<string, string>()
    {
      {"0", ""},
      {"1", ""},
      {"2", "twenty"},
      {"3", "thirty"},
      {"4", "forty"},
      {"5", "fifty"},
      {"6", "sixty"},
      {"7", "seventy"},
      {"8", "eighty"},
      {"9", "ninety"},
    };

    //     public static Dictionary<int, string> suffix = new Dictionary<int, string>()
    // {
    //   {4, "thousand"},
    //   {7, "million"},
    //   {10, "billion"},
    //   {13, "trillion"},
    // };

    public static string NumberConvert(string inputNum)
    {
      int inputInt = int.Parse(inputNum);

      string Ones(string number)
      {
        return digit1[number];
      }

      string Tens(string number)
      {
      string numberToPass = number.Remove(0, 1);
      if (int.Parse(number) >= 20)
        {
          string lastDigit = Ones(numberToPass);
          string secondLastDigit = digit2[number[0].ToString()];
          if (secondLastDigit != "0")
          {
            secondLastDigit += " ";
          }
          string result = $"{secondLastDigit}{lastDigit}";
          return result;
        }
        else if (number[0].ToString() == "0")
        {
          return Ones(numberToPass);
        }
        else
        {
          return Ones(number);
        }
      }

      string Hundreds(string number)
      {
        if (number[0].ToString() == "0" || inputInt < 100)
        {
          return Tens(number);
        }
        else
        {
          string numberToPass = number.Remove(0, 1);
          string endNumber = Tens(numberToPass);
          string result = $"{digit1[number[0].ToString()]} hundred {endNumber}";
          return result;
        }
      }
      return Hundreds(inputNum);
    }
  }
}