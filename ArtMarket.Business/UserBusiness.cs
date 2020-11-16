using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtMarket.Data.EntityFramework;
using ArtMarket.Entities.Model;
using ArtMarket.Data;

namespace ArtMarket.Business
{
    public class UserBusiness
    {
        BaseDataService<User> db;

        public UserBusiness()
        {
            db = new BaseDataService<User>();
        }

        public IList<User> GetAll()
        {
            return db.Get();
        }

        public User Get(string email)
        {
            return db.Get(x => x.Email == email).FirstOrDefault();
        }

        public User Login(string email, string password)
        {
            User user1 = new User();
            //Email result = default(Email);
           List<User> listUser = default(List<User>);

            // Data access component declarations.
            var userDac = new UserDAC();

            // Step 1 - Calling Select on EmailDac.
            listUser = userDac.Select();

            foreach(User user in listUser)
            {
                if(user.Email == email && user.Password == password)
                {
                    user1 = user;
                }

            }
            
            return user1;
        }

        public User Get(int id)
        {
            return db.GetById(id);
        }

        public User Add(User user)
        {
            User result = default(User);

            var userDAC = new UserDAC();
 
            result = userDAC.Create(user);
            return result;
        }

        public void Update(User user)
        {
            //db.Update(user);
        }

        public void Delete(int id)
        {
            //db.Delete(id);
        }
	}
}
