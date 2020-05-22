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
    
    class Covid : Paciente
    {
        #region Parâmetros
        public DateTime dataconsulta;
        public string estadopaciente;
        int codmedico;


        #endregion

        #region Construtores

        public Covid()
        {
            dataconsulta = DateTime.Today;
            estadopaciente = "";
            codmedico = 0;
            PrimeiroNome = "";
            Apelido = "";
            NumeroTelemovel = 0;
            genero = "";
            DataNascimento = DateTime.Today ;
            ID = 0;
        }

        public Covid(string primeiron, string apelido, string genero, int numerotele, DateTime data, DateTime dataconsulta, string estadopaciente, int codmedico , int codpaciente)
        {
            PrimeiroNome = primeiron;
            Apelido = apelido;
            this.genero = genero;
            NumeroTelemovel = numerotele;
            DataNascimento = data;
            this.dataconsulta = dataconsulta;
            if (estadopaciente == "Grave"|| estadopaciente == "Normal" || estadopaciente == "Crítico") this.estadopaciente = estadopaciente;
            this.codmedico = codmedico;
            this.ID = codpaciente;
        }
        #endregion

        #region Propriedades

        public int CodigoMedico
        {
            get { return codmedico; }
            set
            {
                for (int i = 0; i < Hospital.staffs.Length; i++)
                {
                    if (codmedico == Hospital.staffs[i].Id) codmedico = value;
                    //Dizer que o codigo nao existe;
                }
            }
        }

        #endregion

        #region Override
        public override string ToString()
        {
            return String.Format("Nome: {0} {1} | Género: {2} | Data de nascimento: {3} | Número de telemóvel: {4} | Código do paciente: {5} |\nData da consulta: {6} | Estado do paciente: {7} | Código do médico que atendeu: {8}; ",
                this.PrimeiroNome, this.Apelido, this.genero, this.DataNascimento, this.NumeroTelemovel, this.ID, this.dataconsulta, this.estadopaciente, this.codmedico);
        }


        #endregion
    }
}
