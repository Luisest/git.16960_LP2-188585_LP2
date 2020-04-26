using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    class Regiao
    {

        #region Varíaveis


        #endregion


        #region regiao



        // Defenição do valor da região 
        public static string Defreg(string reg)
        {

            Console.Write("\nDigite a região (Norte, Sul, Litoral, Interior): ");
            Console.WriteLine("\n----------------(Insira a primeira letra da palavra, em maíscula)------------------");
            Console.WriteLine("1) N (Norte);");
            Console.WriteLine("2) S (Sul);");
            Console.WriteLine("3) L (Litoral);");
            Console.WriteLine("4) I (Interior);\n");
            reg = Console.ReadLine();

            if (reg == "L")
            {
                Console.Write("A sua região é do Litoral;");
                return (reg);
            }
            else if (reg == "N")
            {
                Console.Write("A sua região é do Norte;");
                return (reg);
            }
            else if (reg == "S")
            {
                Console.Write("A sua região é do Sul;");
                return (reg);
            }
            else if (reg == "I")
            {
                Console.Write("A sua região é do Interior;");
                return (reg);
            }
            else
            {
                Console.Write("A sua regiao é invalida, apenas pode ser Sul, Norte, Litoral e Centro;");
                return ("0");
            }

        }


        //Eliminação de dado do array REGIÃO;
        //Ou seja, sempre que uma pessoa falecer ou recuperar de covid-19, esse espaço do array será limpo;


        public static string Elminar_Reg(int i, string[] reg)
        {

            reg[i - 1] = "0";
            return (reg[i - 1]);

        }


        #endregion








    }
}
