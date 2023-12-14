using _0._0.DataTransferLayer.Objects;
using _3._0.BusinessLayer.Business.User;
using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        [Route("[action]")]
        public ActionResult<DtoUser> Index()
        {
            BusinessUser businessUser = new();

            DtoUser dtoUser = businessUser.getByPk("d49b1388-bd85-4276-b405-9236f4d5113f");

            return dtoUser;
        }
    }
}