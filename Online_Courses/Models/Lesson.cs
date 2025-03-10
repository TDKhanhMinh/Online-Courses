using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Lesson
    {
    [Key]
    public int LessonId { get; set; }

    [Required, ForeignKey("Course")]
    public int CourseId { get; set; }

    [Required, MaxLength(200)]
    public string Title { get; set; }

    public string Content { get; set; } // Could be text or URL to a video

    [Required]
    public int Order { get; set; } // Order of lessons

    public virtual Course Course { get; set; }
    }
