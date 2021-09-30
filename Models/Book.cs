using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prova_dsv_back
{    
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String description { get; set; }
        public int year { get; set; }
    }
}
