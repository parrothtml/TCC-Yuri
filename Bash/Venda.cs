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
    public partial class Venda : Form
    {

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");

        public Venda()
        {
            InitializeComponent();
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisarProduto.Text = "";

        }

        private void da_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from produto where id_produto = ?;", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id_produto", MySqlDbType.Int32).Value = txtPesquisarProduto.Text;

                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lblId.Text = rd["id_produto"].ToString();
                    lblNomeProduto.Text = rd["nome"].ToString();
                    lblValorProduto.Text = rd["valor_venda"].ToString();
                    lblDescricao.Text = rd["descricao"].ToString();                   
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    con.Close();
                    lblId.Text = "";
                    lblNomeProduto.Text = "";
                    lblValorProduto.Text = "";
                    lblDescricao.Text = "";

                }
                con.Close();

            }
            finally
            {
            }
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from cliente where id = ?;", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = txtPesquiseCliente.Text;

                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {                    
                    txtPesquiseCliente.Text = "Pesquise o Clinte Pelo Numero de identificação 'ID'";
                    lblNomeCliente.Text = rd["nome"].ToString();
                    lblCpfCliente.Text = rd["cpf"].ToString();
                    lblIdCliente.Text = rd["id"].ToString();
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

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquiseCliente_Enter(object sender, EventArgs e)
        {
            txtPesquiseCliente.Text = "";
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        { 
            if (txtQtd.Text == "")
            {
                return;
            }
            Decimal ValorProduto = Convert.ToDecimal(lblValorProduto.Text);
            int Quantidade = Convert.ToInt32(txtQtd.Text);
           
            Decimal Total;
            Total = ValorProduto * Quantidade;

            txtValorVenda.Text = Convert.ToString(Total);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow item = new DataGridViewRow();
            item.CreateCells(dtgVenda);
            item.Cells[0].Value = lblId.Text;
            item.Cells[1].Value = lblNomeProduto.Text;
            item.Cells[2].Value = lblValorProduto.Text;
            item.Cells[3].Value = txtQtd.Text;
            item.Cells[4].Value = txtValorVenda.Text;
            dtgVenda.Rows.Add(item);

            decimal soma = 0;
            foreach (DataGridViewRow dr in dtgVenda.Rows) soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtValorTotal.Text = Convert.ToString(soma);

            lblDescricao.Text = "Descrição";
            lblId.Text = "Id";
            lblValorProduto.Text = "00,00";
            lblNomeProduto.Text = "Produto";
            txtPesquisarProduto.Text = "Pesquise o Produto Pelo ID";
            txtQtd.Text = "";
            txtValorVenda.Text = "";


        }

        private void Venda_Load(object sender, EventArgs e)
        {
            dtgVenda.Columns.Add("Id Produto", "Id Produto");
            dtgVenda.Columns.Add("Produto", "Produto");
            dtgVenda.Columns.Add("Valor Produto", "Valor Produto");
            dtgVenda.Columns.Add("Quantidade", "Quantidade");
            dtgVenda.Columns.Add("Valor Total do Produto", "Valor Total do Produto");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int linha = dtgVenda.CurrentRow.Index;
            dtgVenda.Rows.RemoveAt(linha);
            dtgVenda.Refresh();
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO venda(valor_venda, data_venda, fk_id_cliente) VALUES (@valor_venda, @data_venda, @fk_id_cliente)", con);
            cmd.Parameters.Add("@valor_venda", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtValorTotal.Text);
            cmd.Parameters.Add("@data_venda", MySqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.Add("@fk_id_cliente", MySqlDbType.Int32).Value = Convert.ToInt32(lblIdCliente.Text);
            cmd.ExecuteNonQuery();
            string idvenda = "SELECT LAST_INSERT_ID('venda') as id_venda";
            MySqlCommand cmdvenda = new MySqlCommand(idvenda, con);
            Int32 idvenda2 = Convert.ToInt32(cmdvenda.ExecuteScalar());
            foreach (DataGridViewRow dr in dtgVenda.Rows)
            {
                MySqlCommand cmditens = new MySqlCommand("INSERT INTO itens_venda(quantidade_vendida, fk_venda, fk_id_produto, valor_produto, valor_total) " +
                    "VALUES (@quantidade_vendida, @fk_venda, @fk_id_produto, @valor_produto, @valor_total)", con);
               //cmditens.CommandType = CommandType.StoredProcedure;
                string ven = "update produto set quantidade = (quantidade - @quantidade2) where id_produto = @id_produto2";
                MySqlCommand cmditemvenda = new MySqlCommand(ven, con);
                cmditemvenda.Parameters.Add("@quantidade2", MySqlDbType.Int32).Value = Convert.ToInt32(dr.Cells[3].Value);
                cmditemvenda.Parameters.Add("@id_produto2", MySqlDbType.Int32).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmditens.Parameters.Add("@quantidade_vendida", MySqlDbType.Int32).Value = Convert.ToInt32(dr.Cells[3].Value);
                cmditens.Parameters.Add("@fk_id_produto", MySqlDbType.Int32).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmditens.Parameters.Add("@fk_venda", MySqlDbType.Int32).Value = idvenda2;
                cmditens.Parameters.Add("@valor_produto", MySqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[2].Value);
                cmditens.Parameters.Add("@valor_total", MySqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
               
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                cmditemvenda.ExecuteNonQuery();
                cmditens.ExecuteNonQuery();

                
                con.Close();
            }
            DialogResult venda = MessageBox.Show("Venda Realizada Com Sucesso!! Deseja imprimir a nota?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (venda == DialogResult.Yes)
            {
                this.Close();

            }
            else if (venda == DialogResult.No)
            {
                this.Close();
            }


        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from produto where id_produto = @id_produto;", con);
            cmd.Parameters.Add("id_produto", MySqlDbType.Int32).Value = lblId.Text;
            //cmd.Parameters.Add("quantidade", MySqlDbType.Int32).Value = txtQtd.Text;
            MySqlDataReader rd = cmd.ExecuteReader();
            int valor1;
            bool conversaoSucedida = int.TryParse(txtQtd.Text, out valor1);
            if (rd.Read())
            {
                int valor2 = Convert.ToInt32(rd["quantidade"].ToString());
                if (valor1 > valor2)
                {
                    MessageBox.Show("Quantidade insuficiente, por favor faça um pedido desse produto!");

                    return;
                }


            }
        }
    }
    }

