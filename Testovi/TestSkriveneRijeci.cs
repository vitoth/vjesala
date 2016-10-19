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
        public void ImasLiSlovoVraćaFalseZaSlovoKojeNijeURiječi()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.IsFalse(rijec.ImasLiSlovo('b'));
        }

        [TestMethod]
        public void NaPočetkuSkrivenaRiječPrikazujeSamoPodcrtavanje()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            Assert.AreEqual("____", rijec.Prikaz());
        }

        [TestMethod]
        public void  NakonPrvogPogođenogSlovaOnoSePrikazuje()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            rijec.ImasLiSlovo('a');
            Assert.AreEqual("_a_a", rijec.Prikaz());
        }

        [TestMethod]
        public void NakonNepogođenogPrvogSlovaVideSeSamoCrtice()
        {
            SkrivenaRijec rijec = new SkrivenaRijec("mama");
            rijec.ImasLiSlovo('t');
            Assert.AreEqual("____", rijec.Prikaz());
        }
    }
}
