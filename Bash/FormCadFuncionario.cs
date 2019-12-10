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
    public partial class Bash : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");
        public Bash()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSobrenome.Text == "" || cbSexo.Text == "Escolha o sexo..." || dtpNascimento.Value == DateTime.Now || mskCpf.Text == "" || cbFunc.Text == "" || txtEndereco.Text == "" || txtNumero.Text == "" || txtBairro.Text == "" || mskCep.Text == "" || txtCidade.Text == "" || txtEstado.Text == "" || mskCelular.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes de cadastar");
                return;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("inserir_funcionario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text.Trim();
                cmd.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = txtSobrenome.Text.Trim();
                cmd.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = cbSexo.Text.Trim();
                cmd.Parameters.Add("@data_nascimento", MySqlDbType.Date).Value = Convert.ToDateTime(dtpNascimento.Text.Trim());
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = mskCpf.Text.Trim();
                cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = txtEndereco.Text.Trim();
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = txtNumero.Text.Trim();
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = txtBairro.Text.Trim();
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = mskCep.Text.Trim();
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar).Value = mskCelular.Text.Trim();
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtCidade.Text.Trim();
                cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = txtEstado.Text.Trim();
                cmd.Parameters.Add("@funcao", MySqlDbType.VarChar).Value = cbFunc.Text.Trim();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Inserido!!");
                con.Close();
                txtCod.Text = "";
                mskCpf.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                mskCelular.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtSobrenome.Text = "";
                mskCep.Text = "";
                txtCidade.Text = "";
                txtBairro.Text = "";
                cbSexo.Text = "Escolha o sexo...";
                dtpNascimento.Value = DateTime.Now;
                cbFunc.Text = "Escolha a função...";
            }
            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (txtPesquisar.Text == "Pesquise o Funcionario Pelo Cod. Funcionario")
            {
                MessageBox.Show("Insira o código de algum funcionário antes de pesquisar");
                return;
            }
            else
            {


                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from funcionario where cod_funcionario = ? ;", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("cod_funcionario", MySqlDbType.Int32).Value = txtPesquisar.Text;

                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        txtCod.Text = rd["cod_funcionario"].ToString();
                        txtNome.Text = rd["nome"].ToString();
                        mskCpf.Text = rd["cpf"].ToString();
                        mskCelular.Text = rd["celular"].ToString();
                        txtEndereco.Text = rd["endereco"].ToString();
                        txtNumero.Text = rd["numero"].ToString();
                        txtCidade.Text = rd["cidade"].ToString();
                        txtEstado.Text = rd["estado"].ToString();
                        txtSobrenome.Text = rd["sobrenome"].ToString();
                        mskCep.Text = rd["cep"].ToString();
                        txtBairro.Text = rd["bairro"].ToString();
                        cbSexo.Text = rd["sexo"].ToString();
                        dtpNascimento.Text = rd["data_nascimento"].ToString();
                        cbFunc.Text = rd["funcao"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado");
                        con.Close();
                        txtCod.Text = "";
                        mskCpf.Text = "";
                        txtNome.Text = "";
                        txtEndereco.Text = "";
                        mskCelular.Text = "";
                        txtEndereco.Text = "";
                        txtNumero.Text = "";
                        txtEstado.Text = "";
                        txtCidade.Text = "";
                        txtSobrenome.Text = "";
                        mskCep.Text = "";
                        txtCidade.Text = "";
                        txtBairro.Text = "";
                        cbSexo.Text = "Escolha o sexo...";
                        dtpNascimento.Value = DateTime.Now;
                        cbFunc.Text = "Escolha a função...";

                    }
                    con.Close();

                }
                finally
                {
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                MessageBox.Show("Pesquise um funcionário antes de editar");
                return;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE funcionario SET funcao = @funcao, nome = @nome,sobrenome = @sobrenome,sexo = @sexo, data_nascimento= @data_nascimento," +
                "cpf = @cpf, endereco = @endereco, numero = @numero, bairro = @bairro, cep=@cep, celular= @celular,cidade=@cidade,estado=@estado WHERE cod_funcionario = @cod_funcionario;", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cod_funcionario", MySqlDbType.Int32).Value = txtCod.Text.Trim();
                cmd.Parameters.Add("@funcao", MySqlDbType.VarChar).Value = cbFunc.Text.Trim();
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text.Trim();
                cmd.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = txtSobrenome.Text.Trim();
                cmd.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = cbSexo.Text.Trim();
                cmd.Parameters.Add("@data_nascimento", MySqlDbType.Date).Value = Convert.ToDateTime(dtpNascimento.Text.Trim());
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = mskCpf.Text.Trim();
                cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = txtEndereco.Text.Trim();
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = txtNumero.Text.Trim();
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = txtBairro.Text.Trim();
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = mskCep.Text.Trim();
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar).Value = mskCelular.Text.Trim();
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtCidade.Text.Trim();
                cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = txtEstado.Text.Trim();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Alterado!!");

                con.Close();
                txtCod.Text = "";
                mskCpf.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                mskCelular.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtSobrenome.Text = "";
                mskCep.Text = "";
                txtCidade.Text = "";
                txtBairro.Text = "";
                cbSexo.Text = "Escolha o sexo...";
                cbFunc.Text = "";
                dtpNascimento.Value = DateTime.Now;
            }

            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                MessageBox.Show("Pesquise um funcionário antes de excluir");
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM funcionario WHERE cod_funcionario = @cod_funcionario", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cod_funcionario", MySqlDbType.Int32).Value = txtCod.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Deletado!!");
                con.Close();
                con.Close();
                txtCod.Text = "";
                mskCpf.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                mskCelular.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtSobrenome.Text = "";
                mskCep.Text = "";
                txtCidade.Text = "";
                txtBairro.Text = "";
                cbSexo.Text = "Escolha o sexo...";
                cbFunc.Text = "";
                dtpNascimento.Value = DateTime.Now;

            }
            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            mskCpf.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskCelular.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtSobrenome.Text = "";
            mskCep.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            cbSexo.Text = "Escolha o sexo...";
            cbFunc.Text = "";
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }
    }
    }

