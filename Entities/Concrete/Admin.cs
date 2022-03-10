using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public int AdminType_ID { get; set; }

        [ForeignKey("AdminType_ID")]
        public virtual AdminType AdminType { get; set; }

        [Display(Name = "Isim")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "bu alan 3 ile 50 karakter arasında olmalıdır.", MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Soyisim")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "bu alan 3 ile 50 karakter arasında olmalıdır.", MinimumLength = 3)]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "bu alan 3 ile 50 karakter arasında olmalıdır.", MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "bu alan 3 ile 50 karakter arasında olmalıdır.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }

    }
}
