using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareersList.Core
{
   public interface ICareerServices
    {
         List<Career> GetCareers();
        //Career GetCareer(string id);
        Career AddCareer(Career career);

    }
}
