using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Bash
{
    public partial class FormRelatorios : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void DtgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String str = "Server=127.0.0.1;Database=bash;Uid=root;Pwd=;";
            string query = "Select * from cliente";
            MySqlConnection con = new MySqlConnection(str);
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable cliente = new DataTable();
            da.Fill(cliente);
            DtgPessoa.DataSource = cliente;
            con.Close();

            String str2 = "Server=127.0.0.1;Database=bash;Uid=root;Pwd=;";
            string query2 = "Select * from funcionario";
            MySqlConnection con2 = new MySqlConnection(str2);
            MySqlCommand cmd2 = new MySqlCommand(query2, con2);
            con2.Open();
            cmd2.CommandType = CommandType.Text;
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable funcionario = new DataTable();
            da2.Fill(funcionario);
            DtgFuncionario.DataSource = funcionario;
            con2.Close();

            String str3 = "Server=127.0.0.1;Database=bash;Uid=root;Pwd=;";
            string query3 = "Select * from produto";
            MySqlConnection con3 = new MySqlConnection(str3);
            MySqlCommand cmd3 = new MySqlCommand(query3, con3);
            con3.Open();
            cmd3.CommandType = CommandType.Text;
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            DataTable produto = new DataTable();
            da3.Fill(produto);
            DtgProduto.DataSource = produto;
            con3.Close();

            String str4 = "Server=127.0.0.1;Database=bash;Uid=root;Pwd=;";
            string query4 = "Select * from venda";
            MySqlConnection con4 = new MySqlConnection(str4);
            MySqlCommand cmd4 = new MySqlCommand(query4, con4);
            con4.Open();
            cmd4.CommandType = CommandType.Text;
            MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
            DataTable venda = new DataTable();
            da4.Fill(venda);
            DtgVendas.DataSource = venda;
            con4.Close();

        }

        private void DtgPessoa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtgPessoa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormCadPessoa Pessoa = new FormCadPessoa();
            Pessoa.txtId.Text = this.DtgPessoa.CurrentRow.Cells[0].Value.ToString();
            Pessoa.txtNome.Text = this.DtgPessoa.CurrentRow.Cells[1].Value.ToString();
            Pessoa.MskCPF.Text = this.DtgPessoa.CurrentRow.Cells[2].Value.ToString();
            
            Pessoa.MskCelular.Text = this.DtgPessoa.CurrentRow.Cells[4].Value.ToString();
            Pessoa.txtEndereco.Text = this.DtgPessoa.CurrentRow.Cells[6].Value.ToString();
            Pessoa.txtNumero.Text = this.DtgPessoa.CurrentRow.Cells[7].Value.ToString();
            Pessoa.txtEstado.Text = this.DtgPessoa.CurrentRow.Cells[8].Value.ToString();
            Pessoa.txtCidade.Text = this.DtgPessoa.CurrentRow.Cells[9].Value.ToString();
            Pessoa.ShowDialog();
        }
    }
}
