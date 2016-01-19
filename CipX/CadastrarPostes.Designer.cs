namespace CipX
{
    partial class CadastrarPostes
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
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label barramentoLabel;
            System.Windows.Forms.Label latLabel;
            System.Windows.Forms.Label lonLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label sequenciaLabel;
            System.Windows.Forms.Label gps_timeLabel;
            System.Windows.Forms.Label medidorLabel;
            System.Windows.Forms.Label trafo_idLabel;
            System.Windows.Forms.Label posicao_trafoLabel;
            System.Windows.Forms.Label fase_idLabel;
            System.Windows.Forms.Label ativacao_idLabel;
            System.Windows.Forms.Label condicao_risco_idLabel;
            System.Windows.Forms.Label poste_vizinho_idLabel;
            System.Windows.Forms.DataGridTextBoxColumn idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn bairroDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn logradouroDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn gps_timeDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn sequenciaDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn barramentoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn trafo_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn latDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn lonDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn obsDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn gpggaDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn posicao_trafoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn ligacao_clandestinaDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn condicao_risco_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn poste_vizinho_idDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPosteID = new System.Windows.Forms.Label();
            this.posteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.posteDataGrid = new System.Windows.Forms.DataGrid();
            this.posteTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.posteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.medidorTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sequenciaTextBox = new System.Windows.Forms.TextBox();
            this.lonTextBox = new System.Windows.Forms.TextBox();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.barramentoTextBox = new System.Windows.Forms.TextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.condicaoriscoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.ativacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.faseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trafo_idTextBox = new System.Windows.Forms.TextBox();
            this.gps_timeTextBox = new System.Windows.Forms.TextBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.bracoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bracoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter();
            this.faseTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter();
            this.ativacaoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter();
            this.condicao_riscoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.condicao_riscoTableAdapter();
            this.posteTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter();
            bairroLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            barramentoLabel = new System.Windows.Forms.Label();
            latLabel = new System.Windows.Forms.Label();
            lonLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            sequenciaLabel = new System.Windows.Forms.Label();
            gps_timeLabel = new System.Windows.Forms.Label();
            medidorLabel = new System.Windows.Forms.Label();
            trafo_idLabel = new System.Windows.Forms.Label();
            posicao_trafoLabel = new System.Windows.Forms.Label();
            fase_idLabel = new System.Windows.Forms.Label();
            ativacao_idLabel = new System.Windows.Forms.Label();
            condicao_risco_idLabel = new System.Windows.Forms.Label();
            poste_vizinho_idLabel = new System.Windows.Forms.Label();
            idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            bairroDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            logradouroDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            gps_timeDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            sequenciaDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            barramentoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            trafo_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            latDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            lonDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            obsDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            gpggaDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            posicao_trafoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ligacao_clandestinaDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            condicao_risco_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            poste_vizinho_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoriscoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bairroLabel
            // 
            bairroLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            bairroLabel.Location = new System.Drawing.Point(32, 10);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(99, 14);
            bairroLabel.Text = "bairro:";
            // 
            // ruaLabel
            // 
            ruaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ruaLabel.Location = new System.Drawing.Point(3, 37);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(83, 14);
            ruaLabel.Text = "logradouro:";
            // 
            // barramentoLabel
            // 
            barramentoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            barramentoLabel.Location = new System.Drawing.Point(43, 91);
            barramentoLabel.Name = "barramentoLabel";
            barramentoLabel.Size = new System.Drawing.Size(83, 14);
            barramentoLabel.Text = "barramento:";
            // 
            // latLabel
            // 
            latLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            latLabel.Location = new System.Drawing.Point(98, 199);
            latLabel.Name = "latLabel";
            latLabel.Size = new System.Drawing.Size(27, 14);
            latLabel.Text = "lat:";
            // 
            // lonLabel
            // 
            lonLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            lonLabel.Location = new System.Drawing.Point(95, 223);
            lonLabel.Name = "lonLabel";
            lonLabel.Size = new System.Drawing.Size(30, 14);
            lonLabel.Text = "lon:";
            // 
            // obsLabel
            // 
            obsLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            obsLabel.Location = new System.Drawing.Point(6, 10);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(33, 14);
            obsLabel.Text = "obs:";
            // 
            // sequenciaLabel
            // 
            sequenciaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            sequenciaLabel.Location = new System.Drawing.Point(55, 64);
            sequenciaLabel.Name = "sequenciaLabel";
            sequenciaLabel.Size = new System.Drawing.Size(71, 14);
            sequenciaLabel.Text = "sequencia:";
            // 
            // gps_timeLabel
            // 
            gps_timeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            gps_timeLabel.Location = new System.Drawing.Point(61, 223);
            gps_timeLabel.Name = "gps_timeLabel";
            gps_timeLabel.Size = new System.Drawing.Size(64, 14);
            gps_timeLabel.Text = "gps time:";
            // 
            // medidorLabel
            // 
            medidorLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            medidorLabel.Location = new System.Drawing.Point(64, 145);
            medidorLabel.Name = "medidorLabel";
            medidorLabel.Size = new System.Drawing.Size(61, 14);
            medidorLabel.Text = "medidor:";
            // 
            // trafo_idLabel
            // 
            trafo_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            trafo_idLabel.Location = new System.Drawing.Point(68, 196);
            trafo_idLabel.Name = "trafo_idLabel";
            trafo_idLabel.Size = new System.Drawing.Size(57, 14);
            trafo_idLabel.Text = "trafo id:";
            // 
            // posicao_trafoLabel
            // 
            posicao_trafoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            posicao_trafoLabel.Location = new System.Drawing.Point(38, 83);
            posicao_trafoLabel.Name = "posicao_trafoLabel";
            posicao_trafoLabel.Size = new System.Drawing.Size(92, 14);
            posicao_trafoLabel.Text = "posicao trafo:";
            // 
            // fase_idLabel
            // 
            fase_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            fase_idLabel.Location = new System.Drawing.Point(76, 114);
            fase_idLabel.Name = "fase_idLabel";
            fase_idLabel.Size = new System.Drawing.Size(51, 14);
            fase_idLabel.Text = "fase id:";
            // 
            // ativacao_idLabel
            // 
            ativacao_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ativacao_idLabel.Location = new System.Drawing.Point(49, 142);
            ativacao_idLabel.Name = "ativacao_idLabel";
            ativacao_idLabel.Size = new System.Drawing.Size(77, 14);
            ativacao_idLabel.Text = "ativacao id:";
            // 
            // condicao_risco_idLabel
            // 
            condicao_risco_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            condicao_risco_idLabel.Location = new System.Drawing.Point(13, 170);
            condicao_risco_idLabel.Name = "condicao_risco_idLabel";
            condicao_risco_idLabel.Size = new System.Drawing.Size(112, 14);
            condicao_risco_idLabel.Text = "condicao risco id:";
            // 
            // poste_vizinho_idLabel
            // 
            poste_vizinho_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            poste_vizinho_idLabel.Location = new System.Drawing.Point(32, 249);
            poste_vizinho_idLabel.Name = "poste_vizinho_idLabel";
            poste_vizinho_idLabel.Size = new System.Drawing.Size(93, 14);
            poste_vizinho_idLabel.Text = "poste vizinho:";
            // 
            // idDataGridColumnStyleDataGridTextBoxColumn
            // 
            idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "id";
            idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "id";
            // 
            // bairroDataGridColumnStyleDataGridTextBoxColumn
            // 
            bairroDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            bairroDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            bairroDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "bairro";
            bairroDataGridColumnStyleDataGridTextBoxColumn.MappingName = "bairro";
            // 
            // logradouroDataGridColumnStyleDataGridTextBoxColumn
            // 
            logradouroDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            logradouroDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            logradouroDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "logradouro";
            logradouroDataGridColumnStyleDataGridTextBoxColumn.MappingName = "logradouro";
            // 
            // gps_timeDataGridColumnStyleDataGridTextBoxColumn
            // 
            gps_timeDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            gps_timeDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            gps_timeDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "gps_time";
            gps_timeDataGridColumnStyleDataGridTextBoxColumn.MappingName = "gps_time";
            // 
            // sequenciaDataGridColumnStyleDataGridTextBoxColumn
            // 
            sequenciaDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            sequenciaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            sequenciaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "sequencia";
            sequenciaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "sequencia";
            // 
            // barramentoDataGridColumnStyleDataGridTextBoxColumn
            // 
            barramentoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            barramentoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            barramentoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "barramento";
            barramentoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "barramento";
            // 
            // trafo_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            trafo_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            trafo_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            trafo_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "trafo_id";
            trafo_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "trafo_id";
            // 
            // latDataGridColumnStyleDataGridTextBoxColumn
            // 
            latDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            latDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            latDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "lat";
            latDataGridColumnStyleDataGridTextBoxColumn.MappingName = "lat";
            // 
            // lonDataGridColumnStyleDataGridTextBoxColumn
            // 
            lonDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            lonDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            lonDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "lon";
            lonDataGridColumnStyleDataGridTextBoxColumn.MappingName = "lon";
            // 
            // obsDataGridColumnStyleDataGridTextBoxColumn
            // 
            obsDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            obsDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            obsDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "obs";
            obsDataGridColumnStyleDataGridTextBoxColumn.MappingName = "obs";
            // 
            // gpggaDataGridColumnStyleDataGridTextBoxColumn
            // 
            gpggaDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            gpggaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            gpggaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "gpgga";
            gpggaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "gpgga";
            // 
            // posicao_trafoDataGridColumnStyleDataGridTextBoxColumn
            // 
            posicao_trafoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            posicao_trafoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            posicao_trafoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "posicao_trafo";
            posicao_trafoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "posicao_trafo";
            // 
            // ligacao_clandestinaDataGridColumnStyleDataGridTextBoxColumn
            // 
            ligacao_clandestinaDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            ligacao_clandestinaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            ligacao_clandestinaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "ligacao_clandestina";
            ligacao_clandestinaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "ligacao_clandestina";
            // 
            // condicao_risco_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            condicao_risco_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            condicao_risco_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            condicao_risco_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "condicao_risco_id";
            condicao_risco_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "condicao_risco_id";
            // 
            // poste_vizinho_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            poste_vizinho_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            poste_vizinho_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            poste_vizinho_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "poste_vizinho_id";
            poste_vizinho_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "poste_vizinho_id";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem10);
            this.menuItem1.MenuItems.Add(this.menuItem12);
            this.menuItem1.MenuItems.Add(this.menuItem11);
            this.menuItem1.MenuItems.Add(this.menuItem7);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Novo";
            this.menuItem4.Click += new System.EventHandler(this.novo);
            // 
            // menuItem10
            // 
            this.menuItem10.Text = "Salvar";
            this.menuItem10.Click += new System.EventHandler(this.salvar);
            // 
            // menuItem12
            // 
            this.menuItem12.Text = "Croqui";
            this.menuItem12.Click += new System.EventHandler(this.croqui);
            // 
            // menuItem11
            // 
            this.menuItem11.Text = "-";
            // 
            // menuItem7
            // 
            this.menuItem7.MenuItems.Add(this.menuItem5);
            this.menuItem7.MenuItems.Add(this.menuItem6);
            this.menuItem7.MenuItems.Add(this.menuItem8);
            this.menuItem7.MenuItems.Add(this.menuItem9);
            this.menuItem7.Text = "Componentes";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Luminárias";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Lâmpadas";
            this.menuItem6.Click += new System.EventHandler(this.lampadas);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "Reator";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "Uso Mútuo";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelPosteID);
            this.tabPage1.Controls.Add(this.posteDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 271);
            this.tabPage1.Text = "I";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "label1";
            // 
            // labelPosteID
            // 
            this.labelPosteID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPosteID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "id", true));
            this.labelPosteID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPosteID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.labelPosteID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPosteID.Location = new System.Drawing.Point(0, 251);
            this.labelPosteID.Name = "labelPosteID";
            this.labelPosteID.Size = new System.Drawing.Size(240, 20);
            this.labelPosteID.Text = "0";
            this.labelPosteID.Visible = false;
            // 
            // posteBindingSource
            // 
            this.posteBindingSource.DataMember = "poste";
            this.posteBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posteDataGrid
            // 
            this.posteDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.posteDataGrid.DataSource = this.posteBindingSource;
            this.posteDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posteDataGrid.Location = new System.Drawing.Point(0, 0);
            this.posteDataGrid.Name = "posteDataGrid";
            this.posteDataGrid.RowHeadersVisible = false;
            this.posteDataGrid.Size = new System.Drawing.Size(240, 271);
            this.posteDataGrid.TabIndex = 0;
            this.posteDataGrid.TableStyles.Add(this.posteTableStyleDataGridTableStyle);
            // 
            // posteTableStyleDataGridTableStyle
            // 
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(sequenciaDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(bairroDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(logradouroDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(gps_timeDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(barramentoDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(trafo_idDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(idDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(latDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(lonDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(obsDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(gpggaDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(posicao_trafoDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(ligacao_clandestinaDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(condicao_risco_idDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.GridColumnStyles.Add(poste_vizinho_idDataGridColumnStyleDataGridTextBoxColumn);
            this.posteTableStyleDataGridTableStyle.MappingName = "poste";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.comboBox6);
            this.tabPage2.Controls.Add(poste_vizinho_idLabel);
            this.tabPage2.Controls.Add(medidorLabel);
            this.tabPage2.Controls.Add(this.medidorTextBox);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(sequenciaLabel);
            this.tabPage2.Controls.Add(this.sequenciaTextBox);
            this.tabPage2.Controls.Add(lonLabel);
            this.tabPage2.Controls.Add(this.lonTextBox);
            this.tabPage2.Controls.Add(latLabel);
            this.tabPage2.Controls.Add(this.latTextBox);
            this.tabPage2.Controls.Add(barramentoLabel);
            this.tabPage2.Controls.Add(this.barramentoTextBox);
            this.tabPage2.Controls.Add(this.ruaTextBox);
            this.tabPage2.Controls.Add(this.bairroTextBox);
            this.tabPage2.Controls.Add(ruaLabel);
            this.tabPage2.Controls.Add(bairroLabel);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 268);
            this.tabPage2.Text = "II";
            // 
            // checkBox2
            // 
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.posteBindingSource, "aceso", true));
            this.checkBox2.Location = new System.Drawing.Point(132, 170);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 20);
            this.checkBox2.TabIndex = 68;
            this.checkBox2.Text = "Aceso";
            // 
            // posteBindingSource1
            // 
            this.posteBindingSource1.DataMember = "poste";
            this.posteBindingSource1.DataSource = this.eletrocadDataSet;
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.posteBindingSource, "poste_vizinho_id", true));
            this.comboBox6.DataSource = this.posteBindingSource1;
            this.comboBox6.DisplayMember = "sequencia";
            this.comboBox6.Location = new System.Drawing.Point(131, 246);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(66, 22);
            this.comboBox6.TabIndex = 58;
            this.comboBox6.ValueMember = "id";
            // 
            // medidorTextBox
            // 
            this.medidorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "medidor", true));
            this.medidorTextBox.Enabled = false;
            this.medidorTextBox.Location = new System.Drawing.Point(132, 142);
            this.medidorTextBox.Name = "medidorTextBox";
            this.medidorTextBox.Size = new System.Drawing.Size(100, 21);
            this.medidorTextBox.TabIndex = 40;
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.posteBindingSource, "medido", true));
            this.checkBox1.Location = new System.Drawing.Point(132, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 20);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Medido";
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // sequenciaTextBox
            // 
            this.sequenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "sequencia", true));
            this.sequenciaTextBox.Location = new System.Drawing.Point(133, 61);
            this.sequenciaTextBox.Name = "sequenciaTextBox";
            this.sequenciaTextBox.Size = new System.Drawing.Size(64, 21);
            this.sequenciaTextBox.TabIndex = 29;
            // 
            // lonTextBox
            // 
            this.lonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "lon", true));
            this.lonTextBox.Location = new System.Drawing.Point(132, 220);
            this.lonTextBox.Name = "lonTextBox";
            this.lonTextBox.ReadOnly = true;
            this.lonTextBox.Size = new System.Drawing.Size(100, 21);
            this.lonTextBox.TabIndex = 19;
            // 
            // latTextBox
            // 
            this.latTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "lat", true));
            this.latTextBox.Location = new System.Drawing.Point(132, 196);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.ReadOnly = true;
            this.latTextBox.Size = new System.Drawing.Size(100, 21);
            this.latTextBox.TabIndex = 17;
            // 
            // barramentoTextBox
            // 
            this.barramentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "barramento", true));
            this.barramentoTextBox.Location = new System.Drawing.Point(133, 88);
            this.barramentoTextBox.Name = "barramentoTextBox";
            this.barramentoTextBox.Size = new System.Drawing.Size(100, 21);
            this.barramentoTextBox.TabIndex = 9;
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "logradouro", true));
            this.ruaTextBox.Location = new System.Drawing.Point(81, 34);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(152, 21);
            this.ruaTextBox.TabIndex = 3;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(81, 7);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(152, 21);
            this.bairroTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox5);
            this.tabPage3.Controls.Add(condicao_risco_idLabel);
            this.tabPage3.Controls.Add(this.comboBox4);
            this.tabPage3.Controls.Add(ativacao_idLabel);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(fase_idLabel);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(posicao_trafoLabel);
            this.tabPage3.Controls.Add(trafo_idLabel);
            this.tabPage3.Controls.Add(this.trafo_idTextBox);
            this.tabPage3.Controls.Add(gps_timeLabel);
            this.tabPage3.Controls.Add(this.gps_timeTextBox);
            this.tabPage3.Controls.Add(obsLabel);
            this.tabPage3.Controls.Add(this.obsTextBox);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 268);
            this.tabPage3.Text = "III";
            // 
            // condicaoriscoBindingSource
            // 
            this.condicaoriscoBindingSource.DataMember = "condicao_risco";
            this.condicaoriscoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.posteBindingSource, "condicao_risco_id", true));
            this.comboBox5.DataSource = this.condicaoriscoBindingSource;
            this.comboBox5.DisplayMember = "descricao";
            this.comboBox5.Location = new System.Drawing.Point(133, 167);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 22);
            this.comboBox5.TabIndex = 22;
            this.comboBox5.ValueMember = "id";
            // 
            // ativacaoBindingSource
            // 
            this.ativacaoBindingSource.DataMember = "ativacao";
            this.ativacaoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.posteBindingSource, "ativacao_id", true));
            this.comboBox4.DataSource = this.ativacaoBindingSource;
            this.comboBox4.DisplayMember = "descricao";
            this.comboBox4.Location = new System.Drawing.Point(132, 139);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 22);
            this.comboBox4.TabIndex = 21;
            this.comboBox4.ValueMember = "id";
            // 
            // faseBindingSource
            // 
            this.faseBindingSource.DataMember = "fase";
            this.faseBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.posteBindingSource, "fase_id", true));
            this.comboBox3.DataSource = this.faseBindingSource;
            this.comboBox3.DisplayMember = "descricao";
            this.comboBox3.Location = new System.Drawing.Point(133, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 22);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.ValueMember = "id";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.posteBindingSource, "posicao_trafo", true));
            this.comboBox1.Items.Add("Favor");
            this.comboBox1.Items.Add("Contra");
            this.comboBox1.Location = new System.Drawing.Point(133, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 22);
            this.comboBox1.TabIndex = 18;
            // 
            // trafo_idTextBox
            // 
            this.trafo_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "trafo_id", true));
            this.trafo_idTextBox.Location = new System.Drawing.Point(132, 193);
            this.trafo_idTextBox.Name = "trafo_idTextBox";
            this.trafo_idTextBox.ReadOnly = true;
            this.trafo_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.trafo_idTextBox.TabIndex = 17;
            // 
            // gps_timeTextBox
            // 
            this.gps_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "gps_time", true));
            this.gps_timeTextBox.Location = new System.Drawing.Point(132, 220);
            this.gps_timeTextBox.Name = "gps_timeTextBox";
            this.gps_timeTextBox.ReadOnly = true;
            this.gps_timeTextBox.Size = new System.Drawing.Size(100, 21);
            this.gps_timeTextBox.TabIndex = 7;
            // 
            // obsTextBox
            // 
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "obs", true));
            this.obsTextBox.Location = new System.Drawing.Point(46, 7);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.obsTextBox.Size = new System.Drawing.Size(187, 62);
            this.obsTextBox.TabIndex = 1;
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
            // faseTableAdapter
            // 
            this.faseTableAdapter.ClearBeforeFill = true;
            // 
            // ativacaoTableAdapter
            // 
            this.ativacaoTableAdapter.ClearBeforeFill = true;
            // 
            // condicao_riscoTableAdapter
            // 
            this.condicao_riscoTableAdapter.ClearBeforeFill = true;
            // 
            // posteTableAdapter
            // 
            this.posteTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarPostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CadastrarPostes";
            this.Text = "CadastrarPostes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarPostes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.condicaoriscoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox lonTextBox;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.TextBox barramentoTextBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox obsTextBox;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.TextBox sequenciaTextBox;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.TextBox medidorTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox gps_timeTextBox;
        private System.Windows.Forms.TextBox trafo_idTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bracoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter bracoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource faseBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter faseTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource ativacaoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter ativacaoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource condicaoriscoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.condicao_riscoTableAdapter condicao_riscoTableAdapter;
        private System.Windows.Forms.BindingSource posteBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter posteTableAdapter;
        private System.Windows.Forms.DataGrid posteDataGrid;
        private System.Windows.Forms.DataGridTableStyle posteTableStyleDataGridTableStyle;
        private System.Windows.Forms.BindingSource posteBindingSource1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label labelPosteID;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
    }
}