using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model.Classes
{
    [Table("user_account")]
    public class UserAccount
    {
        [Key, Column("user_account_id")]
        public Guid UserAccountID { get; set; }
        [MaxLength(45), Column("username")]
        public string Username { get; set; }
        [MaxLength(45), Column("password")]
        public string Password { get; set; }
        [Column("isDeleted")]
        public short IsDeleted { get; set; }
    }
}
