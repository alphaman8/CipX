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
            System.Windows.Forms.Label gps_timeLabel;
            System.Windows.Forms.Label sequenciaLabel;
            System.Windows.Forms.Label barramentoLabel;
            System.Windows.Forms.Label medidoLabel;
            System.Windows.Forms.Label acesoLabel;
            System.Windows.Forms.Label trafo_idLabel;
            System.Windows.Forms.Label latLabel;
            System.Windows.Forms.Label lonLabel;
            System.Windows.Forms.Label obsLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.posteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posteTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.timer1 = new System.Windows.Forms.Timer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listGPS = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.posteDataGrid = new System.Windows.Forms.DataGrid();
            this.posteTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.gps_timeTextBox = new System.Windows.Forms.TextBox();
            this.sequenciaTextBox = new System.Windows.Forms.TextBox();
            this.barramentoTextBox = new System.Windows.Forms.TextBox();
            this.medidoTextBox = new System.Windows.Forms.TextBox();
            this.acesoTextBox = new System.Windows.Forms.TextBox();
            this.trafo_idTextBox = new System.Windows.Forms.TextBox();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.lonTextBox = new System.Windows.Forms.TextBox();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            bairroLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            gps_timeLabel = new System.Windows.Forms.Label();
            sequenciaLabel = new System.Windows.Forms.Label();
            barramentoLabel = new System.Windows.Forms.Label();
            medidoLabel = new System.Windows.Forms.Label();
            acesoLabel = new System.Windows.Forms.Label();
            trafo_idLabel = new System.Windows.Forms.Label();
            latLabel = new System.Windows.Forms.Label();
            lonLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem10);
            this.menuItem1.MenuItems.Add(this.menuItem7);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
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
            // posteBindingSource
            // 
            this.posteBindingSource.DataMember = "poste";
            this.posteBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // posteTableAdapter
            // 
            this.posteTableAdapter.ClearBeforeFill = true;
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Novo";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.tabPage1.Controls.Add(this.listGPS);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.posteDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 271);
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(lonLabel);
            this.tabPage2.Controls.Add(this.lonTextBox);
            this.tabPage2.Controls.Add(latLabel);
            this.tabPage2.Controls.Add(this.latTextBox);
            this.tabPage2.Controls.Add(trafo_idLabel);
            this.tabPage2.Controls.Add(this.trafo_idTextBox);
            this.tabPage2.Controls.Add(acesoLabel);
            this.tabPage2.Controls.Add(this.acesoTextBox);
            this.tabPage2.Controls.Add(medidoLabel);
            this.tabPage2.Controls.Add(this.medidoTextBox);
            this.tabPage2.Controls.Add(barramentoLabel);
            this.tabPage2.Controls.Add(this.barramentoTextBox);
            this.tabPage2.Controls.Add(sequenciaLabel);
            this.tabPage2.Controls.Add(this.sequenciaTextBox);
            this.tabPage2.Controls.Add(gps_timeLabel);
            this.tabPage2.Controls.Add(this.gps_timeTextBox);
            this.tabPage2.Controls.Add(ruaLabel);
            this.tabPage2.Controls.Add(this.ruaTextBox);
            this.tabPage2.Controls.Add(bairroLabel);
            this.tabPage2.Controls.Add(this.bairroTextBox);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 268);
            this.tabPage2.Text = "tabPage2";
            // 
            // listGPS
            // 
            this.listGPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listGPS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listGPS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.listGPS.ForeColor = System.Drawing.Color.Lime;
            this.listGPS.Location = new System.Drawing.Point(0, 152);
            this.listGPS.Name = "listGPS";
            this.listGPS.Size = new System.Drawing.Size(240, 119);
            this.listGPS.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(123, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // posteDataGrid
            // 
            this.posteDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.posteDataGrid.DataSource = this.posteBindingSource;
            this.posteDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.posteDataGrid.Location = new System.Drawing.Point(0, 0);
            this.posteDataGrid.Name = "posteDataGrid";
            this.posteDataGrid.RowHeadersVisible = false;
            this.posteDataGrid.Size = new System.Drawing.Size(240, 148);
            this.posteDataGrid.TabIndex = 12;
            this.posteDataGrid.TableStyles.Add(this.posteTableStyleDataGridTableStyle);
            // 
            // posteTableStyleDataGridTableStyle
            // 
            this.posteTableStyleDataGridTableStyle.MappingName = "poste";
            // 
            // bairroLabel
            // 
            bairroLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            bairroLabel.Location = new System.Drawing.Point(79, 10);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(47, 14);
            bairroLabel.Text = "bairro:";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(133, 7);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(100, 21);
            this.bairroTextBox.TabIndex = 1;
            // 
            // ruaLabel
            // 
            ruaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ruaLabel.Location = new System.Drawing.Point(95, 37);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(31, 14);
            ruaLabel.Text = "rua:";
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "rua", true));
            this.ruaTextBox.Location = new System.Drawing.Point(133, 34);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(100, 21);
            this.ruaTextBox.TabIndex = 3;
            // 
            // gps_timeLabel
            // 
            gps_timeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            gps_timeLabel.Location = new System.Drawing.Point(62, 250);
            gps_timeLabel.Name = "gps_timeLabel";
            gps_timeLabel.Size = new System.Drawing.Size(64, 14);
            gps_timeLabel.Text = "gps time:";
            // 
            // gps_timeTextBox
            // 
            this.gps_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "gps_time", true));
            this.gps_timeTextBox.Location = new System.Drawing.Point(133, 247);
            this.gps_timeTextBox.Name = "gps_timeTextBox";
            this.gps_timeTextBox.Size = new System.Drawing.Size(100, 21);
            this.gps_timeTextBox.TabIndex = 5;
            // 
            // sequenciaLabel
            // 
            sequenciaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            sequenciaLabel.Location = new System.Drawing.Point(55, 64);
            sequenciaLabel.Name = "sequenciaLabel";
            sequenciaLabel.Size = new System.Drawing.Size(71, 14);
            sequenciaLabel.Text = "sequencia:";
            // 
            // sequenciaTextBox
            // 
            this.sequenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "sequencia", true));
            this.sequenciaTextBox.Location = new System.Drawing.Point(133, 61);
            this.sequenciaTextBox.Name = "sequenciaTextBox";
            this.sequenciaTextBox.Size = new System.Drawing.Size(100, 21);
            this.sequenciaTextBox.TabIndex = 7;
            // 
            // barramentoLabel
            // 
            barramentoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            barramentoLabel.Location = new System.Drawing.Point(43, 91);
            barramentoLabel.Name = "barramentoLabel";
            barramentoLabel.Size = new System.Drawing.Size(83, 14);
            barramentoLabel.Text = "barramento:";
            // 
            // barramentoTextBox
            // 
            this.barramentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "barramento", true));
            this.barramentoTextBox.Location = new System.Drawing.Point(133, 88);
            this.barramentoTextBox.Name = "barramentoTextBox";
            this.barramentoTextBox.Size = new System.Drawing.Size(100, 21);
            this.barramentoTextBox.TabIndex = 9;
            // 
            // medidoLabel
            // 
            medidoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            medidoLabel.Location = new System.Drawing.Point(70, 118);
            medidoLabel.Name = "medidoLabel";
            medidoLabel.Size = new System.Drawing.Size(56, 14);
            medidoLabel.Text = "medido:";
            // 
            // medidoTextBox
            // 
            this.medidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "medido", true));
            this.medidoTextBox.Location = new System.Drawing.Point(133, 115);
            this.medidoTextBox.Name = "medidoTextBox";
            this.medidoTextBox.Size = new System.Drawing.Size(100, 21);
            this.medidoTextBox.TabIndex = 11;
            // 
            // acesoLabel
            // 
            acesoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            acesoLabel.Location = new System.Drawing.Point(81, 145);
            acesoLabel.Name = "acesoLabel";
            acesoLabel.Size = new System.Drawing.Size(45, 14);
            acesoLabel.Text = "aceso:";
            // 
            // acesoTextBox
            // 
            this.acesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "aceso", true));
            this.acesoTextBox.Location = new System.Drawing.Point(133, 142);
            this.acesoTextBox.Name = "acesoTextBox";
            this.acesoTextBox.Size = new System.Drawing.Size(100, 21);
            this.acesoTextBox.TabIndex = 13;
            // 
            // trafo_idLabel
            // 
            trafo_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            trafo_idLabel.Location = new System.Drawing.Point(69, 223);
            trafo_idLabel.Name = "trafo_idLabel";
            trafo_idLabel.Size = new System.Drawing.Size(57, 14);
            trafo_idLabel.Text = "trafo id:";
            // 
            // trafo_idTextBox
            // 
            this.trafo_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "trafo_id", true));
            this.trafo_idTextBox.Location = new System.Drawing.Point(133, 220);
            this.trafo_idTextBox.Name = "trafo_idTextBox";
            this.trafo_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.trafo_idTextBox.TabIndex = 15;
            // 
            // latLabel
            // 
            latLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            latLabel.Location = new System.Drawing.Point(99, 172);
            latLabel.Name = "latLabel";
            latLabel.Size = new System.Drawing.Size(27, 14);
            latLabel.Text = "lat:";
            // 
            // latTextBox
            // 
            this.latTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "lat", true));
            this.latTextBox.Location = new System.Drawing.Point(133, 169);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.Size = new System.Drawing.Size(100, 21);
            this.latTextBox.TabIndex = 17;
            // 
            // lonLabel
            // 
            lonLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            lonLabel.Location = new System.Drawing.Point(96, 196);
            lonLabel.Name = "lonLabel";
            lonLabel.Size = new System.Drawing.Size(30, 14);
            lonLabel.Text = "lon:";
            // 
            // lonTextBox
            // 
            this.lonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "lon", true));
            this.lonTextBox.Location = new System.Drawing.Point(133, 193);
            this.lonTextBox.Name = "lonTextBox";
            this.lonTextBox.Size = new System.Drawing.Size(100, 21);
            this.lonTextBox.TabIndex = 19;
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
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Lâmpadas";
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "Reator";
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "Uso Mútuo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(obsLabel);
            this.tabPage3.Controls.Add(this.obsTextBox);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 268);
            this.tabPage3.Text = "Obs";
            // 
            // obsLabel
            // 
            obsLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            obsLabel.Location = new System.Drawing.Point(6, 10);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(33, 14);
            obsLabel.Text = "obs:";
            // 
            // obsTextBox
            // 
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posteBindingSource, "obs", true));
            this.obsTextBox.Location = new System.Drawing.Point(46, 7);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.obsTextBox.Size = new System.Drawing.Size(187, 114);
            this.obsTextBox.TabIndex = 1;
            // 
            // menuItem10
            // 
            this.menuItem10.Text = "Salvar";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource posteBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter posteTableAdapter;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listGPS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGrid posteDataGrid;
        private System.Windows.Forms.DataGridTableStyle posteTableStyleDataGridTableStyle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox lonTextBox;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.TextBox trafo_idTextBox;
        private System.Windows.Forms.TextBox acesoTextBox;
        private System.Windows.Forms.TextBox medidoTextBox;
        private System.Windows.Forms.TextBox barramentoTextBox;
        private System.Windows.Forms.TextBox sequenciaTextBox;
        private System.Windows.Forms.TextBox gps_timeTextBox;
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
    }
}