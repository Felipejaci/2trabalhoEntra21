using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho02MVC.Model
{
    class Gerador
    {
        public static string preencheTabuleiro(string letra1, string letra2)
        {
            //gera aleatorianmente os numeros
            Random rand = new Random();

            if (rand.Next(1, 3) == 1)
            {
                return letra1;
            }
            else
            {
                return letra2;
            }
        }
        public static string preencheTabuleiro2(string letra1, string letra2, string letra3)
        {
            //gera aleatorianmente os numeros so que com tres numeros
            Random rand = new Random();
            int nu = rand.Next(1, 4);
            if (nu == 1)
            {
                return letra1;
            }
            else if (nu == 2)
            {
                return letra2;
            }
            else
            {
                return letra3;
            }
        }
    }
}
