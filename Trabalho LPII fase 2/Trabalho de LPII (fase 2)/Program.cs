/*
 * 
 * Autores do projecto: Luis Esteves/16960 || Sérgio Ribeiro/18858;
 * Disciplina: Línguagem de Programação II;
 * Projecto I, Fase 2;
 * Propósito do trabalho: Contabilizar os casos de Covid num Hospital;
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

            StaffMedica medico = new StaffMedica("Luis", "Esteves", "Masculino", new DateTime(2008, 3, 2), "Enfermeiro", 3222);
            StaffMedica medico2 = new StaffMedica("Carlos", "Esteves", "Masculino", new DateTime(2004, 3, 2), "Enfermeiro", 3221);
            Paciente pessoa = new Paciente("José", "Cunha", "Masculino", new DateTime(1984, 2, 2), 4343, 939342578, 2301);
            Covid c = new Covid("Luis", "Fernando", "Masculino", 939435791, new DateTime(2013, 8, 2), new DateTime(2020, 2, 1), "Normal", 3221, 2034);
            int opc = 0;

            Hospital.AdicionarStaff(medico);
            Hospital.AdicionarStaff(medico2);
            Hospital.AdicionarPaciente(pessoa);
            Hospital.AdicionarCovid(c);

            do
            {
                Console.Clear();
                Console.WriteLine("-------------- Gerênciador de casos de Covid-19 no Hospital de Braga -------------");
                Console.WriteLine("1)Impressão de toda staff médica do hospital;");
                Console.WriteLine("2)Impressão de todos os pacientes atendidos até agora;");
                Console.WriteLine("3)Impressão de todos os infetados com Covid-19;");
                Console.WriteLine("4)Sair;");
                try
                {
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("" + e);
                }

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------------ Staff médica ------------------\n");
                        Hospital.ImprimirStaff(Hospital.staffs);
                        Console.WriteLine("Clique em qualquer tecla para sair...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("------------------ Pacientes já atendidos ------------------\n");
                        Hospital.ImprimirPacientes(Hospital.pacientes, Hospital.covid);
                        Console.WriteLine("Clique em qualquer tecla para sair...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("------------------ Pacientes diagnosticados com Covid-19 ------------------\n");
                        Hospital.ImprimirPacientesCovid(Hospital.covid);
                        Console.WriteLine("Clique em qualquer tecla para sair...");
                        Console.ReadKey();
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Valor Incorrecto!");
                        break;
                }
            } while (opc != 4);
            #endregion
        }
    }
}
