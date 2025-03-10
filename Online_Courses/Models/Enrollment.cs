using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Enrollment
    {
    [Key]
    public int EnrollmentId { get; set; }

    [Required, ForeignKey("User")]
    public int UserId { get; set; }

    [Required, ForeignKey("Course")]
    public int CourseId { get; set; }

    [Required]
    public string Status { get; set; } // Enrolled, Completed, Cancelled

    public DateTime EnrolledAt { get; set; } = DateTime.Now;

    public virtual User User { get; set; }
    public virtual Course Course { get; set; }
    }