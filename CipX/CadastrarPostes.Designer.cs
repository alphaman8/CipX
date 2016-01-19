namespace CipX
{
    partial class CadastrarPostes
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
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.posteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.posteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.condicaoriscoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ativacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bracoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bracoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter();
            this.faseTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter();
            this.ativacaoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter();
            this.condicao_riscoTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.condicao_riscoTableAdapter();
            this.posteTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoriscoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem10);
            this.menuItem1.MenuItems.Add(this.menuItem12);
            this.menuItem1.MenuItems.Add(this.menuItem11);
            this.menuItem1.MenuItems.Add(this.menuItem7);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Novo";
            this.menuItem4.Click += new System.EventHandler(this.novo);
            // 
            // menuItem10
            // 
            this.menuItem10.Text = "Salvar";
            this.menuItem10.Click += new System.EventHandler(this.salvar);
            // 
            // menuItem12
            // 
            this.menuItem12.Text = "Croqui";
            this.menuItem12.Click += new System.EventHandler(this.croqui);
            // 
            // menuItem11
            // 
            this.menuItem11.Text = "-";
            // 
            // menuItem7
            // 
            this.menuItem7.MenuItems.Add(this.menuItem5);
            this.menuItem7.MenuItems.Add(this.menuItem9);
            this.menuItem7.Text = "Componentes";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Luminárias";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "Uso Mútuo";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
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
            // posteBindingSource
            // 
            this.posteBindingSource.DataMember = "poste";
            this.posteBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posteBindingSource1
            // 
            this.posteBindingSource1.DataMember = "poste";
            this.posteBindingSource1.DataSource = this.eletrocadDataSet;
            // 
            // condicaoriscoBindingSource
            // 
            this.condicaoriscoBindingSource.DataMember = "condicao_risco";
            this.condicaoriscoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // ativacaoBindingSource
            // 
            this.ativacaoBindingSource.DataMember = "ativacao";
            this.ativacaoBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // faseBindingSource
            // 
            this.faseBindingSource.DataMember = "fase";
            this.faseBindingSource.DataSource = this.eletrocadDataSet;
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
            // faseTableAdapter
            // 
            this.faseTableAdapter.ClearBeforeFill = true;
            // 
            // ativacaoTableAdapter
            // 
            this.ativacaoTableAdapter.ClearBeforeFill = true;
            // 
            // condicao_riscoTableAdapter
            // 
            this.condicao_riscoTableAdapter.ClearBeforeFill = true;
            // 
            // posteTableAdapter
            // 
            this.posteTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarPostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CadastrarPostes";
            this.Text = "CadastrarPostes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarPostes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoriscoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.BindingSource bracoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.bracoTableAdapter bracoTableAdapter;
        private System.Windows.Forms.BindingSource faseBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.faseTableAdapter faseTableAdapter;
        private System.Windows.Forms.BindingSource ativacaoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.ativacaoTableAdapter ativacaoTableAdapter;
        private System.Windows.Forms.BindingSource condicaoriscoBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.condicao_riscoTableAdapter condicao_riscoTableAdapter;
        private System.Windows.Forms.BindingSource posteBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.posteTableAdapter posteTableAdapter;
        private System.Windows.Forms.BindingSource posteBindingSource1;
    }
}