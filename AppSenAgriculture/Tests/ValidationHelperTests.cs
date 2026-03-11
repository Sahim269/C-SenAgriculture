using NUnit.Framework;
using AppSenAgriculture.Helper;

namespace AppSenAgriculture.Tests
{
    /// <summary>
    /// Tests unitaires pour la méthode EstTelephoneValide()
    /// de la classe ValidationHelper.
    /// </summary>
    [TestFixture]
    public class ValidationHelperTest
    {
        // ─── Numéros VALIDES ────────────────────────────────────────

        [Test]
        public void TelephoneValide_Orange_77()
        {
            Assert.IsTrue(ValidationHelper.EstTelephoneValide("77 123 45 67"));
        }

        [Test]
        public void TelephoneValide_Free_76()
        {
            Assert.IsTrue(ValidationHelper.EstTelephoneValide("76 123 45 67"));
        }

        [Test]
        public void TelephoneValide_Expresso_70()
        {
            Assert.IsTrue(ValidationHelper.EstTelephoneValide("70 123 45 67"));
        }

        [Test]
        public void TelephoneValide_Wave_75()
        {
            Assert.IsTrue(ValidationHelper.EstTelephoneValide("75 123 45 67"));
        }

        [Test]
        public void TelephoneValide_FormatInternational()
        {
            Assert.IsTrue(ValidationHelper.EstTelephoneValide("+221 77 123 45 67"));
        }

        [Test]
        public void TelephoneValide_FormatInternational00()
        {
            Assert.IsTrue(ValidationHelper.EstTelephoneValide("00221 77 123 45 67"));
        }

        [Test]
        public void TelephoneValide_SansEspaces()
        {
            Assert.IsTrue(ValidationHelper.EstTelephoneValide("771234567"));
        }

        [Test]
        public void TelephoneValide_AvecTirets()
        {
            Assert.IsTrue(ValidationHelper.EstTelephoneValide("77-123-45-67"));
        }

        // ─── Numéros INVALIDES ──────────────────────────────────────

        [Test]
        public void TelephoneInvalide_Vide()
        {
            Assert.IsFalse(ValidationHelper.EstTelephoneValide(""));
        }

        [Test]
        public void TelephoneInvalide_Null()
        {
            Assert.IsFalse(ValidationHelper.EstTelephoneValide(null));
        }

        [Test]
        public void TelephoneInvalide_TropCourt()
        {
            Assert.IsFalse(ValidationHelper.EstTelephoneValide("7712345"));
        }

        [Test]
        public void TelephoneInvalide_TropLong()
        {
            Assert.IsFalse(ValidationHelper.EstTelephoneValide("771234567890"));
        }

        [Test]
        public void TelephoneInvalide_CommencePas7()
        {
            Assert.IsFalse(ValidationHelper.EstTelephoneValide("33 123 45 67"));
        }

        [Test]
        public void TelephoneInvalide_AvecLettres()
        {
            Assert.IsFalse(ValidationHelper.EstTelephoneValide("77ABC4567"));
        }

        [Test]
        public void TelephoneInvalide_Francais()
        {
            Assert.IsFalse(ValidationHelper.EstTelephoneValide("+33 6 12 34 56 78"));
        }

        // ─── Test MessageErreurTelephone ────────────────────────────

        [Test]
        public void MessageErreur_Vide()
        {
            string msg = ValidationHelper.MessageErreurTelephone("");
            Assert.AreEqual("Le numéro de téléphone est obligatoire.", msg);
        }

        [Test]
        public void MessageErreur_Invalide()
        {
            string msg = ValidationHelper.MessageErreurTelephone("12345");
            Assert.IsNotNull(msg);
        }

        [Test]
        public void MessageErreur_Valide()
        {
            string msg = ValidationHelper.MessageErreurTelephone("77 123 45 67");
            Assert.IsNull(msg);
        }
    }
}