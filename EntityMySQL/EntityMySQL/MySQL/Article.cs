using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityMySQL.MySQL
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public int ArticleId { get; set; }

        [ForeignKey("User")]
        public int UserIdFK { get; set; }
        public virtual User User { get; set; }
    }
}
