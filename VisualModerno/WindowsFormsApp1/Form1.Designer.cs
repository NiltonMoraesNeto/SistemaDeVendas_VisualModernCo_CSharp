namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnRes = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.VerticalEsquerda = new System.Windows.Forms.Panel();
            this.subMenuRelatorio = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnRelatoriPagamento = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnRelatorioCompra = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnRelatorioVEnda = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRelatório = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCENTRO = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.VerticalEsquerda.SuspendLayout();
            this.subMenuRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnRes);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnFechar);
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.Location = new System.Drawing.Point(1228, 6);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(25, 25);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRes.TabIndex = 3;
            this.btnRes.TabStop = false;
            this.btnRes.Visible = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1197, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1230, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1263, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // VerticalEsquerda
            // 
            this.VerticalEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.VerticalEsquerda.Controls.Add(this.labelCargo);
            this.VerticalEsquerda.Controls.Add(this.labelEmail);
            this.VerticalEsquerda.Controls.Add(this.labelNome);
            this.VerticalEsquerda.Controls.Add(this.subMenuRelatorio);
            this.VerticalEsquerda.Controls.Add(this.panel7);
            this.VerticalEsquerda.Controls.Add(this.btnRelatório);
            this.VerticalEsquerda.Controls.Add(this.panel6);
            this.VerticalEsquerda.Controls.Add(this.btnPagamento);
            this.VerticalEsquerda.Controls.Add(this.panel5);
            this.VerticalEsquerda.Controls.Add(this.panel4);
            this.VerticalEsquerda.Controls.Add(this.btnFuncionario);
            this.VerticalEsquerda.Controls.Add(this.btnCompra);
            this.VerticalEsquerda.Controls.Add(this.panel3);
            this.VerticalEsquerda.Controls.Add(this.btnCliente);
            this.VerticalEsquerda.Controls.Add(this.panel2);
            this.VerticalEsquerda.Controls.Add(this.panel1);
            this.VerticalEsquerda.Controls.Add(this.btnVenda);
            this.VerticalEsquerda.Controls.Add(this.btnProduto);
            this.VerticalEsquerda.Controls.Add(this.pictureBox1);
            this.VerticalEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerticalEsquerda.Location = new System.Drawing.Point(0, 0);
            this.VerticalEsquerda.Name = "VerticalEsquerda";
            this.VerticalEsquerda.Size = new System.Drawing.Size(220, 650);
            this.VerticalEsquerda.TabIndex = 1;
            // 
            // subMenuRelatorio
            // 
            this.subMenuRelatorio.Controls.Add(this.panel11);
            this.subMenuRelatorio.Controls.Add(this.btnRelatoriPagamento);
            this.subMenuRelatorio.Controls.Add(this.panel10);
            this.subMenuRelatorio.Controls.Add(this.btnRelatorioCompra);
            this.subMenuRelatorio.Controls.Add(this.panel9);
            this.subMenuRelatorio.Controls.Add(this.btnRelatorioVEnda);
            this.subMenuRelatorio.Location = new System.Drawing.Point(45, 354);
            this.subMenuRelatorio.Name = "subMenuRelatorio";
            this.subMenuRelatorio.Size = new System.Drawing.Size(172, 100);
            this.subMenuRelatorio.TabIndex = 0;
            this.subMenuRelatorio.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(2, 69);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 28);
            this.panel11.TabIndex = 19;
            // 
            // btnRelatoriPagamento
            // 
            this.btnRelatoriPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRelatoriPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatoriPagamento.FlatAppearance.BorderSize = 0;
            this.btnRelatoriPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRelatoriPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatoriPagamento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatoriPagamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRelatoriPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatoriPagamento.Location = new System.Drawing.Point(2, 69);
            this.btnRelatoriPagamento.Name = "btnRelatoriPagamento";
            this.btnRelatoriPagamento.Size = new System.Drawing.Size(170, 28);
            this.btnRelatoriPagamento.TabIndex = 20;
            this.btnRelatoriPagamento.Text = "Pagamentos";
            this.btnRelatoriPagamento.UseVisualStyleBackColor = false;
            this.btnRelatoriPagamento.Click += new System.EventHandler(this.btnRelatoriPagamento_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(2, 36);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 28);
            this.panel10.TabIndex = 17;
            // 
            // btnRelatorioCompra
            // 
            this.btnRelatorioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRelatorioCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioCompra.FlatAppearance.BorderSize = 0;
            this.btnRelatorioCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRelatorioCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioCompra.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRelatorioCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioCompra.Location = new System.Drawing.Point(2, 36);
            this.btnRelatorioCompra.Name = "btnRelatorioCompra";
            this.btnRelatorioCompra.Size = new System.Drawing.Size(169, 28);
            this.btnRelatorioCompra.TabIndex = 18;
            this.btnRelatorioCompra.Text = "Compras";
            this.btnRelatorioCompra.UseVisualStyleBackColor = false;
            this.btnRelatorioCompra.Click += new System.EventHandler(this.btnRelatorioCompra_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 28);
            this.panel9.TabIndex = 15;
            // 
            // btnRelatorioVEnda
            // 
            this.btnRelatorioVEnda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRelatorioVEnda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioVEnda.FlatAppearance.BorderSize = 0;
            this.btnRelatorioVEnda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRelatorioVEnda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioVEnda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioVEnda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRelatorioVEnda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioVEnda.Location = new System.Drawing.Point(3, 3);
            this.btnRelatorioVEnda.Name = "btnRelatorioVEnda";
            this.btnRelatorioVEnda.Size = new System.Drawing.Size(169, 28);
            this.btnRelatorioVEnda.TabIndex = 16;
            this.btnRelatorioVEnda.Text = "Vendas";
            this.btnRelatorioVEnda.UseVisualStyleBackColor = false;
            this.btnRelatorioVEnda.Click += new System.EventHandler(this.btnRelatorioVEnda_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(3, 316);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 13;
            // 
            // btnRelatório
            // 
            this.btnRelatório.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRelatório.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatório.FlatAppearance.BorderSize = 0;
            this.btnRelatório.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRelatório.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatório.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatório.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRelatório.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatório.Image")));
            this.btnRelatório.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatório.Location = new System.Drawing.Point(3, 316);
            this.btnRelatório.Name = "btnRelatório";
            this.btnRelatório.Size = new System.Drawing.Size(217, 32);
            this.btnRelatório.TabIndex = 14;
            this.btnRelatório.Text = "Relatórios";
            this.btnRelatório.UseVisualStyleBackColor = false;
            this.btnRelatório.Click += new System.EventHandler(this.btnRelatório_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(3, 278);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 11;
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagamento.FlatAppearance.BorderSize = 0;
            this.btnPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamento.Location = new System.Drawing.Point(3, 278);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(217, 32);
            this.btnPagamento.TabIndex = 12;
            this.btnPagamento.Text = "Pagamentos";
            this.btnPagamento.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(3, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(3, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 7;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(3, 240);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(217, 32);
            this.btnFuncionario.TabIndex = 10;
            this.btnFuncionario.Text = "Funcionários";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnCompra.Image")));
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(3, 202);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(217, 32);
            this.btnCompra.TabIndex = 8;
            this.btnCompra.Text = "Compras";
            this.btnCompra.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(3, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 5;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(3, 164);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(217, 32);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(3, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(3, 126);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(217, 32);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.Text = "Vendas";
            this.btnVenda.UseVisualStyleBackColor = false;
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.Location = new System.Drawing.Point(3, 88);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(217, 32);
            this.btnProduto.TabIndex = 0;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelCENTRO
            // 
            this.panelCENTRO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCENTRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelCENTRO.Location = new System.Drawing.Point(220, 38);
            this.panelCENTRO.Name = "panelCENTRO";
            this.panelCENTRO.Size = new System.Drawing.Size(1080, 612);
            this.panelCENTRO.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(12, 564);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(57, 19);
            this.labelNome.TabIndex = 15;
            this.labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(12, 593);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 19);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email";
            // 
            // labelCargo
            // 
            this.labelCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.ForeColor = System.Drawing.Color.White;
            this.labelCargo.Location = new System.Drawing.Point(12, 622);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(58, 19);
            this.labelCargo.TabIndex = 17;
            this.labelCargo.Text = "Cargo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelCENTRO);
            this.Controls.Add(this.VerticalEsquerda);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.VerticalEsquerda.ResumeLayout(false);
            this.VerticalEsquerda.PerformLayout();
            this.subMenuRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel VerticalEsquerda;
        private System.Windows.Forms.Panel panelCENTRO;
        private System.Windows.Forms.PictureBox btnRes;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRelatório;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Panel subMenuRelatorio;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnRelatoriPagamento;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnRelatorioCompra;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnRelatorioVEnda;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCargo;
    }
}

