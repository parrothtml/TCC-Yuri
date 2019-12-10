using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bash
{
    public partial class FormCadProduto : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");
        public FormCadProduto()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCustoUnitario.Text == "" || txtVenda.Text == "" || txtFabricante.Text == "" || txtQuantidade.Text == "" || txtObs.Text == "")
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
                
                MySqlCommand cmd = new MySqlCommand("INSERT INTO produto( nome, descricao, valor_compra, valor_venda, fabricante, quantidade) VALUES (@nome,@descricao,@valor_compra,@valor_venda,@fabricante,@quantidade)", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("@descricao", MySqlDbType.Text).Value = txtObs.Text.Trim();
                cmd.Parameters.Add("@valor_compra", MySqlDbType.Decimal).Value = txtCustoUnitario.Text.Trim().Replace(".",",");
                cmd.Parameters.Add("@valor_venda", MySqlDbType.Decimal).Value = txtVenda.Text.Trim().Replace(".", ",");
                cmd.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = txtQuantidade.Text.Trim();
                cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = txtFabricante.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Inserido!!");
                con.Close();
                txtId.Text = "";
                txtNome.Text = "";
                txtPesquisar.Text = "Pesquise o Produto Pelo Numero de identificação 'ID'";
                txtVenda.Text = "";
                txtCustoUnitario.Text = "";
                txtFabricante.Text = "";
                txtObs.Text = "";


            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (txtPesquisar.Text == "Pesquise o Produto Pelo Numero de identificação 'ID'")
            {
                MessageBox.Show("Insira o ID de algum produto antes de pesquisar");
                return;
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("select * from produto where id_produto = ?  ;", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("id_produto", MySqlDbType.Int32).Value = txtPesquisar.Text;


                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {

                        txtPesquisar.Text = "Pesquise o Produto Pelo Numero de identificação 'ID'";
                        txtId.Text = rd["id_produto"].ToString();
                        txtNome.Text = rd["nome"].ToString();
                        txtFabricante.Text = rd["fabricante"].ToString();
                        txtCustoUnitario.Text = rd["valor_compra"].ToString();
                        txtVenda.Text = rd["valor_venda"].ToString();
                        txtQuantidade.Text = rd["quantidade"].ToString();
                        txtObs.Text = rd["descricao"].ToString();

                    }

                    else
                    {
                        MessageBox.Show("Item não existe!!");
                        txtId.Text = "";
                        txtNome.Text = "";
                        txtPesquisar.Text = "Pesquise o Produto Pelo Numero de identificação 'ID'";
                        txtVenda.Text = "";
                        txtCustoUnitario.Text = "";
                        txtFabricante.Text = "";
                        txtObs.Text = "";
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
            if(txtId.Text == "")
            {
                MessageBox.Show("Pesquise o ID de algum produto antes de editar");
                return;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE produto SET id_produto = @id_produto, nome = @nome,descricao = @descricao," +
                    "valor_compra= @valor_compra,valor_venda = @valor_Venda, fabricante = @fabricante, quantidade = @quantidade WHERE id_produto =@id_produto", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_produto", MySqlDbType.Int32).Value = txtId.Text;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("@descricao", MySqlDbType.Text).Value = txtObs.Text.Trim();
                cmd.Parameters.Add("@valor_compra", MySqlDbType.Decimal).Value = txtCustoUnitario.Text.Trim().Replace(".", ",");
                cmd.Parameters.Add("@valor_venda", MySqlDbType.Decimal).Value = txtVenda.Text.Trim().Replace(".", ",");
                cmd.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = txtQuantidade.Text.Trim();
                cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = txtFabricante.Text.Trim();


                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Alterado!!");
                txtId.Text = "";
                txtNome.Text = "";
                txtPesquisar.Text = "Pesquise o Produto Pelo Numero de identificação 'ID'";
                txtVenda.Text = "";
                txtCustoUnitario.Text = "";
                txtFabricante.Text = "";
                txtObs.Text = "";

            }

            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
                con.Close();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Pesquise o ID de algum produto antes de excluir");
                return;
            }
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM produto WHERE id_produto = @id_produto", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_produto", MySqlDbType.Int32).Value = txtId.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Apagado!!");
                con.Close();

                txtId.Text = "";
                txtNome.Text = "";
                txtPesquisar.Text = "Pesquise o Produto Pelo Numero de identificação 'ID'";
                txtVenda.Text = "";
                txtCustoUnitario.Text = "";
                txtFabricante.Text = "";
                txtObs.Text = "";

            }
            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
                con.Close();
            }
        }

    }
}
