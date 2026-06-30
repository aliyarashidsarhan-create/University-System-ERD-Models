using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_system.Module
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId {  get; set; }//system generated

        [ForeignKey(nameof(Student))]
        public int studentId { get; set; }//user input from list of student

        [ForeignKey(nameof (Course))]
        public int courseId { get; set; }//user input from list of cource
        [Required]
        public DateTime enrollmentDate { get; set; }//user input
        [MaxLength(2)]
        public string? finalGrade {  get; set; }//user input
        [Required]
        [MaxLength(20)]
        public string status { get; set; } = "In Progress";//defult

        public Student student { get; set; }//navigation
        public Course course { get; set; }//navegation


    }
}
