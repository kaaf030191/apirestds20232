using _0._0.DataTransferLayer.Objects;
using _0._0.DataTransferLayer.OtherObjects;

namespace _2._0.ServiceLayer.ServiceObject
{
    public class SoUser
    {
        public DtoMessageObject mo { get; set; }

        public DtoUser dtoUser { get; set; }

        public List<DtoUser> listDtoUser { get; set; }
    }
}