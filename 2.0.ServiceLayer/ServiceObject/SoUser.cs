using _0._0.DataTransferLayer.Objects;
using _2._0.ServiceLayer.Generic;

namespace _2._0.ServiceLayer.ServiceObject
{
    public class SoUser : SoGeneric
    {
        public DtoUser dtoUser { get; set; }

        public List<DtoUser> listDtoUser { get; set; }
    }
}