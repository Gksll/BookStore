using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Volume : Entity
    {
        [Key]
        public int VolumeId { get; set; }
        [Required(ErrorMessage = "Cilt bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string BookVolume { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}