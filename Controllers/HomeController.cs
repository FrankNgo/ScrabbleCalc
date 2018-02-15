using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using RPS.Models;

namespace RPS.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create()
    {
      string player1 = Request.Form["player1Guess"];
      Game newGame = new Game(player1);
      newGame.GetWinner(player1);
      int winner = newGame.GetResult();
      return View("Index", winner);
    }
  }
}
