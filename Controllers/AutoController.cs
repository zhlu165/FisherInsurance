using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class AutoController : Controller
{

    Quote quote = new Quote {
        Id = 345,
        Product = "Auto Insurance",
        ExpireDate = DateTime.Now.AddDays(45),
        Price = 45.00M};
    public IActionResult Index() 
    {
        return View(); 
    }
    
    
    public IActionResult Quote() 
    {
        return View(quote);
    }
    
}  
 