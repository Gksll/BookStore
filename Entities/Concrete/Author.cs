using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Author : Entity
    {
        [Key]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "İsim bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 30, ErrorMessage = "En fazla 30 karakter olmalıdır")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 30, ErrorMessage = "En fazla 30 karakter olmalıdır")]
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }


    }
}