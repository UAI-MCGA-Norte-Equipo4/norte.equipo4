using Common.Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Implementations;

namespace BusinessLogic
{
	public class ProductManagement : IProductManagement
	{
		BaseDataService<Product> db;

		public ProductManagement()
		{
			db = new BaseDataService<Product>();
		}

		public IList<Product> GetAllProducts()
		{
			return db.Get();
		}

		public Product Get(int id)
		{
			return db.GetById(id);
		}

		/// <summary>
		/// Gets a product which is not being tracked by Entity Framework.
		/// It can be used to show values that won't be modified.
		/// </summary>
		/// <param name="id">The Product ID</param>
		/// <returns>The Product entity</returns>
		public Product GetAsNoTracking(int id)
		{
			return db.GetByIdAsNoTracking(id);
		}

		public void AddProduct(Product prod)
		{
			db.Create(prod);
		}

		public void Update(Product prod)
		{
			db.Update(prod);
		}

		public void Delete(int id)
		{
			db.Delete(id);
		}
    }
}
