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

        public DtoUser getByPk(string pk) 
        {
            return repoUser.getByPk(pk);
        }

        public List<DtoUser> getAll() 
        {
            return repoUser.getAll();
        }
    }
}