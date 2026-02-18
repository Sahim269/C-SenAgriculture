using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class UniteMesure
    {
        [Key]
        public int idUnite { get; set; }
        [Required,MaxLength(50)]
        public string CodeUnite { get; set; }
        [Required,MaxLength(50)]
        public string NameUnite { get; set; }

    }
}
