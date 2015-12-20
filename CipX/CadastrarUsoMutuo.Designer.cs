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
            System.Windows.Forms.DataGridTextBoxColumn descricaoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label poste_idLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.usomutuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uso_mutuoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.uso_mutuoTableAdapter();
            this.postehasusomutuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_uso_mutuoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter();
            this.poste_has_uso_mutuoDataGrid = new System.Windows.Forms.DataGrid();
            this.poste_has_uso_mutuoTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.poste_idTextBox = new System.Windows.Forms.TextBox();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            descricaoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            descricaoLabel = new System.Windows.Forms.Label();
            poste_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usomutuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoDataGridColumnStyleDataGridTextBoxColumn
            // 
            descricaoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            descricaoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            descricaoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "descricao";
            descricaoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "descricao";
            // 
            // descricaoLabel
            // 
            descricaoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            descricaoLabel.Location = new System.Drawing.Point(11, 14);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(67, 14);
            descricaoLabel.Text = "descricao:";
            // 
            // poste_idLabel
            // 
            poste_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            poste_idLabel.Location = new System.Drawing.Point(17, 45);
            poste_idLabel.Name = "poste_idLabel";
            poste_idLabel.Size = new System.Drawing.Size(61, 14);
            poste_idLabel.Text = "poste id:";
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
            // menuItem3
            // 
            this.menuItem3.Text = "-";
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
            // postehasusomutuoBindingSource
            // 
            this.postehasusomutuoBindingSource.DataMember = "poste_has_uso_mutuo";
            this.postehasusomutuoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_uso_mutuoTableAdapter
            // 
            this.poste_has_uso_mutuoTableAdapter.ClearBeforeFill = true;
            // 
            // poste_has_uso_mutuoDataGrid
            // 
            this.poste_has_uso_mutuoDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.poste_has_uso_mutuoDataGrid.DataSource = this.postehasusomutuoBindingSource;
            this.poste_has_uso_mutuoDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.poste_has_uso_mutuoDataGrid.Location = new System.Drawing.Point(0, 115);
            this.poste_has_uso_mutuoDataGrid.Name = "poste_has_uso_mutuoDataGrid";
            this.poste_has_uso_mutuoDataGrid.Size = new System.Drawing.Size(240, 159);
            this.poste_has_uso_mutuoDataGrid.TabIndex = 0;
            this.poste_has_uso_mutuoDataGrid.TableStyles.Add(this.poste_has_uso_mutuoTableStyleDataGridTableStyle);
            // 
            // poste_has_uso_mutuoTableStyleDataGridTableStyle
            // 
            this.poste_has_uso_mutuoTableStyleDataGridTableStyle.GridColumnStyles.Add(descricaoDataGridColumnStyleDataGridTextBoxColumn);
            this.poste_has_uso_mutuoTableStyleDataGridTableStyle.MappingName = "poste_has_uso_mutuo";
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehasusomutuoBindingSource, "uso_mutuo_id", true));
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehasusomutuoBindingSource, "descricao", true));
            this.descricaoComboBox.DataSource = this.usomutuoBindingSource;
            this.descricaoComboBox.DisplayMember = "descricao";
            this.descricaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.descricaoComboBox.Location = new System.Drawing.Point(85, 14);
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.Size = new System.Drawing.Size(100, 22);
            this.descricaoComboBox.TabIndex = 2;
            this.descricaoComboBox.ValueMember = "id";
            // 
            // poste_idTextBox
            // 
            this.poste_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehasusomutuoBindingSource, "poste_id", true));
            this.poste_idTextBox.Enabled = false;
            this.poste_idTextBox.Location = new System.Drawing.Point(85, 42);
            this.poste_idTextBox.Name = "poste_idTextBox";
            this.poste_idTextBox.ReadOnly = true;
            this.poste_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.poste_idTextBox.TabIndex = 4;
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Atualizar Uso Mútuo";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
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
            // CadastrarUsoMutuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(poste_idLabel);
            this.Controls.Add(this.poste_idTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoComboBox);
            this.Controls.Add(this.poste_has_uso_mutuoDataGrid);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CadastrarUsoMutuo";
            this.Text = "CadastrarUsoMutuo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarUsoMutuo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usomutuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource usomutuoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.uso_mutuoTableAdapter uso_mutuoTableAdapter;
        private System.Windows.Forms.BindingSource postehasusomutuoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter poste_has_uso_mutuoTableAdapter;
        private System.Windows.Forms.DataGrid poste_has_uso_mutuoDataGrid;
        private System.Windows.Forms.DataGridTableStyle poste_has_uso_mutuoTableStyleDataGridTableStyle;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.TextBox poste_idTextBox;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.Label label1;
    }
}