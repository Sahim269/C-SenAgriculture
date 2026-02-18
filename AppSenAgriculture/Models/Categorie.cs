using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Categorie
    {
        [Key]
        public int IdCategorie { get; set; }
        [Required, MaxLength(100)]
        public String LibelleCategorie { get; set; }
        [MaxLength(250)]
        public String DescriptionCategorie { get; set; }

        //ACCEDER A LA LISTE DES PRODUITS DE LA CATEGORIE
        public virtual ICollection<Produit> Produits { get; set; }

    }
}
