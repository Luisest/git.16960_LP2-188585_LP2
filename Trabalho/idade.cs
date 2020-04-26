using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    class Idade
    {

        #region idade



        //Eliminação de dado do array que contêm a IDADE;
        //Ou seja, sempre que uma pessoa falecer ou recuperar de covid-19, esse espaço do array será limpo;
        public static int Eliminar_idade(int f, int[] idade)
        {

            idade[f - 1] = 0;
            return (idade[f - 1]);


        }


        //Método em que o utilizado vai inidicar a sua idade;
        public static int Defidade(int[] idade, int i)
        {
            try
            {
                Console.WriteLine("\n\nQual a sua idade?:");
                idade[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nO valor inserido é inválido. Por favor insira outro valor");
            }

            if (idade[i] > 0 && idade[i] < 110)
            {
                return (idade[i]);

            }
            else
            {
                Console.WriteLine("A sua idade não esta correta!");
                return (0);
            }

        }

        #endregion




    }
}
