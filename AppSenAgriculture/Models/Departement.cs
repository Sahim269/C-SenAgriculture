using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Departement
    {
        [Key]
        public int idDepartement { get; set; }
        [Required, MaxLength(100)]
        public String nomDepartement { get; set; }
        public int regionId { get; set; }
        [ForeignKey("regionId")]
        public virtual Region Region { get; set; }
        public virtual ICollection<Commune> Communes { get; set; }
    }
}
