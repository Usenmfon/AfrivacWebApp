using Afrivac.Models.RequestModel;
using Microsoft.AspNetCore.Mvc;


namespace Afrivac.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Register(CreateUserRequestModel model)
        {
            return View();
        }
        
    }
}