using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bash
{
    public partial class FormCadPessoa : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");

        public FormCadPessoa()
        {
            InitializeComponent();


        }

        public void Carregadtg()
        {
            //string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Bash\\Bash\\bashbd.mdf;Integrated Security=True;Connect Timeout=30";
            //string query = "Select * from cadastro";
            //SqlConnection con = new SqlConnection(str);
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //cmd.CommandType = CommandType.Text;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable cadastro = new DataTable();
            //da.Fill(cadastro);
            ////dtgCadastro.DataSource = cadastro;
            //con.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastros_Load(object sender, EventArgs e)
        {
            Carregadtg();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSobrenome.Text == "" || cbSexo.Text == "Escolha o sexo..." || dtpNascimento.Value == DateTime.Now || MskCPF.Text == "" || txtEndereco.Text == "" || txtNumero.Text == "" || txtBairro.Text == "" || MskCEP.Text == "" || txtCidade.Text == "" || txtEstado.Text == "" || MskCelular.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar");
                return;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert_cliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text.Trim();
                cmd.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = txtSobrenome.Text.Trim();
                cmd.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = cbSexo.Text.Trim();
                cmd.Parameters.Add("@data_nascimento", MySqlDbType.Date).Value = Convert.ToDateTime(dtpNascimento.Text.Trim());
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = MskCPF.Text.Trim();
                cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = txtEndereco.Text.Trim();
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = txtNumero.Text.Trim();
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = txtBairro.Text.Trim();
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = MskCEP.Text.Trim();
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar).Value = MskCelular.Text.Trim();
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtCidade.Text.Trim();
                cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = txtEstado.Text.Trim();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Inserido!!");
                Carregadtg();

                con.Close();
                txtId.Text = "";
                MskCPF.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                MskCelular.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtSobrenome.Text = "";
                MskCEP.Text = "";
                txtCidade.Text = "";
                txtBairro.Text = "";
                cbSexo.Text = "Escolha o sexo...";
                dtpNascimento.Value = DateTime.Now;

            }

            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Pesquise um cliente antes de editar");
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE cliente SET nome= @nome,sobrenome= @sobrenome,sexo=@sexo, data_nascimento= @data_nascimento," +
                "cpf=@cpf, endereco = @endereco, numero=@numero,bairro = @bairro,cep=@cep,celular= @celular,cidade=cidade,estado=@estado WHERE id_cliente = @id_cliente;", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = txtId.Text.Trim();
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text.Trim();
                cmd.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = txtSobrenome.Text.Trim();
                cmd.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = cbSexo.Text.Trim();
                cmd.Parameters.Add("@data_nascimento", MySqlDbType.Date).Value = Convert.ToDateTime(dtpNascimento.Text.Trim());
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = MskCPF.Text.Trim();
                cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = txtEndereco.Text.Trim();
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = txtNumero.Text.Trim();
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = txtBairro.Text.Trim();
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = MskCEP.Text.Trim();
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar).Value = MskCelular.Text.Trim();
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtCidade.Text.Trim();
                cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = txtEstado.Text.Trim();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Alterado!!");
                Carregadtg();

                con.Close();
                txtId.Text = "";
                MskCPF.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                MskCelular.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtSobrenome.Text = "";
                MskCEP.Text = "";
                txtCidade.Text = "";
                txtBairro.Text = "";
                cbSexo.Text = "Escolha o sexo...";
                dtpNascimento.Value = DateTime.Now;
            }

            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
                con.Close();
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Pesquise um cliente antes de excluir");
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM cliente WHERE id_cliente = @id_cliente", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = txtId.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Apagado!!");
                Carregadtg();
                con.Close();
                con.Close();
                txtId.Text = "";
                MskCPF.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                MskCelular.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtSobrenome.Text = "";
                MskCEP.Text = "";
                txtCidade.Text = "";
                txtBairro.Text = "";
                cbSexo.Text = "Escolha o sexo...";
                dtpNascimento.Value = DateTime.Now;

            }
            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
            }
        }

        private void DtgCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dtgCadastro.Rows[e.RowIndex];
            //    txtId.Text = row.Cells[0].Value.ToString();
            //    txtNome.Text = row.Cells[1].Value.ToString();
            //    txtcpf.Text = row.Cells[2].Value.ToString();
            //    txtRg.Text = row.Cells[3].Value.ToString();
            //    txtCelular.Text = row.Cells[4].Value.ToString();
            //    txtTelefone.Text = row.Cells[5].Value.ToString();
            //    txtEndereco.Text = row.Cells[6].Value.ToString();
            //    txtNumero.Text = row.Cells[7].Value.ToString();
            //    txtEstado.Text = row.Cells[8].Value.ToString();
            //    txtCidade.Text = row.Cells[9].Value.ToString();

            //}
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (txtPesquisar.Text == "Pesquise o Cliente Pelo Numero de identificação 'ID'")
            {
                MessageBox.Show("Insira o ID de algum cliente antes de pesquisar");
                return;
            }

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from cliente where id = ? ;", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = txtPesquisar.Text;

                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtPesquisar.Text = "Pesquise o Cliente Pelo Número de identificação 'ID'";
                    txtId.Text = rd["id"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    MskCPF.Text = rd["cpf"].ToString();
                    MskCelular.Text = rd["celular"].ToString();
                    txtEndereco.Text = rd["endereco"].ToString();
                    txtNumero.Text = rd["numero"].ToString();
                    txtCidade.Text = rd["cidade"].ToString();
                    txtEstado.Text = rd["estado"].ToString();
                    txtSobrenome.Text = rd["sobrenome"].ToString();
                    MskCEP.Text = rd["cep"].ToString();
                    txtBairro.Text = rd["bairro"].ToString();
                    cbSexo.Text = rd["sexo"].ToString();
                    dtpNascimento.Text = rd["data_nascimento"].ToString();

                }
                else
                {


                }
                con.Close();

            }
            finally
            {
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            con.Close();
            txtId.Text = "";
            MskCPF.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            MskCelular.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtSobrenome.Text = "";
            MskCEP.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            cbSexo.Text = "Escolha o sexo...";
            dtpNascimento.Value = DateTime.Now;
        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {


        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }
    }
}
