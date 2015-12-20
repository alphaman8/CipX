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
            System.Windows.Forms.DataGridTextBoxColumn tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.Label poste_idLabel;
            System.Windows.Forms.Label tipo_luminaria_idLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.postehastipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.poste_has_tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter();
            this.poste_has_tipo_luminariaDataGrid = new System.Windows.Forms.DataGrid();
            this.poste_has_tipo_luminariaTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.poste_idTextBox = new System.Windows.Forms.TextBox();
            this.tipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.tipo_luminariaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            poste_idLabel = new System.Windows.Forms.Label();
            tipo_luminaria_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Luminária";
            tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "tipo_luminaria_id";
            tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // poste_idLabel
            // 
            poste_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            poste_idLabel.Location = new System.Drawing.Point(53, 47);
            poste_idLabel.Name = "poste_idLabel";
            poste_idLabel.Size = new System.Drawing.Size(61, 14);
            poste_idLabel.Text = "poste id:";
            // 
            // tipo_luminaria_idLabel
            // 
            tipo_luminaria_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tipo_luminaria_idLabel.Location = new System.Drawing.Point(4, 20);
            tipo_luminaria_idLabel.Name = "tipo_luminaria_idLabel";
            tipo_luminaria_idLabel.Size = new System.Drawing.Size(110, 14);
            tipo_luminaria_idLabel.Text = "tipo luminaria id:";
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
            this.menuItem6.Text = "Atualizar Luminária";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
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
            // poste_has_tipo_luminariaTableAdapter
            // 
            this.poste_has_tipo_luminariaTableAdapter.ClearBeforeFill = true;
            // 
            // poste_has_tipo_luminariaDataGrid
            // 
            this.poste_has_tipo_luminariaDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.poste_has_tipo_luminariaDataGrid.DataSource = this.postehastipoluminariaBindingSource;
            this.poste_has_tipo_luminariaDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.poste_has_tipo_luminariaDataGrid.Location = new System.Drawing.Point(0, 96);
            this.poste_has_tipo_luminariaDataGrid.Name = "poste_has_tipo_luminariaDataGrid";
            this.poste_has_tipo_luminariaDataGrid.Size = new System.Drawing.Size(240, 178);
            this.poste_has_tipo_luminariaDataGrid.TabIndex = 1;
            this.poste_has_tipo_luminariaDataGrid.TableStyles.Add(this.poste_has_tipo_luminariaTableStyleDataGridTableStyle);
            // 
            // poste_has_tipo_luminariaTableStyleDataGridTableStyle
            // 
            this.poste_has_tipo_luminariaTableStyleDataGridTableStyle.GridColumnStyles.Add(tipo_luminaria_idDataGridColumnStyleDataGridTextBoxColumn);
            this.poste_has_tipo_luminariaTableStyleDataGridTableStyle.MappingName = "poste_has_tipo_luminaria";
            // 
            // poste_idTextBox
            // 
            this.poste_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "poste_id", true));
            this.poste_idTextBox.Location = new System.Drawing.Point(121, 44);
            this.poste_idTextBox.Name = "poste_idTextBox";
            this.poste_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.poste_idTextBox.TabIndex = 3;
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
            this.comboBox1.Location = new System.Drawing.Point(120, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 22);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "id";
            // 
            // tipo_luminariaTableAdapter
            // 
            this.tipo_luminariaTableAdapter.ClearBeforeFill = true;
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
            // CadastrarLuminaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(tipo_luminaria_idLabel);
            this.Controls.Add(poste_idLabel);
            this.Controls.Add(this.poste_idTextBox);
            this.Controls.Add(this.poste_has_tipo_luminariaDataGrid);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CadastrarLuminaria";
            this.Text = "CadastrarLuminaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarLuminaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGrid poste_has_tipo_luminariaDataGrid;
        private System.Windows.Forms.DataGridTableStyle poste_has_tipo_luminariaTableStyleDataGridTableStyle;
        private System.Windows.Forms.TextBox poste_idTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tipoluminariaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.tipo_luminariaTableAdapter tipo_luminariaTableAdapter;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.Label label1;
    }
}