using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMicroservice.Models
{
    [Table("tblStudent")]
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public int Age { get; set; }
    }
}
