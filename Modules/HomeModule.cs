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
      Post["/phrase"] = _ => {
        string newSentence = LeetSpeakClass.Translate(Request.Form["userInput"]);
        return View ["index.cshtml", newSentence];
      };
    }
  }
}
