using System;
using System.Collections.Generic;
using Palindrome;

namespace Palindrome
{
  public class Checker
  {
    public bool IsPalindrome(string word)
    {
      if (word == word.ToString()) {
      return true;
      } else {
        return false;
      }
    }
  }
}

// poss code for breaking input into array//
class Program {
static void Main() 
{
  string word = "1001";
  char[] array = word.ToCharArray();
  Array.Reverse(array);

    Console.WriteLine(word);
    Console.WriteLine(array);
  bool tf = true;
  for (int i=0; i < array.Length; i++)
  {
    if(word[i] != array[i]) {
      tf = false;
    }
    }
  if (tf) {
    Console.Write(word + " is a palindrome");
  }
  else {
    Console.Write(word + " is not a palindrome");
  }
}
}