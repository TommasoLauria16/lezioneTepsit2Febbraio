using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaEsercitazione;

namespace EsercitazioneTest
{
    [TestClass]
    public class Operazioni
    {
        [TestMethod]
        public void TestCalcoloMisterioso()
        {
            int n = 5;
            long valore_aspettato = 240;
            long resp = GestioneTest.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso_1()
        {
            int n = 2;
            long valore_aspettato = 4;
            long resp = GestioneTest.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[] { 4, 6, 7, -9.1 };
            double min = GestioneTest.MisuraMistariosa(valori);
            double valore_aspettato = 3;
            Assert.AreEqual(valore_aspettato, min);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa_1()
        {
            double[] valori = new double[] { 4, 6, 7, -9.1 };
            double min = GestioneTest.MisuraMistariosa1(valori);
            double valore_aspettato = -9.1;
            Assert.AreEqual(valore_aspettato, min);
        }
        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            long n = 3;
            long valore_aspettato = -18;
            long resp = GestioneTest.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

    }
}
