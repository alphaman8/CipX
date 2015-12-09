namespace CipX
{
    partial class CadastrarUsoMutuo
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
            System.Windows.Forms.DataGridTextBoxColumn poste_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn uso_mutuo_idDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.usomutuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uso_mutuoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.uso_mutuoTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.poste_has_uso_mutuoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter();
            this.postehasusomutuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_uso_mutuoDataGrid = new System.Windows.Forms.DataGrid();
            this.poste_has_uso_mutuoTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            poste_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            uso_mutuo_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usomutuoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
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
            // usomutuoBindingSource
            // 
            this.usomutuoBindingSource.DataMember = "uso_mutuo";
            this.usomutuoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // uso_mutuoTableAdapter
            // 
            this.uso_mutuoTableAdapter.ClearBeforeFill = true;
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
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.poste_has_uso_mutuoDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 271);
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 271);
            this.tabPage2.Text = "tabPage2";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehasusomutuoBindingSource, "uso_mutuo_id", true));
            this.textBox1.Location = new System.Drawing.Point(133, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // poste_has_uso_mutuoTableAdapter
            // 
            this.poste_has_uso_mutuoTableAdapter.ClearBeforeFill = true;
            // 
            // postehasusomutuoBindingSource
            // 
            this.postehasusomutuoBindingSource.DataMember = "poste_has_uso_mutuo";
            this.postehasusomutuoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_uso_mutuoDataGrid
            // 
            this.poste_has_uso_mutuoDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.poste_has_uso_mutuoDataGrid.DataSource = this.postehasusomutuoBindingSource;
            this.poste_has_uso_mutuoDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poste_has_uso_mutuoDataGrid.Location = new System.Drawing.Point(0, 0);
            this.poste_has_uso_mutuoDataGrid.Name = "poste_has_uso_mutuoDataGrid";
            this.poste_has_uso_mutuoDataGrid.RowHeadersVisible = false;
            this.poste_has_uso_mutuoDataGrid.Size = new System.Drawing.Size(240, 271);
            this.poste_has_uso_mutuoDataGrid.TabIndex = 1;
            this.poste_has_uso_mutuoDataGrid.TableStyles.Add(this.poste_has_uso_mutuoTableStyleDataGridTableStyle);
            // 
            // poste_has_uso_mutuoTableStyleDataGridTableStyle
            // 
            this.poste_has_uso_mutuoTableStyleDataGridTableStyle.GridColumnStyles.Add(poste_idDataGridColumnStyleDataGridTextBoxColumn);
            this.poste_has_uso_mutuoTableStyleDataGridTableStyle.GridColumnStyles.Add(uso_mutuo_idDataGridColumnStyleDataGridTextBoxColumn);
            this.poste_has_uso_mutuoTableStyleDataGridTableStyle.MappingName = "poste_has_uso_mutuo";
            // 
            // poste_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            poste_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            poste_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            poste_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "poste_id";
            poste_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "poste_id";
            // 
            // uso_mutuo_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            uso_mutuo_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            uso_mutuo_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            uso_mutuo_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "uso_mutuo_id";
            uso_mutuo_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "uso_mutuo_id";
            // 
            // CadastrarUsoMutuo
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
            this.Name = "CadastrarUsoMutuo";
            this.Text = "CadastrarUsoMutuo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarUsoMutuo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usomutuoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource usomutuoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.uso_mutuoTableAdapter uso_mutuoTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource postehasusomutuoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter poste_has_uso_mutuoTableAdapter;
        private System.Windows.Forms.DataGrid poste_has_uso_mutuoDataGrid;
        private System.Windows.Forms.DataGridTableStyle poste_has_uso_mutuoTableStyleDataGridTableStyle;
    }
}