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
    [Index(nameof(departmentName),IsUnique =true)]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId {  get; set; }//system generate
        [Required]
        [MaxLength(100)]
        public string departmentName {  get; set; } //user input
        [MaxLength(50)]
        public string? building {  get; set; }
        [Required]
        [Range(0,double.MaxValue)]
        public decimal budget { get; set; }

        [ForeignKey(nameof(HeadInstructor))]
        public int ?headInstructorId {  get; set; }//foregn key
        public Instructor? HeadInstructor {  get; set; }//navigation property

        public ICollection<Course> Courses { get; set; } = new List<Course>();//navigation property

    }
}
