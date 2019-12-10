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
    public partial class FormUsers : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");
        public FormUsers()
        {
            InitializeComponent();
        }
        public bool habilitarEdit = false;
        public bool habilitarDel = false;
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtPesquisa.Text == "Digite o 'Código do funcionário' a ser pesquisado")
            {
                MessageBox.Show("Insira o código de algum funcionário antes de pesquisar");
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (txtPesquisa.Text == "Digite o 'Código do funcionário' a ser pesquisado")
            {
                return;
            }
            else
            {

            
            con.Close();

            con.Open();
            habilitarEdit = false;
            habilitarDel = false;
            MySqlCommand cmkd = new MySqlCommand("select * from usuario where funcionario = ?;", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            cmkd.Parameters.Add("funcionario", MySqlDbType.Int32).Value = txtPesquisa.Text;

            MySqlDataReader rkd = cmkd.ExecuteReader();
            if (rkd.Read())
            {
                if (MessageBox.Show("Deseja modificar o usuário?", "Usuário já registrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtUser.Enabled = true;
                    txtPassword.Enabled = true;
                    txtUser.Text = rkd["usuario"].ToString();
                    txtPassword.Text = rkd["senha"].ToString();
                    con.Close();
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from funcionario where cod_funcionario = ?;", con);
                    cmd.Parameters.Add("cod_funcionario", MySqlDbType.Int32).Value = txtPesquisa.Text; 
                    MySqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    txtNome.Text = rd["nome"].ToString();
                    txtID.Text = rd["cod_funcionario"].ToString();
                    cmkd.Parameters.Add("usuario", MySqlDbType.VarChar).Value = txtNome.Text;
                    cmkd.Parameters.Add("senha", MySqlDbType.VarChar).Value = txtPassword.Text;
                    con.Close();
                    txtPesquisa.Text = "Digite o 'Código do funcionário' a ser pesquisado";
                    habilitarEdit = true;
                    habilitarDel = true;
                    }
                else
                {
                    txtPesquisa.Text = null;
                    txtID.Text = null;
                    txtNome.Text = null;
                    txtPassword.Text = null;
                    txtUser.Text = null;
                    txtPesquisa.Text = "Digite o 'Código do funcionário' a ser pesquisado";
                    con.Close();
                    return;
                }

            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from funcionario where cod_funcionario = ?;", con);

                    cmd.Parameters.Add("cod_funcionario", MySqlDbType.Int32).Value = txtPesquisa.Text;

                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        txtPesquisa.Text = rd["cod_funcionario"].ToString();
                        txtNome.Text = rd["nome"].ToString();
                        txtID.Text = rd["cod_funcionario"].ToString();
                        txtUser.Enabled = true;
                        txtPassword.Enabled = true;
                        txtPesquisa.Text = "Digite o 'Código do funcionário' a ser pesquisado";
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado");
                        con.Close();


                    }
                    con.Close();

                }
                finally
                {
                }
                }
            }
            con.Close();

        }





        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Preencha os campos antes de cadastrar");
                return;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into usuario (usuario, senha, funcionario) values (@usuario, @senha, @funcionario)", con);
                cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = txtUser.Text.Trim();
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtPassword.Text.Trim();
                cmd.Parameters.Add("@funcionario", MySqlDbType.Int16).Value = txtID.Text.Trim();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário Registrado!!");

                con.Close();
                txtPesquisa.Text = "";
                txtNome.Text = "";
                txtUser.Text = "";
                txtPassword.Text = "";
                txtPassword.Enabled = false;
                txtUser.Enabled = false;
                txtID.Text = "";

            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (habilitarEdit == true)
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE usuario SET usuario = @usuario, senha = @senha WHERE funcionario = @funcionario;", con);
                    cmd.Parameters.Add("@funcionario", MySqlDbType.Int32).Value = txtID.Text.Trim();
                    cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = txtUser.Text.Trim();
                    cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtPassword.Text.Trim();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Alterado!!");

                    con.Close();
                    txtPesquisa.Text = "";
                    txtNome.Text = "";
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtPassword.Enabled = false;
                    txtUser.Enabled = false;
                    txtID.Text = "";
                    habilitarEdit = false;
                }

                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Pesquise um funcionário antes de editar");
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (habilitarDel == true)
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM usuario WHERE funcionario = @funcionario", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@funcionario", MySqlDbType.Int32).Value = txtID.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Apagado!!");
                    con.Close();
                    txtPesquisa.Text = "";
                    txtNome.Text = "";
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtPassword.Enabled = false;
                    txtUser.Enabled = false;
                    txtID.Text = "";

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }

            else
            {
                MessageBox.Show("Pesquise um funcionário antes de excluir");
                return;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
