/**
 * Trabalho nº1 de LP II (1º fase do trabalho)
 * -----------------------------------
 * Luis Esteves / a16960 
 * Sérgio Ribeiro / a18858
 * -----------------------------------
 * 25/04/2020
 * -----------------------------------
 * Objetivo -> Sistema que permita gerir pessoas infetadas numa situação de crise de saúde pública
 *          -> Os resultados/dados guardados vão ser uma pequena amostra do Hospital público de Braga
 * ----------------------------------
 * */

using System;



namespace Trabalho
{


    class Program
    {

        static void Main(string[] args)
        {
            // Declaração das variaveis;
            #region Variáveis
            const int N = 100;
            int opc = 0;
            int opc2 = 0;
            int f = 0;
            int i = 0;
            int aux = 0;
            int fatalidades = 0;
            int cont = 0;
            int k = 0;
            int recup = 0;
            int mudar = 0;

            int se = 0;
            int sel = 0;

            //Arrays que vão guardar a imformação principal do projecto, tal como idades, etc;
            string[] regiao = new string[N];
            int[] idade = new int[N];
            string[] sexo = new string[N];
            int[] doenca = new int[N];
            int[] estadodoe = new int[N];
            int[][] Cont_fatalidades = new int[4][];
            int[][] Cont_recuperados = new int[4][];


           

            //Regiões
            Cont_fatalidades[0] = new int[4];

            //Idade
            Cont_fatalidades[1] = new int[4];

            //Género
            Cont_fatalidades[2] = new int[2];

            //Doenças
            Cont_fatalidades[3] = new int[5];

            //---------------------------------------------------------------

            //Regiões
            Cont_recuperados[0] = new int[4];

            //Idade
            Cont_recuperados[1] = new int[4];

            //Género
            Cont_recuperados[2] = new int[2];

            //Doenças
            Cont_recuperados[3] = new int[5];



            //Inicialização de objetos;



            Pessoas pessoas1 = new Pessoas();




            #endregion

            // Criação de um menu;
            // Aqui o utilizador vai poder decidir se quer: CRIAR, EDITAR, LISTAR qualquer caso de covid-19;

            #region Menu

            while (opc != 4)
            {
                opc = 0;

                while (opc == 0 || opc < 0 || opc > 4)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("\n----------------- Contabilização de casos de coronavírus ------------------");
                        Console.WriteLine("1) Novos casos;");
                        Console.WriteLine("2) Editar casos;");
                        Console.WriteLine("3) Listar;");
                        Console.WriteLine("4) Sair;");
                        opc = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        Console.WriteLine("\nDeu erro! Insira outro valor!");
                        opc = Convert.ToInt32(Console.ReadLine());
                    }



                    switch (opc)
                    {

                        //Criar novos casos
                        #region opc 1

                        case 1:
                            Console.WriteLine("\n------------ Opção 1 ------------");


                            try
                            {
                                Console.WriteLine("\nQuantos novos casos quer inserir?:");
                                cont = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("\n\nErro!");
                            }



                            for (i = 0; i < cont; i++)

                            {


                                Console.WriteLine("\n------------ Caso nº" + (i + 1) + "  ------------");

                                do
                                {

                                    regiao[i] = Regiao.Defreg(regiao[i]);

                                } while (regiao[i] == "0");
                                do
                                {

                                    idade[i] = Idade.Defidade(idade,i);

                                } while (idade[i] == 0);
                                do
                                {

                                    sexo[i] = Genero.Defgen(sexo[i]);

                                } while (sexo[i] == "0");
                                do
                                {

                                    doenca[i] = Doenca.Defdoenca(doenca[i]);

                                } while (doenca[i] == 0);
                                do
                                {

                                    estadodoe[i] = Estado.Defestado(estadodoe[i]);

                                } while (estadodoe[i] == 0);


                            }
                    

                            break;


                        #endregion


                        //Editar o número de casos, ou seja, o nº de casos fatais, recuperados e os que sairam de uma situação grave para uma menos grave ou vice-versa;
                        #region opc 2

                        case 2:

                            Console.WriteLine("\n------------ Opção 2 ------------");
                            Console.WriteLine("\nDeseja alterar que dado?: ");
                            Console.WriteLine("1) Nº de casos fatais; ");
                            Console.WriteLine("2) Nº de casos recuperados; ");
                            Console.WriteLine("3) Nº de casos graves/menos graves;");
                            Console.WriteLine("4) Voltar ao menu inicial;");
                            opc2 = Convert.ToInt32(Console.ReadLine());


                            switch (opc2)
                            {
                                case 1:


                                    try
                                    {
                                        Console.WriteLine("\nQuantos casos fatais aumentaram?:");
                                        aux = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("\nInseriu um valor impossível. Vai voltar ao menu.");

                                    }


                                    while (aux > cont)
                                    {
                                        try
                                        {
                                            aux = 0;
                                            Console.WriteLine("\n\nNão existem tantos casos assim! De certeza que esse valor esta correcto? Caso não tenha as imformações todas, INSIRA UMA LETRA PARA VOLTAR AO MENU.");
                                            Console.WriteLine("Quantos casos fatais aumentaram?:");
                                            aux = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.WriteLine("\nInseriu um valor impossível. Vai voltar ao menu.");
                                        }

                                    }

                                    fatalidades = fatalidades + aux;
                                    cont = cont - aux;


                                    for (i = 0; i < fatalidades; i++)
                                    {

                                        for (i = 0; i < N; i++)
                                        {
                                            if (idade[i] != 0)
                                            {
                                                if (i == 0)
                                                {
                                                    Console.WriteLine("\n\n                              Região            Idade               Género               Doença                Estado do paciente\n");
                                                    pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);

                                                }


                                                else
                                                {
                                                    pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);
                                                }
                                            }
                                        }

                                        k = 0;

                                        while (k != fatalidades)
                                        {
                                            try
                                            {
                                                Console.WriteLine("\n\nQual é o paciente que faleceu?");
                                                f = Convert.ToInt32(Console.ReadLine());

                                                while (idade[f - 1] == 0)
                                                {
                                                    f = 0;
                                                    Console.WriteLine("\nValor não compatível. Por favor insira outro valor.");
                                                    Console.WriteLine("Qual é o paciente que faleceu?");
                                                    f = Convert.ToInt32(Console.ReadLine());
                                                }



                                                se = pessoas1.Selecionador1_doença(f, doenca);
                                                sel = pessoas1.selecionador2_doença(f, doenca);
                                                Cont_fatalidades[se][sel] = pessoas1.Cont_Fatalidades(se, sel, Cont_fatalidades);



                                                se = pessoas1.Selecionador1_genero(f, sexo);
                                                sel = pessoas1.selecionador2_genero(f, sexo);
                                                Cont_fatalidades[se][sel] = pessoas1.Cont_Fatalidades(se, sel, Cont_fatalidades);



                                                se = pessoas1.Selecionador1_idade(f, idade);
                                                sel = pessoas1.Selecionador2_idade(f, idade);
                                                Cont_fatalidades[se][sel] = pessoas1.Cont_Fatalidades(se, sel, Cont_fatalidades);



                                                se = pessoas1.Selecionador1_regiao(f, regiao);
                                                sel = pessoas1.Selecionador2_reg(f, regiao);
                                                Cont_fatalidades[se][sel] = pessoas1.Cont_Fatalidades(se, sel, Cont_fatalidades);
                                                Console.WriteLine("" + Cont_fatalidades[se][sel]);



                                                idade[f - 1] = Idade.Eliminar_idade(i,idade);
                                                regiao[f - 1] = Regiao.Elminar_Reg(f, regiao);
                                                estadodoe[f - 1] = Estado.Eliminar_Estado(f, estadodoe);
                                                doenca[f - 1] = Doenca.Eliminar_Doenca(f, doenca);
                                                sexo[f - 1] = Genero.Eliminar_Gen(f, sexo);


                                                k++;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Insira um valor válido, um número.");
                                            }

                                        }

                                    }



                                    break;


                                case 2:

                                    try
                                    {
                                        Console.WriteLine("\nQuantos casos recuperaram?:");
                                        aux = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("\nInseriu um valor impossível. Vai voltar ao menu.");

                                    }


                                    while (aux > cont)
                                    {
                                        try
                                        {
                                            aux = 0;
                                            Console.WriteLine("\n\nNão existem tantos casos assim! De certeza que esse valor esta correcto? Caso não tenha as imformações todas, INSIRA UMA LETRA PARA VOLTAR AO MENU.");
                                            Console.WriteLine("Quantos casos recuperaram?:");
                                            aux = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.WriteLine("\nInseriu um valor impossível. Vai voltar ao menu.");
                                        }

                                    }

                                    recup = recup + aux;
                                    cont = cont - aux;


                                    for (i = 0; i < recup; i++)
                                    {

                                        for (i = 0; i < N; i++)
                                        {
                                            if (idade[i] != 0)
                                            {
                                                if (i == 0)
                                                {
                                                    Console.WriteLine("\n\n                              Região            Idade               Género               Doença                Estado do paciente\n");
                                                    pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);

                                                }
                                                else
                                                {
                                                    pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);
                                                }
                                            }
                                        }

                                        k = 0;

                                        while (k != recup)
                                        {
                                            try
                                            {
                                                Console.WriteLine("\n\nQual é o paciente que recuperou?");
                                                f = Convert.ToInt32(Console.ReadLine());

                                                while (idade[f - 1] == 0)
                                                {
                                                    f = 0;
                                                    Console.WriteLine("\nValor não compatível. Por favor insira outro valor.");
                                                    Console.WriteLine("Qual é o paciente que recuperou?");
                                                    f = Convert.ToInt32(Console.ReadLine());
                                                }



                                                se = pessoas1.Selecionador1_doença(f, doenca);
                                                sel = pessoas1.selecionador2_doença(f, doenca);
                                                Cont_recuperados[se][sel] = pessoas1.Cont_Fatalidades(se, sel, Cont_recuperados);


                                                se = pessoas1.Selecionador1_genero(f, sexo);
                                                sel = pessoas1.selecionador2_genero(f, sexo);
                                                Cont_recuperados[se][sel] = pessoas1.Cont_Fatalidades(se, sel, Cont_recuperados);


                                                se = pessoas1.Selecionador1_idade(f, idade);
                                                sel = pessoas1.Selecionador2_idade(f, idade);
                                                Cont_recuperados[se][sel] = pessoas1.Cont_Fatalidades(se, sel, Cont_recuperados);


                                                se = pessoas1.Selecionador1_regiao(f, regiao);
                                                sel = pessoas1.Selecionador2_reg(f, regiao);
                                                Cont_recuperados[se][sel] = pessoas1.Cont_Fatalidades(se, sel, Cont_recuperados);



                                                idade[f - 1] = Idade.Eliminar_idade(f, idade);
                                                regiao[f - 1] = Regiao.Elminar_Reg(f, regiao);
                                                estadodoe[f - 1] = Estado.Eliminar_Estado(f, estadodoe);
                                                doenca[f - 1] = Doenca.Eliminar_Doenca(f, doenca);
                                                sexo[f - 1] = Genero.Eliminar_Gen(f, sexo);


                                                k++;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Insira um valor válido, um número.");
                                            }

                                        }

                                    }




                                    break;


                                case 3:


                                    try
                                    {
                                        mudar = 0;
                                        Console.WriteLine("\nQuantos casos mudaram de estado? ");
                                        mudar = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("\nInseriu um valor impossível. Vai voltar ao menu.");

                                    }


                                    while (mudar > cont)
                                    {
                                        try
                                        {
                                            mudar = 0;
                                            Console.WriteLine("\n\nNão existem tantos casos assim! De certeza que esse valor esta correcto? Caso não tenha as imformações todas, INSIRA UMA LETRA PARA VOLTAR AO MENU.");
                                            Console.WriteLine("\nQuantos casos mudaram de estado? ");
                                            mudar = Convert.ToInt32(Console.ReadLine());

                                        }
                                        catch
                                        {
                                            Console.WriteLine("\nInseriu um valor impossível. Vai voltar ao menu.");
                                        }

                                    }


                                    for (i = 0; i < mudar; i++)
                                    {

                                        for (i = 0; i < N; i++)
                                        {
                                            if (idade[i] != 0)
                                            {
                                                if (i == 0)
                                                {
                                                    Console.WriteLine("\n\n                              Região            Idade               Género               Doença                Estado do paciente\n");
                                                    pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);

                                                }
                                                else
                                                {
                                                    pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);
                                                }
                                            }
                                        }


                                        while (k == 0)
                                        {
                                            try
                                            {
                                                Console.WriteLine("\n\n\nQual é o paciente que recuperou?");
                                                f = Convert.ToInt32(Console.ReadLine());

                                                while (idade[f - 1] == 0)
                                                {
                                                    f = 0;
                                                    Console.WriteLine("\nValor não compatível. Por favor insira outro valor.");
                                                    Console.WriteLine("Qual é o paciente que recuperou?");
                                                    f = Convert.ToInt32(Console.ReadLine());
                                                }

                                                //estadodoe[f - 1] = pessoas1.Mudar_Estado(f, estadodoe);
                                                Console.WriteLine(estadodoe[f]);
                                                k++;

                                            }
                                            catch
                                            {
                                                Console.WriteLine("Insira um valor válido, um número.");
                                            }

                                        }


                                        Console.WriteLine("Agora com as alterações efectuadas...");
                                        for (i = 0; i < N; i++)
                                        {
                                            if (idade[i] != 0)
                                            {
                                                if (i == 0)
                                                {
                                                    Console.WriteLine("\n\n                              Região            Idade               Género               Doença                Estado do paciente\n");
                                                    pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);

                                                }
                                                else
                                                {
                                                    pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);
                                                }
                                            }
                                        }

                                    }

                                    Console.WriteLine("\n\nClique em qualquer tecla para voltar ao menu inicial...");


                                    break;

                                case 4:
                                    break;

                                default:
                                    Console.WriteLine("Inseriu a opção incorreta.");
                                    break;
                            }
                            break;

                        #endregion

                        //Listar todos os dados até agora guardados
                        #region opc 3

                        case 3:


                            Console.WriteLine("\n\n------------------ Opção 3 ----------------------");

                            if (cont != 0)
                            {


                                for (i = 0; i < N; i++)
                                {
                                    if (i == 0)
                                    {
                                        Console.WriteLine("\n\n                              Região            Idade               Género               Doença                Estado do paciente\n");
                                        pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);

                                    }
                                    else
                                    {
                                        pessoas1.Imprimir(i, regiao, idade, doenca, estadodoe, sexo);
                                    }
                                }

                            }

                            //Impressao do nº de mortos por: 
                            // Faixa etaria, por genero, por doença, por regiao;

                            Console.WriteLine("\n\n- Fatalidades envolvendo o covid 19;");

                            for (i = 0; i < 4; i++)
                            {



                                for (int col = 0; col < Cont_fatalidades[i].Length; col++)
                                {


                                    pessoas1.Imprimir_FAT_RECUP(i, col, Cont_fatalidades, Cont_recuperados);


                                }


                            }








                            Console.ReadKey();

                            break;

                        // - Recuperados






                        #endregion

                        //Sair
                        #region opc 4


                        case 4:

                            Console.WriteLine("\n\nClique em qualquer botão.....");
                            Console.ReadKey();
                            break;

                            #endregion

                    }




                    #endregion




                }
            }
        }
    }
}

