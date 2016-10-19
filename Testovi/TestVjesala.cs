using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IgraVjesala
{
    [TestClass]
    public class TestVjesala
    {
        [TestMethod]
        public void NakonDodavanjaDijelaNaVješalimaPovećavaBrojač()
        {
            Vjesala v = new Vjesala();
            Assert.AreEqual(0, v.NaVjesalima);
                v.DodajDioTijela();
            Assert.AreEqual(1, v.NaVjesalima);


        }
    }
}
