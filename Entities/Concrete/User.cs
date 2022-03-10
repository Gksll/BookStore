using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class User : Entity
    {
        [Key]
        public int UserId { get; set; }
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        [Required(ErrorMessage = "Isim bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 30, ErrorMessage = "En fazla 30 karakter olmalıdır")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 30, ErrorMessage = "En fazla 30 karakter olmalıdır")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Cinsiyet bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Telefon bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 15, ErrorMessage = "En fazla 15 karakter olmalıdır")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}