namespace Bash
{
    partial class Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPesquiseCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgVenda = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblIdCliente);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.lblCpfCliente);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnPesquisarCliente);
            this.panel1.Controls.Add(this.txtPesquiseCliente);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblNomeProduto);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtQtd);
            this.panel1.Controls.Add(this.txtDesconto);
            this.panel1.Controls.Add(this.txtValorVenda);
            this.panel1.Controls.Add(this.btnCaixa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblValorProduto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPesquisarProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 752);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(401, 166);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(8);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(0, 19);
            this.lblIdCliente.TabIndex = 31;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCliente.Location = new System.Drawing.Point(262, 211);
            this.lblCpfCliente.Margin = new System.Windows.Forms.Padding(8);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(66, 39);
            this.lblCpfCliente.TabIndex = 29;
            this.lblCpfCliente.Text = "CPF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(265, 176);
            this.label12.Margin = new System.Windows.Forms.Padding(8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "CPF Do Cliente";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(54, 211);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(8);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(97, 39);
            this.lblNomeCliente.TabIndex = 27;
            this.lblNomeCliente.Text = "Nome";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Nome Do Cliente";
            // 
            // txtPesquiseCliente
            // 
            this.txtPesquiseCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquiseCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquiseCliente.Location = new System.Drawing.Point(61, 116);
            this.txtPesquiseCliente.Name = "txtPesquiseCliente";
            this.txtPesquiseCliente.Size = new System.Drawing.Size(502, 27);
            this.txtPesquiseCliente.TabIndex = 24;
            this.txtPesquiseCliente.Text = "   Pesquise o Cliente Pelo ID";
            this.txtPesquiseCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPesquiseCliente.Enter += new System.EventHandler(this.txtPesquiseCliente_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 463);
            this.label10.Margin = new System.Windows.Forms.Padding(8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Descrição Produto";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(264, 508);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(8);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(94, 26);
            this.lblDescricao.TabIndex = 22;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(57, 388);
            this.lblId.Margin = new System.Windows.Forms.Padding(8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 39);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Número identificador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nome Do Produto";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(262, 388);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(8);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(123, 39);
            this.lblNomeProduto.TabIndex = 18;
            this.lblNomeProduto.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 589);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 589);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Desconto 0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 589);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valor Total";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(27, 618);
            this.txtQtd.Multiline = true;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(158, 32);
            this.txtQtd.TabIndex = 4;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(226, 619);
            this.txtDesconto.Multiline = true;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(158, 32);
            this.txtDesconto.TabIndex = 3;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(405, 619);
            this.txtValorVenda.Multiline = true;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(158, 32);
            this.txtValorVenda.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Produto";
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProduto.Location = new System.Drawing.Point(54, 495);
            this.lblValorProduto.Margin = new System.Windows.Forms.Padding(8);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(89, 39);
            this.lblValorProduto.TabIndex = 4;
            this.lblValorProduto.Text = "00,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caixa de Venda";
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisarProduto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarProduto.Location = new System.Drawing.Point(61, 292);
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(502, 27);
            this.txtPesquisarProduto.TabIndex = 1;
            this.txtPesquisarProduto.Text = "   Pesquise o Produto Pelo ID";
            this.txtPesquisarProduto.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtgVenda);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(577, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 567);
            this.panel2.TabIndex = 2;
            // 
            // dtgVenda
            // 
            this.dtgVenda.AllowUserToAddRows = false;
            this.dtgVenda.AllowUserToDeleteRows = false;
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenda.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgVenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgVenda.Location = new System.Drawing.Point(0, 0);
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.ReadOnly = true;
            this.dtgVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgVenda.Size = new System.Drawing.Size(469, 563);
            this.dtgVenda.TabIndex = 1;
            this.dtgVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.da_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(623, 632);
            this.txtValorTotal.Multiline = true;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(180, 45);
            this.txtValorTotal.TabIndex = 6;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(619, 602);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor Total Venda";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Image = global::Bash.Properties.Resources.shopping_cart__1_;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.Location = new System.Drawing.Point(99, 662);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(182, 76);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarCliente.Image = global::Bash.Properties.Resources.search__1_;
            this.btnPesquisarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(21, 116);
            this.btnPesquisarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(37, 27);
            this.btnPesquisarCliente.TabIndex = 25;
            this.btnPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = global::Bash.Properties.Resources.purchase__1_;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.Location = new System.Drawing.Point(359, 662);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(187, 76);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir Item";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.SystemColors.Control;
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaixa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.Black;
            this.btnCaixa.Image = global::Bash.Properties.Resources.search__1_;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaixa.Location = new System.Drawing.Point(21, 292);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(37, 27);
            this.btnCaixa.TabIndex = 7;
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = global::Bash.Properties.Resources.cash_register;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.Location = new System.Drawing.Point(822, 664);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(216, 76);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1050, 752);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.TextBox txtPesquiseCliente;
        public System.Windows.Forms.Label lblNomeCliente;
        public System.Windows.Forms.DataGridView dtgVenda;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblIdCliente;
    }
}