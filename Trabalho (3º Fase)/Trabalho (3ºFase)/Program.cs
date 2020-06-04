/*
 * 
 * Autores do projecto: Luis Esteves/16960 || Sérgio Ribeiro/18858;
 * Disciplina: Línguagem de Programação II;
 * Projecto I, Fase 2;
 * Propósito do trabalho: - Guardar e imprimir os casos de Covid num Hospital e seus respetivos dados;
 *                        - Realizar o mesmo processo (guardar e imprimir) com os membros da Staff médica do Hospital e seus respetivos dados;
 *                        - E também com todos os pacientes já atendidos no Hospital;
 *
 */


using System;
using System.IO;

namespace Trabalho_de_LPII__fase_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Projecto

            // Declaração de 3 strings(cada uma indica o "caminho"/endereço do ficheiro de texto respectivo;
            // Inicialização de outras varíaveis;
            #region Varíaveis
            string caminhoficheiroStaff = @"C:\Users\josel\OneDrive\Ambiente de Trabalho\Trabalho (3º Fase)\Ficheiros de texto\StaffMédica.txt";
            string caminhoficheiroCovid = @"C:\Users\josel\OneDrive\Ambiente de Trabalho\Trabalho (3º Fase)\Ficheiros de texto\Covid.txt";
            string caminhoficheiroPacientes = @"C:\Users\josel\OneDrive\Ambiente de Trabalho\Trabalho (3º Fase)\Ficheiros de texto\Paciente.txt";
            int opc = 0;
            #endregion

            //Inicialização dos objectos;
            #region Objectos
            StaffMedica medico = new StaffMedica("Luis", "Esteves", "Masculino", new DateTime(2008, 3, 2), "Enfermeiro", 3222);
            StaffMedica medico2 = new StaffMedica("Carlos", "Esteves", "Masculino", new DateTime(2004, 3, 2), "Enfermeiro", 3221);
            Paciente pessoa = new Paciente("José", "Cunha", "Masculino", new DateTime(1984, 2, 2), 2022, 939342578);
            Paciente pessoa2 = new Paciente("Francisco", "Cunha", "Masculino", new DateTime(1989, 2, 2), 2021, 934354783);

            //A pessoa3 é apenas um teste, de maneira a ver se é ou não adicionado à lista objectos que já estejam lá;
            Paciente pessoa3 = new Paciente("José", "Cunha", "Masculino", new DateTime(1984, 2, 2), 2022, 939473829);
            Covid c = new Covid("Luis", "Fernando", "Masculino", 939435791, new DateTime(2013, 8, 2), new DateTime(2020, 2, 1), "Normal", 3221, 2034);
            Hospital h = new Hospital();
            #endregion

            //Chamada dos métodos da classe "Hospital" que permitem adicionar objectos nas listas e guardar dados em ficheiros .txt;
            #region Adição de objectos nas listas e registro desses dados nos ficheiros .txt
            Hospital.AdicionarStaff(medico);
            Hospital.AdicionarStaff(medico2);
            Hospital.AdicionarPaciente(pessoa);
            Hospital.AdicionarPaciente(pessoa2);
            //A pessoa3 é apenas um teste, de maneira a ver se é ou não adicionado à lista objectos que já estejam lá;
            Hospital.AdicionarPaciente(pessoa3);
            Hospital.AdicionarCovid(c);
            Hospital.RegistroCovid(caminhoficheiroCovid);
            Hospital.RegistroPaciente(caminhoficheiroPacientes);
            Hospital.RegistroStaff(caminhoficheiroStaff);
            #endregion

            //Menu em que o utilizador vai poder interagir e ver em tempo real qual a imformação já guardada até agora;
            #region Menu
            do
            {
                Console.Clear();
                Console.WriteLine("-------------- Gerênciador de casos de Covid-19 no Hospital de Braga -------------");
                Console.WriteLine("1)Impressão de toda staff médica do hospital;");
                Console.WriteLine("2)Impressão de todos os pacientes atendidos até agora;");
                Console.WriteLine("3)Impressão de todos os infetados com Covid-19;");
                Console.WriteLine("4)Procura de um Paciente infetado com Covid em especifíco;");
                Console.WriteLine("5)Sair;");
                try
                {
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("" + e.Message);
                }

                switch (opc)
                {
                    //Nesta opção é feita a impressão de todos os dados relativos a todos os membros da Staff Médica;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------------ Staff médica ------------------\n");
                        Hospital.ImprimirStaff(caminhoficheiroStaff);
                        Console.WriteLine("Clique em qualquer tecla para sair...");
                        Console.ReadKey();
                        break;

                    //Nesta opção é feita a impressão de todos os dados relativos a todos os Pacientes atendidos até agora;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("------------------ Pacientes já atendidos ------------------\n");
                        Hospital.ImprimirPacientes(caminhoficheiroPacientes);
                        Console.WriteLine("Clique em qualquer tecla para sair...");
                        Console.ReadKey();
                        break;

                    //Nesta opção é feita a impressão de todos os dados relativos a todos os Pacientes atendidos até agora e que foram identificados como infetados com Covid;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("------------------ Pacientes diagnosticados com Covid-19 ------------------\n");
                        Hospital.ImprimirPacientesCovid(caminhoficheiroCovid);
                        Console.WriteLine("Clique em qualquer tecla para sair...");
                        Console.ReadKey();
                        break;

                    //Nesta opção é possível ao utilizador procurar por um dado paciente com Covid e ver as suas imformações;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("------------------ Procura de um paciente infetado com Covid-19 ------------------\n");
                        h.AdicionarPessoasDicionario();
                        h.ProcuraDePacienteCovid();
                        Console.WriteLine("\nClique em qualquer tecla para sair...");
                        Console.ReadKey();
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Valor Incorrecto!");
                        break;
                }
            } while (opc != 5);
            #endregion

            #endregion
        }
    }
}