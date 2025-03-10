using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Transaction
    {
    [Key]
    public int TransactionId { get; set; }

    [Required, ForeignKey("User")]
    public int UserId { get; set; }

    [Required, ForeignKey("Course")]
    public int CourseId { get; set; }

    [Required]
    public double Amount { get; set; }

    [Required]
    public string PaymentStatus { get; set; } // Success, Failed, Pending

    public DateTime PaymentDate { get; set; } = DateTime.Now;

    public virtual User User { get; set; }
    public virtual Course Course { get; set; }
    }
