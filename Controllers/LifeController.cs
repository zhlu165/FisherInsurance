using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class LifeController : Controller
{
    Quote quote = new Quote {
        Id = 567,
        Product = "Life Insurance",
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
 