using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherMicroservice.Models;

namespace TeacherMicroservice.Repositories.TeacherRepo
{
    public interface ITeacherRepository
    {
        List<TeacherModel> GetTeachers();
        TeacherModel GetTeacherById(int id);
        void AddTeacher(TeacherModel teacher);
        void UpdateTeacher(TeacherModel teacher);
        void DeleteTeacher(int id);
        void Save();
    }
}
