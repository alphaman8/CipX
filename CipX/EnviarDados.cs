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
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_tipo_luminaria' table. You can move, or remove it, as needed.
            this.poste_has_tipo_luminariaTableAdapter.Fill(this.eletrocadDataSet.poste_has_tipo_luminaria);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_uso_mutuo' table. You can move, or remove it, as needed.
            this.poste_has_uso_mutuoTableAdapter.Fill(this.eletrocadDataSet.poste_has_uso_mutuo);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_reator' table. You can move, or remove it, as needed.
            this.poste_has_reatorTableAdapter.Fill(this.eletrocadDataSet.poste_has_reator);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_lampada' table. You can move, or remove it, as needed.
            this.poste_has_lampadaTableAdapter.Fill(this.eletrocadDataSet.poste_has_lampada);
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

            MySql.Data.MySqlClient.MySqlTransaction mytrans;
            mytrans = myconn.BeginTransaction();

            try
            {
                foreach (db.eletrocadDataSet.trafoRow row in eletrocadDataSet.trafo.Rows)
                {
                    //insere transformadores
                    MySql.Data.MySqlClient.MySqlCommand mycommand = myconn.CreateCommand();
                    mycommand.Connection = myconn;
                    mycommand.Transaction = mytrans;

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

                    listEnviar.Items.Add("Trafo enviado: " + row.chave);
                    Application.DoEvents();

                    //INSERE POSTES
                    foreach (db.eletrocadDataSet.posteRow rowPoste in row.GetposteRows())
                    {
                        MySql.Data.MySqlClient.MySqlCommand mycommandPoste = myconn.CreateCommand();
                        mycommandPoste.Transaction = mytrans;

                        mycommandPoste.CommandText =
                                    "INSERT INTO `eletrocad`.`poste` " +
                                    "(`bairro`, " +
                                    "`logradouro`, " +
                                    "`gps_time`, " +
                                    "`sequencia`, " +
                                    "`barramento`, " +
                                    "`medido`, " +
                                    "`aceso`, " +
                                    "`trafo_id`, " +
                                    "`lat`, " +
                                    "`lon`, " +
                                    "`obs`, " +
                                    "`gpgga`, " +
                                    "`medidor`, " +
                                    "`posicao_trafo`, " +
                                    "`ligacao_clandestina`, " +
                                    "`braco_id`, " +
                                    "`fase_id`, " +
                                    "`ativacao_id`, " +
                                    "`condicao_risco_id`) " +
                                    "VALUES " +
                                    "(@bairro , " +
                                    "@logradouro , " +
                                    "@gps_time , " +
                                    "@sequencia , " +
                                    "@barramento , " +
                                    "@medido , " +
                                    "@aceso , " +
                                    "@trafo_id , " +
                                    "@lat , " +
                                    "@lon , " +
                                    "@obs , " +
                                    "@gpgga , " +
                                    "@medidor , " +
                                    "@posicao_trafo , " +
                                    "@ligacao_clandestina , " +
                                    "@braco_id , " +
                                    "@fase_id , " +
                                    "@ativacao_id , " +
                                    "@condicao_risco_id)";

                        if (rowPoste.IsbairroNull()) { mycommandPoste.Parameters.AddWithValue("bairro", null); }
                        else { mycommandPoste.Parameters.AddWithValue("bairro", rowPoste.bairro); }

                        if (rowPoste.IslogradouroNull()) { mycommandPoste.Parameters.AddWithValue("logradouro", null); }
                        else { mycommandPoste.Parameters.AddWithValue("logradouro", rowPoste.logradouro); }

                        mycommandPoste.Parameters.AddWithValue("gps_time", rowPoste.gps_time);
                        mycommandPoste.Parameters.AddWithValue("sequencia", rowPoste.sequencia);

                        if (rowPoste.IsbarramentoNull()) { mycommandPoste.Parameters.AddWithValue("barramento", null); }
                        else { mycommandPoste.Parameters.AddWithValue("barramento", rowPoste.barramento); }

                        if (rowPoste.IsmedidoNull()) { mycommandPoste.Parameters.AddWithValue("medido", null); }
                        else { mycommandPoste.Parameters.AddWithValue("medido", rowPoste.medido); }

                        if (rowPoste.IsacesoNull()) { mycommandPoste.Parameters.AddWithValue("aceso", null); }
                        else { mycommandPoste.Parameters.AddWithValue("aceso", rowPoste.aceso); }

                        mycommandPoste.Parameters.AddWithValue("trafo_id", mycommand.LastInsertedId);
                        mycommandPoste.Parameters.AddWithValue("lat", rowPoste.lat);
                        mycommandPoste.Parameters.AddWithValue("lon", rowPoste.lon);

                        if (rowPoste.IsobsNull()) { mycommandPoste.Parameters.AddWithValue("obs", null); }
                        else { mycommandPoste.Parameters.AddWithValue("obs", rowPoste.obs); }

                        if (rowPoste.IsgpggaNull()) { mycommandPoste.Parameters.AddWithValue("gpgga", null); }
                        else { mycommandPoste.Parameters.AddWithValue("gpgga", rowPoste.gpgga); }

                        if (rowPoste.IsmedidorNull()) { mycommandPoste.Parameters.AddWithValue("medidor", null); }
                        else { mycommandPoste.Parameters.AddWithValue("medidor", rowPoste.medidor); }

                        if (rowPoste.Isposicao_trafoNull()) { mycommandPoste.Parameters.AddWithValue("posicao_trafo", null); }
                        else { mycommandPoste.Parameters.AddWithValue("posicao_trafo", rowPoste.posicao_trafo); }

                        if (rowPoste.Isligacao_clandestinaNull()) { mycommandPoste.Parameters.AddWithValue("ligacao_clandestina", null); }
                        else { mycommandPoste.Parameters.AddWithValue("ligacao_clandestina", rowPoste.ligacao_clandestina); }

                        if (rowPoste.Isbraco_idNull()) { mycommandPoste.Parameters.AddWithValue("braco_id", null); }
                        else { mycommandPoste.Parameters.AddWithValue("braco_id", rowPoste.braco_id); }

                        if (rowPoste.Isfase_idNull()) { mycommandPoste.Parameters.AddWithValue("fase_id", null); }
                        else { mycommandPoste.Parameters.AddWithValue("fase_id", rowPoste.fase_id); }

                        if (rowPoste.Isativacao_idNull()) { mycommandPoste.Parameters.AddWithValue("ativacao_id", null); }
                        else { mycommandPoste.Parameters.AddWithValue("ativacao_id", rowPoste.ativacao_id); }

                        if (rowPoste.Iscondicao_risco_idNull()) { mycommandPoste.Parameters.AddWithValue("condicao_risco_id", null); }
                        else { mycommandPoste.Parameters.AddWithValue("condicao_risco_id", rowPoste.condicao_risco_id); }

                        mycommandPoste.ExecuteNonQuery();

                        //INSERE LAMPADAS
                        foreach (db.eletrocadDataSet.poste_has_lampadaRow rowPosteHasLampada 
                                    in rowPoste.Getposte_has_lampadaRows())
                        {

                            MySql.Data.MySqlClient.MySqlCommand mycommandPosteHasLamapada = myconn.CreateCommand();
                            mycommandPosteHasLamapada.Transaction = mytrans;

                            mycommandPosteHasLamapada.CommandText = "INSERT INTO `eletrocad`.`poste_has_lampada` " +
                                "(`poste_id`,`lampada_id`) VALUES (@posteId, @lampadaId)";

                            mycommandPosteHasLamapada.Parameters.AddWithValue("posteId", mycommandPoste.LastInsertedId);
                            mycommandPosteHasLamapada.Parameters.AddWithValue("lampadaId", rowPosteHasLampada.lampada_id);

                            mycommandPosteHasLamapada.ExecuteNonQuery();

                        }

                        //INSERE REATOR
                        foreach (db.eletrocadDataSet.poste_has_reatorRow rowPosteHasReator
                                    in rowPoste.Getposte_has_reatorRows())
                        {

                            MySql.Data.MySqlClient.MySqlCommand mycommandPosteHasReator = myconn.CreateCommand();
                            mycommandPosteHasReator.Transaction = mytrans;

                            mycommandPosteHasReator.CommandText = "INSERT INTO `eletrocad`.`poste_has_reator` " +
                                "(`poste_id`,`reator_id`) VALUES (@posteId, @reatorId)";

                            mycommandPosteHasReator.Parameters.AddWithValue("posteId", mycommandPoste.LastInsertedId);
                            mycommandPosteHasReator.Parameters.AddWithValue("reatorId", rowPosteHasReator.reator_id);

                            mycommandPosteHasReator.ExecuteNonQuery();


                        }

                        //INSERE luminaria
                        foreach (db.eletrocadDataSet.poste_has_tipo_luminariaRow rowPosteHasTipoLuminaria
                                    in rowPoste.Getposte_has_tipo_luminariaRows())
                        {

                            MySql.Data.MySqlClient.MySqlCommand mycommandPosteHasTipoLuminaria = myconn.CreateCommand();
                            mycommandPosteHasTipoLuminaria.Transaction = mytrans;

                            mycommandPosteHasTipoLuminaria.CommandText = "INSERT INTO `eletrocad`.`poste_has_tipo_luminaria` " +
                                "(`poste_id`,`tipo_luminaria_id`) VALUES (@posteId, @tipoId)";

                            mycommandPosteHasTipoLuminaria.Parameters.AddWithValue("posteId", mycommandPoste.LastInsertedId);
                            mycommandPosteHasTipoLuminaria.Parameters.AddWithValue("tipoId", rowPosteHasTipoLuminaria.tipo_luminaria_id);

                            mycommandPosteHasTipoLuminaria.ExecuteNonQuery();
                        }

                        //INSERE uso mútuo
                        foreach (db.eletrocadDataSet.poste_has_uso_mutuoRow rowPosteHasUsoMutuo
                                    in rowPoste.Getposte_has_uso_mutuoRows())
                        {

                            MySql.Data.MySqlClient.MySqlCommand mycommandPosteHasUsoMutuo = myconn.CreateCommand();
                            mycommandPosteHasUsoMutuo.Transaction = mytrans;

                            mycommandPosteHasUsoMutuo.CommandText = "INSERT INTO `eletrocad`.`poste_has_uso_mutuo` " +
                                "(`poste_id`,`uso_mutuo_id`) VALUES (@posteId, @usoId)";

                            mycommandPosteHasUsoMutuo.Parameters.AddWithValue("posteId", mycommandPoste.LastInsertedId);
                            mycommandPosteHasUsoMutuo.Parameters.AddWithValue("usoId", rowPosteHasUsoMutuo.uso_mutuo_id);

                            mycommandPosteHasUsoMutuo.ExecuteNonQuery();


                        }

                        listEnviar.Items.Add("Sequência: " + rowPoste.sequencia + " componentes inseridos");
                        Application.DoEvents();

                    }

                    //listEnviar.Items.Add("Trafo enviado: "+row.chave);
                    //Application.DoEvents();

                    
                }
                mytrans.Commit();
                listEnviar.Items.Add("Trafos enviados com sucesso!");
                
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
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            enviar(sender, e);
        }
    }
}