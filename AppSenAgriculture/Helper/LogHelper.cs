using System;
using System.Collections.Generic;
using System.IO;

namespace AppSenAgriculture.Helper
{
    /// <summary>
    /// Classe utilitaire pour la gestion des logs de l'application.
    /// Adaptée depuis la classe Utils du professeur pour WinForms sur Debian.
    /// Les logs sont stockés dans des fichiers texte dans le dossier "Error".
    /// </summary>
    public class LogHelper
    {
        // Dossier où sont stockés les fichiers de logs
        private static readonly string DossierError = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "Error"
        );

        /// <summary>
        /// Initialise le dossier Error s'il n'existe pas encore.
        /// </summary>
        private static void Initialiser()
        {
            if (!Directory.Exists(DossierError))
                Directory.CreateDirectory(DossierError);
        }

        /// <summary>
        /// Rédiger le message d'erreur dans un fichier erreur.txt.
        /// Equivalent de WriteFileError du professeur adapté pour WinForms.
        /// </summary>
        /// <param name="message">Le message d'erreur</param>
        public static void WriteFileError(string message)
        {
            try
            {
                Initialiser();
                string path = Path.Combine(DossierError, "erreur.txt");

                // Ouvre le fichier en mode ajout pour ne pas écraser les logs existants
                TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("" + DateTime.Now);
                writeFile.WriteLine(message);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                // En cas d'erreur d'écriture, on écrit dans la console
                Console.WriteLine("Erreur WriteFileError : " + e.Message);
            }
        }

        /// <summary>
        /// Crée un fichier d'erreur nommé par la date du jour.
        /// Equivalent de CreateFile du professeur adapté pour WinForms.
        /// </summary>
        /// <param name="message">Le message d'erreur</param>
        /// <returns>Retourne true si le fichier est créé avec succès</returns>
        public bool CreateFile(string message)
        {
            bool rep = false;

            // Nom du fichier basé sur la date du jour
            string fileName = string.Format("{0}{1}{2}",
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day
            );

            try
            {
                Initialiser();
                string path = Path.Combine(DossierError, fileName + ".txt");

                // Supprime le fichier s'il existe déjà
                if (File.Exists(path))
                    File.Delete(path);

                bool fileUse = true;
                while (fileUse)
                {
                    try
                    {
                        // Écrit le message dans le fichier
                        TextWriter writeFile = new StreamWriter(path, true);
                        writeFile.WriteLine("" + DateTime.Now);
                        writeFile.WriteLine(message);
                        writeFile.WriteLine("-------------------------------------------");
                        writeFile.Flush();
                        writeFile.Close();
                        writeFile = null;
                        fileUse = false;
                    }
                    catch (Exception e)
                    {
                        WriteFileError("CreateFile : " + e.ToString());
                    }
                }
                rep = true;
            }
            catch (IOException e)
            {
                WriteFileError("WriteFileError : " + e.ToString());
            }
            return rep;
        }

        /// <summary>
        /// Permet de rédiger une liste d'erreurs dans un fichier.
        /// Equivalent de WriteErrorLoad du professeur adapté pour WinForms.
        /// </summary>
        /// <param name="message">Liste des messages d'erreur</param>
        /// <param name="theFile">Nom du fichier de sortie</param>
        public void WriteErrorLoad(List<string> message, string theFile)
        {
            try
            {
                Initialiser();
                string path = Path.Combine(DossierError, theFile + ".txt");

                // Supprime le fichier s'il existe déjà
                if (File.Exists(path))
                    File.Delete(path);

                TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("---------------------DEBUT----------------------");

                // Écrit chaque message de la liste
                foreach (var item in message)
                    writeFile.WriteLine(item);

                writeFile.WriteLine("----------------------FIN---------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                WriteFileError("WriteErrorLoad : " + e.ToString());
            }
        }

        /// <summary>
        /// Enregistre une action utilisateur dans un fichier de logs.
        /// Méthode ajoutée pour tracer les actions des utilisateurs.
        /// </summary>
        /// <param name="login">Le login de l'utilisateur</param>
        /// <param name="action">La description de l'action effectuée</param>
        public static void WriteAction(string login, string action)
        {
            try
            {
                Initialiser();
                string path = Path.Combine(DossierError, "actions.txt");

                TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("" + DateTime.Now);
                writeFile.WriteLine(string.Format("[{0}] {1}", login, action));
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                Console.WriteLine("Erreur WriteAction : " + e.Message);
            }
        }
    }
}