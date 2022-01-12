using CareersList.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareersList.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CareersController : ControllerBase 
    {
        private readonly ICareerServices _careerServices;

        public CareersController(ICareerServices careerServices)
        {
            _careerServices = careerServices;
        } 
        [HttpGet]
        public IActionResult GetCareers()
        {
            return Ok(_careerServices.GetCareers());
        }
      


       [HttpPost]
       public IActionResult AddCareer(Career career)
        {
          _careerServices.AddCareer(career);

            return Ok(career);
      }
               
    }
}
