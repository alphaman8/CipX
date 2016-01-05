namespace CipX
{
    partial class EnviarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarDados));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.trafoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trafoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter();
            this.listEnviar = new System.Windows.Forms.ListBox();
            this.posteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posteTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter();
            this.postehaslampadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_lampadaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_lampadaTableAdapter();
            this.button1 = new CipX.components.ButtonImage(this.components);
            this.postehasreatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_reatorTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_reatorTableAdapter();
            this.postehasusomutuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_uso_mutuoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter();
            this.postehastipoluminariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poste_has_tipo_luminariaTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehaslampadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasreatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Enviar";
            this.menuItem3.Click += new System.EventHandler(this.enviar);
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
            // trafoBindingSource
            // 
            this.trafoBindingSource.DataMember = "trafo";
            this.trafoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // trafoTableAdapter
            // 
            this.trafoTableAdapter.ClearBeforeFill = true;
            // 
            // listEnviar
            // 
            this.listEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listEnviar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listEnviar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.listEnviar.ForeColor = System.Drawing.Color.Lime;
            this.listEnviar.Location = new System.Drawing.Point(0, 175);
            this.listEnviar.Name = "listEnviar";
            this.listEnviar.Size = new System.Drawing.Size(240, 119);
            this.listEnviar.TabIndex = 2;
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
            // postehaslampadaBindingSource
            // 
            this.postehaslampadaBindingSource.DataMember = "poste_has_lampada";
            this.postehaslampadaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_lampadaTableAdapter
            // 
            this.poste_has_lampadaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enviar";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // postehasreatorBindingSource
            // 
            this.postehasreatorBindingSource.DataMember = "poste_has_reator";
            this.postehasreatorBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_reatorTableAdapter
            // 
            this.poste_has_reatorTableAdapter.ClearBeforeFill = true;
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
            // postehastipoluminariaBindingSource
            // 
            this.postehastipoluminariaBindingSource.DataMember = "poste_has_tipo_luminaria";
            this.postehastipoluminariaBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // poste_has_tipo_luminariaTableAdapter
            // 
            this.poste_has_tipo_luminariaTableAdapter.ClearBeforeFill = true;
            // 
            // EnviarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listEnviar);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "EnviarDados";
            this.Text = "EnviarDados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EnviarDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehaslampadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasreatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehasusomutuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postehastipoluminariaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource trafoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.trafoTableAdapter trafoTableAdapter;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.ListBox listEnviar;
        private System.Windows.Forms.BindingSource posteBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter posteTableAdapter;
        private CipX.components.ButtonImage button1;
        private System.Windows.Forms.BindingSource postehaslampadaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_lampadaTableAdapter poste_has_lampadaTableAdapter;
        private System.Windows.Forms.BindingSource postehasreatorBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_reatorTableAdapter poste_has_reatorTableAdapter;
        private System.Windows.Forms.BindingSource postehasusomutuoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_uso_mutuoTableAdapter poste_has_uso_mutuoTableAdapter;
        private System.Windows.Forms.BindingSource postehastipoluminariaBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.poste_has_tipo_luminariaTableAdapter poste_has_tipo_luminariaTableAdapter;
    }
}