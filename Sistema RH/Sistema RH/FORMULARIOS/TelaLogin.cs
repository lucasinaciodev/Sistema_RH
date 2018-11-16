﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_RH.NEGOCIOS;

namespace Sistema_RH.Formulários
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        public string usuario;
        public string senha;
        private void btnLogar_Click(object sender, EventArgs e)
        {
            
            usuario = txtUser.Text;
            senha = txtPwd.Text;
            Autenticacao.login(usuario, senha);
            
            this.Visible = false;
            if (Autenticacao.situacao() == true)
            {
                TelaPrincipal telaprincipal = new TelaPrincipal();
                telaprincipal.ShowDialog();
            }
            //
            else
            {
                MessageBox.Show("login ou senha estão errados.");
                txtUser.Text = "";
                txtPwd.Text = "";
                this.Visible = true;
                txtUser.Focus();
                
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Deseja fechar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
            Application.Exit();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}