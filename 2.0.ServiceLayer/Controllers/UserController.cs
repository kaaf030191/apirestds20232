using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        [Route("[action]")]
        public ActionResult<string> Index()
        {
            return "Hola!!!";
        }
    }
}