using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class HomePageController : Controller
{
    Quote quote = new Quote {
        Id = 456,
        Product = "Home Insurance",
        ExpireDate = DateTime.Now.AddDays(45),
        Price = 45.00M
    };
    public IActionResult Index() 
    {
        return View(); 
    }

    public IActionResult Quote() 
    {
        return View(quote);
    }
    
}