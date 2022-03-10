using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book : Entity
    {
        public int BookId { get; set; }
        public int LanguageId { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }
        public int VolumeId { get; set; }
        
        [ForeignKey("VolumeId")]
        public virtual Volume Volume { get; set; }
        public int KindId { get; set; }
        
        [ForeignKey("KindId")]
        public virtual Kind Kind { get; set; }
        public int CategoryId { get; set; }
        
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public int PublisherId { get; set; }
        
        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }
        public int AuthorId { get; set; }
        
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        [Required(ErrorMessage = "Kitap adı  yazılmalıdır")]
        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "ISBN bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 30, ErrorMessage = "En fazla 30 karakter olmalıdır")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Sayfa sayısı bilgisi yazılmalıdır")]
        public int PageCount { get; set; }
        [Required(ErrorMessage = "Kitap yaş sınırlaması bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 10, ErrorMessage = "En fazla 10 karakter olmalıdır")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Baskı sayısı bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 10, ErrorMessage = "En fazla 10 karakter olmalıdır")]
        public string Edition { get; set; }
        [Required(ErrorMessage = "Kitap boyut bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string Size { get; set; }
        [Required(ErrorMessage = "Kitap açıklama bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 300, ErrorMessage = "En fazla 300 karakter olmalıdır")]
        public string Description { get; set; }
        
        [StringLength(maximumLength: 200, ErrorMessage = "En fazla 200 karakter olmalıdır")]
        public string Image { get; set; }


    }
}