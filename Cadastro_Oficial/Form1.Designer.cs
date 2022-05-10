namespace Cadastro_Oficial
{
    partial class CadastroEnd
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEnd));
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.endereçosDataSet = new Cadastro_Oficial.EndereçosDataSet();
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter = new Cadastro_Oficial.EndereçosDataSetTableAdapters.CadastroTableAdapter();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tltnovoCadastro = new MetroFramework.Controls.MetroTile();
            this.tltpesquisar = new MetroFramework.Controls.MetroTile();
            this.txtpesquisar = new MetroFramework.Controls.MetroTextBox();
            this.tltdeletar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.endereçosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime1.Location = new System.Drawing.Point(381, 30);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(347, 30);
            this.metroDateTime1.TabIndex = 0;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // endereçosDataSet
            // 
            this.endereçosDataSet.DataSetName = "EndereçosDataSet";
            this.endereçosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataMember = "Cadastro";
            this.cadastroBindingSource.DataSource = this.endereçosDataSet;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.endereçoDataGridViewTextBoxColumn,
            this.númeroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.metroGrid.DataSource = this.cadastroBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(5, 202);
            this.metroGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid.RowHeadersVisible = false;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.RowTemplate.Height = 24;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(1421, 561);
            this.metroGrid.TabIndex = 1;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellClick);
            this.metroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellContentClick);
            this.metroGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 32;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.Width = 67;
            // 
            // endereçoDataGridViewTextBoxColumn
            // 
            this.endereçoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.Name = "endereçoDataGridViewTextBoxColumn";
            // 
            // númeroDataGridViewTextBoxColumn
            // 
            this.númeroDataGridViewTextBoxColumn.DataPropertyName = "Número";
            this.númeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.númeroDataGridViewTextBoxColumn.Name = "númeroDataGridViewTextBoxColumn";
            this.númeroDataGridViewTextBoxColumn.Width = 102;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.Width = 151;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.Width = 86;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.Width = 93;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 90;
            // 
            // tltnovoCadastro
            // 
            this.tltnovoCadastro.ActiveControl = null;
            this.tltnovoCadastro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tltnovoCadastro.Location = new System.Drawing.Point(1515, 566);
            this.tltnovoCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tltnovoCadastro.Name = "tltnovoCadastro";
            this.tltnovoCadastro.Size = new System.Drawing.Size(244, 137);
            this.tltnovoCadastro.TabIndex = 3;
            this.tltnovoCadastro.Text = "Novo Cadastro";
            this.tltnovoCadastro.TileImage = ((System.Drawing.Image)(resources.GetObject("tltnovoCadastro.TileImage")));
            this.tltnovoCadastro.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltnovoCadastro.UseSelectable = true;
            this.tltnovoCadastro.UseTileImage = true;
            this.tltnovoCadastro.Click += new System.EventHandler(this.tltnovoCadastro_Click);
            // 
            // tltpesquisar
            // 
            this.tltpesquisar.ActiveControl = null;
            this.tltpesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tltpesquisar.Location = new System.Drawing.Point(1513, 181);
            this.tltpesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tltpesquisar.Name = "tltpesquisar";
            this.tltpesquisar.Size = new System.Drawing.Size(244, 137);
            this.tltpesquisar.TabIndex = 4;
            this.tltpesquisar.Text = "Pesquisar CEP/ Endereço";
            this.tltpesquisar.TileImage = ((System.Drawing.Image)(resources.GetObject("tltpesquisar.TileImage")));
            this.tltpesquisar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltpesquisar.UseSelectable = true;
            this.tltpesquisar.UseTileImage = true;
            this.tltpesquisar.Click += new System.EventHandler(this.tltpesquisar_Click);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.txtpesquisar.CustomButton.Image = null;
            this.txtpesquisar.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtpesquisar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpesquisar.CustomButton.Name = "";
            this.txtpesquisar.CustomButton.Size = new System.Drawing.Size(36, 33);
            this.txtpesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpesquisar.CustomButton.TabIndex = 1;
            this.txtpesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpesquisar.CustomButton.UseSelectable = true;
            this.txtpesquisar.CustomButton.Visible = false;
            this.txtpesquisar.Lines = new string[0];
            this.txtpesquisar.Location = new System.Drawing.Point(1513, 143);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpesquisar.MaxLength = 32767;
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.PasswordChar = '\0';
            this.txtpesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpesquisar.SelectedText = "";
            this.txtpesquisar.SelectionLength = 0;
            this.txtpesquisar.SelectionStart = 0;
            this.txtpesquisar.ShortcutsEnabled = true;
            this.txtpesquisar.Size = new System.Drawing.Size(245, 32);
            this.txtpesquisar.TabIndex = 5;
            this.txtpesquisar.UseSelectable = true;
            this.txtpesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpesquisar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tltdeletar
            // 
            this.tltdeletar.ActiveControl = null;
            this.tltdeletar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tltdeletar.Location = new System.Drawing.Point(1513, 373);
            this.tltdeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tltdeletar.Name = "tltdeletar";
            this.tltdeletar.Size = new System.Drawing.Size(243, 137);
            this.tltdeletar.TabIndex = 6;
            this.tltdeletar.Text = "Deletar";
            this.tltdeletar.TileImage = ((System.Drawing.Image)(resources.GetObject("tltdeletar.TileImage")));
            this.tltdeletar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltdeletar.UseSelectable = true;
            this.tltdeletar.UseTileImage = true;
            this.tltdeletar.Click += new System.EventHandler(this.tltdeletar_Click);
            // 
            // CadastroEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 878);
            this.Controls.Add(this.tltdeletar);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.tltpesquisar);
            this.Controls.Add(this.tltnovoCadastro);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.metroDateTime1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CadastroEnd";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Cadastro de Endereço";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.endereçosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private EndereçosDataSet endereçosDataSet;
        private System.Windows.Forms.BindingSource cadastroBindingSource;
        private EndereçosDataSetTableAdapters.CadastroTableAdapter cadastroTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroTile tltnovoCadastro;
        private MetroFramework.Controls.MetroTile tltpesquisar;
        private MetroFramework.Controls.MetroTextBox txtpesquisar;
        private MetroFramework.Controls.MetroTile tltdeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}

