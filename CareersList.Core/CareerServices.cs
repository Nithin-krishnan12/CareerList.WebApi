using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareersList
    .Core
{
   public class CareerServices : ICareerServices
    {
        private readonly IMongoCollection<Career> _careers;
        public CareerServices(IDbClient dbClient)
        {
            _careers = dbClient.GetCareersCollection();


        }

        public Career AddCareer(Career career)
        {
           _careers.InsertOne(career);
            return career;
        }
        public List<Career> GetCareers()
        {

            return _careers.Find(Career => true).ToList();
        }
       

    }
}
