using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherMicroservice.Contexts;
using TeacherMicroservice.Models;

namespace TeacherMicroservice.Repositories.TeacherRepo
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly TeacherDbContext _teacherDb;
        public TeacherRepository(TeacherDbContext teacherDb)
        {
            _teacherDb = teacherDb;
        }
        public void AddTeacher(TeacherModel teacher)
        {
            _teacherDb.Teachers.Add(teacher);
            Save();
        }

        public void DeleteTeacher(int id)
        {
            var teacher =  _teacherDb.Teachers.Find(id);
            _teacherDb.Teachers.Remove(teacher);
            Save();
        }

        public TeacherModel GetTeacherById(int id)
        {
            var teacher = _teacherDb.Teachers.Find(id);
            return teacher;
        }

        public List<TeacherModel> GetTeachers()
        {
            return _teacherDb.Teachers.ToList();
        }

        public void Save()
        {
            _teacherDb.SaveChanges();
        }

        public void UpdateTeacher(TeacherModel teacher)
        {
            _teacherDb.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
