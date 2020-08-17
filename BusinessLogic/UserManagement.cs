using Common.Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Implementations;

namespace BusinessLogic
{
	public class UserManagement : IUserManagement
	{
		BaseDataService<User> db;

		public UserManagement()
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

		public User Get(int id)
		{
			return db.GetById(id);
		}

		public void Add(User user)
		{
			db.Create(user);
		}

		public void Update(User user)
		{
			db.Update(user);
		}

		public void Delete(int id)
		{
			db.Delete(id);
		}
    }
}
