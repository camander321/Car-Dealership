using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership
{
  public class HomeController : Controller
  {
    //xhome - add car button
    //home - view Cars
    //xaddcarpage - add another car?
    //carlist - go back to home/add car
    //carlist - clear cars
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/caradded")]
    public ActionResult caradded()
    {
      int iPrice = int.Parse(Request.Query["price"]);
      Car newCar = new Car(Request.Query["make-model"], Request.Query["year"], Request.Query["color"], Request.Query["mileage"], iPrice);

      newCar.Save();

      return View(newCar);
    }

    [Route("/allcars")]
    public ActionResult GetCars()
    {
      return View("allcars", Car.GetAllCars());
    }

  }
}
