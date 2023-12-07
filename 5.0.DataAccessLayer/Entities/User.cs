using _5._0.DataAccessLayer.Generic;

namespace _5._0.DataAccessLayer.Entities
{
    public class User : EntityGeneric
    {
        public string idUser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string dni { get; set; }
        public DateTime birthDate { get; set; }
        public bool gender { get; set; }
    }
}