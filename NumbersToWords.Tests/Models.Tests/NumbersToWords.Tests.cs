using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberTests
  {

    [TestMethod]
    public void NumberFunction_ConvertsTwoDigitsToWords_String()
    {
      Number number = new Number();
      string outputWords = number.WordCounter("73");
      Assert.AreEqual("seventy three ", outputWords);
    }

    [TestMethod]
    public void NumberFunction_ConvertsThreeDigitsToWords_String()
    {
      Number number = new Number();
      string outputWords = number.WordCounter("127");
      Assert.AreEqual("one hundred twenty seven ", outputWords);
    }

    [TestMethod]
    public void NumberFunction_ConvertsFourDigitsToWords_String()
    {
      Number number = new Number();
      string outputWords = number.WordCounter("2127");
      Assert.AreEqual("two thousand one hundred twenty seven ", outputWords);
    }

    [TestMethod]
    public void NumberFunction_ConvertsManyDigitsToWords_String()
    {
      Number number = new Number();
      string outputWords = number.WordCounter("32142127");
      Assert.AreEqual("thirty two million one hundred forty two thousand one hundred twenty seven ", outputWords);
    }

    [TestMethod]
    public void NumberFunction_ConvertsManyManyDigitsToWords_String()
    {
      Number number = new Number();
      string outputWords = number.WordCounter("987332142127");
      Assert.AreEqual("nine hundred eighty seven billion three hundred thirty two million one hundred forty two thousand one hundred twenty seven ", outputWords);
    }    
  }
}