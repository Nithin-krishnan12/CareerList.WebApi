using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareersList.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Career> _careers;

        public DbClient(Microsoft.Extensions.Options.IOptions<CareersListDbConfig> CareersListDbConfig)
        {
            var client = new MongoClient(CareersListDbConfig.Value.Connection_String);
            var database = client.GetDatabase(CareersListDbConfig.Value.Database_Name);
            _careers = database.GetCollection<Career>(CareersListDbConfig.Value.Careers_Collection_name);
        }
        public IMongoCollection<Career> GetCareersCollection()
        {
            return _careers;

        }
    }
}
