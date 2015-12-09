namespace CipX
{
    partial class CadastrarLampadas
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
            System.Windows.Forms.DataGridTextBoxColumn lampada_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.Label lampada_idLabel;
            System.Windows.Forms.Label poste_idLabel;
            System.Windows.Forms.Label descricaoLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.postehaslampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_lampadaTableAdapter();
            this.poste_has_lampadaDataGrid = new System.Windows.Forms.DataGrid();
            this.poste_has_lampadaTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tipolampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.tipo_lampadaTableAdapter();
            this.lampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lampadaCb = new System.Windows.Forms.ComboBox();
            this.poste_idTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter();
            lampada_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            lampada_idLabel = new System.Windows.Forms.Label();
            poste_idLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehaslampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipolampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lampada_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            lampada_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            lampada_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            lampada_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Lampadas";
            lampada_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "descricao";
            lampada_idDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // lampada_idLabel
            // 
            lampada_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            lampada_idLabel.Location = new System.Drawing.Point(18, 15);
            lampada_idLabel.Name = "lampada_idLabel";
            lampada_idLabel.Size = new System.Drawing.Size(77, 14);
            lampada_idLabel.Text = "lampada id:";
            // 
            // poste_idLabel
            // 
            poste_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            poste_idLabel.Location = new System.Drawing.Point(33, 46);
            poste_idLabel.Name = "poste_idLabel";
            poste_idLabel.Size = new System.Drawing.Size(61, 14);
            poste_idLabel.Text = "poste id:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            descricaoLabel.Location = new System.Drawing.Point(27, 73);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(67, 14);
            descricaoLabel.Text = "descricao:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Novo";
            this.menuItem3.Click += new System.EventHandler(this.novo);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Salvar";
            this.menuItem5.Click += new System.EventHandler(this.salvar);
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
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postehaslampadaBindingSource
            // 
            this.postehaslampadaBindingSource.DataMember = "poste_has_lampada";
            this.postehaslampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_lampadaTableAdapter
            // 
            this.poste_has_lampadaTableAdapter.ClearBeforeFill = true;
            // 
            // poste_has_lampadaDataGrid
            // 
            this.poste_has_lampadaDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.poste_has_lampadaDataGrid.DataSource = this.postehaslampadaBindingSource;
            this.poste_has_lampadaDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.poste_has_lampadaDataGrid.Location = new System.Drawing.Point(0, 112);
            this.poste_has_lampadaDataGrid.Name = "poste_has_lampadaDataGrid";
            this.poste_has_lampadaDataGrid.RowHeadersVisible = false;
            this.poste_has_lampadaDataGrid.Size = new System.Drawing.Size(240, 182);
            this.poste_has_lampadaDataGrid.TabIndex = 1;
            this.poste_has_lampadaDataGrid.TableStyles.Add(this.poste_has_lampadaTableStyleDataGridTableStyle);
            // 
            // poste_has_lampadaTableStyleDataGridTableStyle
            // 
            this.poste_has_lampadaTableStyleDataGridTableStyle.GridColumnStyles.Add(lampada_idDataGridColumnStyleDataGridTextBoxColumn);
            this.poste_has_lampadaTableStyleDataGridTableStyle.MappingName = "poste_has_lampada";
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
            // lampadaBindingSource
            // 
            this.lampadaBindingSource.DataMember = "lampada";
            this.lampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // lampadaCb
            // 
            this.lampadaCb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehaslampadaBindingSource, "lampada_id", true));
            this.lampadaCb.DataSource = this.lampadaBindingSource;
            this.lampadaCb.DisplayMember = "descricao";
            this.lampadaCb.Location = new System.Drawing.Point(101, 15);
            this.lampadaCb.Name = "lampadaCb";
            this.lampadaCb.Size = new System.Drawing.Size(100, 22);
            this.lampadaCb.TabIndex = 3;
            this.lampadaCb.ValueMember = "id";
            this.lampadaCb.SelectedIndexChanged += new System.EventHandler(this.lampadaCb_SelectedIndexChanged);
            // 
            // poste_idTextBox
            // 
            this.poste_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehaslampadaBindingSource, "poste_id", true));
            this.poste_idTextBox.Location = new System.Drawing.Point(101, 43);
            this.poste_idTextBox.Name = "poste_idTextBox";
            this.poste_idTextBox.ReadOnly = true;
            this.poste_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.poste_idTextBox.TabIndex = 4;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehaslampadaBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(101, 70);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 21);
            this.descricaoTextBox.TabIndex = 6;
            // 
            // lampadaTableAdapter
            // 
            this.lampadaTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarLampadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(poste_idLabel);
            this.Controls.Add(this.poste_idTextBox);
            this.Controls.Add(this.lampadaCb);
            this.Controls.Add(lampada_idLabel);
            this.Controls.Add(this.poste_has_lampadaDataGrid);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CadastrarLampadas";
            this.Text = "CadastrarLampadas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarLampadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehaslampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipolampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource postehaslampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_lampadaTableAdapter poste_has_lampadaTableAdapter;
        private System.Windows.Forms.DataGrid poste_has_lampadaDataGrid;
        private System.Windows.Forms.DataGridTableStyle poste_has_lampadaTableStyleDataGridTableStyle;
        private System.Windows.Forms.BindingSource tipolampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.tipo_lampadaTableAdapter tipo_lampadaTableAdapter;
        private System.Windows.Forms.ComboBox lampadaCb;
        private System.Windows.Forms.TextBox poste_idTextBox;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.BindingSource lampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter lampadaTableAdapter;
    }
}