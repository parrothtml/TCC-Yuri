using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Bash
{
    public partial class FormLogin : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            { con.Close();
            }
            con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from usuario where senha = @senha AND usuario = @usuario;", con);

            cmd.Parameters.Add("usuario", MySqlDbType.VarChar).Value = txtUsuario.Text.Trim();
            cmd.Parameters.Add("senha", MySqlDbType.VarChar).Value = txtSenha.Text.Trim();

            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                this.Hide();
                FormPrincipal Geral = new FormPrincipal();
                Geral.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
                txtSenha.Text = "";
                txtUsuario.Text = "";
                return;
            }
            con.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
