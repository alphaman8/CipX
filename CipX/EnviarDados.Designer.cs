namespace CipX
{
    partial class EnviarDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarDados));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.trafoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trafoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter();
            this.listEnviar = new System.Windows.Forms.ListBox();
            this.posteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posteTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter();
            this.postehaslampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btEnviar = new CipX.components.ButtonImage(this.components);
            this.postehasreatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postehasusomutuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_uso_mutuoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter();
            this.postehastipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usuarioTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.usuarioTableAdapter();
            this.listTrafos = new System.Windows.Forms.ListBox();
            this.listEnviaveis = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkEnviarTudo = new System.Windows.Forms.CheckBox();
            nomeLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehaslampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasreatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nomeLabel.Location = new System.Drawing.Point(19, 14);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(45, 14);
            nomeLabel.Text = "nome:";
            // 
            // senhaLabel
            // 
            senhaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            senhaLabel.Location = new System.Drawing.Point(17, 45);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(47, 14);
            senhaLabel.Text = "senha:";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(5, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 16);
            label1.Text = "trafos:";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(134, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 16);
            label2.Text = "enviar:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Login";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trafoBindingSource
            // 
            this.trafoBindingSource.DataMember = "trafo";
            this.trafoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // trafoTableAdapter
            // 
            this.trafoTableAdapter.ClearBeforeFill = true;
            // 
            // listEnviar
            // 
            this.listEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listEnviar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.listEnviar.ForeColor = System.Drawing.Color.Lime;
            this.listEnviar.Location = new System.Drawing.Point(0, 214);
            this.listEnviar.Name = "listEnviar";
            this.listEnviar.Size = new System.Drawing.Size(240, 80);
            this.listEnviar.TabIndex = 2;
            // 
            // posteBindingSource
            // 
            this.posteBindingSource.DataMember = "poste";
            this.posteBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // posteTableAdapter
            // 
            this.posteTableAdapter.ClearBeforeFill = true;
            // 
            // postehaslampadaBindingSource
            // 
            this.postehaslampadaBindingSource.DataMember = "poste_has_lampada";
            this.postehaslampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // btEnviar
            // 
            this.btEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btEnviar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEnviar.Enabled = false;
            this.btEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btEnviar.Image")));
            this.btEnviar.Location = new System.Drawing.Point(0, 0);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(240, 37);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // postehasreatorBindingSource
            // 
            this.postehasreatorBindingSource.DataMember = "poste_has_reator";
            this.postehasreatorBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // postehasusomutuoBindingSource
            // 
            this.postehasusomutuoBindingSource.DataMember = "poste_has_uso_mutuo";
            this.postehasusomutuoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_uso_mutuoTableAdapter
            // 
            this.poste_has_uso_mutuoTableAdapter.ClearBeforeFill = true;
            // 
            // postehastipoluminariaBindingSource
            // 
            this.postehastipoluminariaBindingSource.DataMember = "poste_has_tipo_luminaria";
            this.postehastipoluminariaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_tipo_luminariaTableAdapter
            // 
            this.poste_has_tipo_luminariaTableAdapter.ClearBeforeFill = true;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelLogin.Controls.Add(senhaLabel);
            this.panelLogin.Controls.Add(this.senhaTextBox);
            this.panelLogin.Controls.Add(nomeLabel);
            this.panelLogin.Controls.Add(this.nomeComboBox);
            this.panelLogin.Controls.Add(this.button3);
            this.panelLogin.Controls.Add(this.button2);
            this.panelLogin.Location = new System.Drawing.Point(23, 180);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(197, 111);
            this.panelLogin.Visible = false;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(71, 42);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(100, 21);
            this.senhaTextBox.TabIndex = 5;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "id", true));
            this.nomeComboBox.DataSource = this.usuarioBindingSource;
            this.nomeComboBox.DisplayMember = "nome";
            this.nomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.nomeComboBox.Location = new System.Drawing.Point(71, 14);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(100, 22);
            this.nomeComboBox.TabIndex = 3;
            this.nomeComboBox.ValueMember = "id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 20);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cancelar";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 20);
            this.button2.TabIndex = 0;
            this.button2.Text = "Confirmar";
            this.button2.Click += new System.EventHandler(this.login);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // listTrafos
            // 
            this.listTrafos.DataSource = this.trafoBindingSource;
            this.listTrafos.DisplayMember = "chave";
            this.listTrafos.Location = new System.Drawing.Point(8, 88);
            this.listTrafos.Name = "listTrafos";
            this.listTrafos.Size = new System.Drawing.Size(100, 114);
            this.listTrafos.TabIndex = 7;
            this.listTrafos.ValueMember = "chave";
            // 
            // listEnviaveis
            // 
            this.listEnviaveis.Location = new System.Drawing.Point(137, 88);
            this.listEnviaveis.Name = "listEnviaveis";
            this.listEnviaveis.Size = new System.Drawing.Size(100, 114);
            this.listEnviaveis.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = ">";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(17, 20);
            this.button4.TabIndex = 12;
            this.button4.Text = "<";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkEnviarTudo
            // 
            this.chkEnviarTudo.Checked = true;
            this.chkEnviarTudo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnviarTudo.Location = new System.Drawing.Point(3, 41);
            this.chkEnviarTudo.Name = "chkEnviarTudo";
            this.chkEnviarTudo.Size = new System.Drawing.Size(100, 20);
            this.chkEnviarTudo.TabIndex = 13;
            this.chkEnviarTudo.Text = "Enviar Tudo";
            // 
            // EnviarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.chkEnviarTudo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.listEnviar);
            this.Controls.Add(this.listTrafos);
            this.Controls.Add(this.listEnviaveis);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "EnviarDados";
            this.Text = "EnviarDados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EnviarDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehaslampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasreatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).EndInit();
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource trafoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter trafoTableAdapter;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.ListBox listEnviar;
        private System.Windows.Forms.BindingSource posteBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter posteTableAdapter;
        private CipX.components.ButtonImage btEnviar;
        private System.Windows.Forms.BindingSource postehaslampadaBindingSource;
        private System.Windows.Forms.BindingSource postehasreatorBindingSource;
        private System.Windows.Forms.BindingSource postehasusomutuoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter poste_has_uso_mutuoTableAdapter;
        private System.Windows.Forms.BindingSource postehastipoluminariaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter poste_has_tipo_luminariaTableAdapter;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private System.Windows.Forms.ListBox listTrafos;
        private System.Windows.Forms.ListBox listEnviaveis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkEnviarTudo;
    }
}