using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ArtMarket.Entities.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace ArtMarket.Data
{
    public partial class UserDAC : DataAccessComponent
    {
        public User Create(User user)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.[User] ([FirstName], [LastName], [Email], [Password], [City], [Country]) " +
                "VALUES(@FirstName, @LastName, @Email, @Password, @City, @Country); SELECT SCOPE_IDENTITY();";

            var db = DatabaseFactory.CreateDatabase(ConnectionName);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@FirstName", DbType.String, user.FirstName);
                db.AddInParameter(cmd, "@LastName", DbType.String, user.LastName);
                db.AddInParameter(cmd, "@Email", DbType.String, user.Email);
                db.AddInParameter(cmd, "@Password", DbType.String, user.Password);
                db.AddInParameter(cmd, "@City", DbType.String, user.City);
                db.AddInParameter(cmd, "@Country", DbType.String, user.Country);

                db.AddInParameter(cmd, "@CreatedOn", DbType.DateTime, user.CreatedOn != DateTime.MinValue ? user.CreatedOn : DateTime.Now);
                db.AddInParameter(cmd, "@CreatedBy", DbType.String, String.IsNullOrEmpty(user.CreatedBy) ? "ApiUser" : user.CreatedBy);
                db.AddInParameter(cmd, "@ChangedOn", DbType.DateTime, user.ChangedOn != DateTime.MinValue ? user.CreatedOn : DateTime.Now);
                db.AddInParameter(cmd, "@ChangedBy", DbType.String, String.IsNullOrEmpty(user.ChangedBy) ? "ApiUser" : user.ChangedBy);

                user.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return user;
        }


        public List<User> Select()
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [FirstName], [LastName], [Email], [Password], [City], [Country] " +
                "FROM dbo.[User] ";

            List<User> result = new List<User>();

            var db = DatabaseFactory.CreateDatabase(ConnectionName);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        User user = LoadUser(dr);
                        result.Add(user);
                    }
                }
            }

            return result;
        }

        private User LoadUser(IDataReader dr)
        {
            User user = new User();

            user.Id = GetDataValue<int>(dr, "Id");
            user.FirstName = GetDataValue<string>(dr, "FirstName");
            user.LastName = GetDataValue<string>(dr, "LastName");
            user.Email = GetDataValue<string>(dr, "Email");
            user.Password = GetDataValue<string>(dr, "Password");
            user.City = GetDataValue<string>(dr, "City");
            user.Country = GetDataValue<string>(dr, "Country");

            return user;
        }
    }
}
