using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherMicroservice.Models
{
    [Table("tblTeacher")]
    public class TeacherModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JoiningYear { get; set; }
        public int Age { get; set; }

    }
}
