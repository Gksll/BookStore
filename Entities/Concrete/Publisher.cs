using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Publisher : Entity
    {
        [Key]
        public int PublisherId { get; set; }
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        [Required(ErrorMessage = "Yayınevi bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 150, ErrorMessage = "En fazla 150 karakter olmalıdır")]
        public string PublisherName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}