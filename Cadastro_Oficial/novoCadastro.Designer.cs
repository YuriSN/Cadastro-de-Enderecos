namespace Cadastro_Oficial
{
    partial class novoCadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(novoCadastro));
            this.txtcep = new MetroFramework.Controls.MetroTextBox();
            this.txtendereco = new MetroFramework.Controls.MetroTextBox();
            this.txtnumero = new MetroFramework.Controls.MetroTextBox();
            this.txtcomplemento = new MetroFramework.Controls.MetroTextBox();
            this.txtbairro = new MetroFramework.Controls.MetroTextBox();
            this.lblcep = new MetroFramework.Controls.MetroLabel();
            this.lblendereco = new MetroFramework.Controls.MetroLabel();
            this.lblnumero = new MetroFramework.Controls.MetroLabel();
            this.lblcomplemento = new MetroFramework.Controls.MetroLabel();
            this.lblbairro = new MetroFramework.Controls.MetroLabel();
            this.lblcidade = new MetroFramework.Controls.MetroLabel();
            this.lblestado = new MetroFramework.Controls.MetroLabel();
            this.cmdsalvar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmdlimpar = new System.Windows.Forms.Button();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.endereçosDataSet1 = new Cadastro_Oficial.EndereçosDataSet1();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeTableAdapter = new Cadastro_Oficial.EndereçosDataSet1TableAdapters.cidadeTableAdapter();
            this.endereçosDataSet2 = new Cadastro_Oficial.EndereçosDataSet2();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoTableAdapter = new Cadastro_Oficial.EndereçosDataSet2TableAdapters.estadoTableAdapter();
            this.txtid = new MetroFramework.Controls.MetroTextBox();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.txtcidade = new MetroFramework.Controls.MetroTextBox();
            this.txtestado = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.endereçosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endereçosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcep
            // 
            // 
            // 
            // 
            this.txtcep.CustomButton.Image = null;
            this.txtcep.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtcep.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcep.CustomButton.Name = "";
            this.txtcep.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.txtcep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcep.CustomButton.TabIndex = 1;
            this.txtcep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcep.CustomButton.UseSelectable = true;
            this.txtcep.CustomButton.Visible = false;
            this.txtcep.Lines = new string[0];
            this.txtcep.Location = new System.Drawing.Point(17, 194);
            this.txtcep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcep.MaxLength = 32767;
            this.txtcep.Name = "txtcep";
            this.txtcep.PasswordChar = '\0';
            this.txtcep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcep.SelectedText = "";
            this.txtcep.SelectionLength = 0;
            this.txtcep.SelectionStart = 0;
            this.txtcep.ShortcutsEnabled = true;
            this.txtcep.Size = new System.Drawing.Size(170, 29);
            this.txtcep.TabIndex = 2;
            this.txtcep.UseSelectable = true;
            this.txtcep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtcep.Click += new System.EventHandler(this.txtcep_Click);
            // 
            // txtendereco
            // 
            // 
            // 
            // 
            this.txtendereco.CustomButton.Image = null;
            this.txtendereco.CustomButton.Location = new System.Drawing.Point(508, 1);
            this.txtendereco.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtendereco.CustomButton.Name = "";
            this.txtendereco.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtendereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtendereco.CustomButton.TabIndex = 1;
            this.txtendereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtendereco.CustomButton.UseSelectable = true;
            this.txtendereco.CustomButton.Visible = false;
            this.txtendereco.Lines = new string[0];
            this.txtendereco.Location = new System.Drawing.Point(202, 194);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtendereco.MaxLength = 32767;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.PasswordChar = '\0';
            this.txtendereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtendereco.SelectedText = "";
            this.txtendereco.SelectionLength = 0;
            this.txtendereco.SelectionStart = 0;
            this.txtendereco.ShortcutsEnabled = true;
            this.txtendereco.Size = new System.Drawing.Size(536, 29);
            this.txtendereco.TabIndex = 3;
            this.txtendereco.UseSelectable = true;
            this.txtendereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtendereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtendereco.Click += new System.EventHandler(this.txtendereco_Click);
            // 
            // txtnumero
            // 
            // 
            // 
            // 
            this.txtnumero.CustomButton.Image = null;
            this.txtnumero.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtnumero.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumero.CustomButton.Name = "";
            this.txtnumero.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtnumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnumero.CustomButton.TabIndex = 1;
            this.txtnumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnumero.CustomButton.UseSelectable = true;
            this.txtnumero.CustomButton.Visible = false;
            this.txtnumero.Lines = new string[0];
            this.txtnumero.Location = new System.Drawing.Point(755, 194);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnumero.MaxLength = 32767;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.PasswordChar = '\0';
            this.txtnumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnumero.SelectedText = "";
            this.txtnumero.SelectionLength = 0;
            this.txtnumero.SelectionStart = 0;
            this.txtnumero.ShortcutsEnabled = true;
            this.txtnumero.Size = new System.Drawing.Size(153, 29);
            this.txtnumero.TabIndex = 4;
            this.txtnumero.UseSelectable = true;
            this.txtnumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtnumero.Click += new System.EventHandler(this.txtnumero_Click);
            // 
            // txtcomplemento
            // 
            // 
            // 
            // 
            this.txtcomplemento.CustomButton.Image = null;
            this.txtcomplemento.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtcomplemento.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcomplemento.CustomButton.Name = "";
            this.txtcomplemento.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.txtcomplemento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcomplemento.CustomButton.TabIndex = 1;
            this.txtcomplemento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcomplemento.CustomButton.UseSelectable = true;
            this.txtcomplemento.CustomButton.Visible = false;
            this.txtcomplemento.Lines = new string[0];
            this.txtcomplemento.Location = new System.Drawing.Point(17, 276);
            this.txtcomplemento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcomplemento.MaxLength = 32767;
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.PasswordChar = '\0';
            this.txtcomplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcomplemento.SelectedText = "";
            this.txtcomplemento.SelectionLength = 0;
            this.txtcomplemento.SelectionStart = 0;
            this.txtcomplemento.ShortcutsEnabled = true;
            this.txtcomplemento.Size = new System.Drawing.Size(170, 29);
            this.txtcomplemento.TabIndex = 5;
            this.txtcomplemento.UseSelectable = true;
            this.txtcomplemento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcomplemento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtcomplemento.Click += new System.EventHandler(this.txtcomplemento_Click);
            // 
            // txtbairro
            // 
            // 
            // 
            // 
            this.txtbairro.CustomButton.Image = null;
            this.txtbairro.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtbairro.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbairro.CustomButton.Name = "";
            this.txtbairro.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.txtbairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbairro.CustomButton.TabIndex = 1;
            this.txtbairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbairro.CustomButton.UseSelectable = true;
            this.txtbairro.CustomButton.Visible = false;
            this.txtbairro.Lines = new string[0];
            this.txtbairro.Location = new System.Drawing.Point(202, 276);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbairro.MaxLength = 32767;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.PasswordChar = '\0';
            this.txtbairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbairro.SelectedText = "";
            this.txtbairro.SelectionLength = 0;
            this.txtbairro.SelectionStart = 0;
            this.txtbairro.ShortcutsEnabled = true;
            this.txtbairro.Size = new System.Drawing.Size(204, 29);
            this.txtbairro.TabIndex = 6;
            this.txtbairro.UseSelectable = true;
            this.txtbairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbairro.Click += new System.EventHandler(this.txtbairro_Click);
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(17, 168);
            this.lblcep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(33, 19);
            this.lblcep.TabIndex = 2;
            this.lblcep.Text = "CEP";
            this.lblcep.Click += new System.EventHandler(this.lblcep_Click);
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(202, 168);
            this.lblendereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(64, 19);
            this.lblendereco.TabIndex = 3;
            this.lblendereco.Text = "Endereço";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(755, 168);
            this.lblnumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(58, 19);
            this.lblnumero.TabIndex = 4;
            this.lblnumero.Text = "Número";
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.Location = new System.Drawing.Point(17, 250);
            this.lblcomplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(94, 19);
            this.lblcomplemento.TabIndex = 5;
            this.lblcomplemento.Text = "Complemento";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(202, 250);
            this.lblbairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(45, 19);
            this.lblbairro.TabIndex = 6;
            this.lblbairro.Text = "Bairro";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(423, 247);
            this.lblcidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(51, 19);
            this.lblcidade.TabIndex = 7;
            this.lblcidade.Text = "Cidade";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(755, 250);
            this.lblestado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(48, 19);
            this.lblestado.TabIndex = 8;
            this.lblestado.Text = "Estado";
            // 
            // cmdsalvar
            // 
            this.cmdsalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdsalvar.BackColor = System.Drawing.Color.Transparent;
            this.cmdsalvar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmdsalvar.ForeColor = System.Drawing.Color.DimGray;
            this.cmdsalvar.ImageIndex = 0;
            this.cmdsalvar.ImageList = this.imageList1;
            this.cmdsalvar.Location = new System.Drawing.Point(617, 37);
            this.cmdsalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdsalvar.Name = "cmdsalvar";
            this.cmdsalvar.Size = new System.Drawing.Size(95, 102);
            this.cmdsalvar.TabIndex = 9;
            this.cmdsalvar.Text = "Salvar";
            this.cmdsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdsalvar.UseVisualStyleBackColor = false;
            this.cmdsalvar.Click += new System.EventHandler(this.cmdsalvar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2_save_52px.png");
            this.imageList1.Images.SetKeyName(1, "broom_52px.png");
            this.imageList1.Images.SetKeyName(2, "password_reset_52px.png");
            // 
            // cmdlimpar
            // 
            this.cmdlimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdlimpar.BackColor = System.Drawing.Color.Transparent;
            this.cmdlimpar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmdlimpar.ForeColor = System.Drawing.Color.DimGray;
            this.cmdlimpar.ImageIndex = 1;
            this.cmdlimpar.ImageList = this.imageList1;
            this.cmdlimpar.Location = new System.Drawing.Point(769, 37);
            this.cmdlimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdlimpar.Name = "cmdlimpar";
            this.cmdlimpar.Size = new System.Drawing.Size(95, 102);
            this.cmdlimpar.TabIndex = 10;
            this.cmdlimpar.Text = "Limpar";
            this.cmdlimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdlimpar.UseVisualStyleBackColor = false;
            this.cmdlimpar.Click += new System.EventHandler(this.cmdlimpar_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(17, 63);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(272, 29);
            this.metroDateTime1.TabIndex = 11;
            // 
            // endereçosDataSet1
            // 
            this.endereçosDataSet1.DataSetName = "EndereçosDataSet1";
            this.endereçosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.endereçosDataSet1;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // endereçosDataSet2
            // 
            this.endereçosDataSet2.DataSetName = "EndereçosDataSet2";
            this.endereçosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "estado";
            this.estadoBindingSource.DataSource = this.endereçosDataSet2;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // txtid
            // 
            // 
            // 
            // 
            this.txtid.CustomButton.Image = null;
            this.txtid.CustomButton.Location = new System.Drawing.Point(8, 1);
            this.txtid.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid.CustomButton.Name = "";
            this.txtid.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.txtid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtid.CustomButton.TabIndex = 1;
            this.txtid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtid.CustomButton.UseSelectable = true;
            this.txtid.CustomButton.Visible = false;
            this.txtid.Lines = new string[0];
            this.txtid.Location = new System.Drawing.Point(17, 129);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid.MaxLength = 32767;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.ShortcutsEnabled = true;
            this.txtid.Size = new System.Drawing.Size(38, 29);
            this.txtid.TabIndex = 1;
            this.txtid.UseSelectable = true;
            this.txtid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtid.Click += new System.EventHandler(this.txtid_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 110);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 19);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // txtcidade
            // 
            // 
            // 
            // 
            this.txtcidade.CustomButton.Image = null;
            this.txtcidade.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.txtcidade.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcidade.CustomButton.Name = "";
            this.txtcidade.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtcidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcidade.CustomButton.TabIndex = 1;
            this.txtcidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcidade.CustomButton.UseSelectable = true;
            this.txtcidade.CustomButton.Visible = false;
            this.txtcidade.Lines = new string[0];
            this.txtcidade.Location = new System.Drawing.Point(423, 276);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcidade.MaxLength = 32767;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.PasswordChar = '\0';
            this.txtcidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcidade.SelectedText = "";
            this.txtcidade.SelectionLength = 0;
            this.txtcidade.SelectionStart = 0;
            this.txtcidade.ShortcutsEnabled = true;
            this.txtcidade.Size = new System.Drawing.Size(315, 29);
            this.txtcidade.TabIndex = 7;
            this.txtcidade.UseSelectable = true;
            this.txtcidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtcidade.Click += new System.EventHandler(this.txtcidade_Click);
            // 
            // txtestado
            // 
            // 
            // 
            // 
            this.txtestado.CustomButton.Image = null;
            this.txtestado.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtestado.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtestado.CustomButton.Name = "";
            this.txtestado.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.txtestado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtestado.CustomButton.TabIndex = 1;
            this.txtestado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtestado.CustomButton.UseSelectable = true;
            this.txtestado.CustomButton.Visible = false;
            this.txtestado.Lines = new string[0];
            this.txtestado.Location = new System.Drawing.Point(755, 276);
            this.txtestado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtestado.MaxLength = 32767;
            this.txtestado.Name = "txtestado";
            this.txtestado.PasswordChar = '\0';
            this.txtestado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtestado.SelectedText = "";
            this.txtestado.SelectionLength = 0;
            this.txtestado.SelectionStart = 0;
            this.txtestado.ShortcutsEnabled = true;
            this.txtestado.Size = new System.Drawing.Size(153, 29);
            this.txtestado.TabIndex = 8;
            this.txtestado.UseSelectable = true;
            this.txtestado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtestado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtestado.Click += new System.EventHandler(this.txtestado_Click);
            // 
            // novoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 383);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.cmdlimpar);
            this.Controls.Add(this.cmdsalvar);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblcomplemento);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcep);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "novoCadastro";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Novo Cadastro";
            this.Load += new System.EventHandler(this.novoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.endereçosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endereçosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblcep;
        private MetroFramework.Controls.MetroLabel lblendereco;
        private MetroFramework.Controls.MetroLabel lblnumero;
        private MetroFramework.Controls.MetroLabel lblcomplemento;
        private MetroFramework.Controls.MetroLabel lblbairro;
        private MetroFramework.Controls.MetroLabel lblcidade;
        private MetroFramework.Controls.MetroLabel lblestado;
        private System.Windows.Forms.Button cmdsalvar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button cmdlimpar;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private EndereçosDataSet1 endereçosDataSet1;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private EndereçosDataSet1TableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private EndereçosDataSet2 endereçosDataSet2;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private EndereçosDataSet2TableAdapters.estadoTableAdapter estadoTableAdapter;
        public MetroFramework.Controls.MetroTextBox txtcep;
        public MetroFramework.Controls.MetroTextBox txtendereco;
        public MetroFramework.Controls.MetroTextBox txtnumero;
        public MetroFramework.Controls.MetroTextBox txtcomplemento;
        public MetroFramework.Controls.MetroTextBox txtbairro;
        public MetroFramework.Controls.MetroTextBox txtid;
        public MetroFramework.Controls.MetroLabel lblID;
        public MetroFramework.Controls.MetroTextBox txtcidade;
        public MetroFramework.Controls.MetroTextBox txtestado;
    }
}