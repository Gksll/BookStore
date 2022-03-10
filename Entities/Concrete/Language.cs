using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Language : Entity
    {
        [Key]
        public int LanguageId { get; set; }
        [Required(ErrorMessage = "Kitap dil bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string BookLanguage { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}