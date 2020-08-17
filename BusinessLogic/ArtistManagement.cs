using BusinessLogic.Contracts;
using Common.Entities;
using DataAccess.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class ArtistManagement : IArtistManagement
    {
        BaseDataService<Artist> db;

        public ArtistManagement()
        {
            db = new BaseDataService<Artist>();
        }

        public IList<Artist> GetAll()
        {
            return db.Get();
        }

        public Artist Get(int id)
        {
            return db.Get(x => x.Id == id).FirstOrDefault();
        }

        public void Add(Artist artist)
        {
            db.Create(artist);
        }

        public void Update(Artist artist)
        {
            db.Update(artist);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }
    }
}
