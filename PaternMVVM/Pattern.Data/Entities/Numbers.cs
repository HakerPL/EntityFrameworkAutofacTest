using System.ComponentModel.DataAnnotations;

namespace Pattern.Entities
{
    public class Number
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal Number1 { get; set; }
        [Required]
        public decimal Number2 { get; set; }
        [StringLength(100)]
        public string Notes { get; set; }
    }
}
