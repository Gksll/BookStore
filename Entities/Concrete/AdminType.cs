using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class AdminType
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Yönetici tür ismi yazılmalıdır")]
        [StringLength(maximumLength: 20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string Name { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
    }
}
