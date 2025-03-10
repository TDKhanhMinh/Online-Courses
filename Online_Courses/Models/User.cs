using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class User
    {
    [Key]
    public int UserId { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; }

    [Required, MaxLength(100)]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public string Role { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public virtual ICollection<Course> Courses { get; set; } 
    public virtual ICollection<Enrollment> Enrollments { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; }
    }

