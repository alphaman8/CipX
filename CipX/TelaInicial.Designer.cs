namespace CipX
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.button1 = new CipX.components.ButtonImage(this.components);
            this.listGPS = new System.Windows.Forms.ListBox();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.usuarioTableAdapter();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postehastipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter();
            this.postehasusomutuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_uso_mutuoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter();
            this.ativacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ativacaoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter();
            this.bracoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bracoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter();
            this.faseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faseTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter();
            this.condicaoriscoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condicao_riscoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.condicao_riscoTableAdapter();
            this.lampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter();
            this.tipolampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.tipo_lampadaTableAdapter();
            this.posteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posteTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter();
            this.trafoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trafoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter();
            this.reatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reatorTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.reatorTableAdapter();
            this.programacaoipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programacao_ipTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.programacao_ipTableAdapter();
            this.usomutuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uso_mutuoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.uso_mutuoTableAdapter();
            this.timerVerificarGps = new System.Windows.Forms.Timer();
            this.tipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.tipo_luminariaTableAdapter();
            this.chavecomandoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chave_comandoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.chave_comandoTableAdapter();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoriscoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipolampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programacaoipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usomutuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chavecomandoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nomeLabel.Location = new System.Drawing.Point(6, 7);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(66, 14);
            nomeLabel.Text = "Usuário";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.menuItem7);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Cadastrar";
            this.menuItem6.Click += new System.EventHandler(this.cadastrar);
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Importar Dados";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.MenuItems.Add(this.menuItem5);
            this.menuItem3.Text = "GPS";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Conectar";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar";
            this.button1.Click += new System.EventHandler(this.cadastrar);
            // 
            // listGPS
            // 
            this.listGPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listGPS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listGPS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.listGPS.ForeColor = System.Drawing.Color.Lime;
            this.listGPS.Location = new System.Drawing.Point(0, 155);
            this.listGPS.Name = "listGPS";
            this.listGPS.Size = new System.Drawing.Size(240, 119);
            this.listGPS.TabIndex = 1;
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.DataSource = this.usuarioBindingSource;
            this.nomeComboBox.DisplayMember = "nome";
            this.nomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.nomeComboBox.Location = new System.Drawing.Point(6, 24);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(158, 22);
            this.nomeComboBox.TabIndex = 3;
            this.nomeComboBox.ValueMember = "nome";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "label1";
            this.label1.Visible = false;
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
            // postehasusomutuoBindingSource
            // 
            this.postehasusomutuoBindingSource.DataMember = "poste_has_uso_mutuo";
            this.postehasusomutuoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_uso_mutuoTableAdapter
            // 
            this.poste_has_uso_mutuoTableAdapter.ClearBeforeFill = true;
            // 
            // ativacaoBindingSource
            // 
            this.ativacaoBindingSource.DataMember = "ativacao";
            this.ativacaoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // ativacaoTableAdapter
            // 
            this.ativacaoTableAdapter.ClearBeforeFill = true;
            // 
            // bracoBindingSource
            // 
            this.bracoBindingSource.DataMember = "braco";
            this.bracoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // bracoTableAdapter
            // 
            this.bracoTableAdapter.ClearBeforeFill = true;
            // 
            // faseBindingSource
            // 
            this.faseBindingSource.DataMember = "fase";
            this.faseBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // faseTableAdapter
            // 
            this.faseTableAdapter.ClearBeforeFill = true;
            // 
            // condicaoriscoBindingSource
            // 
            this.condicaoriscoBindingSource.DataMember = "condicao_risco";
            this.condicaoriscoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // condicao_riscoTableAdapter
            // 
            this.condicao_riscoTableAdapter.ClearBeforeFill = true;
            // 
            // lampadaBindingSource
            // 
            this.lampadaBindingSource.DataMember = "lampada";
            this.lampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // lampadaTableAdapter
            // 
            this.lampadaTableAdapter.ClearBeforeFill = true;
            // 
            // tipolampadaBindingSource
            // 
            this.tipolampadaBindingSource.DataMember = "tipo_lampada";
            this.tipolampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // tipo_lampadaTableAdapter
            // 
            this.tipo_lampadaTableAdapter.ClearBeforeFill = true;
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
            // trafoBindingSource
            // 
            this.trafoBindingSource.DataMember = "trafo";
            this.trafoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // trafoTableAdapter
            // 
            this.trafoTableAdapter.ClearBeforeFill = true;
            // 
            // reatorBindingSource
            // 
            this.reatorBindingSource.DataMember = "reator";
            this.reatorBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // reatorTableAdapter
            // 
            this.reatorTableAdapter.ClearBeforeFill = true;
            // 
            // programacaoipBindingSource
            // 
            this.programacaoipBindingSource.DataMember = "programacao_ip";
            this.programacaoipBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // programacao_ipTableAdapter
            // 
            this.programacao_ipTableAdapter.ClearBeforeFill = true;
            // 
            // usomutuoBindingSource
            // 
            this.usomutuoBindingSource.DataMember = "uso_mutuo";
            this.usomutuoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // uso_mutuoTableAdapter
            // 
            this.uso_mutuoTableAdapter.ClearBeforeFill = true;
            // 
            // timerVerificarGps
            // 
            this.timerVerificarGps.Tick += new System.EventHandler(this.timerVerificarGps_Tick);
            // 
            // tipoluminariaBindingSource
            // 
            this.tipoluminariaBindingSource.DataMember = "tipo_luminaria";
            this.tipoluminariaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // tipo_luminariaTableAdapter
            // 
            this.tipo_luminariaTableAdapter.ClearBeforeFill = true;
            // 
            // chavecomandoBindingSource
            // 
            this.chavecomandoBindingSource.DataMember = "chave_comando";
            this.chavecomandoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // chave_comandoTableAdapter
            // 
            this.chave_comandoTableAdapter.ClearBeforeFill = true;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeComboBox);
            this.Controls.Add(this.listGPS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoriscoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipolampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programacaoipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usomutuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chavecomandoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.components.ButtonImage button1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.ListBox listGPS;
        private System.Windows.Forms.MenuItem menuItem6;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource postehastipoluminariaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter poste_has_tipo_luminariaTableAdapter;
        private System.Windows.Forms.BindingSource postehasusomutuoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter poste_has_uso_mutuoTableAdapter;
        private System.Windows.Forms.BindingSource ativacaoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter ativacaoTableAdapter;
        private System.Windows.Forms.BindingSource bracoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter bracoTableAdapter;
        private System.Windows.Forms.BindingSource faseBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter faseTableAdapter;
        private System.Windows.Forms.BindingSource condicaoriscoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.condicao_riscoTableAdapter condicao_riscoTableAdapter;
        private System.Windows.Forms.BindingSource lampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter lampadaTableAdapter;
        private System.Windows.Forms.BindingSource tipolampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.tipo_lampadaTableAdapter tipo_lampadaTableAdapter;
        private System.Windows.Forms.BindingSource posteBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter posteTableAdapter;
        private System.Windows.Forms.BindingSource trafoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter trafoTableAdapter;
        private System.Windows.Forms.BindingSource reatorBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.reatorTableAdapter reatorTableAdapter;
        private System.Windows.Forms.BindingSource programacaoipBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.programacao_ipTableAdapter programacao_ipTableAdapter;
        private System.Windows.Forms.BindingSource usomutuoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.uso_mutuoTableAdapter uso_mutuoTableAdapter;
        private System.Windows.Forms.Timer timerVerificarGps;
        private System.Windows.Forms.BindingSource tipoluminariaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.tipo_luminariaTableAdapter tipo_luminariaTableAdapter;
        private System.Windows.Forms.BindingSource chavecomandoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.chave_comandoTableAdapter chave_comandoTableAdapter;
    }
}