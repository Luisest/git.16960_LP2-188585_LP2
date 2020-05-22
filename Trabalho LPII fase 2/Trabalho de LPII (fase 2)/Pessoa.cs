/*
 * 
 * Autores do projecto: Luis Esteves/16960 || Sérgio Ribeiro/18858;
 * Disciplina: Línguagem de Programação II;
 * Projecto I, Fase 2;
 * Propósito do trabalho: Contabilizar os casos de Covid num Hospital;
 * 
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;



namespace Trabalho_de_LPII__fase_2_
{
    class Pessoa
    {
        #region Parâmetros

        string primeiro_nome;
        string apelido;
        public string genero;
        DateTime datanascimento;
        
        #endregion
        
        #region Construtores

        public Pessoa() 
        {
            primeiro_nome = "";
            apelido = "";
            genero = "";
            datanascimento = DateTime.Today;
        }

        public Pessoa (string primeiro_nome, string apelido, string genero, int idade,  DateTime data )
        {
            this.primeiro_nome = primeiro_nome;
            this.apelido = apelido;
            this.genero = genero;
            this.datanascimento = data;

        }

        #endregion

        #region Propriedades

        public string PrimeiroNome
        {
            get { return primeiro_nome; }
            set { if (primeiro_nome.Length < 20) primeiro_nome = value; }
        }

        public string Apelido
        {
            get { return apelido; }
            set { if (apelido.Length < 20) apelido = value; }      
        }

        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { if (datanascimento > DateTime.Today) datanascimento = value; }
        }

        #endregion
    }
}
