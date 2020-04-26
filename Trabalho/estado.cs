using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    class Estado
    {

        #region est



        //Eliminação de dado do array que contÊm a imformação do ESTADO ACTUAL DA PESSOA;
        //Ou seja, sempre que uma pessoa falecer ou recuperar de covid-19, esse espaço do array será limpo;
        public static int Eliminar_Estado(int i, int[] estadopaciente)
        {
            estadopaciente[i - 1] = 0;
            return (estadopaciente[i - 1]);

        }

        //Aqui vai ser indicado o estado do doente
        public static int Defestado(int number)
        {
            try
            {

                Console.WriteLine("\nDigite o número correspondente ao estado do paciente:");
                Console.WriteLine("Grave (1)");
                Console.WriteLine("Não Grave (2)");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nO valor inserido é inválido. Por favor insira outro valor");

            }

            if (number == 1)
            {
                Console.WriteLine("Está num estado grave!");
                return (number);
            }
            else if (number == 2)
            {
                Console.WriteLine("Está num estado menos estado grave.");
                return (number);
            }
            else
            {
                Console.WriteLine("Número inválido. Por favor insira 1 ou 2, consoante o estado.");
                return (0);
            }
        }

       


        


    #endregion




    //Neste método é pretendido mudar a estado do paciente, conforme o utilizador necessite;


    public static int Me(int f, int[] e)
    {

        if (e[f] == 1)
        {

            e[f] = 2;
            Console.WriteLine("O paciente nº" + f + " encontra-se num melhor estado.");
            return (e[f]);


        }
        else
        {
            e[f] = 1;
            Console.WriteLine("O paciente nº" + f + " encontra-se num pior estado.");
            return (e[f]);

        }


    }




}

