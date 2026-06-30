using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_system.Module
{
    [Index(nameof(courseCode),IsUnique = true)]
   public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId {  get; set; }//system generate
        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; }//user input
        [Required,MaxLength(150)]
        public string courseTitle { get; set; }
        [Required]
        [Range(1,6)]
        public int creditHours { get; set; }

        [ForeignKey(nameof(Department))]
        public int departmentId { get; set; }

        [ForeignKey(nameof(Instructor))]
        public int ? instructorId { get; set; }
        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; }

        public Department Department { get; set; }//navigation property

        public Instructor ?Instructor {  get; set; }//NAVIGATION 

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
