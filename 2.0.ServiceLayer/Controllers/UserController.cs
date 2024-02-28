using _0._0.DataTransferLayer.Objects;
using _0._0.DataTransferLayer.OtherObjects;
using _2._0.ServiceLayer.ServiceObject;
using _3._0.BusinessLayer.Business.User;
using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        BusinessUser _business = null;
        SoUser _so = null;

        public UserController() 
        {
            _business = new();
            _so = new();
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult<SoUser> Insert(SoUser so)
        {
            _so.mo = _business.Insert(so.dtoUser);

            return _so;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<SoUser> GetByPk(string idUser)
        {
            _so.dtoUser = _business.getByPk(idUser);

            return _so;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<SoUser> GetAll() 
        {
            _so.listDtoUser = _business.getAll();

            return _so;
        }
    }
}