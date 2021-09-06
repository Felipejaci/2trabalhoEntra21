using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho02MVC.Control
{
    class Controller
    {
        public static string
            
        ContadorPontos(string[][] matriz, string nu)
        {
            //cria variaveis utilizadas
            double points = 0;
            string numProcura = "";
            bool confere = false;
            
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] == nu[0].ToString())
                    {
                        //se o numero esta na metriz
                        confere = true;
                        //numProcura recebe o numero atual
                        numProcura = matriz[i][j];
                        //adiciona os pontos ao usuario
                        points += 0.5;
                        i = 20;
                        break;
                    }
                }
            }
            //confere for true
            if (confere)
            {
                for (int k = 1; k < nu.Length; k++)// for do numero letra a conferir
                {
                    for (int i = 0; i < matriz.Length; i++)//for matriz
                    {
                        for (int j = 0; j < matriz[i].Length; j++)//for matriz
                        {
                            if (matriz[i][j] == numProcura)//achar o numero atual na matriz
                            {
                                List<string> lista = new List<string>();//lista de numeros adjacentes
                                try//try catch que adiciona na lista os numeros adjacentes
                                {
                                    lista.Add(matriz[i - 1][j - 1]);
                                }
                                catch (Exception)
                                {
                                }
                                try
                                {
                                    lista.Add(matriz[i][j - 1]);
                                }
                                catch (Exception)
                                {
                                }
                                try
                                {
                                    lista.Add(matriz[i - 1][j]);
                                }
                                catch (Exception)
                                {
                                }
                                try
                                {
                                    lista.Add(matriz[i + 1][j + 1]);
                                }
                                catch (Exception)
                                {
                                }
                                try
                                {
                                    lista.Add(matriz[i + 1][j - 1]);
                                }
                                catch (Exception)
                                {
                                }
                                try
                                {
                                    lista.Add(matriz[i - 1][j + 1]);
                                }
                                catch (Exception)
                                {
                                }
                                try
                                {
                                    lista.Add(matriz[i + 1][j]);
                                }
                                catch (Exception)
                                {
                                }
                                try
                                {
                                    lista.Add(matriz[i][j + 1]);
                                }
                                catch (Exception)
                                {
                                }

                                int confNumerosProx = 0;
                                bool teste2 = false;
                                for (int l = 0; l < lista.Count; l++)//for que confere se o proximo numero esta na lista de numeros adjacentes
                                {
                                    for (int m = k - 1; m > 0; m--)//for que confere numeros repetidos
                                    {
                                        if (nu[k] == nu[m])
                                        {
                                            teste2 = true;
                                            l = lista.Count - 1;
                                            break;
                                        }
                                    }

                                    if (nu[k].ToString() == lista[l] && teste2 == false)//confere se o proximo numero esta na lista de numeros adjacentes
                                    {
                                        confNumerosProx = 1;
                                        numProcura = lista[l];
                                    }
                                }
                                if (confNumerosProx == 1)//adciona os pontos
                                {
                                    points += 0.5;
                                    i = 2;
                                    break;
                                }
                                else
                                {
                                    i = 2;
                                    k = 20;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                
            }

            return Math.Floor(points).ToString();//retorna o numero arredondado para baixo
        }
    }
}
