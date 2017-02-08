using Microsoft.AspNetCore.Mvc;

[Route("claim")]
public class CustomerCareController : Controller
{
    [Route("index")]
    public IActionResult Index() 
    {
        return Ok("This is the index of the CustomerCareController"); 
    }

    [Route("claim")]
    public IActionResult Quote() 
    {
        return Ok("This is the claim of the CustomerCareController"); 
    }

    [Route("fileclaim")]
    public IActionResult NewClaim()        
    {
        return Ok("This is the fileclaims of the CustomerCareController"); 
    }
    
    [Route("myclaims")]
    public IActionResult ClaimHistory()        
    {
        return Ok("This is the myclaims of the CustomerCareController"); 
    }
}
