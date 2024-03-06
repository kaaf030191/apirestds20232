using _0._0.DataTransferLayer.Objects;
using _4._0.RepositoryLayer.Repository;
using _5._0.DataAccessLayer.Connection;
using _5._0.DataAccessLayer.Entities;

namespace _5._0.DataAccessLayer.Query
{
    public class QUser : RepoUser
    {
        public int delete(string id)
        {
            using DataBaseContext dbc = new();

            int quantityRegisterModify = 0;

            User user = dbc.Users.Find(id);

            if (user is not null) 
            {
                dbc.Users.Remove(user);

                quantityRegisterModify = dbc.SaveChanges();
            }

            return quantityRegisterModify;
        }

        public List<DtoUser> getAll()
        {
            using DataBaseContext dbc = new();

            return InitAutoMapper.mapper.Map<List<DtoUser>>(dbc.Users.ToList());   
        }

        public DtoUser getByDni(string dni)
        {
            using DataBaseContext dbc = new();

            return InitAutoMapper.mapper.Map<DtoUser>(dbc.Users.Where(w => w.dni == dni).FirstOrDefault());
        }

        public DtoUser getByPk(string pk)
        {
            using DataBaseContext dbc = new();

            return InitAutoMapper.mapper.Map<DtoUser>(dbc.Users.Find(pk));
        }

        public DtoUser getByUsername(string username)
        {
            using DataBaseContext dbc = new();

            return InitAutoMapper.mapper.Map<DtoUser>(dbc.Users.Where(w => w.username == username).FirstOrDefault());
        }

        public int insert(DtoUser dto)
        {
            using DataBaseContext dbc = new();

            dbc.Add(InitAutoMapper.mapper.Map<User>(dto));

            return dbc.SaveChanges();
        }

        public int update(DtoUser dto)
        {
            using DataBaseContext dbc = new();

            User user = dbc.Users.Find(dto.idUser);

            user.username = dto.username;
            user.firstName = dto.firstName;
            user.surName = dto.surName;
            user.dni = dto.dni;
            user.birthDate = dto.birthDate;
            user.gender = dto.gender;
            user.modificationDate = dto.modificationDate;

            return dbc.SaveChanges();
        }
    }
}