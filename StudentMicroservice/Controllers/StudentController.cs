using Microsoft.AspNetCore.Mvc;
using StudentMicroservice.Models;
using StudentMicroservice.Repositories.StudentRepo;
using System.Collections.Generic;

namespace StudentMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;
        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public List<StudentModel> Get()
        {
            return _repository.GetStudents();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var std = _repository.GetStudentById(id);
            return new OkObjectResult(std);
            //test_remove 
        }

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult Post([FromBody] StudentModel student)
        {
            _repository.AddStudent(student);
            return Ok("Inserted Successfully!");
        }

        // PUT api/<StudentController>/5
        [HttpPut]
        public IActionResult Put([FromBody] StudentModel student)
        {
            _repository.UpdateStudent(student);
            return Ok("Updated Successfully!");
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteStudent(id);
            return Ok("Deleted successfully");
        }
    }
}
