using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_String_True() 
    {
      Checker testChecker = new Checker();
      Assert.AreEqual(true, testChecker.IsPalindrome("racecar"));

    }

    [TestMethod]
    public void IsPalindrome_anArray_True()
    {
      Checker testChecker = new Checker();
      Assert.AreEqual(true, testChecker.IsPalindrome("racecare"));
    }
  }
}