using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Review
    {
    [Key]
    public int ReviewId { get; set; }

    [Required, ForeignKey("User")]
    public int UserId { get; set; }

    [Required, ForeignKey("Course")]
    public int CourseId { get; set; }

    [Required, Range(1, 5)]
    public int Rating { get; set; } // 1-5 stars

    public string Comment { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public virtual User User { get; set; }
    public virtual Course Course { get; set; }
    }

