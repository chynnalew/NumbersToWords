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
      {"2", "twenty"},
      {"3", "thirty"},
      {"4", "forty"},
      {"5", "fifty"},
      {"6", "sixty"},
      {"7", "seventy"},
      {"8", "eighty"},
      {"9", "ninety"},
    };

        public static Dictionary<int, string> suffix = new Dictionary<int, string>()
    {
      {3, "hundred"},
      {4, "thousand"},
      {7, "million"},
      {10, "billion"},
      {13, "trillion"},
    };

    public static string NumberConvert(string inputNum)
    {
      string lastDigit = digit1[inputNum[inputNum.Length - 1].ToString()];
      int inputInt = int.Parse(inputNum);
      if (inputNum.Length > 2)
      {
      string secondLastDigit = digit2[inputNum[inputNum.Length - 2].ToString()];
      int lastTwoDigits = int.Parse(inputNum[inputNum.Length -2] + inputNum[inputNum.Length - 1]);
      bool teensCheck = lastTwoDigits <= 19;
        if (inputNum[1].ToString() == "0")
        {
          string result = $"{digit1[inputNum[0].ToString()]} hundred {lastDigit}";
          return result;
        } 
        else
        {
          string tensPlace = $"{secondLastDigit} {lastDigit}";
          if (teensCheck)
          {
            tensPlace = $"{digit1[lastTwoDigits.ToString()]}";
          }
          // else
          // {
          // }
          string result = $"{digit1[inputNum[0].ToString()]} hundred {digit1[tensPlace]}";
          return result;
        }
      }
      else
      {
        if (teensCheck)
        {
          return digit1[inputNum];
        }
        else
        {
          string secondLastDigit = digit2[inputNum[inputNum.Length - 2].ToString()];
          string result = $"{secondLastDigit} {lastDigit}";
          return result;
        }
      }
    }
  }
}