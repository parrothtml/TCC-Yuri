using System;
using System.Windows.Forms;

namespace Bash
{
    public partial class FormCadGeral : Form
    { //travar a tela para ela nao se mover
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        public FormCadGeral()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormCadPessoa Pessoa = new FormCadPessoa();
            Pessoa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadProduto Prod = new FormCadProduto();
            Prod.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsers user = new FormUsers();
            user.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Bash fun = new Bash();
            fun.ShowDialog();
        }
    }
}
