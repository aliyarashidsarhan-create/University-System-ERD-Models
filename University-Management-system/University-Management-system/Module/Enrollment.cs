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
        public int studentId { get; set; }
        [ForeignKey(nameof (Course))]
        public int courseId { get; set; }
        [Required]
        public DateTime enrollmentDate { get; set; }
        [MaxLength(2)]
        public string? finalGrade {  get; set; }
        [Required]
        [MaxLength(20)]
        public string status { get; set; } = "In Progress";//defult
    }
}
