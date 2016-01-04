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
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).BeginInit();
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
            // EnviarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
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
    }
}