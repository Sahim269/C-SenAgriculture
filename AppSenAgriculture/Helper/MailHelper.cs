using System;
using System.Net;
using System.Net.Mail;

namespace AppSenAgriculture.Helper
{
    /// <summary>
    /// Classe utilitaire pour l'envoi d'emails via Gmail.
    /// Adaptée depuis la classe GMailer du professeur pour WinForms sur Debian.
    /// La configuration SMTP est lue depuis App.config.
    /// </summary>
    public class MailHelper
    {
        // Paramètres de configuration du serveur SMTP Gmail
        public static string GmailUsername { get; set; }
        public static string GmailPassword { get; set; }
        public static string GmailHost { get; set; }
        public static int GmailPort { get; set; }
        public static bool GmailSSL { get; set; }

        // Paramètres du message à envoyer
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }

        /// <summary>
        /// Initialise les paramètres SMTP par défaut pour Gmail.
        /// </summary>
        static MailHelper()
        {
            GmailHost = "smtp.gmail.com";
            GmailPort = 587;
            GmailSSL = true;
        }

        /// <summary>
        /// Envoie un email en utilisant les paramètres de l'instance.
        /// </summary>
        public void Send()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = GmailHost;
            smtp.Port = GmailPort;
            smtp.EnableSsl = GmailSSL;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(GmailUsername, GmailPassword);

              try
    {
        // Log de la tentative de connexion SMTP
        LogHelper.WriteAction("Système", string.Format(
            "Tentative de connexion SMTP : {0}:{1} avec l'email {2}",
            GmailHost, GmailPort, GmailUsername
        ));

        using (var message = new MailMessage(GmailUsername, ToEmail))
        {
            message.Subject = Subject;
            message.Body = Body;
            message.IsBodyHtml = IsHtml;
            smtp.Send(message);

            // Log de l'envoi réussi
            LogHelper.WriteAction("Système", string.Format(
                "Email envoyé avec succès à {0} - Sujet : {1}",
                ToEmail, Subject
            ));
             }
            }
            catch (Exception ex)
            {
                // Log de l'échec de connexion ou d'envoi
                LogHelper.WriteFileError(string.Format(
                    "MailHelper.Send - Échec envoi à {0} : {1}",
                    ToEmail, ex.ToString()
                ));
            }
        }

        /// <summary>
        /// Envoie un email simple avec les paramètres fournis.
        /// Méthode statique pour un envoi rapide sans instancier la classe.
        /// </summary>
        /// <param name="destinataire">L'adresse email du destinataire</param>
        /// <param name="sujet">Le sujet de l'email</param>
        /// <param name="corps">Le corps de l'email en HTML</param>
        public static void EnvoyerMail(string destinataire, string sujet, string corps)
        {
            try
            {
                // Récupère les identifiants depuis App.config
                GmailUsername = System.Configuration.ConfigurationManager.AppSettings["Email"];
                GmailPassword = System.Configuration.ConfigurationManager.AppSettings["PasswordEmail"];

                // Crée une instance et envoie le mail
                MailHelper mailer = new MailHelper();
                mailer.ToEmail = destinataire;
                mailer.Subject = sujet;
                mailer.Body = "<pre>" + corps + "</pre>";
                mailer.IsHtml = true;
                mailer.Send();

                // Enregistre l'action dans les logs
                LogHelper.WriteAction("Système", "Email envoyé à : " + destinataire);
            }
            catch (Exception ex)
            {
                // Enregistre l'erreur dans les logs si l'envoi échoue
                LogHelper.WriteFileError("MailHelper.EnvoyerMail : " + ex.ToString());
            }
        }
    }
}