namespace CipX
{
    partial class CadastroProgramacao
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
            System.Windows.Forms.DataGridTextBoxColumn regionalDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn cod_localDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn inicio_programadoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn termino_programadoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn municipio_idDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.programacaoipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.programacao_ipDataGrid = new System.Windows.Forms.DataGrid();
            this.programacao_ipTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.programacao_ipTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.programacao_ipTableAdapter();
            regionalDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            cod_localDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            municipio_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.programacaoipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // regionalDataGridColumnStyleDataGridTextBoxColumn
            // 
            regionalDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            regionalDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            regionalDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "regional";
            regionalDataGridColumnStyleDataGridTextBoxColumn.MappingName = "regional";
            regionalDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // cod_localDataGridColumnStyleDataGridTextBoxColumn
            // 
            cod_localDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            cod_localDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            cod_localDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cod_local";
            cod_localDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cod_local";
            cod_localDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // inicio_programadoDataGridColumnStyleDataGridTextBoxColumn
            // 
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "inicio_programado";
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "inicio_programado";
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // termino_programadoDataGridColumnStyleDataGridTextBoxColumn
            // 
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "termino_programado";
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "termino_programado";
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // municipio_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "municipio_id";
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "municipio_id";
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Trafos";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Importar Programação";
            this.menuItem3.Click += new System.EventHandler(this.importar);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // programacaoipBindingSource
            // 
            this.programacaoipBindingSource.DataMember = "programacao_ip";
            this.programacaoipBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programacao_ipDataGrid
            // 
            this.programacao_ipDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.programacao_ipDataGrid.DataSource = this.programacaoipBindingSource;
            this.programacao_ipDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programacao_ipDataGrid.Location = new System.Drawing.Point(0, 0);
            this.programacao_ipDataGrid.Name = "programacao_ipDataGrid";
            this.programacao_ipDataGrid.RowHeadersVisible = false;
            this.programacao_ipDataGrid.Size = new System.Drawing.Size(240, 294);
            this.programacao_ipDataGrid.TabIndex = 0;
            this.programacao_ipDataGrid.TableStyles.Add(this.programacao_ipTableStyleDataGridTableStyle);
            // 
            // programacao_ipTableStyleDataGridTableStyle
            // 
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(regionalDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(cod_localDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(inicio_programadoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(termino_programadoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(municipio_idDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.MappingName = "programacao_ip";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacaoipBindingSource, "id", true));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(0, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // programacao_ipTableAdapter
            // 
            this.programacao_ipTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroProgramacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programacao_ipDataGrid);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CadastroProgramacao";
            this.Text = "CadastroProgramacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroProgramacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programacaoipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource programacaoipBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.programacao_ipTableAdapter programacao_ipTableAdapter;
        private System.Windows.Forms.DataGrid programacao_ipDataGrid;
        private System.Windows.Forms.DataGridTableStyle programacao_ipTableStyleDataGridTableStyle;
        private System.Windows.Forms.BindingSource pripsituacaoBindingSource;
        private System.Windows.Forms.BindingSource pripsituacaobaseBindingSource;
        private System.Windows.Forms.BindingSource contasreceberBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem3;
    }
}