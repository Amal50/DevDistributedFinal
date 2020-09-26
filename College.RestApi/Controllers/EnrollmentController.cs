using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using College.Logic;
using College.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace College.RestApi.Controllers
{
    [Route("api/enrollment")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly EnrollmentLogic _enrollmentLogic;

        public EnrollmentController(EnrollmentLogic enrollmentLogic)
        {
            _enrollmentLogic = enrollmentLogic;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_enrollmentLogic.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_enrollmentLogic.GetSingle(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Enrollment enrollment)
        {
            _enrollmentLogic.Add(enrollment);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Enrollment enrollment)
        {
            _enrollmentLogic.Update(enrollment);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Enrollment enrollment)
        {
            _enrollmentLogic.Delete(enrollment);
            return Ok();
        }
    }
}
