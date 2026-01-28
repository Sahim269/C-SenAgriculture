using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Commune
    {
        [Key]
        public int idCommune { get; set; }
        [Required, MaxLength(100)]
        public String nomCommune { get; set; }
        public int departementId { get; set; }

        [ForeignKey("departementId")]
        public virtual Departement Departement { get; set; }

        public virtual ICollection<Champ> Champs { get; set; }
    }
}
