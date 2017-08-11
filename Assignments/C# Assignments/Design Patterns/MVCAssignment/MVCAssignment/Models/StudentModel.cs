using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCAssignment.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Roll No. is a mandatory field")]
        public int RollNo { get; set; }
        [Required(ErrorMessage = "Name is a mandatory field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Class is a mandatory field")]
        public int Class { get; set; }
    }
}