using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Course
    {
    [Key]
    public int CourseId { get; set; }

    [Required, MaxLength(200)]
    public string Title { get; set; }

    public string Description { get; set; }

    [Required]
    public double Price { get; set; }

    [Required, ForeignKey("Instructor")]
    public int InstructorId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public virtual User Instructor { get; set; }
    public virtual ICollection<Enrollment> Enrollments { get; set; }
    public virtual ICollection<Lesson> Lessons { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; }
    }
