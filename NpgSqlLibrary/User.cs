using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NpgSqlLibrary
{
    [Table("public.users")]
    public class User
    {
        [Key]
        [Column("username")]
        public string Username { get; set; }

        [Column("password", TypeName = "text")]
        [Required]
        public string Password { get; set; }

        [Column("salt", TypeName = "text")]
        public string Salt { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
