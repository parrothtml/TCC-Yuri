using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bash
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {

        }


        private void Button2_Click_1(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormCadGeral cad = new FormCadGeral();
            cad.TopLevel = false;
            panel3.Controls.Add(cad);
            cad.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastros_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCadastros_Leave(object sender, EventArgs e)
        {

        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnEstoque_Click_1(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormRelatorios f = new FormRelatorios();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }

        private void BtnCadastros_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormCadGeral GeralCad = new FormCadGeral();
            GeralCad.TopLevel = false;
            panel3.Controls.Add(GeralCad);
            GeralCad.Show();
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Venda pdv = new Venda();
            pdv.TopLevel = false;
            panel3.Controls.Add(pdv);
            pdv.Show();
        }

        private void BtnTesteBanco_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
