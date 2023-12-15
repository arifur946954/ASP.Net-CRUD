using System.ComponentModel.DataAnnotations.Schema;

namespace ContractApi.Models
{
    [Table("Book")]
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        // Foreign key
        public int ConId { get; set; }

        // Navigation property
        public Contracts contract { get; set; }
    }
}
