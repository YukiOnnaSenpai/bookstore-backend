using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model.Classes
{
    [Table("book")]
    public class Book
    {
        [Key, Column("book_id")]
        public Guid BookID { get; set; }
        [MaxLength(13), Column("isbn")]
        public string ISBN { get; set; }
        [MaxLength(256), Column("title")]
        public string Title { get; set; }
        [MaxLength(256), Column("author")]
        public string Author { get; set; }
        [MaxLength(128), Column("genre")]
        public string Genre { get; set; }
        [Column("isDeleted")]
        public short IsDeleted { get; set; }
    }
}
