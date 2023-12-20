using _2._0.ServiceLayer.ServiceObject;
using _3._0.BusinessLayer.Business.User;
using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public ActionResult<SoUser> GetByPk(string idUser)
        {
            BusinessUser businessUser = new();
            SoUser soUser = new();

            soUser.dtoUser = businessUser.getByPk(idUser);

            return soUser;
        }
    }
}