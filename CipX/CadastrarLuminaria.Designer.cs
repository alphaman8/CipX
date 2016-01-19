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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label tipo_luminaria_idLabel;
            System.Windows.Forms.Label poste_idLabel;
            System.Windows.Forms.Label quantidadeLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.postehastipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.poste_has_tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter();
            this.tipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.tipo_luminariaTableAdapter();
            this.lampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter();
            this.reatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reatorTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.reatorTableAdapter();
            this.bracoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bracoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.poste_idTextBox = new System.Windows.Forms.TextBox();
            this.poste_has_tipo_luminariaDataGrid = new System.Windows.Forms.DataGrid();
            this.poste_has_tipo_luminariaTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tipo_luminaria_idLabel = new System.Windows.Forms.Label();
            poste_idLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // tipoluminariaBindingSource
            // 
            this.tipoluminariaBindingSource.DataMember = "tipo_luminaria";
            this.tipoluminariaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // tipo_luminariaTableAdapter
            // 
            this.tipo_luminariaTableAdapter.ClearBeforeFill = true;
            // 
            // lampadaBindingSource
            // 
            this.lampadaBindingSource.DataMember = "lampada";
            this.lampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // lampadaTableAdapter
            // 
            this.lampadaTableAdapter.ClearBeforeFill = true;
            // 
            // reatorBindingSource
            // 
            this.reatorBindingSource.DataMember = "reator";
            this.reatorBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // reatorTableAdapter
            // 
            this.reatorTableAdapter.ClearBeforeFill = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 294);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.poste_has_tipo_luminariaDataGrid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 271);
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(quantidadeLabel);
            this.tabPage2.Controls.Add(this.quantidadeTextBox);
            this.tabPage2.Controls.Add(label4);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(label3);
            this.tabPage2.Controls.Add(label2);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(tipo_luminaria_idLabel);
            this.tabPage2.Controls.Add(poste_idLabel);
            this.tabPage2.Controls.Add(this.poste_idTextBox);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 271);
            this.tabPage2.Text = "tabPage2";
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(17, 91);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 14);
            label4.Text = "Braço:";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "reator_id", true));
            this.comboBox4.DataSource = this.bracoBindingSource;
            this.comboBox4.DisplayMember = "descricao";
            this.comboBox4.Location = new System.Drawing.Point(133, 91);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 22);
            this.comboBox4.TabIndex = 24;
            this.comboBox4.ValueMember = "id";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(17, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 14);
            label3.Text = "Reator:";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(17, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 14);
            label2.Text = "Lâmpada:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "reator_id", true));
            this.comboBox3.DataSource = this.reatorBindingSource;
            this.comboBox3.DisplayMember = "descricao";
            this.comboBox3.Location = new System.Drawing.Point(133, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 22);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.ValueMember = "id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "lampada_id", true));
            this.comboBox2.DataSource = this.lampadaBindingSource;
            this.comboBox2.DisplayMember = "descricao";
            this.comboBox2.Location = new System.Drawing.Point(133, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 22);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.ValueMember = "id";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postehastipoluminariaBindingSource, "tipo_luminaria_id", true));
            this.comboBox1.DataSource = this.tipoluminariaBindingSource;
            this.comboBox1.DisplayMember = "descricao";
            this.comboBox1.Location = new System.Drawing.Point(133, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 22);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "id";
            // 
            // tipo_luminaria_idLabel
            // 
            tipo_luminaria_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tipo_luminaria_idLabel.Location = new System.Drawing.Point(17, 11);
            tipo_luminaria_idLabel.Name = "tipo_luminaria_idLabel";
            tipo_luminaria_idLabel.Size = new System.Drawing.Size(110, 14);
            tipo_luminaria_idLabel.Text = "tipo luminaria id:";
            // 
            // poste_idLabel
            // 
            poste_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            poste_idLabel.Location = new System.Drawing.Point(65, 250);
            poste_idLabel.Name = "poste_idLabel";
            poste_idLabel.Size = new System.Drawing.Size(61, 14);
            poste_idLabel.Text = "poste id:";
            poste_idLabel.Visible = false;
            // 
            // poste_idTextBox
            // 
            this.poste_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "poste_id", true));
            this.poste_idTextBox.Location = new System.Drawing.Point(133, 247);
            this.poste_idTextBox.Name = "poste_idTextBox";
            this.poste_idTextBox.ReadOnly = true;
            this.poste_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.poste_idTextBox.TabIndex = 20;
            this.poste_idTextBox.Visible = false;
            // 
            // poste_has_tipo_luminariaDataGrid
            // 
            this.poste_has_tipo_luminariaDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.poste_has_tipo_luminariaDataGrid.DataSource = this.postehastipoluminariaBindingSource;
            this.poste_has_tipo_luminariaDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poste_has_tipo_luminariaDataGrid.Location = new System.Drawing.Point(0, 0);
            this.poste_has_tipo_luminariaDataGrid.Name = "poste_has_tipo_luminariaDataGrid";
            this.poste_has_tipo_luminariaDataGrid.Size = new System.Drawing.Size(240, 251);
            this.poste_has_tipo_luminariaDataGrid.TabIndex = 3;
            this.poste_has_tipo_luminariaDataGrid.TableStyles.Add(this.poste_has_tipo_luminariaTableStyleDataGridTableStyle);
            // 
            // poste_has_tipo_luminariaTableStyleDataGridTableStyle
            // 
            this.poste_has_tipo_luminariaTableStyleDataGridTableStyle.MappingName = "poste_has_tipo_luminaria";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            quantidadeLabel.Location = new System.Drawing.Point(17, 119);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(81, 14);
            quantidadeLabel.Text = "quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postehastipoluminariaBindingSource, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(133, 119);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 21);
            this.quantidadeTextBox.TabIndex = 29;
            // 
            // CadastrarLuminaria
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
            this.Name = "CadastrarLuminaria";
            this.Text = "CadastrarLuminaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarLuminaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoluminariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource lampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.lampadaTableAdapter lampadaTableAdapter;
        private System.Windows.Forms.BindingSource reatorBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.reatorTableAdapter reatorTableAdapter;
        private System.Windows.Forms.BindingSource bracoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter bracoTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGrid poste_has_tipo_luminariaDataGrid;
        private System.Windows.Forms.DataGridTableStyle poste_has_tipo_luminariaTableStyleDataGridTableStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox poste_idTextBox;
    }
}