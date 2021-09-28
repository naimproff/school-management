using StudentMicroservice.Contexts;
using StudentMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMicroservice.Repositories.StudentRepo
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StdDbContext _stdDbContext;
        public StudentRepository(StdDbContext stdDbContext)
        {
            _stdDbContext = stdDbContext;
        }
        public void AddStudent(StudentModel student)
        {
            _stdDbContext.Students.Add(student);
            Save();
        }

        public void DeleteStudent(int id)
        {
            var std = _stdDbContext.Students.Find(id);
            _stdDbContext.Students.Remove(std);
            Save();
        }

        public StudentModel GetStudentById(int id)
        {
            return _stdDbContext.Students.Find(id);
        }

        public List<StudentModel> GetStudents()
        {
            return _stdDbContext.Students.ToList();
        }

        public void Save()
        {
            _stdDbContext.SaveChanges();
        }

        public void UpdateStudent(StudentModel student)
        {
            _stdDbContext.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
