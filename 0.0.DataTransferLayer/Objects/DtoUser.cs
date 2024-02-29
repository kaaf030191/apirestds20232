using _0._0.DataTransferLayer.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace _0._0.DataTransferLayer.Objects
{
    public class DtoUser : DtoGeneric
    {
        [Required(ErrorMessage = "El campo \"idUser\" es requerido.")]
        public string idUser { get; set; }

        [Required(ErrorMessage = "El campo \"username\" es requerido.")]
        public string username { get; set; }

        [Required(ErrorMessage = "El campo \"password\" es requerido.")]
        public string password { get; set; }

        [Required(ErrorMessage = "El campo \"firstName\" es requerido.")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "El campo \"surName\" es requerido.")]
        public string surName { get; set; }

        [Required(ErrorMessage = "El campo \"dni\" es requerido.")]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "El formato del campo \"dni\" no es correcto.")]
        public string dni { get; set; }

        [Required(ErrorMessage = "El campo \"birthDate\" es requerido.")]
        public DateTime birthDate { get; set; }

        [Required(ErrorMessage = "El campo \"gender\" es requerido.")]
        public bool gender { get; set; }
    }
}