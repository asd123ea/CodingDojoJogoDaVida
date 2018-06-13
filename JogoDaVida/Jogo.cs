using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVida
{
    public class Jogo
    {
        public object RetornarSeCelulaVaiEstarViva(int[,] matrizInicial)
        {
            Int16 result = 0;

            if (matrizInicial[0, 1] == 1)
                result++;

            if (matrizInicial[1, 0] == 1)
                result++;

            if (matrizInicial[1, 1] == 1)
                result++;

            return result == 3 ? true : false;
        }

        public object RetornarSeCelulaVaiEstarVivaP01(int[,] matrizInicial)
        {
            Int16 result = 0;

            if (matrizInicial[0, 2] == 1)
                result++;

            if (matrizInicial[1, 2] == 1)
                result++;

            if (matrizInicial[1, 1] == 1)
                result++;

            if (matrizInicial[1, 0] == 1)
                result++;

            if (matrizInicial[0, 0] == 1)
                result++;

            return result == 3 ? true : false;
        }

        public object RetornarSeCelulaVaiEstarVivaP02(int[,] matrizInicial)
        {
            Int16 result = 0;

            if (matrizInicial[1, 2] == 1)
                result++;

            if (matrizInicial[1, 1] == 1)
                result++;

            if (matrizInicial[0, 1] == 1)
                result++;

            return result == 3 ? true : false;
        }
    }
}
