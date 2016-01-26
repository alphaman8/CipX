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
            System.Windows.Forms.Label reator_idLabel;
            System.Windows.Forms.Label braco_idLabel;
            System.Windows.Forms.Label ativacao_idLabel;
            System.Windows.Forms.Label fase_idLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label chave_comandoLabel;
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
            this.poste_has_tipo_luminariaDataGrid = new System.Windows.Forms.DataGrid();
            this.postehastipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.poste_has_tipo_luminariaTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.faseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.ativacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.bracoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.reatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.poste_idTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblFotoPath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.poste_has_tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter();
            this.tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.tipo_luminariaTableAdapter();
            this.lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter();
            this.reatorTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.reatorTableAdapter();
            this.bracoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter();
            this.ativacaoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter();
            this.faseTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.chavecomandoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.chave_comandoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.chave_comandoTableAdapter();
            tipo_luminaria_idLabel = new System.Windows.Forms.Label();
            poste_idLabel = new System.Windows.Forms.Label();
            lampada_idLabel = new System.Windows.Forms.Label();
            reator_idLabel = new System.Windows.Forms.Label();
            braco_idLabel = new System.Windows.Forms.Label();
            ativacao_idLabel = new System.Windows.Forms.Label();
            fase_idLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            chave_comandoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chavecomandoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipo_luminaria_idLabel
            // 
            tipo_luminaria_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tipo_luminaria_idLabel.Location = new System.Drawing.Point(12, 11);
            tipo_luminaria_idLabel.Name = "tipo_luminaria_idLabel";
            tipo_luminaria_idLabel.Size = new System.Drawing.Size(110, 14);
            tipo_luminaria_idLabel.Text = "tipo luminaria id:";
            // 
            // poste_idLabel
            // 
            poste_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            poste_idLabel.Location = new System.Drawing.Point(60, 230);
            poste_idLabel.Name = "poste_idLabel";
            poste_idLabel.Size = new System.Drawing.Size(61, 14);
            poste_idLabel.Text = "poste id:";
            poste_idLabel.Visible = false;
            // 
            // lampada_idLabel
            // 
            lampada_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            lampada_idLabel.Location = new System.Drawing.Point(44, 38);
            lampada_idLabel.Name = "lampada_idLabel";
            lampada_idLabel.Size = new System.Drawing.Size(77, 14);
            lampada_idLabel.Text = "lampada id:";
            // 
            // reator_idLabel
            // 
            reator_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            reator_idLabel.Location = new System.Drawing.Point(57, 66);
            reator_idLabel.Name = "reator_idLabel";
            reator_idLabel.Size = new System.Drawing.Size(64, 14);
            reator_idLabel.Text = "reator id:";
            // 
            // braco_idLabel
            // 
            braco_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            braco_idLabel.Location = new System.Drawing.Point(61, 93);
            braco_idLabel.Name = "braco_idLabel";
            braco_idLabel.Size = new System.Drawing.Size(60, 14);
            braco_idLabel.Text = "braco id:";
            // 
            // ativacao_idLabel
            // 
            ativacao_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ativacao_idLabel.Location = new System.Drawing.Point(44, 124);
            ativacao_idLabel.Name = "ativacao_idLabel";
            ativacao_idLabel.Size = new System.Drawing.Size(77, 14);
            ativacao_idLabel.Text = "ativacao id:";
            // 
            // fase_idLabel
            // 
            fase_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            fase_idLabel.Location = new System.Drawing.Point(70, 151);
            fase_idLabel.Name = "fase_idLabel";
            fase_idLabel.Size = new System.Drawing.Size(51, 14);
            fase_idLabel.Text = "fase id:";
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
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.tabPage1.Controls.Add(this.poste_has_tipo_luminariaDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 251);
            this.tabPage1.Text = "tabPage1";
            // 
            // poste_has_tipo_luminariaDataGrid
            // 
            this.poste_has_tipo_luminariaDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.poste_has_tipo_luminariaDataGrid.DataSource = this.postehastipoluminariaBindingSource;
            this.poste_has_tipo_luminariaDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poste_has_tipo_luminariaDataGrid.Location = new System.Drawing.Point(0, 0);
            this.poste_has_tipo_luminariaDataGrid.Name = "poste_has_tipo_luminariaDataGrid";
            this.poste_has_tipo_luminariaDataGrid.Size = new System.Drawing.Size(240, 251);
            this.poste_has_tipo_luminariaDataGrid.TabIndex = 2;
            this.poste_has_tipo_luminariaDataGrid.TableStyles.Add(this.poste_has_tipo_luminariaTableStyleDataGridTableStyle);
            // 
            // postehastipoluminariaBindingSource
            // 
            this.postehastipoluminariaBindingSource.DataMember = "poste_has_tipo_luminaria";
            this.postehastipoluminariaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poste_has_tipo_luminariaTableStyleDataGridTableStyle
            // 
            this.poste_has_tipo_luminariaTableStyleDataGridTableStyle.MappingName = "poste_has_tipo_luminaria";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox7);
            this.tabPage2.Controls.Add(chave_comandoLabel);
            this.tabPage2.Controls.Add(quantidadeLabel);
            this.tabPage2.Controls.Add(this.quantidadeTextBox);
            this.tabPage2.Controls.Add(this.comboBox6);
            this.tabPage2.Controls.Add(this.comboBox5);
            this.tabPage2.Controls.Add(fase_idLabel);
            this.tabPage2.Controls.Add(ativacao_idLabel);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(braco_idLabel);
            this.tabPage2.Controls.Add(reator_idLabel);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(lampada_idLabel);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(tipo_luminaria_idLabel);
            this.tabPage2.Controls.Add(poste_idLabel);
            this.tabPage2.Controls.Add(this.poste_idTextBox);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 251);
            this.tabPage2.Text = "tabPage2";
            // 
            // faseBindingSource
            // 
            this.faseBindingSource.DataMember = "fase";
            this.faseBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "fase_id", true));
            this.comboBox6.DataSource = this.faseBindingSource;
            this.comboBox6.DisplayMember = "descricao";
            this.comboBox6.Location = new System.Drawing.Point(128, 149);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 22);
            this.comboBox6.TabIndex = 22;
            this.comboBox6.ValueMember = "id";
            // 
            // ativacaoBindingSource
            // 
            this.ativacaoBindingSource.DataMember = "ativacao";
            this.ativacaoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "ativacao_id", true));
            this.comboBox5.DataSource = this.ativacaoBindingSource;
            this.comboBox5.DisplayMember = "descricao";
            this.comboBox5.Location = new System.Drawing.Point(128, 121);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 22);
            this.comboBox5.TabIndex = 21;
            this.comboBox5.ValueMember = "id";
            // 
            // bracoBindingSource
            // 
            this.bracoBindingSource.DataMember = "braco";
            this.bracoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "braco_id", true));
            this.comboBox4.DataSource = this.bracoBindingSource;
            this.comboBox4.DisplayMember = "descricao";
            this.comboBox4.Location = new System.Drawing.Point(128, 93);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 22);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.ValueMember = "id";
            // 
            // reatorBindingSource
            // 
            this.reatorBindingSource.DataMember = "reator";
            this.reatorBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "reator_id", true));
            this.comboBox3.DataSource = this.reatorBindingSource;
            this.comboBox3.DisplayMember = "descricao";
            this.comboBox3.Location = new System.Drawing.Point(128, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 22);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.ValueMember = "id";
            // 
            // lampadaBindingSource
            // 
            this.lampadaBindingSource.DataMember = "lampada";
            this.lampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "lampada_id", true));
            this.comboBox2.DataSource = this.lampadaBindingSource;
            this.comboBox2.DisplayMember = "descricao";
            this.comboBox2.Location = new System.Drawing.Point(128, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 22);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "id";
            // 
            // tipoluminariaBindingSource
            // 
            this.tipoluminariaBindingSource.DataMember = "tipo_luminaria";
            this.tipoluminariaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "tipo_luminaria_id", true));
            this.comboBox1.DataSource = this.tipoluminariaBindingSource;
            this.comboBox1.DisplayMember = "descricao";
            this.comboBox1.Location = new System.Drawing.Point(128, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 22);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "id";
            // 
            // poste_idTextBox
            // 
            this.poste_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "poste_id", true));
            this.poste_idTextBox.Location = new System.Drawing.Point(128, 227);
            this.poste_idTextBox.Name = "poste_idTextBox";
            this.poste_idTextBox.ReadOnly = true;
            this.poste_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.poste_idTextBox.TabIndex = 7;
            this.poste_idTextBox.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.lblFotoPath);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 251);
            this.tabPage3.Text = "Foto";
            this.tabPage3.GotFocus += new System.EventHandler(this.tabPage3_GotFocus);
            // 
            // lblFotoPath
            // 
            this.lblFotoPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "foto_path", true));
            this.lblFotoPath.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblFotoPath.Location = new System.Drawing.Point(1, 191);
            this.lblFotoPath.Name = "lblFotoPath";
            this.lblFotoPath.Size = new System.Drawing.Size(230, 13);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mostar Foto";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            quantidadeLabel.Location = new System.Drawing.Point(40, 180);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(81, 14);
            quantidadeLabel.Text = "quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(128, 177);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 21);
            this.quantidadeTextBox.TabIndex = 31;
            this.quantidadeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidadeTextBox_KeyPress);
            // 
            // chave_comandoLabel
            // 
            chave_comandoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            chave_comandoLabel.Location = new System.Drawing.Point(15, 205);
            chave_comandoLabel.Name = "chave_comandoLabel";
            chave_comandoLabel.Size = new System.Drawing.Size(106, 14);
            chave_comandoLabel.Text = "chave comando:";
            // 
            // chavecomandoBindingSource
            // 
            this.chavecomandoBindingSource.DataMember = "chave_comando";
            this.chavecomandoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // comboBox7
            // 
            this.comboBox7.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "chave_comando", true));
            this.comboBox7.DataSource = this.chavecomandoBindingSource;
            this.comboBox7.DisplayMember = "descricao";
            this.comboBox7.Location = new System.Drawing.Point(128, 203);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(100, 22);
            this.comboBox7.TabIndex = 32;
            this.comboBox7.ValueMember = "id";
            // 
            // chave_comandoTableAdapter
            // 
            this.chave_comandoTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chavecomandoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGrid poste_has_tipo_luminariaDataGrid;
        private System.Windows.Forms.DataGridTableStyle poste_has_tipo_luminariaTableStyleDataGridTableStyle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox poste_idTextBox;
        private System.Windows.Forms.BindingSource lampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter lampadaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource reatorBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.reatorTableAdapter reatorTableAdapter;
        private System.Windows.Forms.BindingSource bracoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter bracoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource ativacaoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter ativacaoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.BindingSource faseBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter faseTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFotoPath;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.BindingSource chavecomandoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.chave_comandoTableAdapter chave_comandoTableAdapter;
    }
}