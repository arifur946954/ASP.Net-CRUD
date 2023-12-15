using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractApi.Models
{
    [Table("Contract")]
    public class Contracts
    {
        [Key]
        public int ConId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
