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

namespace Trabalho_de_LPII__fase_2_
{
    
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
            set 
            {
                //Adicionar aqui as varias profissoes existentes num Hospital
                if (trabalho == "Enfermeiro" || trabalho == "Médico")
                trabalho = value; 
            }
        }

        //Id não existente;
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        #endregion
         
        #region Override
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} ; Género: {2} ; Data de nascimento: {3} ; Trabalho no hospital: {4} ; ID: {5}",
                this.PrimeiroNome, this.Apelido, this.genero, this.DataNascimento , this.trabalho, this.ID);
        }

        #endregion

    }
}
