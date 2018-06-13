using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JogoDaVidaTeste
{
    [TestClass]
    public class UnitTest1
    {
        int[,] matrizInicial = null;

        [TestInitialize]
        public void IniciarTeste()
        {
            matrizInicial = new int[3, 3];
            matrizInicial[0, 0] = 1;
            matrizInicial[0, 1] = 0;
            matrizInicial[0, 2] = 1;

            matrizInicial[1, 0] = 0;
            matrizInicial[1, 1] = 1;
            matrizInicial[1, 2] = 0;

            matrizInicial[2, 0] = 1;
            matrizInicial[2, 1] = 0;
            matrizInicial[2, 2] = 1;
        }

        [TestMethod]
        public void TestarP00VaiEstarMorto()
        {
            Assert.AreEqual(false, new JogoDaVida.Jogo().RetornarSeCelulaVaiEstarViva(matrizInicial));
        }

        [TestMethod]
        public void TestarP01VaiEstarVivo()
        {
            Assert.AreEqual(true, new JogoDaVida.Jogo().RetornarSeCelulaVaiEstarVivaP01(matrizInicial));
        }

        [TestMethod]
        public void TestarP02VaiEstarMorto()
        {
            Assert.AreEqual(false, new JogoDaVida.Jogo().RetornarSeCelulaVaiEstarVivaP02(matrizInicial));
        }

        //[TestMethod]
        //public void TestarP01VaiEstarMorto()
        //{
        //    Int16 posicoesVivas = new JogoDaVida.Jogo().retornarQuantidadeCelulasVivas(matrizInicial);
        //    Assert.AreEqual(1, posicoesVivas);
        //}
    }
}
