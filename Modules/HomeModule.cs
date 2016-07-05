using Nancy;
using System.Collections.Generic;
using LeetSpeakGenerator.Objects;

namespace LeetSpeakClassGenerator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/phrase"] = _ => {
        string newSentence = LeetSpeakClass.Translate(Request.Query["userInput"]);
        return View ["result_sentence.cshtml", newSentence];
      };
    }
  }
}
