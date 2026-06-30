using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_system.Module
{
    [Index(nameof(email), IsUnique = true)]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; } //system generated
        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }//user input
        [Required]
        [MaxLength (150)]
        public string email { get; set; }//user input
        [MaxLength(20)]
        public string ?phoneNumber { get; set; }//user input
        [Required]
        public DateTime dateOfBirth { get; set; }//user input
        [Required]
        [Range(2000,2030)]
        public int enrollmentYear { get; set; }//user input 
        [Range(0, 4)]
        public decimal gpa { get; set; } = 0;//defult

        
    }
}
