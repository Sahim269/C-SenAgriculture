using System;
using System.Security.Cryptography;
using System.Text;

namespace AppSenAgriculture.Helper
{
    /// <summary>
    /// Classe utilitaire pour le cryptage et la vérification des mots de passe
    /// </summary>
    public static class CryptageHelper
    {
        /// <summary>
        /// Hache un mot de passe en utilisant SHA256
        /// Utilisé pour stocker le mot de passe en base de données
        /// </summary>
        /// <param name="motDePasse">Le mot de passe en clair</param>
        /// <returns>Le mot de passe haché en hexadécimal</returns>
        public static string HacherMotDePasse(string motDePasse)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertit le mot de passe en bytes puis applique le hachage
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasse));

                // Convertit le résultat en chaîne hexadécimale
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        /// <summary>
        /// Vérifie si un mot de passe en clair correspond à un mot de passe haché
        /// Utilisé lors de la connexion pour valider le mot de passe saisi
        /// </summary>
        /// <param name="motDePasse">Le mot de passe en clair saisi par l'utilisateur</param>
        /// <param name="motDePasseHache">Le mot de passe haché stocké en base</param>
        /// <returns>True si le mot de passe correspond, False sinon</returns>
        public static bool VerifierMotDePasse(string motDePasse, string motDePasseHache)
        {
            // Hache le mot de passe saisi et compare avec celui en base
            string hache = HacherMotDePasse(motDePasse);
            return string.Equals(hache, motDePasseHache, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Chiffre un texte en utilisant AES pour les données sensibles
        /// Utilisé pour chiffrer des données autres que les mots de passe
        /// </summary>
        /// <param name="texte">Le texte à chiffrer</param>
        /// <param name="cle">La clé de chiffrement</param>
        /// <returns>Le texte chiffré en Base64</returns>
        public static string Chiffrer(string texte, string cle)
        {
            using (Aes aes = Aes.Create())
            {
                // Génère une clé et un vecteur d'initialisation à partir de la clé fournie
                aes.Key = GenererCle(cle);
                aes.IV = new byte[16];

                // Chiffre le texte
                ICryptoTransform chiffreur = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] bytesTexte = Encoding.UTF8.GetBytes(texte);
                byte[] bytesChiffres = chiffreur.TransformFinalBlock(bytesTexte, 0, bytesTexte.Length);

                // Retourne le résultat en Base64
                return Convert.ToBase64String(bytesChiffres);
            }
        }

        /// <summary>
        /// Déchiffre un texte chiffré avec AES
        /// </summary>
        /// <param name="texteChiffre">Le texte chiffré en Base64</param>
        /// <param name="cle">La clé de déchiffrement</param>
        /// <returns>Le texte déchiffré</returns>
        public static string Dechiffrer(string texteChiffre, string cle)
        {
            using (Aes aes = Aes.Create())
            {
                // Utilise la même clé et vecteur d'initialisation que lors du chiffrement
                aes.Key = GenererCle(cle);
                aes.IV = new byte[16];

                // Déchiffre le texte
                ICryptoTransform dechiffreur = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] bytesChiffres = Convert.FromBase64String(texteChiffre);
                byte[] bytesTexte = dechiffreur.TransformFinalBlock(bytesChiffres, 0, bytesChiffres.Length);

                return Encoding.UTF8.GetString(bytesTexte);
            }
        }

        /// <summary>
        /// Génère une clé AES de 32 bytes à partir d'une chaîne de caractères
        /// </summary>
        /// <param name="cle">La clé sous forme de chaîne</param>
        /// <returns>Un tableau de 32 bytes utilisable par AES</returns>
        private static byte[] GenererCle(string cle)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Hache la clé pour obtenir exactement 32 bytes
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(cle));
            }
        }
    }
}