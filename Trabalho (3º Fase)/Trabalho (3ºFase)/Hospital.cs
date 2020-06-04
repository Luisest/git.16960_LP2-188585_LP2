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
using System.Collections.Generic;

namespace Trabalho_de_LPII__fase_2_
{
    /// <summary>
    /// Esta classe têm como objetivo "comandar" todas as outras classes;
    /// Também realiza as funções/métodos essencias para o bom funcionamento do programa;
    /// </summary>
    class Hospital
    {
        #region Parâmetros
        public static List<Covid> listaCovid;
        public static List<Paciente> listaPacientes;
        public static List<StaffMedica> listaStaff;
        #endregion

        #region Construtores
        static Hospital()
        {
            listaCovid = new List<Covid>();
            listaPacientes = new List<Paciente>();
            listaStaff = new List<StaffMedica>();
        }
        #endregion

        #region Métodos de Escrita dos Ficheiros
        // Este método registra as imformações pretendidas nos ficheiros, imformações relacionadas com Staff do Hospital;
        public static void RegistroStaff(string caminhoficheiro)
        {
            StreamWriter sw = new StreamWriter(caminhoficheiro, true);
            for (int i = 0; i < listaStaff.Count; i++)
            {
                if (listaStaff[i].PrimeiroNome == null)
                {
                    sw.Close();
                    i = listaStaff.Count + 1;
                }

                if (listaStaff[i].genero != "")
                {
                    if (File.Exists(caminhoficheiro) == true)
                    {
                        sw.WriteLine(listaStaff[i].ToString());
                    }
                    else
                    {
                        sw = File.CreateText(caminhoficheiro);
                        sw.WriteLine(listaStaff[i].ToString());
                    }
                }
            }
            sw.Close();
        }
        // Este método registra as imformações pretendidas nos ficheiros, imformações relacionadas com os pacientes que têm Covid;
        public static void RegistroCovid(string caminhoficheiro)
        {
            StreamWriter sw = new StreamWriter(caminhoficheiro, true);
            for (int i = 0; i < listaCovid.Count; i++)
            {
                if (listaCovid[i] == null)
                {
                    sw.Close();
                    i = listaCovid.Count + 1;
                }

                if (listaCovid[i].genero != "")
                {
                    if (File.Exists(caminhoficheiro) == true)
                    {

                        sw.WriteLine(listaCovid[i].ToString());
                    }
                    else
                    {
                        sw = File.CreateText(caminhoficheiro);
                        sw.WriteLine(listaCovid[i].ToString());
                    }
                }
            }
            sw.Close();
        }
        // Este método registra as imformações pretendidas nos ficheiros, imformações relacionadas com todos os pacientes atendidos;
        public static void RegistroPaciente(string caminhoficheiro)
        {
            StreamWriter sw = new StreamWriter(caminhoficheiro, true);
            for (int i = 0; i < listaPacientes.Count; i++)
            {
                if (listaPacientes[i] == null && listaCovid[i] == null)
                {
                    sw.Close();
                    i = listaPacientes.Count + 1;
                }
                if (listaPacientes[i].genero != "")
                {
                    if (File.Exists(caminhoficheiro) == true)
                    {
                        sw.WriteLine(listaPacientes[i].ToString());
                        if (i < listaCovid.Count)
                        {
                            sw.WriteLine("Nome: {0} {1} ; Género: {2} ; Data de nascimento: {3} ; Número de telemóvel: {4} ; ID: {5}",
                            listaCovid[i].PrimeiroNome, listaCovid[i].Apelido, listaCovid[i].genero, listaCovid[i].DataNascimento, listaCovid[i].NumeroTelemovel, listaCovid[i].Idpaciente);
                        }

                    }
                    else
                    {
                        sw = File.CreateText(caminhoficheiro);
                        if (i < listaCovid.Count)
                        {
                            sw.WriteLine("Nome: {0} {1} ; Género: {2} ; Data de nascimento: {3} ; Número de telemóvel: {4} ; ID: {5}",
                            listaCovid[i].PrimeiroNome, listaCovid[i].Apelido, listaCovid[i].genero, listaCovid[i].DataNascimento, listaCovid[i].NumeroTelemovel, listaCovid[i].Idpaciente);
                        }
                    }
                }
            }
            sw.Close();
        }
        #endregion

        #region Métodos de Leitura de Ficheiros
        //Este método lê o ficheiro que possui as imformações relativas à staff do Hospital;
        public static void LerStaff(string caminhoficheiro)
        {
            StreamReader sr;
            try
            {
                if (File.Exists(caminhoficheiro) == true)
                {
                    string linha = "";
                    sr = File.OpenText(caminhoficheiro);
                    //escrever as caracteristicas
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] c = new string[5];
                        c = linha.Split(';');
                        Console.WriteLine("{0};", c[0]);
                        Console.WriteLine("{0};", c[1]);
                        Console.WriteLine("{0};", c[2]);
                        Console.WriteLine("{0};", c[3]);
                        Console.WriteLine("{0};", c[4]);
                        Console.WriteLine("-----------------------------------------\n");
                    }
                    sr.Close();
                }
            }
            catch
            {
                Console.WriteLine("Ficheiro não encontrado.");
            }
        }
        //Este método lê o ficheiro que possui as imformações relativas aos pacientes atendidos pelo Hospital e que possuem Covid;
        public static void LerCovid(string caminhoficheiro)
        {
            try
            {
                StreamReader sr;
                if (File.Exists(caminhoficheiro) == true)
                {
                    string linha = "";
                    sr = File.OpenText(caminhoficheiro);

                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] c = new string[10];
                        c = linha.Split(';');
                        Console.WriteLine("{0};", c[0]);
                        Console.WriteLine("{0};", c[1]);
                        Console.WriteLine("{0};", c[2]);
                        Console.WriteLine("{0};", c[3]);
                        Console.WriteLine("{0};", c[4]);
                        Console.WriteLine("{0};", c[5]);
                        Console.WriteLine("{0};", c[6]);
                        Console.WriteLine("{0};", c[7]);
                        Console.WriteLine("-----------------------------------------\n");
                    }
                    sr.Close();
                }
            }
            catch
            {
                Console.WriteLine("Ficheiro não encontrado.");
            }
        }
        //Este método lê o ficheiro que possui as imformações relativas aos pacientes atendidos pelo Hospital;
        public static void LerPacientes(string caminhoficheiro)
        {
            StreamReader sr;
            try
            {
                if (File.Exists(caminhoficheiro) == true)
                {
                    string linha = "";
                    sr = File.OpenText(caminhoficheiro);
                    //escrever as caracteristicas
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] c = new string[5];
                        c = linha.Split(';');
                        Console.WriteLine("{0};", c[0]);
                        Console.WriteLine("{0};", c[1]);
                        Console.WriteLine("{0};", c[2]);
                        Console.WriteLine("{0};", c[3]);
                        Console.WriteLine("{0};", c[4]);
                        Console.WriteLine("-----------------------------------------\n");
                    }
                    sr.Close();
                }
            }
            catch
            {
                Console.WriteLine("Ficheiro não encontrado.");
            }
        }

        #endregion

        #region Métodos 
        public static void ImprimirStaff(string caminhoficheiro)
        {
            LerStaff(caminhoficheiro);
        }
        public static void ImprimirPacientes(string caminhoficheiro)
        {
            LerPacientes(caminhoficheiro);
        }

        public static void ImprimirPacientesCovid(string caminhoficheiro)
        {
            LerCovid(caminhoficheiro);
        }
        //Este método adiciona membros na lista Paciente;
        public static bool AdicionarPaciente(Paciente p)
        {
            int t = 0;
            // Este ciclo for serve para verficar se já existe um objeto com a mesma imformação na lista;
            // Se houver, então o objeto não é adicionado;
            for (int i = 0; i <= listaPacientes.Count; i++)
            {
                if (listaPacientes.Count == 0)
                {
                    listaPacientes.Add(p);
                    t = 1;
                }
                if (listaPacientes.Count != 0)
                {
                    if (i != listaPacientes.Count && listaPacientes[i].Idpaciente == p.Idpaciente) t = 1;
                }
                if (t == 0 && i == listaPacientes.Count)
                {
                    listaPacientes.Add(p);
                    t = 1;
                }
            }
            return true;
        }
        //Este método adiciona membros na lista Staff;
        public static bool AdicionarStaff(StaffMedica s)
        {
            int t = 0;
            // Este ciclo for serve para verficar se já existe um objeto com a mesma imformação na lista;
            // Se houver, então o objeto não é adicionado;
            for (int i = 0; i <= listaStaff.Count; i++)
            {
                if (listaStaff.Count == 0)
                {
                    listaStaff.Add(s);
                    t = 1;
                }
                if (listaStaff.Count != 0)
                {
                    if (i != listaStaff.Count && listaStaff[i].Idstaff == s.Idstaff) t = 1;
                }
                if (t == 0 && i == listaStaff.Count)
                {
                    listaStaff.Add(s);
                    t = 1;
                }
            }
            return true;
        }
        //Este método adiciona membros na lista Covid;
        public static bool AdicionarCovid(Covid c)
        {
            int t = 0;
            // Este ciclo for serve para verficar se já existe um objeto com a mesma imformação na lista;
            // Se houver, então o objeto não é adicionado;
            for (int i = 0; i <= listaCovid.Count; i++)
            {
                if (listaCovid.Count == 0)
                {
                    listaCovid.Add(c);
                    t = 1;
                }
                if (listaCovid.Count != 0)
                {
                    if (i != listaCovid.Count && listaCovid[i].Idpaciente == c.Idpaciente) t = 1;
                }
                if (t == 0 && i == listaCovid.Count)
                {
                    listaCovid.Add(c);
                    t = 1;
                }
            }
            return true;
        }

        public void ProcuraDePacienteCovid()
        {
            int cod = 0;
            foreach (KeyValuePair<int, string> pessoa in pessoasCovid)
            {
                Console.WriteLine($"Códido do paciente: {pessoa.Key}");
            }
            while (pessoasCovid.ContainsKey(cod) == false)
            {
                try
                {
                    Console.WriteLine("\nQual o paciente que deseja ver as imformações melhor?");
                    cod = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nValor incorrecto.Insira outro valor por favor");
                }
            }
            if (pessoasCovid.ContainsKey(cod) == true)
            {
                for (int f = 0; f < listaCovid.Count; f++)
                {
                    if (listaCovid[f].Idpaciente == cod)
                    {
                        Console.WriteLine(listaCovid[f].ToString());
                    }
                }
            }

        }
        #endregion

        #region Dicionário

        //Criação de um dicionário que vai conter todos os infetados com covid;
        //Estes vão ser identificados pelo o seu ID e pelo o seu estado de saúde;
        Dictionary<int, string> pessoasCovid = new Dictionary<int, string>() { };

        //Este método serve a adição de dados no mesmo;
        public void AdicionarPessoasDicionario()
        {
            for (int i = 0; i < listaCovid.Count; i++)
            {
                pessoasCovid.Add(listaCovid[i].Idpaciente, listaCovid[i].estadopaciente);
            }
        }

        #endregion

    }

}