using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    class Doenca
    {


        #region doença


        //Eliminação de dado do array que contêm a imformação que tinha anteriormente OUTRA DOENÇA;
        //Ou seja, sempre que uma pessoa falecer ou recuperar de covid-19, esse espaço do array será limpo;
        public static int Eliminar_Doenca(int i, int[] doenca)
        {

            doenca[i - 1] = 0;
            return (doenca[i - 1]);
        }

        //Método em que o utilizador vai confirmar se têm alguma outra doenç0a para além do covid-19;
        public static int Defdoenca(int num)
        {
            try
            {
                Console.WriteLine("\nDigite o número correspondente à doença que o paciente tem:");
                Console.WriteLine("Doenças cardiovasculares (1)");
                Console.WriteLine("Doenças pulmonares (2)");
                Console.WriteLine("Diabetes (3)");
                Console.WriteLine("Outra doença (4)");
                Console.WriteLine("Não tem doenças (5)");
                num = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("\nO valor inserido é inválido. Por favor insira outro valor");

            }

            if (num == 1)
            {
                Console.WriteLine("A sua doença é cardiovascular");
                return (num);
            }
            else if (num == 2)
            {
                Console.WriteLine("A sua doença é pulmonar");
                return (num);
            }
            else if (num == 3)

            {
                Console.WriteLine("A sua doença é diabetes");
                return (num);
            }
            else if (num == 4)
            {
                Console.WriteLine("Você têm outra doença");
                return (num);
            }
            else if (num == 5)
            {

                Console.WriteLine("Você não tem nenhuma doença");
                return (num);
            }
            else
            {
                Console.WriteLine("Número inválido. Por favor, insira um valor de 1 a 5.");
                return (0);

            }
        }


        #endregion




    }
}
