using StudentMicroservice.Models;
using System.Collections.Generic;


namespace StudentMicroservice.Repositories.StudentRepo
{
    public interface IStudentRepository
    {
        List<StudentModel> GetStudents();
        StudentModel GetStudentById(int id);
        void AddStudent(StudentModel student);
        void UpdateStudent(StudentModel student);
        void DeleteStudent(int id);
        void Save();
    }
}
