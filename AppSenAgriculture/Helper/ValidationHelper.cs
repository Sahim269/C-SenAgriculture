using System;
using System.Text.RegularExpressions;

namespace AppSenAgriculture.Helper
{
    /// <summary>
    /// Classe utilitaire pour la validation des données de l'application.
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Vérifie si un numéro de téléphone est valide pour le Sénégal.
        /// Formats acceptés :
        /// - 77 123 45 67
        /// - 70 123 45 67
        /// - 76 123 45 67
        /// - 75 123 45 67
        /// - 78 123 45 67
        /// - +221 77 123 45 67
        /// - 00221 77 123 45 67
        /// </summary>
        /// <param name="telephone">Le numéro de téléphone à valider</param>
        /// <returns>True si le numéro est valide, false sinon</returns>
        public static bool EstTelephoneValide(string telephone)
        {
            if (string.IsNullOrEmpty(telephone))
                return false;

            // Supprime les espaces, tirets et points
            string numero = telephone.Replace(" ", "")
                                     .Replace("-", "")
                                     .Replace(".", "");

            // Format local : 7X XXX XX XX (9 chiffres commençant par 7)
            // Opérateurs : 70 (Expresso), 75/76/77/78 (Orange/Free/Expresso)
            if (Regex.IsMatch(numero, @"^7[0-8]\d{7}$"))
                return true;

            // Format international : +221 7X XXX XX XX
            if (Regex.IsMatch(numero, @"^\+2217[0-8]\d{7}$"))
                return true;

            // Format international avec 00 : 00221 7X XXX XX XX
            if (Regex.IsMatch(numero, @"^002217[0-8]\d{7}$"))
                return true;

            return false;
        }

        /// <summary>
        /// Retourne un message d'erreur si le numéro est invalide.
        /// </summary>
        /// <param name="telephone">Le numéro de téléphone à valider</param>
        /// <returns>Message d'erreur ou null si valide</returns>
        public static string MessageErreurTelephone(string telephone)
        {
            if (string.IsNullOrEmpty(telephone))
                return "Le numéro de téléphone est obligatoire.";

            if (!EstTelephoneValide(telephone))
                return "Numéro invalide, saisissez un numero de telephone valide  Exemples valides : 77 123 45 67 / +221 77 123 45 67";

            return null;
        }
    }
}