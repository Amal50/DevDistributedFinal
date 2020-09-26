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
    [Route("api/Students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentLogic _studentLogic;

        public StudentController(StudentLogic studentLogic)
        {
            _studentLogic = studentLogic;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentLogic.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_studentLogic.GetSingle(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _studentLogic.Add(student);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Student student)
        {
            _studentLogic.Update(student);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Student student)
        {
            _studentLogic.Delete(student);
            return Ok();
        }
    }
}
