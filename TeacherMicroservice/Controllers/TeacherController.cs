using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherMicroservice.Models;
using TeacherMicroservice.Repositories.TeacherRepo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeacherMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepo;
        public TeacherController(ITeacherRepository teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }
        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<TeacherModel> Get()
        {
            return _teacherRepo.GetTeachers();
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public TeacherModel Get(int id)
        {
            return _teacherRepo.GetTeacherById(id);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public void Post([FromBody] TeacherModel teacher)
        {
            _teacherRepo.AddTeacher(teacher);
            Ok("Teacher Inserted Successfully");
        }

        // PUT api/<TeacherController>/5
        [HttpPut]
        public void Put([FromBody] TeacherModel teacher)
        {
            _teacherRepo.UpdateTeacher(teacher);
            Ok("updated Successfully");
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _teacherRepo.DeleteTeacher(id);
            Ok("Deleted Successfully");
        }
    }
}
