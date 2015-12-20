using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CipX
{
    public partial class CadastroProgramacao : Form
    {
        public CadastroProgramacao()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroProgramacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_tipo_luminaria' table. You can move, or remove it, as needed.
            this.poste_has_tipo_luminariaTableAdapter.Fill(this.eletrocadDataSet.poste_has_tipo_luminaria);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_lampada' table. You can move, or remove it, as needed.
            this.poste_has_lampadaTableAdapter.Fill(this.eletrocadDataSet.poste_has_lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste' table. You can move, or remove it, as needed.
            this.posteTableAdapter.Fill(this.eletrocadDataSet.poste);
            // TODO: This line of code loads data into the 'eletrocadDataSet.trafo' table. You can move, or remove it, as needed.
            this.trafoTableAdapter.Fill(this.eletrocadDataSet.trafo);
            // TODO: This line of code loads data into the 'eletrocadDataSet.programacao_ip' table. You can move, or remove it, as needed.
            this.programacao_ipTableAdapter.Fill(this.eletrocadDataSet.programacao_ip);

            myconn = new MySqlConnection(strconn);
            myconn.StateChange += new StateChangeEventHandler(myconn_StateChange);

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        void myconn_StateChange(object sender, StateChangeEventArgs e)
        {
            if (myconn.State == ConnectionState.Open)
            {
                //
            }
            if (myconn.State == ConnectionState.Closed)
            {
                //
            }
            if (myconn.State == ConnectionState.Connecting)
            {
                //
            }
            Application.DoEvents();
        }

        private MySql.Data.MySqlClient.MySqlConnection myconn;
        string strconn =
            "Server=cipweb.com.br;Database=eletrocad;Uid=marcelo;Pwd=0830@rnmf;pooling=false;";

        private void limpaTabelas()
        {
            try
            {
                while (eletrocadDataSet.poste_has_tipo_luminaria.Count > 0)
                {
                    eletrocadDataSet.poste_has_tipo_luminaria.Rows[0].Delete();
                    poste_has_tipo_luminariaTableAdapter.Update(eletrocadDataSet.poste_has_tipo_luminaria);
                    eletrocadDataSet.poste_has_tipo_luminaria.AcceptChanges();
                }

                while (eletrocadDataSet.poste_has_lampada.Count > 0)
                {
                    eletrocadDataSet.poste_has_lampada.Rows[0].Delete();
                    poste_has_lampadaTableAdapter.Update(eletrocadDataSet.poste_has_lampada);
                    eletrocadDataSet.poste_has_lampada.AcceptChanges();
                }

                while (eletrocadDataSet.poste.Count > 0)
                {
                    eletrocadDataSet.poste.Rows[0].Delete();
                    posteTableAdapter.Update(eletrocadDataSet.poste);
                    eletrocadDataSet.poste.AcceptChanges();
                }

                while (eletrocadDataSet.trafo.Count > 0)
                {
                    eletrocadDataSet.trafo.Rows[0].Delete();
                    trafoTableAdapter.Update(eletrocadDataSet.trafo);
                    eletrocadDataSet.trafo.AcceptChanges();
                }

                // Remove all
                while (eletrocadDataSet.programacao_ip.Count > 0)
                {
                    eletrocadDataSet.programacao_ip.Rows[0].Delete();
                    programacao_ipTableAdapter.Update(eletrocadDataSet.programacao_ip);
                    eletrocadDataSet.programacao_ip.AcceptChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            importar();
        }

        public static int programacaoId;

        private void importar()
        {
            label1.Text = "Iniciando Importação. Aguarde";
            label1.Visible = true;

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            limpaTabelas();
            label1.Text = "Dados locais apagados";
            Application.DoEvents();

            //abre conexao
            try
            {
                myconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao servidor, verifique a sua conexão com a internet.");
            }

            if (myconn.State == ConnectionState.Open)
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                //inicia a transacao
                MySqlCommand mycommand = myconn.CreateCommand();
                mycommand.Connection = myconn;
                mycommand.CommandText =
                    "SELECT programacao_ip.id, " +
                    "programacao_ip.regional, " +
                    "programacao_ip.cod_local, " +
                    "programacao_ip.ultimo_levantamento, " +
                    "programacao_ip.inicio_programado, " +
                    "programacao_ip.termino_programado, " +
                    "programacao_ip.pontos_projetado, " +
                    "programacao_ip.cliente_id, " +
                    "programacao_ip.data_faturamento, " +
                    "programacao_ip.pr_situacao_base_id, " +
                    "programacao_ip.total_pt_levantado, " +
                    "programacao_ip.inicio, " +
                    "programacao_ip.fim, " +
                    "programacao_ip.relatorios_entregue, " +
                    "programacao_ip.cd_entregue, " +
                    "programacao_ip.shape_entregue, " +
                    "programacao_ip.shape_atualiza_inico, " +
                    "programacao_ip.shape_atualiza_fim, " +
                    "programacao_ip.pr_ip_situacao_id, " +
                    "programacao_ip.carta_apresentacao, " +
                    "programacao_ip.oficio_prefeitura, " +
                    "programacao_ip.carta_conclusao, " +
                    "programacao_ip.valor_faturado " +
                "FROM eletrocad.programacao_ip";
                //mycommand.Parameters.Clear();
                //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                try
                {
                    MySqlDataReader reader = mycommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.programacao_ipRow pipRow;
                        pipRow = eletrocadDataSet.programacao_ip.Newprogramacao_ipRow();
                        pipRow.id = reader.GetInt32("id");
                        pipRow.regional = reader.GetString("regional");
                        pipRow.cod_local = reader.GetString("cod_local");
                        pipRow.inicio_programado = reader.GetDateTime("inicio_programado");
                        pipRow.termino_programado = reader.GetDateTime("termino_programado");
                        pipRow.pontos_projetado = reader.GetString("pontos_projetado");
                        pipRow.cliente_id = reader.GetInt32("cliente_id");

                        eletrocadDataSet.programacao_ip.Rows.Add(pipRow);
                        
                    }
                    programacao_ipTableAdapter.Update(eletrocadDataSet.programacao_ip);
                    eletrocadDataSet.programacao_ip.AcceptChanges();
                    programacao_ipTableAdapter.Fill(eletrocadDataSet.programacao_ip);

                    reader.Close();

                    Cursor.Current = Cursors.Default;
                    Application.DoEvents();
                    MessageBox.Show("Informações recuperadas com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível importar: " + ex.Message);
                }
                finally
                {
                    //myconn.Close();
                }
            }
            myconn.Close();
            label1.Visible = false;
            Cursor.Current = Cursors.Default;
            Application.DoEvents(); 
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            programacaoId = Convert.ToInt32(label2.Text);
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarTrafo t = new CadastrarTrafo();
            t.ShowDialog();
        }
        //fim
    }
}