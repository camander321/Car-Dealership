using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership
{
  public class HomeController : Controller
  {
    //home - add car button
    //home - view Cars
    //carlist - go back to home/add car
    //carlist - clear cars
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
