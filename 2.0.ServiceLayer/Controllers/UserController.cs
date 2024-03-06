using _2._0.ServiceLayer.Generic;
using _2._0.ServiceLayer.ServiceObject;
using _3._0.BusinessLayer.Business.User;
using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [Route("[controller]")]
    public class UserController : ControllerGeneric<BusinessUser, SoUser>
    {
        [HttpPost]
        [Route("[action]")]
        public ActionResult<SoUser> Insert(SoUser so)
        {
            try
            {
                _so.mo = ValidatePartDto(so.dtoUser, new string[] {
                    "username",
                    "password",
                    "firstName",
                    "surName",
                    "dni",
                    "birthDate",
                    "gender"
                });

                if (_so.mo.exsistsMessage())
                {
                    return _so;
                }

                _so.mo = _business.insert(so.dtoUser);
            }
            catch (Exception ex)
            {
                _so.mo.listMessage.Add(ex.Message);
                _so.mo.exception();
            }

            return _so;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<SoUser> GetByPk(string idUser)
        {
            (_so.mo, _so.dtoUser) = _business.getByPk(idUser);

            return _so;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<SoUser> GetAll() 
        {
            (_so.mo, _so.listDtoUser) = _business.getAll();

            return _so;
        }

        [HttpDelete]
        [Route("[action]")]
        public ActionResult<SoUser> Delete(string idUser)
        {
            _so.mo = _business.delete(idUser);

            return _so;
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult<SoUser> Update(SoUser so)
        {
            try
            {
                _so.mo = ValidatePartDto(so.dtoUser, new string[] {
                    "idUser",
                    "username",
                    "firstName",
                    "surName",
                    "dni",
                    "birthDate",
                    "gender"
                });

                if (_so.mo.exsistsMessage())
                {
                    return _so;
                }

                _so.mo = _business.update(so.dtoUser);
            }
            catch (Exception ex)
            {
                _so.mo.listMessage.Add(ex.Message);
                _so.mo.exception();
            }

            return _so;
        }
    }
}