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
    [Index(nameof(email),IsUnique = true)]
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId {  get; set; }//system generate
        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }//user input
        [Required]
        [MaxLength (150)]
        public string email { get; set; }//user input
        [MaxLength(20)]
        public string ?officeNumber { get; set; }//user input
        [Required]
        public DateTime hireDate { get; set; }//user input
        [Required]
        [Range(0.01,double.MaxValue)]
        public decimal salary { get; set; }//user input
        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; }//user input

        public Department? HeadDepartment {  get; set; }//navigation property

        public ICollection<Course> courses {  get; set; }= new List<Course>();//navig

    }
}
