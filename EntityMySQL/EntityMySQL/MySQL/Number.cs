using System.ComponentModel.DataAnnotations;

namespace EntityMySQL.MySQL
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
