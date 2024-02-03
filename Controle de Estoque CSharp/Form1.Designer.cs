namespace Controle_de_Estoque_CSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtNome = new TextBox();
            txtValorCompra = new TextBox();
            txtValorVenda = new TextBox();
            txtQuantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCadastrar = new Button();
            bntDeletar = new Button();
            btnEditar = new Button();
            btnLimpar = new Button();
            dataGridView1 = new DataGridView();
            produtoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorCompraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoBindingSource = new BindingSource(components);
            lbTeste = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(143, 27);
            txtNome.TabIndex = 0;
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(231, 64);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(143, 27);
            txtValorCompra.TabIndex = 1;
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(380, 64);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(143, 27);
            txtValorVenda.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(529, 64);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(155, 27);
            txtQuantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 41);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 5;
            label2.Text = "Valor de compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 41);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 6;
            label3.Text = "Valor de venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 41);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 7;
            label4.Text = "Quantidade adquirida";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Green;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Location = new Point(82, 114);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(143, 29);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // bntDeletar
            // 
            bntDeletar.BackColor = Color.Red;
            bntDeletar.FlatStyle = FlatStyle.Popup;
            bntDeletar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bntDeletar.ForeColor = SystemColors.Control;
            bntDeletar.Location = new Point(380, 114);
            bntDeletar.Name = "bntDeletar";
            bntDeletar.Size = new Size(143, 29);
            bntDeletar.TabIndex = 6;
            bntDeletar.Text = "deletar";
            bntDeletar.UseVisualStyleBackColor = false;
            bntDeletar.Click += bntDeletar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Blue;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(231, 114);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(143, 29);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkSlateGray;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.Control;
            btnLimpar.Location = new Point(529, 114);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(155, 29);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { produtoIdDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, valorCompraDataGridViewTextBoxColumn, valorVendaDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = produtoBindingSource;
            dataGridView1.Location = new Point(30, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(730, 235);
            dataGridView1.TabIndex = 51;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            produtoIdDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "D3";
            produtoIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            produtoIdDataGridViewTextBoxColumn.HeaderText = "ProdutoId";
            produtoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            produtoIdDataGridViewTextBoxColumn.ReadOnly = true;
            produtoIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            produtoIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            produtoIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            nomeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // valorCompraDataGridViewTextBoxColumn
            // 
            valorCompraDataGridViewTextBoxColumn.DataPropertyName = "ValorCompra";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            valorCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            valorCompraDataGridViewTextBoxColumn.HeaderText = "ValorCompra";
            valorCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorCompraDataGridViewTextBoxColumn.Name = "valorCompraDataGridViewTextBoxColumn";
            valorCompraDataGridViewTextBoxColumn.ReadOnly = true;
            valorCompraDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            valorCompraDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            valorCompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorVendaDataGridViewTextBoxColumn
            // 
            valorVendaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            valorVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            valorVendaDataGridViewTextBoxColumn.HeaderText = "ValorVenda";
            valorVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorVendaDataGridViewTextBoxColumn.Name = "valorVendaDataGridViewTextBoxColumn";
            valorVendaDataGridViewTextBoxColumn.ReadOnly = true;
            valorVendaDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            valorVendaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            valorVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "D3";
            quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            quantidadeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // lbTeste
            // 
            lbTeste.AutoSize = true;
            lbTeste.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTeste.Location = new Point(305, 18);
            lbTeste.Name = "lbTeste";
            lbTeste.Size = new Size(0, 23);
            lbTeste.TabIndex = 52;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(797, 450);
            Controls.Add(lbTeste);
            Controls.Add(dataGridView1);
            Controls.Add(btnLimpar);
            Controls.Add(btnEditar);
            Controls.Add(bntDeletar);
            Controls.Add(btnCadastrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantidade);
            Controls.Add(txtValorVenda);
            Controls.Add(txtValorCompra);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtValorCompra;
        private TextBox txtValorVenda;
        private TextBox txtQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLimpar;
        private Button button2;
        private Button btnCadastrar;
        private Button bntDeletar;
        private Button btnEditar;
        private Button button4;
        private DataGridView dataGridView1;
        private BindingSource produtoBindingSource;
        private DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private Label lbTeste;
    }
}