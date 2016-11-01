using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IgraVjesala
{
    [TestClass]
    public class TestSkriveneRijeci
    {
        [TestMethod]
        public void ImasLiSlovoVraćaTrueZaSlovoKojeJeURiječi()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.IsTrue(rijec.ImasLiSlovo('a'));
        }


        [TestMethod]
        public void ImasLiSlovoVraćaTrueZaSlovoKojeJeURiječiBezObziraVelikoMalo()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.IsTrue(rijec.ImasLiSlovo('A'));
        }


        [TestMethod]
        public void ImasLiSlovoVraćaFalseZaSlovoKojeNijeURiječi()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.IsFalse(rijec.ImasLiSlovo('b'));
        }

        [TestMethod]
        public void NaPočetkuSkrivenaRiječPrikazujeSamoPodcrtavanje()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            string očekivani = string.Format("{0}{0}{0}{0}", SkrivenaRijec.ZnakZaNeotkrivenaSlova);
            Assert.AreEqual(očekivani, rijec.Prikaz());
        }

        [TestMethod]
        public void  NakonPrvogPogođenogSlovaOnoSePrikazuje()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            rijec.ImasLiSlovo('a');
            string očekivani = string.Format("{0}A{0}A", SkrivenaRijec.ZnakZaNeotkrivenaSlova);
            Assert.AreEqual(očekivani, rijec.Prikaz());
        }

        [TestMethod]
        public void NakonNepogođenogPrvogSlovaVideSeSamoCrtice()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            rijec.ImasLiSlovo('t');
            string očekivani = string.Format("{0}{0}{0}{0}", SkrivenaRijec.ZnakZaNeotkrivenaSlova);
            Assert.AreEqual(očekivani, rijec.Prikaz());
        }

        [TestMethod]
        public void PokušajOtkrivanjaCijeleRiječiVraćaTrueZaPravuRiječ()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.IsTrue(rijec.JesiLi("mama"));
        }

        [TestMethod]
        public void PokušajOtkrivanjaCijeleRiječiVraćaTrueZaPravuRiječBezObziraVelikoMalo()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.IsTrue(rijec.JesiLi("MAma"));
        }

        [TestMethod]
        public void PokušajOtkrivanjaCijeleRiječiVraćaFalseZaKrivuRiječ()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.IsFalse(rijec.JesiLi("mata"));
        }
    }
}
