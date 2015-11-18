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
            System.Windows.Forms.DataGridTextBoxColumn idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn regionalDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn cod_localDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn ultimo_levantamentoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn inicio_programadoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn termino_programadoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn pontos_projetadoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn cliente_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn data_faturamentoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn pr_situacao_base_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn total_pt_levantadoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn inicioDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn fimDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn relatorios_entregueDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn cd_entregueDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn shape_entregueDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn shape_atualiza_inicoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn shape_atualiza_fimDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn pr_ip_situacao_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn valor_faturadoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn municipio_idDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.eletrocadDataSet = new CipX.db.eletrocadDataSet();
            this.programacaoipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programacao_ipTableAdapter = new CipX.db.eletrocadDataSetTableAdapters.programacao_ipTableAdapter();
            this.programacao_ipDataGrid = new System.Windows.Forms.DataGrid();
            this.programacao_ipTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            regionalDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            cod_localDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ultimo_levantamentoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            pontos_projetadoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            cliente_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            data_faturamentoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            pr_situacao_base_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            total_pt_levantadoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            inicioDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            fimDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            relatorios_entregueDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            cd_entregueDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            shape_entregueDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            shape_atualiza_inicoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            shape_atualiza_fimDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            pr_ip_situacao_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            valor_faturadoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            municipio_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programacaoipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Atualizar";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // eletrocadDataSet
            // 
            this.eletrocadDataSet.DataSetName = "eletrocadDataSet";
            this.eletrocadDataSet.Prefix = "";
            this.eletrocadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programacaoipBindingSource
            // 
            this.programacaoipBindingSource.DataMember = "programacao_ip";
            this.programacaoipBindingSource.DataSource = this.eletrocadDataSet;
            // 
            // programacao_ipTableAdapter
            // 
            this.programacao_ipTableAdapter.ClearBeforeFill = true;
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
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(idDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(regionalDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(cod_localDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(ultimo_levantamentoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(inicio_programadoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(termino_programadoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(pontos_projetadoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(cliente_idDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(data_faturamentoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(pr_situacao_base_idDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(total_pt_levantadoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(inicioDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(fimDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(relatorios_entregueDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(cd_entregueDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(shape_entregueDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(shape_atualiza_inicoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(shape_atualiza_fimDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(pr_ip_situacao_idDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(valor_faturadoDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.GridColumnStyles.Add(municipio_idDataGridColumnStyleDataGridTextBoxColumn);
            this.programacao_ipTableStyleDataGridTableStyle.MappingName = "programacao_ip";
            // 
            // idDataGridColumnStyleDataGridTextBoxColumn
            // 
            idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "id";
            idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "id";
            // 
            // regionalDataGridColumnStyleDataGridTextBoxColumn
            // 
            regionalDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            regionalDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            regionalDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "regional";
            regionalDataGridColumnStyleDataGridTextBoxColumn.MappingName = "regional";
            // 
            // cod_localDataGridColumnStyleDataGridTextBoxColumn
            // 
            cod_localDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            cod_localDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            cod_localDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cod_local";
            cod_localDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cod_local";
            // 
            // ultimo_levantamentoDataGridColumnStyleDataGridTextBoxColumn
            // 
            ultimo_levantamentoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            ultimo_levantamentoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            ultimo_levantamentoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "ultimo_levantamento";
            ultimo_levantamentoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "ultimo_levantamento";
            // 
            // inicio_programadoDataGridColumnStyleDataGridTextBoxColumn
            // 
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "inicio_programado";
            inicio_programadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "inicio_programado";
            // 
            // termino_programadoDataGridColumnStyleDataGridTextBoxColumn
            // 
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "termino_programado";
            termino_programadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "termino_programado";
            // 
            // pontos_projetadoDataGridColumnStyleDataGridTextBoxColumn
            // 
            pontos_projetadoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            pontos_projetadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            pontos_projetadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "pontos_projetado";
            pontos_projetadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "pontos_projetado";
            // 
            // cliente_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            cliente_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            cliente_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            cliente_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cliente_id";
            cliente_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cliente_id";
            // 
            // data_faturamentoDataGridColumnStyleDataGridTextBoxColumn
            // 
            data_faturamentoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            data_faturamentoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            data_faturamentoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "data_faturamento";
            data_faturamentoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "data_faturamento";
            // 
            // pr_situacao_base_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            pr_situacao_base_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            pr_situacao_base_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            pr_situacao_base_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "pr_situacao_base_id";
            pr_situacao_base_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "pr_situacao_base_id";
            // 
            // total_pt_levantadoDataGridColumnStyleDataGridTextBoxColumn
            // 
            total_pt_levantadoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            total_pt_levantadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            total_pt_levantadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "total_pt_levantado";
            total_pt_levantadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "total_pt_levantado";
            // 
            // inicioDataGridColumnStyleDataGridTextBoxColumn
            // 
            inicioDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            inicioDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            inicioDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "inicio";
            inicioDataGridColumnStyleDataGridTextBoxColumn.MappingName = "inicio";
            // 
            // fimDataGridColumnStyleDataGridTextBoxColumn
            // 
            fimDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            fimDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            fimDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "fim";
            fimDataGridColumnStyleDataGridTextBoxColumn.MappingName = "fim";
            // 
            // relatorios_entregueDataGridColumnStyleDataGridTextBoxColumn
            // 
            relatorios_entregueDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            relatorios_entregueDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            relatorios_entregueDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "relatorios_entregue";
            relatorios_entregueDataGridColumnStyleDataGridTextBoxColumn.MappingName = "relatorios_entregue";
            // 
            // cd_entregueDataGridColumnStyleDataGridTextBoxColumn
            // 
            cd_entregueDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            cd_entregueDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            cd_entregueDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cd_entregue";
            cd_entregueDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cd_entregue";
            // 
            // shape_entregueDataGridColumnStyleDataGridTextBoxColumn
            // 
            shape_entregueDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            shape_entregueDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            shape_entregueDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "shape_entregue";
            shape_entregueDataGridColumnStyleDataGridTextBoxColumn.MappingName = "shape_entregue";
            // 
            // shape_atualiza_inicoDataGridColumnStyleDataGridTextBoxColumn
            // 
            shape_atualiza_inicoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            shape_atualiza_inicoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            shape_atualiza_inicoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "shape_atualiza_inico";
            shape_atualiza_inicoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "shape_atualiza_inico";
            // 
            // shape_atualiza_fimDataGridColumnStyleDataGridTextBoxColumn
            // 
            shape_atualiza_fimDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            shape_atualiza_fimDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            shape_atualiza_fimDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "shape_atualiza_fim";
            shape_atualiza_fimDataGridColumnStyleDataGridTextBoxColumn.MappingName = "shape_atualiza_fim";
            // 
            // pr_ip_situacao_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            pr_ip_situacao_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            pr_ip_situacao_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            pr_ip_situacao_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "pr_ip_situacao_id";
            pr_ip_situacao_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "pr_ip_situacao_id";
            // 
            // valor_faturadoDataGridColumnStyleDataGridTextBoxColumn
            // 
            valor_faturadoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            valor_faturadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            valor_faturadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "valor_faturado";
            valor_faturadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "valor_faturado";
            // 
            // municipio_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "municipio_id";
            municipio_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "municipio_id";
            // 
            // CadastroProgramacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.programacao_ipDataGrid);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CadastroProgramacao";
            this.Text = "CadastroProgramacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroProgramacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eletrocadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programacaoipBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private CipX.db.eletrocadDataSet eletrocadDataSet;
        private System.Windows.Forms.BindingSource programacaoipBindingSource;
        private CipX.db.eletrocadDataSetTableAdapters.programacao_ipTableAdapter programacao_ipTableAdapter;
        private System.Windows.Forms.DataGrid programacao_ipDataGrid;
        private System.Windows.Forms.DataGridTableStyle programacao_ipTableStyleDataGridTableStyle;
    }
}