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

namespace Trabalho_de_LPII__fase_2_
{
    /// <summary>
    /// Esta classe tem como objetivo caracterizar os Staff, as suas características;
    /// </summary>
    class StaffMedica : Pessoa
    {
        #region Parâmetros
        string trabalho;
        int ID;
        #endregion

        #region Construtores
        public StaffMedica()
        {
            PrimeiroNome = "";
            Apelido = "";
            genero = "";
            ID = 0;
            trabalho = "";
            DataNascimento = DateTime.Today;
        }

        public StaffMedica(string primeiro_nome, string apelido, string genero, DateTime data, string trabalho, int ID)
        {
            this.PrimeiroNome = primeiro_nome;
            this.Apelido = apelido;
            this.genero = genero;
            this.DataNascimento = data;
            this.ID = ID;
            this.trabalho = trabalho;
        }
        #endregion

        #region Propriedades
        public string Trabalho
        {
            get { return trabalho; }
            set { trabalho = value; }
        }

        public int Idstaff
        {
            get { return ID; }
            set { ID = value; }
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} ;Género: {2} ;Data de nascimento: {3} ;Trabalho no hospital: {4} ;ID: {5}",
                this.PrimeiroNome, this.Apelido, this.genero, this.DataNascimento, this.trabalho, this.ID);
        }

        #endregion

    }
}
