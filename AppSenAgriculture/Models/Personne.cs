using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Personne
    {
        [Key]
        public int IdPersonne { get; set; }

        [Required, MaxLength(80)]
        public String NomPersonne { get; set; }

        [Required,MaxLength(100)]
        public String PrenomPersonne { get; set; }
        public String EmailPersonne { get; set; }

        [Required, MaxLength(20)]
        public String TelephonePersonne { get; set; }

    }
}
