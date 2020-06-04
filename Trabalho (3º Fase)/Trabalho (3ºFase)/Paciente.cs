
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
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Esta classe tem como objetivo caracterizar os Pacientes, as suas características;
/// </summary>

namespace Trabalho_de_LPII__fase_2_
{

    class Paciente : Pessoa
    {
        #region Parâmetros
        int numerotelemovel;
        int id;
        #endregion

        #region Construtores
        public Paciente()
        {
            PrimeiroNome = "";
            Apelido = "";
            genero = "";
            DataNascimento = DateTime.Today;
            numerotelemovel = 0;
            id = 0;
        }

        public Paciente(string primeiro_nome, string apelido, string genero, DateTime datanscimento, int ID, int numerotelemovel)
        {
            this.PrimeiroNome = primeiro_nome;
            this.Apelido = apelido;
            this.genero = genero;
            this.id = ID;
            this.DataNascimento = datanscimento;
            this.numerotelemovel = numerotelemovel;
        }
        #endregion

        #region Propriedades
        public int NumeroTelemovel
        {
            get { return numerotelemovel; }
            set { numerotelemovel = value; }
        }
        public int Idpaciente
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} ;Género: {2} ;Data de nascimento: {3} ;Número de telemóvel: {4} ;ID: {5};",
                this.PrimeiroNome, this.Apelido, this.genero, this.DataNascimento, this.numerotelemovel, this.id);
        }

        #endregion
    }

}

