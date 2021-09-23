using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Number
  {
    public static Dictionary<string, string> digit1 = new Dictionary<string, string>()
    {
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
      {"2", "twenty"},
      {"3", "thirty"},
      {"4", "forty"},
      {"5", "fifty"},
      {"6", "sixty"},
      {"7", "seventy"},
      {"8", "eighty"},
      {"9", "ninety"},
    };

    public static string NumberConvert(string inputNum)
    {
      int inputInt = int.Parse(inputNum);
      if (inputInt<=19)
      {
        return digit1[inputNum];
      }
      else
      {
        string result = $"{digit2[inputNum[0].ToString()]} {digit1[inputNum[1].ToString()]}";
        return result;
      }
    }
  }
}