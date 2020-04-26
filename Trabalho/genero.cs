using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    class Genero
    {

        #region género


        //Eliminação de dado do array que contêm o GÉNERO;
        //Ou seja, sempre que uma pessoa falecer ou recuperar de covid-19, esse espaço do array será limpo;
        public static string Eliminar_Gen(int i, string[] genero)
        {
            genero[i - 1] = "0";
            return (genero[i - 1]);


        }

        //Método em que o utilador vai defenir o seu género;
        public static string Defgen(string sexo)
        {
            Console.WriteLine("\nQual é o seu género (insira M se for masculino ou F se for femenino)?:");
            sexo = Console.ReadLine();


            if (sexo == "M" || sexo == "F")
            {
                if (sexo == "F")
                {
                    Console.WriteLine("O seu género é Femenino");
                    return (sexo);
                }
                else
                {
                    Console.WriteLine("O seu género é Masculino");
                    return (sexo);
                }

            }
            else
            {
                Console.WriteLine("Género inserido errado!");
                return ("0");
            }
        }

        #endregion







    }
}
