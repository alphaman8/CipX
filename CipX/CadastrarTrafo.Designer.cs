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
            System.Windows.Forms.DataGridTextBoxColumn programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.Label chaveLabel;
            System.Windows.Forms.Label ciaLabel;
            System.Windows.Forms.Label alimentadorLabel;
            System.Windows.Forms.Label gps_timeLabel;
            System.Windows.Forms.Label usuario_idLabel;
            System.Windows.Forms.Label programacao_ip_idLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.trafoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.trafoDataGrid = new System.Windows.Forms.DataGrid();
            this.trafoTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.programacao_ip_idTextBox = new System.Windows.Forms.TextBox();
            this.usuario_idTextBox = new System.Windows.Forms.TextBox();
            this.gps_timeTextBox = new System.Windows.Forms.TextBox();
            this.alimentadorTextBox = new System.Windows.Forms.TextBox();
            this.ciaTextBox = new System.Windows.Forms.TextBox();
            this.chaveTextBox = new System.Windows.Forms.TextBox();
            this.lblTtrafoId = new System.Windows.Forms.Label();
            this.trafoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            chaveDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ciaDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            chaveLabel = new System.Windows.Forms.Label();
            ciaLabel = new System.Windows.Forms.Label();
            alimentadorLabel = new System.Windows.Forms.Label();
            gps_timeLabel = new System.Windows.Forms.Label();
            usuario_idLabel = new System.Windows.Forms.Label();
            programacao_ip_idLabel = new System.Windows.Forms.Label();
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
            chaveDataGridColumnStyleDataGridTextBoxColumn.NullText = "";
            chaveDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // ciaDataGridColumnStyleDataGridTextBoxColumn
            // 
            ciaDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            ciaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            ciaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cia";
            ciaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cia";
            ciaDataGridColumnStyleDataGridTextBoxColumn.NullText = "";
            ciaDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "programacao_ip_id";
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "programacao_ip_id";
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.NullText = "";
            programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
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
            // gps_timeLabel
            // 
            gps_timeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            gps_timeLabel.Location = new System.Drawing.Point(34, 91);
            gps_timeLabel.Name = "gps_timeLabel";
            gps_timeLabel.Size = new System.Drawing.Size(64, 14);
            gps_timeLabel.Text = "gps time:";
            // 
            // usuario_idLabel
            // 
            usuario_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            usuario_idLabel.Location = new System.Drawing.Point(27, 199);
            usuario_idLabel.Name = "usuario_idLabel";
            usuario_idLabel.Size = new System.Drawing.Size(71, 14);
            usuario_idLabel.Text = "usuario id:";
            usuario_idLabel.Visible = false;
            // 
            // programacao_ip_idLabel
            // 
            programacao_ip_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            programacao_ip_idLabel.Location = new System.Drawing.Point(7, 226);
            programacao_ip_idLabel.Name = "programacao_ip_idLabel";
            programacao_ip_idLabel.Size = new System.Drawing.Size(91, 14);
            programacao_ip_idLabel.Text = "programação:";
            programacao_ip_idLabel.Visible = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem7);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.menuItem8);
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
            // menuItem7
            // 
            this.menuItem7.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Postes";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "Enviar Dados";
            this.menuItem8.Click += new System.EventHandler(this.enviarDados);
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
            this.trafoDataGrid.Size = new System.Drawing.Size(227, 251);
            this.trafoDataGrid.TabIndex = 1;
            this.trafoDataGrid.TableStyles.Add(this.trafoTableStyleDataGridTableStyle);
            // 
            // trafoTableStyleDataGridTableStyle
            // 
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(chaveDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(ciaDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(programacao_ip_idDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.MappingName = "trafo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(227, 274);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trafoDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(227, 251);
            this.tabPage1.Text = "Tabela";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(programacao_ip_idLabel);
            this.tabPage2.Controls.Add(this.programacao_ip_idTextBox);
            this.tabPage2.Controls.Add(usuario_idLabel);
            this.tabPage2.Controls.Add(this.usuario_idTextBox);
            this.tabPage2.Controls.Add(gps_timeLabel);
            this.tabPage2.Controls.Add(this.gps_timeTextBox);
            this.tabPage2.Controls.Add(alimentadorLabel);
            this.tabPage2.Controls.Add(this.alimentadorTextBox);
            this.tabPage2.Controls.Add(ciaLabel);
            this.tabPage2.Controls.Add(this.ciaTextBox);
            this.tabPage2.Controls.Add(chaveLabel);
            this.tabPage2.Controls.Add(this.chaveTextBox);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(219, 248);
            this.tabPage2.Text = "Formulário";
            // 
            // programacao_ip_idTextBox
            // 
            this.programacao_ip_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "programacao_ip_id", true));
            this.programacao_ip_idTextBox.Location = new System.Drawing.Point(105, 223);
            this.programacao_ip_idTextBox.Name = "programacao_ip_idTextBox";
            this.programacao_ip_idTextBox.ReadOnly = true;
            this.programacao_ip_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.programacao_ip_idTextBox.TabIndex = 17;
            this.programacao_ip_idTextBox.Visible = false;
            // 
            // usuario_idTextBox
            // 
            this.usuario_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "usuario_id", true));
            this.usuario_idTextBox.Location = new System.Drawing.Point(105, 196);
            this.usuario_idTextBox.Name = "usuario_idTextBox";
            this.usuario_idTextBox.ReadOnly = true;
            this.usuario_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.usuario_idTextBox.TabIndex = 16;
            this.usuario_idTextBox.Text = "USER";
            this.usuario_idTextBox.Visible = false;
            // 
            // gps_timeTextBox
            // 
            this.gps_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "gps_time", true));
            this.gps_timeTextBox.Location = new System.Drawing.Point(105, 88);
            this.gps_timeTextBox.Name = "gps_timeTextBox";
            this.gps_timeTextBox.ReadOnly = true;
            this.gps_timeTextBox.Size = new System.Drawing.Size(100, 21);
            this.gps_timeTextBox.TabIndex = 12;
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
            // lblTtrafoId
            // 
            this.lblTtrafoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTtrafoId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "id", true));
            this.lblTtrafoId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTtrafoId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblTtrafoId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTtrafoId.Location = new System.Drawing.Point(0, 294);
            this.lblTtrafoId.Name = "lblTtrafoId";
            this.lblTtrafoId.Size = new System.Drawing.Size(227, 20);
            this.lblTtrafoId.Text = "0";
            this.lblTtrafoId.Visible = false;
            // 
            // trafoTableAdapter
            // 
            this.trafoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.Text = "label1";
            // 
            // CadastrarTrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTtrafoId);
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
        private System.Windows.Forms.TextBox gps_timeTextBox;
        private System.Windows.Forms.TextBox usuario_idTextBox;
        private System.Windows.Forms.TextBox programacao_ip_idTextBox;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.Label lblTtrafoId;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.Label label1;
    }
}