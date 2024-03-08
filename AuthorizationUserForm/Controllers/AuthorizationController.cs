
using Microsoft.AspNetCore.Mvc;


namespace AuthorizationUserForm.Controllers;


public class AuthorizationController : Controller
{

    
    public IActionResult Index()
    {
        return View();
    }
    
}