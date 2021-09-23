using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System;
using System.Collections.Generic;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberTests
  {
    [TestMethod]
    public void NumberConvert_OutputsWithSingleDigit_String()
    {
      string inputNum = "3";
      string numToWord = Number.NumberConvert(inputNum);
      Assert.AreEqual(numToWord, "three");
    }

    [TestMethod]
    public void NumberConvert_OutputsWithTeensNumber_String()
    {
      string inputNum = "12";
      string numToWord = Number.NumberConvert(inputNum);
      Assert.AreEqual(numToWord, "twelve");
    }

    [TestMethod]
    public void NumberConvert_OutputsWith47_String()
    {
      string inputNum = "47";
      string numToWord = Number.NumberConvert(inputNum);
      Assert.AreEqual(numToWord, "forty seven");
    }
    
    [TestMethod]
    public void NumberConvert_OutputsWith104_String()
    {
      string inputNum = "104";
      string numToWord = Number.NumberConvert(inputNum);
      Assert.AreEqual(numToWord, "one hundred four");
    }

    [TestMethod]
    public void NumberConvert_OutputsWith817_String()
    {
      string inputNum = "817";
      string numToWord = Number.NumberConvert(inputNum);
      Assert.AreEqual(numToWord, "eight hundred seventeen");
    }
  }
}