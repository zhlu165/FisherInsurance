using Microsoft.AspNetCore.Mvc;
public class LifeController : Controller
{
    public IActionResult Index() 
    {
        return View();  
    }

    public IActionResult Quote() 
    {
        return Ok("This is the quote of the LifeController"); 
    }
    
}
 