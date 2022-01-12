using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareersList.Core
{
   public interface IDbClient
    {
        IMongoCollection<Career> GetCareersCollection();
    }
}
