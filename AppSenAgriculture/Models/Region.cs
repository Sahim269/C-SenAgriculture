using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Region
    {
        [Key]
        public int idRegion { get; set; }
        [Required,MaxLength(100)]
        public String nomRegion { get; set; }
        public virtual ICollection<Departement> Departements { get; set; }
    }
}
