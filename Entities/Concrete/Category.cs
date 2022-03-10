using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category : Entity
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Kategori ismi yazılmalıdır")]
        [StringLength(maximumLength: 30, ErrorMessage = "En fazla 30 karakter olmalıdır")]
        public string BookCategory { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}