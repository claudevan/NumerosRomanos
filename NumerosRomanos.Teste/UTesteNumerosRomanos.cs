using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos.Conversao;

namespace NumerosRomanos.Teste
{
    [TestClass]
    public class UTesteNumerosRomanos
    {
        [TestMethod]
        public void Numero_1_Resulta_I()
        {
            Assert.AreEqual("I", Romanos.Converter(1));
        }

        [TestMethod]
        public void Numero_3_Resulta_III()
        {
            Assert.AreEqual("III", Romanos.Converter(3));
        }

        [TestMethod]
        public void Numero_5_Resulta_V()
        {
            Assert.AreEqual("V", Romanos.Converter(5));
        }

        [TestMethod]
        public void Numero_10_Resulta_X()
        {
            Assert.AreEqual("X", Romanos.Converter(10));
        }

        [TestMethod]
        public void Numero_18_Resulta_XVIII()
        {
            Assert.AreEqual("XVIII", Romanos.Converter(18));
        }
    }
}
