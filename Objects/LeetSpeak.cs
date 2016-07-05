using System;
using System.Collections.Generic;
namespace LeetSpeakGenerator.Objects
{
  public class LeetSpeakClass
  {
    public static string Translate(string input)
    {
      char[] array = input.ToCharArray();
      for (int i=0; i <array.Length; i++)
      {
        if (array[i] == Convert.ToChar('e'))
        {
          array[i] = Convert.ToChar("3");
        }
        else if (array[i] == Convert.ToChar('o'))
        {
          array[i] = Convert.ToChar("0");
        }
        else
        {

        }

      }
      string result = string.Join("", array);
      return result;
    }
  }
}
