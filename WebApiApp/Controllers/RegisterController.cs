using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiApp.Data;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        [HttpGet]
        public dynamic Get(int? id)
        {
            
            if(id == null || id == 0)
            {
                return RegisterDataClass.SelectAll().ToArray();
            }
           return RegisterDataClass.Select((int)id);
        }       

        [HttpPost]
        public Register Post(Register model)
        {
            //var colleges = SurveyReport.GetColleges();
            //var fileName = "Colleges.json";
            //JsonFileUtils.SimpleWrite(colleges, fileName);

            return RegisterDataClass.Add(model);

        }

        [HttpPut]
        public Register Put(Register model)
        {
            return RegisterDataClass.Update(model);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return RegisterDataClass.Delete(id);
        }
    }

    
}
