using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    class Pessoas
    {
        //Objetcos da classe
        // Defenimos que uma PESSOA ao dar registo no hospital vai ser defenidade por 5 categorias:
        //- Região;
        //- Idade;
        //- Género;
        //- Se já tinha outra doença para além de covid-19(titulamos este aspeto como DOENÇA);
        //- O nível de urgência;

        #region Varíaveis

        string[] sexo;
        string[] reg;
        int[] doenca;
        int[] urg;
        int [] idade;

        int i;

        #endregion





        //Métodos


        #region Métodos


        #region Fatalidades e Recuperados
        //Todos os métodos que se encotram nesta REGION têm como finalidade ajudar na contagem de falecidos e recuperados num dado Hospital;


        //Recebendo os valores que os métodos SELECIONADOR1  e SELECIONADOR2 (todas as suas rammificações tem exatamente a mesma função, apenas guardam a imformação de arrys diferentes);
        //Imprime-se as fatalidades e recuperações, ao longo que o utilizador mudifica a imformação

        public void Imprimir_FAT_RECUP(int row, int col, int[][] fatalidades, int[][] recup)
        {
            // Impressão das fatalidades por região do país;


            if (fatalidades[row][col] != 0)
            {
                if (row == 0 && col == 0 && fatalidades[row][col] != 0)

                {
                    if (fatalidades[0][0] == 1) Console.WriteLine("-> Faleceu " + fatalidades[0][0] + " pessoa do Norte;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[0][0] + " pessoas do Norte;");
                    }


                }
                if (row == 0 && col == 1 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[0][1] == 1) Console.WriteLine("-> Faleceu " + fatalidades[0][1] + " pessoa do Sul;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[0][1] + " pessoas do Sul;");
                    }


                }
                if (row == 0 && col == 2 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[0][2] == 1) Console.WriteLine("-> Faleceu " + fatalidades[0][2] + " pessoa do Interior;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[0][2] + " pessoas do Interior;");
                    }


                }
                if (row == 0 && col == 3 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[0][3] == 1) Console.WriteLine("->Faleceu " + fatalidades[0][3] + " pessoa do Litoral;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[0][3] + " pessoas do Litoral;");
                    }


                }


                // Impressão das fatalidades por idade;

                if (row == 1 && col == 0 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[1][0] == 1) Console.WriteLine("->Faleceu " + fatalidades[1][0] + " criança;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[1][0] + " crianças;");
                    }


                }
                if (row == 1 && col == 1 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[1][1] == 1) Console.WriteLine("->Faleceu " + fatalidades[1][1] + " jovem adulto;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[1][1] + " jovem adultos;");
                    }


                }
                if (row == 1 && col == 2 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[1][2] == 1) Console.WriteLine("->Faleceu " + fatalidades[1][2] + " adultos;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[1][2] + " adultos;");
                    }


                }
                if (row == 1 && col == 3 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[1][3] == 1) Console.WriteLine("->Faleceu " + fatalidades[1][3] + " sénior;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[1][3] + " séniores;");
                    }


                }

                // Impressão das fatalidades por género;

                if (row == 2 && col == 0 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[2][0] == 1) Console.WriteLine("->Faleceu " + fatalidades[2][0] + " pessoa do sexo masculino;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[2][0] + " pessoas do sexo sexo masculino;");
                    }


                }
                if (row == 2 && col == 1 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[2][1] == 1) Console.WriteLine("->Faleceu " + fatalidades[2][1] + " pessoa do sexo femenino;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[2][1] + " pessoas do sexo sexo femenino;");
                    }


                }

                // Impressão das fatalidades por doença;

                if (row == 3 && col == 0 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[3][0] == 1) Console.WriteLine("->Faleceu " + fatalidades[3][0] + "pessoa que já tinha uma saúde frágil devido a uma doença cardiovascular;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[3][0] + " pessoas que já tinham uma saúde frágil devido a uma doença cardiovascular;");
                    }


                }
                if (row == 3 && col == 1 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[3][1] == 1) Console.WriteLine("->Faleceu " + fatalidades[3][1] + " pessoa que já tinha uma saúde frágil devido a uma doença pulmonar;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[3][1] + " pessoas que já tinham uma saúde frágil devido a uma doença pulmonar;");
                    }


                }
                if (row == 3 && col == 2 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[3][2] == 1) Console.WriteLine("->Faleceu " + fatalidades[3][2] + " pessoas que já tinha uma saúde frágil devido a diabetes;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[3][2] + " pessoas que já tinham uma saúde frágil devido a diabetes;");
                    }


                }
                if (row == 3 && col == 3 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[3][3] == 1) Console.WriteLine("->Faleceu " + fatalidades[3][3] + " pessoa que já tinha uma saúde frágil devido a outra doença;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[3][3] + " pessoas que já tinham uma saúde frágil devido a outra doença;");
                    }


                }
                if (row == 3 && col == 4 && fatalidades[row][col] != 0)
                {
                    if (fatalidades[3][4] == 1) Console.WriteLine("->Faleceu " + fatalidades[3][4] + " pessoas de covid 19, sem qualquer registo de outra doença que tenha dificultado o caso;");
                    else
                    {
                        Console.WriteLine("-> Faleceram " + fatalidades[3][4] + " pessoas de covid 19, sem qualquer registo de outra doença que tenha dificultado o caso;");
                    }


                }

                //-------------------------------------------------------------------------------------------------
                // Impressão dos dados que recuperaram por região;

                if (row == 0 && col == 0 && recup[row][col] != 0)
                {
                    if (recup[0][0] == 1) Console.WriteLine("-> " + recup[0][0] + " pessoa do Norte recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[0][0] + " pessoas do Norte recuperaram;");
                    }


                }
                if (row == 0 && col == 1 && recup[row][col] != 0)
                {
                    if (recup[0][1] == 1) Console.WriteLine("-> " + recup[0][1] + " pessoa do Sul recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[0][1] + " pessoas do Sul recuperaram;");
                    }


                }
                if (row == 0 && col == 2 && recup[row][col] != 0)
                {
                    if (recup[0][2] == 1) Console.WriteLine("-> " + recup[0][2] + " pessoa do Interior recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[0][2] + " pessoas do Interior recuperaram;");
                    }


                }
                if (row == 0 && col == 3 && recup[row][col] != 0)
                {
                    if (recup[0][3] == 1) Console.WriteLine("-> " + recup[0][3] + " pessoa do Litural recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[0][3] + " pessoas do Litural recuperaram;");
                    }


                }


                // Impressão das fatalidades por idade;

                if (row == 1 && col == 0 && recup[row][col] != 0)
                {
                    if (recup[1][0] == 1) Console.WriteLine("-> " + recup[1][0] + " criança recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[1][0] + " crianças recuperarm;");
                    }


                }
                if (row == 1 && col == 1 && recup[row][col] != 0)
                {
                    if (recup[1][1] == 1) Console.WriteLine("-> " + recup[1][1] + " jovem adulto recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[1][1] + " jovens adultos recuperarm;");
                    }


                }
                if (row == 1 && col == 2 && recup[row][col] != 0)
                {
                    if (recup[1][2] == 1) Console.WriteLine("-> " + recup[1][2] + " adulto recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[1][2] + " adultos recuperarm;");
                    }


                }
                if (row == 1 && col == 3 && recup[row][col] != 0)
                {
                    if (recup[1][3] == 1) Console.WriteLine("-> " + recup[1][3] + " sénior recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[1][3] + " séniros recuperarm;");
                    }


                }

                // Impressão das fatalidades por género;

                if (row == 2 && col == 0 && recup[row][col] != 0)
                {
                    if (recup[2][0] == 1) Console.WriteLine("-> " + recup[2][0] + " pessoa do sexo masculino recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[2][0] + " pessoas do sexo masculino recuperarm;");
                    }


                }
                if (row == 2 && col == 1 && recup[row][col] != 0)
                {
                    if (recup[2][1] == 1) Console.WriteLine("-> " + recup[2][1] + " pessoa do sexo femenino recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[2][1] + " pessoas do sexo femenino recuperarm;");
                    }


                }

                // Impressão das fatalidades por doença;

                if (row == 3 && col == 0 && recup[row][col] != 0)
                {
                    if (recup[3][0] == 1) Console.WriteLine("-> " + recup[3][0] + " pessoa que já tinham uma saúde frágil devido a uma doença cardiovascular recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[3][0] + " pessoas que já tinham uma saúde frágil devido a uma doença cardiovascular recuperaram;");
                    }


                }
                if (row == 3 && col == 1 && recup[row][col] != 0)
                {
                    if (recup[3][1] == 1) Console.WriteLine("-> " + recup[3][1] + " pessoa que já tinham uma saúde frágil devido a uma doença pulmonar recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[3][1] + " pessoas que já tinham uma saúde frágil devido a uma doença pulmonar recuperaram;");
                    }


                }
                if (row == 3 && col == 2 && recup[row][col] != 0)
                {
                    if (recup[3][2] == 1) Console.WriteLine("-> " + recup[3][2] + " pessoa que já tinham uma saúde frágil devido a diabetes recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[3][2] + " pessoas que já tinham uma saúde frágil devido a diabetes recuperaram;");
                    }


                }
                if (row == 3 && col == 3 && recup[row][col] != 0)
                {
                    if (recup[3][3] == 1) Console.WriteLine("-> " + recup[3][3] + " pessoa que já tinham uma saúde frágil devido a outra doença recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[3][3] + " pessoas que já tinham uma saúde frágil devido a outra doença recuperaram;");
                    }


                }
                if (row == 3 && col == 4 && recup[row][col] != 0)
                {
                    if (recup[3][4] == 1) Console.WriteLine("-> " + recup[3][4] + " pessoa sem qualquer registo de outra doença recuperou;");
                    else
                    {
                        Console.WriteLine("-> " + recup[3][4] + " pessoas sem qualquer registo de outra doença recuperaram;");
                    }


                }

                //}
                //else if (recup[row][col] != 0)
                //{

                //    // Impressão das recuperações por região do país;


                //    if (row == 0 && col == 0  && recup[row][col] != 0)
                //    {
                //        if (recup[0][0] == 1) Console.WriteLine("-> " + recup[0][0] + " pessoa do Norte recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[0][0] + " pessoas do Norte recuperaram;");
                //        }


                //    }
                //    if ( == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[0][1] == 1) Console.WriteLine("-> " + recup[0][1] + " pessoa do Sul recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[0][1] + " pessoas do Sul recuperaram;");
                //        }


                //    }
                //    if (recup[0][2] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[0][2] == 1) Console.WriteLine("-> " + recup[0][2] + " pessoa do Interior recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[0][2] + " pessoas do Interior recuperaram;");
                //        }


                //    }
                //    if (recup[0][3] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[0][3] == 1) Console.WriteLine("-> " + recup[0][3] + " pessoa do Litural recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[0][3] + " pessoas do Litural recuperaram;");
                //        }


                //    }


                //    // Impressão das recuperações por idade;

                //    if (recup[1][0] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[1][0] == 1) Console.WriteLine("-> " + recup[1][0] + " criança recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[1][0] + " crianças recuperarm;");
                //        }


                //    }
                //    if (recup[1][1] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[1][1] == 1) Console.WriteLine("-> " + recup[1][1] + " jovem adulto recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[1][1] + " jovens adultos recuperarm;");
                //        }


                //    }
                //    if (recup[1][2] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[1][2] == 1) Console.WriteLine("-> " + recup[1][2] + " adulto recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[1][2] + " adultos recuperarm;");
                //        }


                //    }
                //    if (recup[1][3] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[1][0] == 1) Console.WriteLine("-> " + recup[1][3] + " sénior recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[1][3] + " séniros recuperarm;");
                //        }


                //    }

                //    // Impressão das recuperações por género;

                //    if (recup[2][0] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[2][0] == 1) Console.WriteLine("-> " + recup[2][0] + " pessoa do sexo masculino recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[2][0] + " pessoas do sexo masculino recuperarm;");
                //        }


                //    }
                //    if (recup[2][1] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[2][1] == 1) Console.WriteLine("-> " + recup[2][1] + " pessoa do sexo femenino recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[2][1] + " pessoas do sexo femenino recuperarm;");
                //        }


                //    }


                //    // Impressão das recuperações\ por doença;

                //    if (recup[3][0] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[3][0] == 1) Console.WriteLine("-> " + recup[3][0] + " pessoa que já tinham uma saúde frágil devido a uma doença cardiovascular recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[3][0] + " pessoas que já tinham uma saúde frágil devido a uma doença cardiovascular recuperaram;");
                //        }


                //    }
                //    if (recup[3][1] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[3][1] == 1) Console.WriteLine("-> " + recup[3][1] + " pessoa que já tinham uma saúde frágil devido a uma doença pulmonar recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[3][1] + " pessoas que já tinham uma saúde frágil devido a uma doença pulmonar recuperaram;");
                //        }


                //    }
                //    if (recup[3][2] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[3][2] == 1) Console.WriteLine("-> " + recup[3][2] + " pessoa que já tinham uma saúde frágil devido a diabetes recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[3][2] + " pessoas que já tinham uma saúde frágil devido a diabetes recuperaram;");
                //        }


                //    }
                //    if (recup[3][3] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[3][3] == 1) Console.WriteLine("-> " + recup[3][3] + " pessoa que já tinham uma saúde frágil devido a outra doença recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[3][3] + " pessoas que já tinham uma saúde frágil devido a outra doença recuperaram;");
                //        }


                //    }
                //    if (recup[3][4] == recup[row][col] && recup[row][col] != 0)
                //    {
                //        if (recup[3][4] == 1) Console.WriteLine("-> " + recup[3][4] + " pessoa sem qualquer registo de outra doença recuperou;");
                //        else
                //        {
                //            Console.WriteLine("-> " + recup[3][4] + " pessoas sem qualquer registo de outra doença recuperaram;");
                //        }


                //    }

            }



        }

        public int Selecionador1_regiao(int i, string[] reg)
        {
            if (reg[i - 1] == "N")
            {
                return (0);
            }
            if (reg[i - 1] == "S")
            {
                return 0;
            }
            if (reg[i - 1] == "I")
            {
                return 0;
            }
            if (reg[i - 1] == "L")
            {
                return 0;
            }

            else { return 0; }
        }

        public int Selecionador1_idade(int i, int[] idade)
        {
            if (idade[i - 1] > 1 && idade[i - 1] <= 12)
            {
                return 1;

            }
            if (idade[i - 1] > 12 && idade[i - 1] <= 18)
            {
                return 1; ;

            }
            if (idade[i - 1] > 18 && idade[i - 1] <= 50)
            {
                return 1;

            }
            if (idade[i - 1] > 50 && idade[i - 1] <= 120)
            {
                return 1;

            }
            else { return 0; }

        }

        public int Selecionador1_genero(int i, string[] gen)
        {
            if (gen[i - 1] == "M")
            {
                return 2;

            }
            if (gen[i - 1] == "F")
            {
                return 2;
            }
            else { return 0; }

        }

        public int Selecionador1_doença(int i, int[] doenca)
        {
            if (doenca[i - 1] == 1)
            {
                return 3;

            }
            if (doenca[i - 1] == 2)
            {
                return 3;

            }
            if (doenca[i - 1] == 3)
            {
                return 3;

            }
            if (doenca[i - 1] == 4)
            {
                return 3;

            }
            if (doenca[i - 1] == 5)
            {
                return 3;

            }

            else
            {
                return 0;
            }


        }

        public int Selecionador2_reg(int i, string[] reg)
        {
            if (reg[i - 1] == "N")
            {
                return (0);
            }
            if (reg[i - 1] == "S")
            {
                return 1;
            }
            if (reg[i - 1] == "I")
            {
                return 2;
            }
            if (reg[i - 1] == "L")
            {
                return 3;
            }
            return 0;
        }

        public int Selecionador2_idade(int i, int[] idade)
        {
            if (idade[i - 1] > 1 && idade[i - 1] <= 12)
            {
                return 0;

            }
            if (idade[i - 1] > 12 && idade[i - 1] <= 18)
            {
                return 1;

            }
            if (idade[i - 1] > 18 && idade[i - 1] <= 50)
            {
                return 2;

            }
            if (idade[i - 1] > 50 && idade[i - 1] <= 120)
            {
                return 3;
            }
            else { return 0; }

        }

        public int selecionador2_genero(int i, string[] gen)
        {
            if (gen[i - 1] == "M")
            {
                return 0;

            }
            if (gen[i - 1] == "F")
            {
                return 1;
            }
            else { return 0; }

        }

        public int selecionador2_doença(int i, int[] doenca)
        {
            if (doenca[i - 1] == 1)
            {
                return 0;

            }
            if (doenca[i - 1] == 2)
            {
                return 1;

            }
            if (doenca[i - 1] == 3)
            {
                return 2;

            }
            if (doenca[i - 1] == 4)
            {
                return 3;

            }
            if (doenca[i - 1] == 5)
            {
                return 4;

            }



            else
            {
                return 0;
            }


        }

        //Este array têm como finalidade guardar correctamente o número de falecidos, dependendo da REGIAO, GEN, etc. 
        //A o espaço do array que vai ser guardada a imformação vai depender claro, dos dados de cada pessoa. Através dos SELECIONADORES, pode-se fazer essa distinção;
        public int Cont_Fatalidades(int se, int sel, int[][] fat)
        {
            fat[se][sel] = fat[se][sel] + 1;
            return (fat[se][sel]);

        }

        //Este array têm como finalidade guardar correctamente o número de recuperados, dependendo da REGIAO, GEN, etc. 
        //A o espaço do array que vai ser guardada a imformação vai depender claro, dos dados de cada pessoa. Através dos SELECIONADORES, pode-se fazer essa distinção;
        public int Cont_Recuperados(int se, int sel, int[][] recup)
        {
            recup[se][sel] = recup[se][sel] + 1;
            return (recup[se][sel]);

        }

        #endregion


        #region Listar

        //Este método é necessário para, dependendo da imformação guardada nos arrays, ele vai imprimir de uma maneira correcta e listada os dados dos pacientes;
        //Esta impressão vai ser feita por ordem de entrada. Exemplo: São acrescentados 2 casos. Depois, nesta impressão, ele vai escrever o primeiro caso que se inseriu pelo o utlizador e depois o segundo caso;
        public void Imprimir(int i, string[] reg, int[] idade, int[] doenca, int[] estadodoe, string[] sexo)
        {
            if (reg[i] == "N" || reg[i] == "S" || reg[i] == "I" || reg[i] == "L")
            {

                Console.WriteLine("\n");

            }

            if (reg[i] == "L" && doenca[i] == 1 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Cardiovascular" + "                 " + "Grave");
            }
            if (reg[i] == "L" && doenca[i] == 2 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Pulmonar" + "                 " + "Grave");
            }
            if (reg[i] == "L" && doenca[i] == 3 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Diabetes" + "                 " + "Grave");
            }
            if (reg[i] == "L" && doenca[i] == 4 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Outra" + "                 " + "Grave");
            }
            if (reg[i] == "L" && doenca[i] == 5 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Não tem" + "                 " + "Grave");
            }
            if (reg[i] == "L" && doenca[i] == 1 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Cardiovascular" + "                 " + "Não Grave");
            }
            if (reg[i] == "L" && doenca[i] == 2 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Pulmonar" + "                 " + "Não Grave");
            }
            if (reg[i] == "L" && doenca[i] == 3 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Diabetes" + "                 " + "Não Grave");
            }
            if (reg[i] == "L" && doenca[i] == 4 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Outra" + "                 " + "Não Grave");
            }
            if (reg[i] == "L" && doenca[i] == 5 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Litoral" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Não tem" + "                 " + "Não Grave");
            }




            if (reg[i] == "N" && doenca[i] == 1 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Cardiovascular" + "                 " + "Grave");
            }
            if (reg[i] == "N" && doenca[i] == 2 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Pulmonar" + "                 " + "Grave");
            }
            if (reg[i] == "N" && doenca[i] == 3 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Diabetes" + "                 " + "Grave");
            }
            if (reg[i] == "N" && doenca[i] == 4 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Outra" + "                 " + "Grave");
            }
            if (reg[i] == "N" && doenca[i] == 5 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Não tem" + "                 " + "Grave");
            }
            if (reg[i] == "N" && doenca[i] == 1 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Cardiovascular" + "                 " + "Não Grave");
            }
            if (reg[i] == "N" && doenca[i] == 2 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + (sexo[i]) + "                 " + "Pulmonar" + "                 " + "Não Grave");
            }
            if (reg[i] == "N" && doenca[i] == 3 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Diabetes" + "                 " + "Não Grave");
            }
            if (reg[i] == "N" && doenca[i] == 4 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Outra" + "                 " + "Não Grave");
            }
            if (reg[i] == "N" && doenca[i] == 5 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Norte" + "                 " + (idade[i]) + "               " + (sexo[i]) + "                  " + "Não tem" + "                 " + "Não Grave");
            }



            if (reg[i] == "S" && doenca[i] == 1 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Cardiovascular" + "                 " + "Grave");
            }
            if (reg[i] == "S" && doenca[i] == 2 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Pulmonar" + "                 " + "Grave");
            }
            if (reg[i] == "S" && doenca[i] == 3 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Diabetes" + "                 " + "Grave");
            }
            if (reg[i] == "S" && doenca[i] == 4 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Outra" + "                 " + "Grave");
            }
            if (reg[i] == "S" && doenca[i] == 5 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Não tem" + "                 " + "Grave");
            }
            if (reg[i] == "S" && doenca[i] == 1 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Cardiovascular" + "                 " + "Não Grave");
            }
            if (reg[i] == "S" && doenca[i] == 2 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                  " + "Pulmonar" + "                 " + "Não Grave");
            }
            if (reg[i] == "S" && doenca[i] == 3 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Diabetes" + "                 " + "Não Grave");
            }
            if (reg[i] == "S" && doenca[i] == 4 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Outra" + "                 " + "Não Grave");
            }
            if (reg[i] == "S" && doenca[i] == 5 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Sul" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Não tem" + "                 " + "Não Grave");
            }






            if (reg[i] == "I" && doenca[i] == 1 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Cardiovascular" + "                 " + "Grave");
            }
            if (reg[i] == "I" && doenca[i] == 2 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Pulmonar" + "                 " + "Grave");
            }
            if (reg[i] == "I" && doenca[i] == 3 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Diabetes" + "                 " + "Grave");
            }
            if (reg[i] == "I" && doenca[i] == 4 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Outra" + "                 " + "Grave");
            }
            if (reg[i] == "I" && doenca[i] == 5 && estadodoe[i] == 1)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Não tem" + "                 " + "Grave");
            }
            if (reg[i] == "I" && doenca[i] == 1 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Cardiovascular" + "                 " + "Não Grave");
            }
            if (reg[i] == "I" && doenca[i] == 2 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Pulmonar" + "                 " + "Não Grave");
            }
            if (reg[i] == "I" && doenca[i] == 3 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Diabetes" + "                 " + "Não Grave");
            }
            if (reg[i] == "I" && doenca[i] == 4 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Outra" + "                 " + "Não Grave");
            }
            if (reg[i] == "I" && doenca[i] == 5 && estadodoe[i] == 2)
            {
                Console.Write("Paciente nº" + (i + 1) + ":                 " + "Interior" + "                 " + (idade[i]) + "                " + (sexo[i]) + "                 " + "Não tem" + "                 " + "Não Grave");
            }


        }

        #endregion


       

       

        #endregion
    }
}

