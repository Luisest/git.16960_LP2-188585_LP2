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
    class Hospital
    {
        #region Parâmetros
        const int MAXPESSOAS = 1000;
        public static Paciente[] pacientes;
        public static StaffMedica[] staffs;
        public static Covid[] covid;
        #endregion

        #region Construtores
        static Hospital()
        {
            pacientes = new Paciente[MAXPESSOAS];
            staffs = new StaffMedica[MAXPESSOAS];
            covid = new Covid[MAXPESSOAS];
        }
        #endregion

        #region Propriedades
        #endregion

        #region Métodos dos Ficheiros
        public static void RegistroStaff(int i, StaffMedica[] s)
        {
            string ficheiro = "Staff.txt";
            StreamWriter sw = new StreamWriter(@"C:\Users\josel\OneDrive\Ambiente de Trabalho\LESI\LPII\Trabalho LPII fase 2\Trabalho de LPII (fase 2)" + "\\"+@"Staff");
            if (File.Exists(ficheiro) == true)
            {
                sw = File.AppendText(ficheiro);
            }
            else
            {
                sw = File.CreateText(ficheiro);
            }
            sw.WriteLine(s[i].ToString());
            sw.Close();
        }

        public static void RegistroCovid(int i, Covid[] c)
        {
            string ficheiro = @"Covid.txt";
            StreamWriter s1 = new StreamWriter(@"C:\Users\josel\OneDrive\Ambiente de Trabalho\LESI\LPII\Trabalho LPII fase 2\Trabalho de LPII (fase 2)" + "\\" + ficheiro);
            if (File.Exists(ficheiro) == true)
            {
                s1 = File.AppendText(ficheiro);
            }
            else
            {
                s1 = File.CreateText(ficheiro);
            }
            s1.WriteLine(c[i].ToString());
            s1.Close();
        }
        public static void RegistroPaciente(int i, Paciente[] p)
        {
            string ficheiro = @"Paciente.txt";
            StreamWriter ss = new StreamWriter(@"C:\Users\josel\OneDrive\Ambiente de Trabalho\LESI\LPII\Trabalho LPII fase 2\Trabalho de LPII (fase 2)" + "\\" + ficheiro);
            if (File.Exists(ficheiro) == true)
            {
                ss = File.AppendText(ficheiro);
            }
            else
            {
                ss = File.CreateText(ficheiro);
            }
            ss.WriteLine(p[i].ToString());
            ss.Close();
        } 
        #endregion

        #region Métodos
        public static void ImprimirStaff(StaffMedica[] staffs)
        {
            for (int i = 0; i < staffs.Length; i++)
            {
                if (staffs[i] != null)
                {
                    Console.WriteLine(staffs[i].ToString());
                    RegistroStaff(i, staffs);
                }
            }
        }
        public static void ImprimirPacientes(Paciente[] pacientes, Covid[] c)
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] != null)
                {
                    Console.WriteLine(pacientes[i].ToString());
                    if(c[i] != null)
                    {
                        Console.WriteLine("Nome: {0} {1} ; Género: {2} ; Data de nascimento: {3} ; Número de telemóvel: {4} ; ID: {5}",
                        covid[i].PrimeiroNome, covid[i].Apelido, covid[i].genero, covid[i].DataNascimento, covid[i].NumeroTelemovel, covid[i].ID);
                        RegistroPaciente(i, pacientes);
                    }
                }
            }
        }

        public static void ImprimirPacientesCovid(Covid[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != null)
                {
                    Console.WriteLine(c[i].ToString());
                    RegistroCovid(i, c);
                }
            }
        }

        public static bool AdicionarPaciente(Paciente p)
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] == null)
                {
                    pacientes[i] = p;
                    return true;
                }
                if (pacientes[i].DataNascimento == p.DataNascimento) return false;
                
            }
            return false;
        }

        public static bool AdicionarStaff(StaffMedica s)
        {
            for (int i = 0; i < staffs.Length; i++)
            {
                if (staffs[i] == null)
                {
                    staffs[i] = s;
                    return true;
                }
                if (staffs[i].Id == s.Id) return false;
              
            }
            return false;
        }

        public static bool AdicionarCovid(Covid c)
        {
            for (int i = 0; i < staffs.Length; i++)
            {
                if (covid[i] == null)
                {
                    covid[i] = c;
                    return true;
                }
                if (covid[i].DataNascimento == c.DataNascimento) return false;

            }
            return false;
        }
        #endregion

    }
}
