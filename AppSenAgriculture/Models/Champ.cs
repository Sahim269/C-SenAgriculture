using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Champ
    {
        [Key]
        public int idChamp { get; set; }
        [Required,MaxLength(50)]
        public String nomChamp { get; set; }
        [MaxLength(150)]
        public String descriptionChamp { get; set; }
        [Required]
        public double superficie { get; set; }
        [Required]
        public double latitude { get; set; }
        [Required]
        public double longitude { get; set; }

        public int communeId { get; set; }
        public int agriculteurId { get; set; }

        [ForeignKey("communeId")]
        public virtual Commune Commune { get; set; }
        [ForeignKey("agriculteurId")]
        public virtual Agriculteur Agriculteur { get; set; }

    }
}
