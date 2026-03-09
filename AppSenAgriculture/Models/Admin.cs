using System.ComponentModel.DataAnnotations;

namespace AppSenAgriculture.Models
{

    /// <summary>
    /// Représente un administrateur de l'application.
    /// Hérite de la classe Personne via l'héritage TPH (Table Per Hierarchy).
    /// Les données sont stockées dans la table "Personnes" avec le discriminateur "Admin".
    /// </summary>

    public class Admin : Personne
    {
         /// <summary>
         ///  acces  admin, admin 123
        /// Identifiant unique de connexion de l'administrateur.
        /// Utilisé pour s'authentifier dans l'application.
        /// Obligatoire, longueur maximale de 100 caractères.
        /// </summary>
        [Required, MaxLength(100)]
        public string Login { get; set; }
        /// <summary>
        /// Mot de passe de l'administrateur haché en SHA256.
        /// Ne jamais stocker le mot de passe en clair.
        /// Le hachage produit une chaîne de 64 caractères hexadécimaux.
        /// Obligatoire, longueur maximale de 255 caractères.
        /// </summary>
        [Required, MaxLength(255)]
        public string MotDePasse { get; set; }
    }
}