using _0._0.DataTransferLayer.Objects;
using _0._0.DataTransferLayer.OtherObjects;

namespace _3._0.BusinessLayer.Business.User
{
    public partial class BusinessUser
    {
        public DtoMessageObject Insert(DtoUser dto)
        {
            dto.idUser = Guid.NewGuid().ToString();
            dto.registerDate = DateTime.Now;
            dto.modificationDate = dto.registerDate;

            repoUser.insert(dto);

            DtoMessageObject mo = new();

            mo.addMessage("Operación realizada correctamente.");
            mo.success();

            return mo;
        }

        public (DtoMessageObject, DtoUser) getByPk(string pk) 
        {
            DtoMessageObject mo = new();

            mo.success();

            return (mo, repoUser.getByPk(pk));
        }

        public (DtoMessageObject, List<DtoUser>) getAll() 
        {
            DtoMessageObject mo = new();

            mo.success();

            return (mo, repoUser.getAll());
        }
    }
}