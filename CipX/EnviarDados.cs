using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CipX
{
    public partial class EnviarDados : Form
    {
        public EnviarDados()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnviarDados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste' table. You can move, or remove it, as needed.
            this.posteTableAdapter.Fill(this.eletrocadDataSet.poste);
            // TODO: This line of code loads data into the 'eletrocadDataSet.trafo' table. You can move, or remove it, as needed.
            this.trafoTableAdapter.Fill(this.eletrocadDataSet.trafo);

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private MySql.Data.MySqlClient.MySqlConnection myconn;
        string strconn =
            "Server=cipweb.com.br;Database=cip2;Uid=marcelo;Pwd=0830@rnmf;pooling=false;";

        private void enviar(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            //inicia a transacao
            myconn = new MySql.Data.MySqlClient.MySqlConnection(strconn);

            try
            {
                myconn.Open();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Application.DoEvents();
                MessageBox.Show(ex.Message);
                return;
            }

            MySql.Data.MySqlClient.MySqlCommand mycommand = myconn.CreateCommand();
            MySql.Data.MySqlClient.MySqlTransaction mytrans;
            mytrans = myconn.BeginTransaction();
            mycommand.Connection = myconn;
            mycommand.Transaction = mytrans;

            try
            {
                foreach (db.eletrocadDataSet.trafoRow row in eletrocadDataSet.trafo.Rows)
                {
                    //insere transformadores
                    mycommand.CommandText =
                                "INSERT INTO `eletrocad`.`trafo` " +
                                "(`chave`, " +
                                "`cia`, " +
                                "`gps_time`, " +
                                "`alimentador`, " +
                                "`usuario_id`, " +
                                "`programacao_ip_id`) " +
                                "VALUES " +
                                "(@chave, " +
                                "@cia, " +
                                "@gps_time, " +
                                "@alimentador, " +
                                "@usuario_id, " +
                                "@programacao_ip_id)";

                    mycommand.Parameters.AddWithValue("chave", row.chave);
                    if (row.IsciaNull()) { mycommand.Parameters.AddWithValue("cia", null); }
                    else { mycommand.Parameters.AddWithValue("cia", row.cia); }
                    mycommand.Parameters.AddWithValue("gps_time", row.gps_time);
                    if (row.IsalimentadorNull()) { mycommand.Parameters.AddWithValue("alimentador", null); }
                    else { mycommand.Parameters.AddWithValue("alimentador", row.alimentador); }
                    mycommand.Parameters.AddWithValue("usuario_id", row.usuario_id);
                    mycommand.Parameters.AddWithValue("programacao_ip_id", row.programacao_ip_id);

                    mycommand.ExecuteNonQuery();

                    listEnviar.Items.Add("Trafo enviado: "+row.chave);
                    Application.DoEvents();

                    
                }
                listEnviar.Items.Add("Trafos enviados com sucesso!");

                //insere postes
                foreach (db.eletrocadDataSet.posteRow row in eletrocadDataSet.poste.Rows)
                {
                    mycommand.CommandText =
                                "INSERT INTO `eletrocad`.`poste` "+
                                "(`bairro`, "+
                                "`logradouro`, "+
                                "`gps_time`, "+
                                "`sequencia`, "+
                                "`barramento`, "+
                                "`medido`, "+
                                "`aceso`, "+
                                "`trafo_id`, "+
                                "`lat`, "+
                                "`lon`, "+
                                "`obs`, "+
                                "`gpgga`, "+
                                "`medidor`, "+
                                "`posicao_trafo`, "+
                                "`ligacao_clandestina`, "+
                                "`braco_id`, "+
                                "`fase_id`, "+
                                "`ativacao_id`, "+
                                "`condicao_risco_id`) "+
                                "VALUES "+
                                "(@bairro , "+
                                "@logradouro , "+
                                "@gps_time , "+
                                "@sequencia , "+
                                "@barramento , "+
                                "@medido , "+
                                "@aceso , "+
                                "@trafo_id , "+
                                "@lat , "+
                                "@lon , "+
                                "@obs , "+
                                "@gpgga , "+
                                "@medidor , "+
                                "@posicao_trafo , "+
                                "@ligacao_clandestina , "+
                                "@braco_id , "+
                                "@fase_id , "+
                                "@ativacao_id , " +
                                "@condicao_risco_id)";

                    if (row.IsbairroNull()) { mycommand.Parameters.AddWithValue("bairro", null); }
                    else { mycommand.Parameters.AddWithValue("bairro", row.bairro); }

                    if (row.IslogradouroNull()) { mycommand.Parameters.AddWithValue("logradouro", null); }
                    else { mycommand.Parameters.AddWithValue("logradouro", row.logradouro); }

                    mycommand.Parameters.AddWithValue("gps_time", row.gps_time);
                    mycommand.Parameters.AddWithValue("sequencia", row.sequencia);

                    if (row.IsbarramentoNull()) { mycommand.Parameters.AddWithValue("barramento", null); }
                    else { mycommand.Parameters.AddWithValue("barramento", row.barramento); }

                    if (row.IsmedidoNull()) { mycommand.Parameters.AddWithValue("medido", null); }
                    else { mycommand.Parameters.AddWithValue("medido", row.medido); }

                    if (row.IsacesoNull()) { mycommand.Parameters.AddWithValue("aceso", null); }
                    else { mycommand.Parameters.AddWithValue("aceso", row.aceso); }

                    mycommand.Parameters.AddWithValue("lat", row.lat);
                    mycommand.Parameters.AddWithValue("lon", row.lon);

                    if (row.IsobsNull()) { mycommand.Parameters.AddWithValue("obs", null); }
                    else { mycommand.Parameters.AddWithValue("obs", row.obs); }

                    if (row.IsgpggaNull()) { mycommand.Parameters.AddWithValue("gpgga", null); }
                    else { mycommand.Parameters.AddWithValue("gpgga", row.gpgga); }

                    if (row.IsmedidorNull()) { mycommand.Parameters.AddWithValue("medidor", null); }
                    else { mycommand.Parameters.AddWithValue("medidor", row.medidor); }

                    if (row.Isposicao_trafoNull()) { mycommand.Parameters.AddWithValue("posicao_trafo", null); }
                    else { mycommand.Parameters.AddWithValue("posicao_trafo", row.posicao_trafo); }

                    if (row.Isligacao_clandestinaNull()) { mycommand.Parameters.AddWithValue("ligacao_clandestina", null); }
                    else { mycommand.Parameters.AddWithValue("ligacao_clandestina", row.ligacao_clandestina); }

                    if (row.Isbraco_idNull()) { mycommand.Parameters.AddWithValue("braco_id", null); }
                    else { mycommand.Parameters.AddWithValue("braco_id", row.braco_id); }

                    if (row.Isfase_idNull()) { mycommand.Parameters.AddWithValue("fase_id", null); }
                    else { mycommand.Parameters.AddWithValue("fase_id", row.fase_id); }

                    if (row.Isativacao_idNull()) { mycommand.Parameters.AddWithValue("ativacao_id", null); }
                    else { mycommand.Parameters.AddWithValue("ativacao_id", row.ativacao_id); }

                    if (row.Iscondicao_risco_idNull()) { mycommand.Parameters.AddWithValue("condicao_risco_id", null); }
                    else { mycommand.Parameters.AddWithValue("condicao_risco_id", row.condicao_risco_id); }

                    mycommand.ExecuteNonQuery();

                    listEnviar.Items.Add("Poste enviado: " + row.sequencia);
                    Application.DoEvents();

                }

                
            }
            catch (Exception ex)
            {
                try
                {
                    mytrans.Rollback();
                }
                catch (MySql.Data.MySqlClient.MySqlException myex)
                {
                    if (mytrans.Connection != null)
                    {
                        listEnviar.Text = ex.Message + " An exception of type " + myex.GetType() +
                                          " was encountered while attempting to roll back the transaction.";
                    }
                }

                MessageBox.Show("Não foi possível enviar: "+ex.Message);
            }


            mytrans.Commit();
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }
    }
}