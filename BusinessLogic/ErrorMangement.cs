using Common.Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Implementations;
using System;
using BusinessLogic.Contracts;

namespace BusinessLogic
{
    public class ErrorMangement : IErrorManagement
    {
        BaseDataService<Error> db;

        public ErrorMangement()
        {
            db = new BaseDataService<Error>();
        }

        public void AddError(Error error)
        {
            db.Create(error);
        }

        public Error Get(int id)
        {
            return db.Get(x => x.Id == id).FirstOrDefault();
        }

        public IList<Error> GetAllErros()
        {
            return db.Get();
        }
    }
}
