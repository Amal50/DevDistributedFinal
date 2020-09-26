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
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentLogic _departmentLogic;

        public DepartmentController(DepartmentLogic departmentLogic)
        {
            _departmentLogic = departmentLogic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_departmentLogic.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_departmentLogic.GetSingle(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Department department)
        {
            _departmentLogic.Add(department);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Department department)
        {
            _departmentLogic.Update(department);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Department department)
        {
            _departmentLogic.Delete(department);
            return Ok();
        }
    }
}
