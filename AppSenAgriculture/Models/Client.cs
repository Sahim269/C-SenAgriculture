using System.ComponentModel.DataAnnotations;

namespace AppSenAgriculture.Models
{
    /// <summary>
    /// Représente un client de l'application.
    /// Hérite de la classe Personne via l'héritage
    /// Les données sont stockées dans la table "Personnes.
    /// </summary>
    public class Client : Personne
    {
        /// <summary>
        /// Adresse physique du client.
        /// </summary>
        [MaxLength(255)]
        public string AdresseClient { get; set; }

        /// <summary>
        /// Profession du client.
        /// </summary>
        [MaxLength(100)]
        public string ProfessionClient { get; set; }
    }

    public class ReportListeClient {         
        public int IdPersonne { get; set; }
        public string NomPersonne { get; set; }
        public string PrenomPersonne { get; set; }
        public string AdresseClient { get; set; }
        public string EmailPersonne { get; set; }
        public string TelephonePersonne { get; set; }
        public string ProfessionClient { get; set; }
    }
}