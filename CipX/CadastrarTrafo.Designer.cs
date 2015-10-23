namespace CipX
{
    partial class CadastrarTrafo
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
            System.Windows.Forms.DataGridTextBoxColumn chaveDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn ciaDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn gps_timeDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn alimentadorDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn usuario_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.Label chaveLabel;
            System.Windows.Forms.Label ciaLabel;
            System.Windows.Forms.Label alimentadorLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.trafoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.trafoDataGrid = new System.Windows.Forms.DataGrid();
            this.trafoTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.alimentadorTextBox = new System.Windows.Forms.TextBox();
            this.ciaTextBox = new System.Windows.Forms.TextBox();
            this.chaveTextBox = new System.Windows.Forms.TextBox();
            this.trafoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter();
            this.listGPS = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer();
            chaveDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ciaDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            gps_timeDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            alimentadorDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            usuario_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            chaveLabel = new System.Windows.Forms.Label();
            ciaLabel = new System.Windows.Forms.Label();
            alimentadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chaveDataGridColumnStyleDataGridTextBoxColumn
            // 
            chaveDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            chaveDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            chaveDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "chave";
            chaveDataGridColumnStyleDataGridTextBoxColumn.MappingName = "chave";
            // 
            // ciaDataGridColumnStyleDataGridTextBoxColumn
            // 
            ciaDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            ciaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            ciaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cia";
            ciaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cia";
            // 
            // gps_timeDataGridColumnStyleDataGridTextBoxColumn
            // 
            gps_timeDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            gps_timeDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            gps_timeDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "gps_time";
            gps_timeDataGridColumnStyleDataGridTextBoxColumn.MappingName = "gps_time";
            // 
            // alimentadorDataGridColumnStyleDataGridTextBoxColumn
            // 
            alimentadorDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            alimentadorDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            alimentadorDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "alimentador";
            alimentadorDataGridColumnStyleDataGridTextBoxColumn.MappingName = "alimentador";
            // 
            // usuario_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            usuario_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            usuario_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            usuario_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "usuario_id";
            usuario_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "usuario_id";
            // 
            // programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "programacao_ip_id";
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "programacao_ip_id";
            // 
            // chaveLabel
            // 
            chaveLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            chaveLabel.Location = new System.Drawing.Point(52, 10);
            chaveLabel.Name = "chaveLabel";
            chaveLabel.Size = new System.Drawing.Size(46, 14);
            chaveLabel.Text = "chave:";
            // 
            // ciaLabel
            // 
            ciaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ciaLabel.Location = new System.Drawing.Point(71, 37);
            ciaLabel.Name = "ciaLabel";
            ciaLabel.Size = new System.Drawing.Size(27, 14);
            ciaLabel.Text = "cia:";
            // 
            // alimentadorLabel
            // 
            alimentadorLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            alimentadorLabel.Location = new System.Drawing.Point(14, 64);
            alimentadorLabel.Name = "alimentadorLabel";
            alimentadorLabel.Size = new System.Drawing.Size(84, 14);
            alimentadorLabel.Text = "alimentador:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Novo";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Salvar";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
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
            // trafoBindingSource
            // 
            this.trafoBindingSource.DataMember = "trafo";
            this.trafoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trafoDataGrid
            // 
            this.trafoDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trafoDataGrid.DataSource = this.trafoBindingSource;
            this.trafoDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trafoDataGrid.Location = new System.Drawing.Point(0, 0);
            this.trafoDataGrid.Name = "trafoDataGrid";
            this.trafoDataGrid.RowHeadersVisible = false;
            this.trafoDataGrid.Size = new System.Drawing.Size(240, 271);
            this.trafoDataGrid.TabIndex = 1;
            this.trafoDataGrid.TableStyles.Add(this.trafoTableStyleDataGridTableStyle);
            // 
            // trafoTableStyleDataGridTableStyle
            // 
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(chaveDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(ciaDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(gps_timeDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(alimentadorDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(usuario_idDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.MappingName = "trafo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 294);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trafoDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 271);
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listGPS);
            this.tabPage2.Controls.Add(alimentadorLabel);
            this.tabPage2.Controls.Add(this.alimentadorTextBox);
            this.tabPage2.Controls.Add(ciaLabel);
            this.tabPage2.Controls.Add(this.ciaTextBox);
            this.tabPage2.Controls.Add(chaveLabel);
            this.tabPage2.Controls.Add(this.chaveTextBox);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 271);
            this.tabPage2.Text = "tabPage2";
            // 
            // alimentadorTextBox
            // 
            this.alimentadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "alimentador", true));
            this.alimentadorTextBox.Location = new System.Drawing.Point(105, 61);
            this.alimentadorTextBox.Name = "alimentadorTextBox";
            this.alimentadorTextBox.Size = new System.Drawing.Size(100, 21);
            this.alimentadorTextBox.TabIndex = 5;
            // 
            // ciaTextBox
            // 
            this.ciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "cia", true));
            this.ciaTextBox.Location = new System.Drawing.Point(105, 34);
            this.ciaTextBox.Name = "ciaTextBox";
            this.ciaTextBox.Size = new System.Drawing.Size(100, 21);
            this.ciaTextBox.TabIndex = 3;
            // 
            // chaveTextBox
            // 
            this.chaveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "chave", true));
            this.chaveTextBox.Location = new System.Drawing.Point(105, 7);
            this.chaveTextBox.Name = "chaveTextBox";
            this.chaveTextBox.Size = new System.Drawing.Size(100, 21);
            this.chaveTextBox.TabIndex = 1;
            // 
            // trafoTableAdapter
            // 
            this.trafoTableAdapter.ClearBeforeFill = true;
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
            this.listGPS.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CadastrarTrafo
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
            this.Name = "CadastrarTrafo";
            this.Text = "CadastrarTrafo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarTrafo_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.CadastrarTrafo_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource trafoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter trafoTableAdapter;
        private System.Windows.Forms.DataGrid trafoDataGrid;
        private System.Windows.Forms.DataGridTableStyle trafoTableStyleDataGridTableStyle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.TextBox alimentadorTextBox;
        private System.Windows.Forms.TextBox ciaTextBox;
        private System.Windows.Forms.TextBox chaveTextBox;
        private System.Windows.Forms.ListBox listGPS;
        private System.Windows.Forms.Timer timer1;
    }
}