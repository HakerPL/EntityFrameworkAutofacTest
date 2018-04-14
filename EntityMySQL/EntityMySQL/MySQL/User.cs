using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Cache;

namespace EntityMySQL.MySQL
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [MaxLength(20)]
        public string Name2 { get; set; }

        public List<Article> Articles { get; set; }
    }
}
