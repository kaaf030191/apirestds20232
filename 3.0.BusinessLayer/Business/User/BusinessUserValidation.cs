using _0._0.DataTransferLayer.Objects;

namespace _3._0.BusinessLayer.Business.User
{
    public partial class BusinessUser
    {
        private void insertValidation(DtoUser dtoUser) 
        {
            if (repoUser.getByDni(dtoUser.dni) is not null) 
            {
                _mo.addMessage("El usuario ya existe (DNI existente)");
            }

            if (repoUser.getByUsername(dtoUser.username) is not null)
            {
                _mo.addMessage("El usuario ya existe (Nombre de usuario existente)");
            }
        }

        private void updateValidation(DtoUser dtoUser)
        {
            DtoUser dtoUserTempForDni = repoUser.getByDni(dtoUser.dni);

            if (dtoUserTempForDni is not null && dtoUserTempForDni.dni != dtoUser.dni)
            {
                _mo.addMessage("El usuario ya existe (DNI existente)");
            }

            DtoUser dtoUserTempUsername = repoUser.getByUsername(dtoUser.username);

            if (dtoUserTempUsername is not null && dtoUserTempUsername.username != dtoUser.username)
            {
                _mo.addMessage("El usuario ya existe (Nombre de usuario existente)");
            }
        }
    }
}