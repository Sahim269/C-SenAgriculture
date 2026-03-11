using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Helper
{
    public class FillList
    {
        BdSenAgricultureContext db = new BdSenAgricultureContext();

        ///<summary>
        /// Permet de remplir la liste des unités de mesure
        /// </summary>
        /// <returns>Une liste d'unités de mesure</returns>

        public List<ListItem> fillUniteMesure()
        {
            List<ListItem> laliste = new List<ListItem>();

            var unites = db.UniteMesures.ToList();
            laliste.Add(new ListItem {
                Value = null,
                Text = "Sélectionnez une unité de mesure....."
            });
            foreach (var t in unites)
            {
                var item = new ListItem
                {
                    Value = t.idUnite.ToString(),
                    Text = t.NameUnite
                };
                laliste.Add(item);
            }

            return laliste;
        }


        ///<summary>
        /// Permet de remplir la liste des categories de produits
        /// </summary>
        /// <returns>Une liste des categorie</returns>

        public List<ListItem> fillCategorie()
        {
            List<ListItem> laliste = new List<ListItem>();

            var unites = db.Categories.ToList();
            laliste.Add(new ListItem
            {
                Value = null,
                Text = "Sélectionnez une categorie....."
            });
            foreach (var t in unites)
            {
                var item = new ListItem
                {
                    Value = t.IdCategorie.ToString(),
                    Text = t.LibelleCategorie
                };
                laliste.Add(item);
            }

            return laliste;
        }
    }
}
