using FriendLetter.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter() 
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      myLetterVariable.Location = "Dollywood";
      myLetterVariable.Souvenier = "Hair spray";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string souvenier)
    {
      LetterVariable myLetterVariables = new LetterVariable();
      myLetterVariables.Recipient = recipient;
      myLetterVariables.Sender = sender;
      myLetterVariables.Location = location;
      myLetterVariables.Souvenier = souvenier;
      return View(myLetterVariables);
    }

  }
}