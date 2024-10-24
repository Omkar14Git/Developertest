using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Developertest.Models
{
    public class Test
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string TeacherName { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string SubjectName { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        public int age { get; set; }

        [Required(ErrorMessage = "Image is required")]
        public string uploadimg { get; set; }

        [Required(ErrorMessage = "Class is required")]
        public string Class { get; set; }

        [Required(ErrorMessage = "Roll Number is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Roll number must be a numeric value")]
        public string rollno { get; set; }
        public int Id { get; set; }
        public int TeachId { get; set; }
        public int SubId { get; set; }

        public string image { get; set; }
        public List<Test> Studentlst { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Language is required")]
        public string lang { get; set; }
    }
}