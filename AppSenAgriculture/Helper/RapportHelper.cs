using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using AppSenAgriculture.Models;

namespace AppSenAgriculture.Helper
{
    /// <summary>
    /// Classe utilitaire pour la génération de rapports PDF.
    /// Utilise la bibliothèque iTextSharp pour créer les fichiers PDF.
    /// </summary>
    public static class RapportHelper
    {
        // Dossier où sont stockés les rapports générés
        private static readonly string DossierRapports = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "Rapports"
        );

        /// <summary>
        /// Initialise le dossier Rapports s'il n'existe pas encore.
        /// </summary>
        private static void Initialiser()
        {
            if (!Directory.Exists(DossierRapports))
                Directory.CreateDirectory(DossierRapports);
        }

        /// <summary>
        /// Génère un rapport PDF de la liste des produits.
        /// </summary>
        /// <param name="produits">La liste des produits à inclure dans le rapport</param>
        /// <returns>Le chemin du fichier PDF généré</returns>
        public static string GenererRapportProduits(List<Produit> produits)
        {
            Initialiser();

            // Nom du fichier basé sur la date et l'heure
            string nomFichier = string.Format("rapport_produits_{0}.pdf", DateTime.Now.ToString("yyyy_MM_dd_HH_mm"));
            string cheminFichier = Path.Combine(DossierRapports, nomFichier);

            // Crée le document PDF en format A4
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);

            try
            {
                // Crée le writer qui va écrire dans le fichier
                PdfWriter.GetInstance(document, new FileStream(cheminFichier, FileMode.Create));
                document.Open();

                // Définit les polices
                Font fontTitre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                Font fontSousTitre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                Font fontDate = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9, BaseColor.GRAY);

                // Ajoute le titre du rapport
                Paragraph titre = new Paragraph("SenAgriculture - Liste des Produits", fontTitre);
                titre.Alignment = Element.ALIGN_CENTER;
                titre.SpacingAfter = 5;
                document.Add(titre);

                // Ajoute la date de génération
                Paragraph date = new Paragraph(
                    "Généré le : " + DateTime.Now.ToString("dd/MM/yyyy à HH:mm"), fontDate
                );
                date.Alignment = Element.ALIGN_CENTER;
                date.SpacingAfter = 20;
                document.Add(date);

                // Crée le tableau avec 5 colonnes
                PdfPTable tableau = new PdfPTable(5);
                tableau.WidthPercentage = 100;

                // Définit la largeur des colonnes
                tableau.SetWidths(new float[] { 3f, 5f, 2f, 2f, 3f });

                // Ajoute les en-têtes du tableau
                AjouterEnTeteTableau(tableau, "Libellé", fontSousTitre);
                AjouterEnTeteTableau(tableau, "Description", fontSousTitre);
                AjouterEnTeteTableau(tableau, "Prix Min", fontSousTitre);
                AjouterEnTeteTableau(tableau, "Prix Max", fontSousTitre);
                AjouterEnTeteTableau(tableau, "Catégorie", fontSousTitre);

                // Ajoute les données des produits
                bool ligneAlternee = false;
                foreach (var produit in produits)
                {
                    // Alterne la couleur des lignes pour la lisibilité
                    BaseColor couleurLigne = ligneAlternee
                        ? new BaseColor(240, 240, 240)
                        : BaseColor.WHITE;

                    AjouterCelluleTableau(tableau, produit.LibelleProduit, fontNormal, couleurLigne);
                    AjouterCelluleTableau(tableau, produit.DescriptionProduit, fontNormal, couleurLigne);
                    AjouterCelluleTableau(tableau, produit.PrixUnitaireMin + " FCFA", fontNormal, couleurLigne);
                    AjouterCelluleTableau(tableau, produit.PrixUnitaireMax + " FCFA", fontNormal, couleurLigne);
                    AjouterCelluleTableau(tableau,
                        produit.Categorie != null ? produit.Categorie.LibelleCategorie : "-",
                        fontNormal, couleurLigne
                    );

                    ligneAlternee = !ligneAlternee;
                }

                document.Add(tableau);

                // Ajoute le nombre total de produits
                Paragraph total = new Paragraph(
                    string.Format("Total : {0} produit(s)", produits.Count),
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)
                );
                total.SpacingBefore = 15;
                total.Alignment = Element.ALIGN_RIGHT;
                document.Add(total);
            }
            finally
            {
                // Ferme toujours le document même en cas d'erreur
                document.Close();
            }

            return cheminFichier;
        }

        /// <summary>
        /// Ajoute une cellule d'en-tête au tableau avec fond vert.
        /// </summary>
        private static void AjouterEnTeteTableau(PdfPTable tableau, string texte, Font font)
        {
            PdfPCell cellule = new PdfPCell(new Phrase(texte, font));
            cellule.BackgroundColor = new BaseColor(34, 139, 34);
            cellule.HorizontalAlignment = Element.ALIGN_CENTER;
            cellule.Padding = 8;
            tableau.AddCell(cellule);
        }

        /// <summary>
        /// Ajoute une cellule de données au tableau.
        /// </summary>
        private static void AjouterCelluleTableau(PdfPTable tableau, string texte, Font font, BaseColor couleur)
        {
            PdfPCell cellule = new PdfPCell(new Phrase(texte, font));
            cellule.BackgroundColor = couleur;
            cellule.Padding = 6;
            tableau.AddCell(cellule);
        }
    }
}