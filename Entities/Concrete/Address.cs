using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Address:Entity
    {
        [Key]
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Adres bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 100, ErrorMessage = "En fazla 100 karakter olmalıdır")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Adres-isim bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string AddressName { get; set; }
        [Required(ErrorMessage = "Şehir bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string City { get; set; }
        [Required(ErrorMessage = "PostaKodu bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 10, ErrorMessage = "En fazla 10 karakter olmalıdır")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Ülke bilgisi yazılmalıdır")]
        [StringLength(maximumLength: 20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string Country { get; set; }
        
        [StringLength(maximumLength: 200, ErrorMessage = "En fazla 200 karakter olmalıdır")]
        public string Notes { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }

    }
}