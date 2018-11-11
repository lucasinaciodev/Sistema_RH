﻿using Sistema_RH.Classes;
using Sistema_RH.NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_RH.Formulários
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            NEGOCIOS.Funcionario._funcionario.Nome = txtNome.Text;
            NEGOCIOS.Funcionario._funcionario.Sexo = txtSexo.Text;
            NEGOCIOS.Funcionario._funcionario.Departamento = txtDepartamento.Text;
            NEGOCIOS.Funcionario._funcionario.Endereco = txtEndereço.Text;
            NEGOCIOS.Funcionario._funcionario.Funcao = txtFunção.Text;
            NEGOCIOS.Funcionario._funcionario.Estadocivil = txtEstadoCivil.Text;
            NEGOCIOS.Funcionario._funcionario.Admissão = Convert.ToDateTime(mskDataAdmissão.Text);
            NEGOCIOS.Funcionario._funcionario.Datanascimento = Convert.ToDateTime(mskDatadeNascimento.Text);
            NEGOCIOS.Funcionario._funcionario.Cpf = mskCPF.Text;
            NEGOCIOS.Funcionario._funcionario.Telefone = mskTelefone.Text;
            NEGOCIOS.Funcionario._funcionario.Email = txtEmail.Text;
            NEGOCIOS.Funcionario._funcionario.Rg = mskRG.Text;
            NEGOCIOS.Funcionario._funcionario.CarteiraTrabalho = mskCarteira.Text;

            DADOS.DAOFuncionario.InsertBD();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
