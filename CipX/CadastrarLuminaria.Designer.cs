namespace CipX
{
    partial class CadastrarLuminaria
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
            System.Windows.Forms.Label tipo_luminaria_idLabel;
            System.Windows.Forms.Label poste_idLabel;
            System.Windows.Forms.Label lampada_idLabel;
            System.Windows.Forms.Label braco_idLabel;
            System.Windows.Forms.Label ativacao_idLabel;
            System.Windows.Forms.Label fase_idLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label chave_comandoLabel;
            System.Windows.Forms.Label latLabel;
            System.Windows.Forms.Label lonLabel;
            System.Windows.Forms.Label gps_timeLabel;
            System.Windows.Forms.DataGridTextBoxColumn quantidadeDataGridColumnStyleDataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn lampadaDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn luminariaDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.Label reator_idLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.luminariasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luminariasDataGrid = new System.Windows.Forms.DataGrid();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.luminariasTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chavecomandoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbChaveComando = new System.Windows.Forms.ComboBox();
            this.postehastipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.faseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbFaseId = new System.Windows.Forms.ComboBox();
            this.ativacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbAtivacao = new System.Windows.Forms.ComboBox();
            this.bracoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbBraco = new System.Windows.Forms.ComboBox();
            this.lampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbLampada = new System.Windows.Forms.ComboBox();
            this.tipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTipoLum = new System.Windows.Forms.ComboBox();
            this.poste_idTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkRepetir = new System.Windows.Forms.CheckBox();
            this.reatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbReator = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gps_timeTextBox = new System.Windows.Forms.TextBox();
            this.lonTextBox = new System.Windows.Forms.TextBox();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.foto_pathTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.poste_has_tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter();
            this.tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.tipo_luminariaTableAdapter();
            this.lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter();
            this.reatorTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.reatorTableAdapter();
            this.bracoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter();
            this.ativacaoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter();
            this.faseTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter();
            this.chave_comandoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.chave_comandoTableAdapter();
            this.luminariasTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.luminariasTableAdapter();
            this.chkDerivacao = new System.Windows.Forms.CheckBox();
            tipo_luminaria_idLabel = new System.Windows.Forms.Label();
            poste_idLabel = new System.Windows.Forms.Label();
            lampada_idLabel = new System.Windows.Forms.Label();
            braco_idLabel = new System.Windows.Forms.Label();
            ativacao_idLabel = new System.Windows.Forms.Label();
            fase_idLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            chave_comandoLabel = new System.Windows.Forms.Label();
            latLabel = new System.Windows.Forms.Label();
            lonLabel = new System.Windows.Forms.Label();
            gps_timeLabel = new System.Windows.Forms.Label();
            quantidadeDataGridColumnStyleDataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            lampadaDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            luminariaDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            reator_idLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luminariasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chavecomandoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reatorBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipo_luminaria_idLabel
            // 
            tipo_luminaria_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tipo_luminaria_idLabel.Location = new System.Drawing.Point(4, 11);
            tipo_luminaria_idLabel.Name = "tipo_luminaria_idLabel";
            tipo_luminaria_idLabel.Size = new System.Drawing.Size(110, 14);
            tipo_luminaria_idLabel.Text = "tipo luminaria id:";
            // 
            // poste_idLabel
            // 
            poste_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            poste_idLabel.Location = new System.Drawing.Point(52, 230);
            poste_idLabel.Name = "poste_idLabel";
            poste_idLabel.Size = new System.Drawing.Size(61, 14);
            poste_idLabel.Text = "poste id:";
            poste_idLabel.Visible = false;
            // 
            // lampada_idLabel
            // 
            lampada_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            lampada_idLabel.Location = new System.Drawing.Point(36, 38);
            lampada_idLabel.Name = "lampada_idLabel";
            lampada_idLabel.Size = new System.Drawing.Size(77, 14);
            lampada_idLabel.Text = "lampada id:";
            // 
            // braco_idLabel
            // 
            braco_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            braco_idLabel.Location = new System.Drawing.Point(53, 62);
            braco_idLabel.Name = "braco_idLabel";
            braco_idLabel.Size = new System.Drawing.Size(60, 14);
            braco_idLabel.Text = "braco id:";
            // 
            // ativacao_idLabel
            // 
            ativacao_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ativacao_idLabel.Location = new System.Drawing.Point(36, 93);
            ativacao_idLabel.Name = "ativacao_idLabel";
            ativacao_idLabel.Size = new System.Drawing.Size(77, 14);
            ativacao_idLabel.Text = "ativacao id:";
            // 
            // fase_idLabel
            // 
            fase_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            fase_idLabel.Location = new System.Drawing.Point(62, 120);
            fase_idLabel.Name = "fase_idLabel";
            fase_idLabel.Size = new System.Drawing.Size(51, 14);
            fase_idLabel.Text = "fase id:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            quantidadeLabel.Location = new System.Drawing.Point(32, 177);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(81, 14);
            quantidadeLabel.Text = "quantidade:";
            // 
            // chave_comandoLabel
            // 
            chave_comandoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            chave_comandoLabel.Location = new System.Drawing.Point(7, 148);
            chave_comandoLabel.Name = "chave_comandoLabel";
            chave_comandoLabel.Size = new System.Drawing.Size(106, 14);
            chave_comandoLabel.Text = "chave comando:";
            // 
            // latLabel
            // 
            latLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            latLabel.Location = new System.Drawing.Point(50, 61);
            latLabel.Name = "latLabel";
            latLabel.Size = new System.Drawing.Size(27, 14);
            latLabel.Text = "lat:";
            // 
            // lonLabel
            // 
            lonLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            lonLabel.Location = new System.Drawing.Point(47, 88);
            lonLabel.Name = "lonLabel";
            lonLabel.Size = new System.Drawing.Size(30, 14);
            lonLabel.Text = "lon:";
            // 
            // gps_timeLabel
            // 
            gps_timeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            gps_timeLabel.Location = new System.Drawing.Point(13, 115);
            gps_timeLabel.Name = "gps_timeLabel";
            gps_timeLabel.Size = new System.Drawing.Size(64, 14);
            gps_timeLabel.Text = "gps time:";
            // 
            // quantidadeDataGridColumnStyleDataGridTextBoxColumn1
            // 
            quantidadeDataGridColumnStyleDataGridTextBoxColumn1.Format = "";
            quantidadeDataGridColumnStyleDataGridTextBoxColumn1.FormatInfo = null;
            quantidadeDataGridColumnStyleDataGridTextBoxColumn1.HeaderText = "quantidade";
            quantidadeDataGridColumnStyleDataGridTextBoxColumn1.MappingName = "quantidade";
            quantidadeDataGridColumnStyleDataGridTextBoxColumn1.NullText = "";
            quantidadeDataGridColumnStyleDataGridTextBoxColumn1.Width = 80;
            // 
            // lampadaDataGridColumnStyleDataGridTextBoxColumn
            // 
            lampadaDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            lampadaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            lampadaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "lâmpada";
            lampadaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "lampada";
            lampadaDataGridColumnStyleDataGridTextBoxColumn.Width = 120;
            // 
            // luminariaDataGridColumnStyleDataGridTextBoxColumn
            // 
            luminariaDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            luminariaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            luminariaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "luminária";
            luminariaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "luminaria";
            luminariaDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // reator_idLabel
            // 
            reator_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            reator_idLabel.Location = new System.Drawing.Point(18, 10);
            reator_idLabel.Name = "reator_idLabel";
            reator_idLabel.Size = new System.Drawing.Size(64, 14);
            reator_idLabel.Text = "reator id:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Novo";
            this.menuItem4.Click += new System.EventHandler(this.novo);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Salvar";
            this.menuItem5.Click += new System.EventHandler(this.salvar);
            // 
            // menuItem6
            // 
            this.menuItem6.MenuItems.Add(this.menuItem7);
            this.menuItem6.Text = "Mais";
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Excluir";
            this.menuItem7.Click += new System.EventHandler(this.excluir);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 274);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.luminariasDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 251);
            this.tabPage1.Text = "Tabela";
            // 
            // luminariasBindingSource
            // 
            this.luminariasBindingSource.DataMember = "luminarias";
            this.luminariasBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // luminariasDataGrid
            // 
            this.luminariasDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.luminariasDataGrid.DataSource = this.luminariasBindingSource;
            this.luminariasDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.luminariasDataGrid.Location = new System.Drawing.Point(0, 0);
            this.luminariasDataGrid.Name = "luminariasDataGrid";
            this.luminariasDataGrid.RowHeadersVisible = false;
            this.luminariasDataGrid.Size = new System.Drawing.Size(240, 248);
            this.luminariasDataGrid.TabIndex = 2;
            this.luminariasDataGrid.TableStyles.Add(this.luminariasTableStyleDataGridTableStyle);
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luminariasTableStyleDataGridTableStyle
            // 
            this.luminariasTableStyleDataGridTableStyle.GridColumnStyles.Add(luminariaDataGridColumnStyleDataGridTextBoxColumn);
            this.luminariasTableStyleDataGridTableStyle.GridColumnStyles.Add(lampadaDataGridColumnStyleDataGridTextBoxColumn);
            this.luminariasTableStyleDataGridTableStyle.GridColumnStyles.Add(quantidadeDataGridColumnStyleDataGridTextBoxColumn1);
            this.luminariasTableStyleDataGridTableStyle.MappingName = "luminarias";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbChaveComando);
            this.tabPage2.Controls.Add(chave_comandoLabel);
            this.tabPage2.Controls.Add(quantidadeLabel);
            this.tabPage2.Controls.Add(this.quantidadeTextBox);
            this.tabPage2.Controls.Add(this.cbFaseId);
            this.tabPage2.Controls.Add(this.cbAtivacao);
            this.tabPage2.Controls.Add(fase_idLabel);
            this.tabPage2.Controls.Add(ativacao_idLabel);
            this.tabPage2.Controls.Add(this.cbBraco);
            this.tabPage2.Controls.Add(braco_idLabel);
            this.tabPage2.Controls.Add(this.cbLampada);
            this.tabPage2.Controls.Add(lampada_idLabel);
            this.tabPage2.Controls.Add(this.cbTipoLum);
            this.tabPage2.Controls.Add(tipo_luminaria_idLabel);
            this.tabPage2.Controls.Add(poste_idLabel);
            this.tabPage2.Controls.Add(this.poste_idTextBox);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 248);
            this.tabPage2.Text = "Formulário I";
            // 
            // chavecomandoBindingSource
            // 
            this.chavecomandoBindingSource.DataMember = "chave_comando";
            this.chavecomandoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // cbChaveComando
            // 
            this.cbChaveComando.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "chave_comando", true));
            this.cbChaveComando.DataSource = this.chavecomandoBindingSource;
            this.cbChaveComando.DisplayMember = "descricao";
            this.cbChaveComando.Location = new System.Drawing.Point(114, 146);
            this.cbChaveComando.Name = "cbChaveComando";
            this.cbChaveComando.Size = new System.Drawing.Size(119, 22);
            this.cbChaveComando.TabIndex = 32;
            this.cbChaveComando.ValueMember = "id";
            // 
            // postehastipoluminariaBindingSource
            // 
            this.postehastipoluminariaBindingSource.DataMember = "poste_has_tipo_luminaria";
            this.postehastipoluminariaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(114, 174);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(119, 21);
            this.quantidadeTextBox.TabIndex = 31;
            this.quantidadeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidadeTextBox_KeyPress);
            // 
            // faseBindingSource
            // 
            this.faseBindingSource.DataMember = "fase";
            this.faseBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // cbFaseId
            // 
            this.cbFaseId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "fase_id", true));
            this.cbFaseId.DataSource = this.faseBindingSource;
            this.cbFaseId.DisplayMember = "descricao";
            this.cbFaseId.Location = new System.Drawing.Point(114, 118);
            this.cbFaseId.Name = "cbFaseId";
            this.cbFaseId.Size = new System.Drawing.Size(119, 22);
            this.cbFaseId.TabIndex = 22;
            this.cbFaseId.ValueMember = "id";
            // 
            // ativacaoBindingSource
            // 
            this.ativacaoBindingSource.DataMember = "ativacao";
            this.ativacaoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // cbAtivacao
            // 
            this.cbAtivacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "ativacao_id", true));
            this.cbAtivacao.DataSource = this.ativacaoBindingSource;
            this.cbAtivacao.DisplayMember = "descricao";
            this.cbAtivacao.Location = new System.Drawing.Point(114, 90);
            this.cbAtivacao.Name = "cbAtivacao";
            this.cbAtivacao.Size = new System.Drawing.Size(119, 22);
            this.cbAtivacao.TabIndex = 21;
            this.cbAtivacao.ValueMember = "id";
            // 
            // bracoBindingSource
            // 
            this.bracoBindingSource.DataMember = "braco";
            this.bracoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // cbBraco
            // 
            this.cbBraco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "braco_id", true));
            this.cbBraco.DataSource = this.bracoBindingSource;
            this.cbBraco.DisplayMember = "descricao";
            this.cbBraco.Location = new System.Drawing.Point(114, 62);
            this.cbBraco.Name = "cbBraco";
            this.cbBraco.Size = new System.Drawing.Size(119, 22);
            this.cbBraco.TabIndex = 13;
            this.cbBraco.ValueMember = "id";
            // 
            // lampadaBindingSource
            // 
            this.lampadaBindingSource.DataMember = "lampada";
            this.lampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // cbLampada
            // 
            this.cbLampada.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "lampada_id", true));
            this.cbLampada.DataSource = this.lampadaBindingSource;
            this.cbLampada.DisplayMember = "descricao";
            this.cbLampada.Location = new System.Drawing.Point(114, 35);
            this.cbLampada.Name = "cbLampada";
            this.cbLampada.Size = new System.Drawing.Size(119, 22);
            this.cbLampada.TabIndex = 11;
            this.cbLampada.ValueMember = "id";
            // 
            // tipoluminariaBindingSource
            // 
            this.tipoluminariaBindingSource.DataMember = "tipo_luminaria";
            this.tipoluminariaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // cbTipoLum
            // 
            this.cbTipoLum.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "tipo_luminaria_id", true));
            this.cbTipoLum.DataSource = this.tipoluminariaBindingSource;
            this.cbTipoLum.DisplayMember = "descricao";
            this.cbTipoLum.Location = new System.Drawing.Point(114, 7);
            this.cbTipoLum.Name = "cbTipoLum";
            this.cbTipoLum.Size = new System.Drawing.Size(119, 22);
            this.cbTipoLum.TabIndex = 8;
            this.cbTipoLum.ValueMember = "id";
            this.cbTipoLum.SelectedIndexChanged += new System.EventHandler(this.cbTipoLum_SelectedIndexChanged);
            this.cbTipoLum.SelectedValueChanged += new System.EventHandler(this.cbTipoLum_SelectedValueChanged);
            // 
            // poste_idTextBox
            // 
            this.poste_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "poste_id", true));
            this.poste_idTextBox.Location = new System.Drawing.Point(114, 227);
            this.poste_idTextBox.Name = "poste_idTextBox";
            this.poste_idTextBox.ReadOnly = true;
            this.poste_idTextBox.Size = new System.Drawing.Size(119, 21);
            this.poste_idTextBox.TabIndex = 7;
            this.poste_idTextBox.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkDerivacao);
            this.tabPage4.Controls.Add(this.chkRepetir);
            this.tabPage4.Controls.Add(this.cbReator);
            this.tabPage4.Controls.Add(reator_idLabel);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(gps_timeLabel);
            this.tabPage4.Controls.Add(this.gps_timeTextBox);
            this.tabPage4.Controls.Add(lonLabel);
            this.tabPage4.Controls.Add(this.lonTextBox);
            this.tabPage4.Controls.Add(latLabel);
            this.tabPage4.Controls.Add(this.latTextBox);
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(240, 251);
            this.tabPage4.Text = "Formulário II";
            // 
            // chkRepetir
            // 
            this.chkRepetir.Location = new System.Drawing.Point(9, 142);
            this.chkRepetir.Name = "chkRepetir";
            this.chkRepetir.Size = new System.Drawing.Size(224, 20);
            this.chkRepetir.TabIndex = 47;
            this.chkRepetir.Text = "Repetir Coordenada do poste";
            this.chkRepetir.CheckStateChanged += new System.EventHandler(this.chkDerivacao_CheckStateChanged);
            // 
            // reatorBindingSource
            // 
            this.reatorBindingSource.DataMember = "reator";
            this.reatorBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // cbReator
            // 
            this.cbReator.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "reator_id", true));
            this.cbReator.DataSource = this.reatorBindingSource;
            this.cbReator.DisplayMember = "descricao";
            this.cbReator.Location = new System.Drawing.Point(83, 7);
            this.cbReator.Name = "cbReator";
            this.cbReator.Size = new System.Drawing.Size(119, 22);
            this.cbReator.TabIndex = 45;
            this.cbReator.ValueMember = "id";
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.postehastipoluminariaBindingSource, "aceso", true));
            this.checkBox1.Location = new System.Drawing.Point(83, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Aceso 24 H";
            // 
            // gps_timeTextBox
            // 
            this.gps_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "gps_time", true));
            this.gps_timeTextBox.Location = new System.Drawing.Point(83, 115);
            this.gps_timeTextBox.Name = "gps_timeTextBox";
            this.gps_timeTextBox.ReadOnly = true;
            this.gps_timeTextBox.Size = new System.Drawing.Size(150, 21);
            this.gps_timeTextBox.TabIndex = 5;
            // 
            // lonTextBox
            // 
            this.lonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "lon", true));
            this.lonTextBox.Location = new System.Drawing.Point(83, 88);
            this.lonTextBox.Name = "lonTextBox";
            this.lonTextBox.ReadOnly = true;
            this.lonTextBox.Size = new System.Drawing.Size(150, 21);
            this.lonTextBox.TabIndex = 3;
            // 
            // latTextBox
            // 
            this.latTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "lat", true));
            this.latTextBox.Location = new System.Drawing.Point(83, 61);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.ReadOnly = true;
            this.latTextBox.Size = new System.Drawing.Size(150, 21);
            this.latTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.foto_pathTextBox);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 248);
            this.tabPage3.Text = "Foto";
            this.tabPage3.GotFocus += new System.EventHandler(this.tabPage3_GotFocus);
            // 
            // foto_pathTextBox
            // 
            this.foto_pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foto_pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "foto_path", true));
            this.foto_pathTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.foto_pathTextBox.Location = new System.Drawing.Point(3, 186);
            this.foto_pathTextBox.Name = "foto_pathTextBox";
            this.foto_pathTextBox.ReadOnly = true;
            this.foto_pathTextBox.Size = new System.Drawing.Size(230, 19);
            this.foto_pathTextBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mostar Foto";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fotografar";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postehastipoluminariaBindingSource, "foto_path", true));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // poste_has_tipo_luminariaTableAdapter
            // 
            this.poste_has_tipo_luminariaTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_luminariaTableAdapter
            // 
            this.tipo_luminariaTableAdapter.ClearBeforeFill = true;
            // 
            // lampadaTableAdapter
            // 
            this.lampadaTableAdapter.ClearBeforeFill = true;
            // 
            // reatorTableAdapter
            // 
            this.reatorTableAdapter.ClearBeforeFill = true;
            // 
            // bracoTableAdapter
            // 
            this.bracoTableAdapter.ClearBeforeFill = true;
            // 
            // ativacaoTableAdapter
            // 
            this.ativacaoTableAdapter.ClearBeforeFill = true;
            // 
            // faseTableAdapter
            // 
            this.faseTableAdapter.ClearBeforeFill = true;
            // 
            // chave_comandoTableAdapter
            // 
            this.chave_comandoTableAdapter.ClearBeforeFill = true;
            // 
            // luminariasTableAdapter
            // 
            this.luminariasTableAdapter.ClearBeforeFill = true;
            // 
            // chkDerivacao
            // 
            this.chkDerivacao.Location = new System.Drawing.Point(9, 168);
            this.chkDerivacao.Name = "chkDerivacao";
            this.chkDerivacao.Size = new System.Drawing.Size(224, 20);
            this.chkDerivacao.TabIndex = 52;
            this.chkDerivacao.Text = "Derivação (Outra Coordenada)";
            this.chkDerivacao.CheckStateChanged += new System.EventHandler(this.chkDerivacao_CheckStateChanged);
            // 
            // CadastrarLuminaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CadastrarLuminaria";
            this.Text = "CadastrarLuminaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarLuminaria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luminariasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chavecomandoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reatorBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource postehastipoluminariaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter poste_has_tipo_luminariaTableAdapter;
        private System.Windows.Forms.BindingSource tipoluminariaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.tipo_luminariaTableAdapter tipo_luminariaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbLampada;
        private System.Windows.Forms.ComboBox cbTipoLum;
        private System.Windows.Forms.TextBox poste_idTextBox;
        private System.Windows.Forms.BindingSource lampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter lampadaTableAdapter;
        private System.Windows.Forms.ComboBox cbBraco;
        private System.Windows.Forms.BindingSource reatorBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.reatorTableAdapter reatorTableAdapter;
        private System.Windows.Forms.BindingSource bracoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter bracoTableAdapter;
        private System.Windows.Forms.ComboBox cbAtivacao;
        private System.Windows.Forms.BindingSource ativacaoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter ativacaoTableAdapter;
        private System.Windows.Forms.ComboBox cbFaseId;
        private System.Windows.Forms.BindingSource faseBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter faseTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.ComboBox cbChaveComando;
        private System.Windows.Forms.BindingSource chavecomandoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.chave_comandoTableAdapter chave_comandoTableAdapter;
        private System.Windows.Forms.TextBox foto_pathTextBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox lonTextBox;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.TextBox gps_timeTextBox;
        private System.Windows.Forms.BindingSource luminariasBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.luminariasTableAdapter luminariasTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGrid luminariasDataGrid;
        private System.Windows.Forms.DataGridTableStyle luminariasTableStyleDataGridTableStyle;
        private System.Windows.Forms.CheckBox chkRepetir;
        private System.Windows.Forms.ComboBox cbReator;
        private System.Windows.Forms.CheckBox chkDerivacao;
    }
}