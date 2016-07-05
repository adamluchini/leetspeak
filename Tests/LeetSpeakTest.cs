using Xunit;
using System;
using System.Collections.Generic;
namespace LeetSpeakGenerator.Objects
{
  public class LeetSpeakClassTest
  {
    [Fact]
    public void TestTranslate_LetterEto3_TranslatedSentence()
    {
      //Arrange
      string input = "sweet";
      string result = "sw33t";

      //Act
      string newLeetSpeakClass = LeetSpeakClass.Translate(input);

      //Assert
      Assert.Equal(newLeetSpeakClass, result);
    }
    [Fact]
    public void TestTranslate_LetterOto0_TranslatedSentence()
    {
      //Arrange
      string input = "mole";
      string result = "m0l3";

      //Act
      string newLeetSpeakClass = LeetSpeakClass.Translate(input);

      //Assert
      Assert.Equal(newLeetSpeakClass, result);
    }
  }
}
