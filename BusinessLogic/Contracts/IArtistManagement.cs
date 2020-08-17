using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Contracts
{
    public interface IArtistManagement
    {
        IList<Artist> GetAll();
        void Add(Artist artist);
        Artist Get(int id);
        void Update(Artist artist);
        void Delete(int id);
    }
}
