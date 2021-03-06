﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using College.Logic;
using College.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace College.RestApi.Controllers
{
    [Route("api/Courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly CourseLogic _courseLogic;

        public CoursesController(CourseLogic courseLogic)
        {
            _courseLogic = courseLogic;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_courseLogic.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_courseLogic.GetSingle(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Course course)
        {
            _courseLogic.Add(course);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Course course)
        {
            _courseLogic.Update(course);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Course course)
        {
            _courseLogic.Delete(course);
            return Ok();
        }
    }
}
