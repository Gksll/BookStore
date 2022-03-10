using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Kind : Entity
    {
        [Key]
        public int KindId { get; set; }
        [Required(ErrorMessage = "Tür bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 30, ErrorMessage = "En fazla 30 karakter olmalıdır")]
        public string BookKind { get; set; }
        

        public virtual ICollection<Book> Books { get; set; }
    }
}