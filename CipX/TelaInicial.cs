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
    public partial class TelaInicial : GPSForm
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void conectarGps()
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            StopTrimble();
            listGPS.Items.Clear();
            listGPS.Items.Add(ConectarTrimble());
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            conectarGps();
        }

        bool gpsOk = false;

        public override void statusTrimble()
        {
            if (pos == null)
                return;


            //if (!timerVerificarGps.Enabled)
            //{
            //    timerVerificarGps.Interval = 6000;
            //    timerVerificarGps.Enabled = true;
            //}

            listGPS.Items.Clear();
            string status = gpsTrimbleStatus;

            if (status.Contains("tracking"))
            {
                status = "Pesquisando por satélites";
                listGPS.ForeColor = Color.Red;
            }
            if (status.Contains("Calculating"))
            {
                status = "Trabalhando corretamente";
                listGPS.ForeColor = Color.Lime;
            }
            if (status.Contains("Waiting"))
            {
                status = "Esperando Satélites";
                listGPS.ForeColor = Color.Red;
            }

            //if (pos == null)
            //{
            //    if (menuItem3.Enabled)
            //    {
            //        menuItem3.Enabled = false;
            //    }
            //    return;
            //}

            GPS.status = status;
            GPS.gpsTime = pos.GPSTime;

            /* 
             * armazena o ultima hora do gps
             * ao inserir o trafo para depois
             * comparar com a hora quando o usuario 
             * for inserir um novo trafo.
             * caso a hora seja a mesma o gps parou 
             * e deve ser reiniciado 
             */
            //if (GPS.gpsOldTime.Equals(GPS.gpsTime))
            //{
            //    MessageBeep();
            //    //DesconectarTrimble();
            //    listGPS.Items.Clear();
            //    listGPS.Items.Add(status);
            //    Application.DoEvents();
            //    return;
            //} 

            //GPS.gpsOldTime = GPS.gpsTime;

            GPS.lat = pos.Latitude;
            GPS.lon = pos.Longitude;
            GPS.numberOfSatellites = pos.NumberOfSatellites;
            GPS.accuracy = Math.Round(pos.EstimatedAccuracy, 2);

            listGPS.Items.Add("Situação do GPS: " + status);
            listGPS.Items.Add("Latitude: " + GPS.lat);
            listGPS.Items.Add("Longitude: " + GPS.lon);
            listGPS.Items.Add("Satélites: " + GPS.numberOfSatellites);
            listGPS.Items.Add("Acurácia: " + GPS.accuracy + "m");
            listGPS.Items.Add("Data/Hora do GPS: " + GPS.gpsTime.ToString("dd/MM/yyyy - HH:mm"));
            //listGPS.Items.Add("Error: " + GPS.error);


            if (GPS.accuracy > 15 && status.Contains("corretamente"))
            {
                listGPS.Items.Add("Baixa acurácia!");
                listGPS.ForeColor = Color.Orange;
                gpsOk = false;
            }
            if (GPS.accuracy < GPS.accuracyIdeal && status.Contains("corretamente"))
            {
                listGPS.Items.Add("Boa acurácia!");
                listGPS.ForeColor = Color.Lime;
                gpsOk = true;
                MessageBeep();
            }
            

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

                while (eletrocadDataSet.poste_has_uso_mutuo.Count > 0)
                {
                    eletrocadDataSet.poste_has_uso_mutuo.Rows[0].Delete();
                    poste_has_uso_mutuoTableAdapter.Update(eletrocadDataSet.poste_has_uso_mutuo);
                    eletrocadDataSet.poste_has_uso_mutuo.AcceptChanges();
                }

                //CONDICAO DE RISCO
                while (eletrocadDataSet.condicao_risco.Count > 0)
                {
                    eletrocadDataSet.condicao_risco.Rows[0].Delete();
                    condicao_riscoTableAdapter.Update(eletrocadDataSet.condicao_risco);
                    eletrocadDataSet.condicao_risco.AcceptChanges();
                }

                //ativacao
                while (eletrocadDataSet.ativacao.Count > 0)
                {
                    eletrocadDataSet.ativacao.Rows[0].Delete();
                    ativacaoTableAdapter.Update(eletrocadDataSet.ativacao);
                    eletrocadDataSet.ativacao.AcceptChanges();
                }

                //FASE
                while (eletrocadDataSet.fase.Count > 0)
                {
                    eletrocadDataSet.fase.Rows[0].Delete();
                    faseTableAdapter.Update(eletrocadDataSet.fase);
                    eletrocadDataSet.fase.AcceptChanges();
                }

                //BRACO
                while (eletrocadDataSet.braco.Count > 0)
                {
                    eletrocadDataSet.braco.Rows[0].Delete();
                    bracoTableAdapter.Update(eletrocadDataSet.braco);
                    eletrocadDataSet.braco.AcceptChanges();
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

                while (eletrocadDataSet.usuario.Count > 0)
                {
                    eletrocadDataSet.usuario.Rows[0].Delete();
                    usuarioTableAdapter.Update(eletrocadDataSet.usuario);
                    eletrocadDataSet.usuario.AcceptChanges();
                }

                while (eletrocadDataSet.tipo_luminaria.Count > 0)
                {
                    eletrocadDataSet.tipo_luminaria.Rows[0].Delete();
                    tipo_luminariaTableAdapter.Update(eletrocadDataSet.tipo_luminaria);
                    eletrocadDataSet.tipo_luminaria.AcceptChanges();
                }

                while (eletrocadDataSet.lampada.Count > 0)
                {
                    eletrocadDataSet.lampada.Rows[0].Delete();
                    lampadaTableAdapter.Update(eletrocadDataSet.lampada);
                    eletrocadDataSet.lampada.AcceptChanges();
                }

                while (eletrocadDataSet.reator.Count > 0)
                {
                    eletrocadDataSet.reator.Rows[0].Delete();
                    reatorTableAdapter.Update(eletrocadDataSet.reator);
                    eletrocadDataSet.reator.AcceptChanges();
                }

                while (eletrocadDataSet.tipo_lampada.Count > 0)
                {
                    eletrocadDataSet.tipo_lampada.Rows[0].Delete();
                    tipo_lampadaTableAdapter.Update(eletrocadDataSet.tipo_lampada);
                    eletrocadDataSet.tipo_lampada.AcceptChanges();
                }

                while (eletrocadDataSet.uso_mutuo.Count > 0)
                {
                    eletrocadDataSet.uso_mutuo.Rows[0].Delete();
                    uso_mutuoTableAdapter.Update(eletrocadDataSet.uso_mutuo);
                    eletrocadDataSet.uso_mutuo.AcceptChanges();
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

                try
                {
                    //inicia a transacao
                    MySql.Data.MySqlClient.MySqlCommand mycommand = myconn.CreateCommand();
                    //mycommand.Connection = myconn;

                    //inserir usuarios
                    mycommand.CommandText =
                        "SELECT `usuario`.`id`, " +
                            "`usuario`.`nome`, " +
                            "`usuario`.`senha`, " +
                            "`usuario`.`nmax_barramento`, " +
                            "`usuario`.`nmin_barramento`, " +
                            "`usuario`.`email` " +
                        "FROM `eletrocad`.`usuario`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);
                    MySql.Data.MySqlClient.MySqlDataReader reader = mycommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.usuarioRow uRow;
                        uRow = eletrocadDataSet.usuario.NewusuarioRow();
                        uRow.id = reader.GetInt32("id");
                        uRow.nome = reader.GetString("nome");
                        uRow.email = reader.GetString("email");
                        uRow.senha = reader.GetString("senha");
                        uRow.nmax_barramento = reader.GetInt32("nmax_barramento");
                        uRow.nmin_barramento = reader.GetInt32("nmin_barramento");

                        eletrocadDataSet.usuario.Rows.Add(uRow);

                    }
                    usuarioTableAdapter.Update(eletrocadDataSet.usuario);
                    eletrocadDataSet.usuario.AcceptChanges();
                    usuarioTableAdapter.Fill(eletrocadDataSet.usuario);

                    reader.Close();


                    label1.Text = "Usuário importado com sucesso!";
                    Application.DoEvents();

                    //inserir usuarios
                    //mycommand = myconn.CreateCommand();                
                    mycommand.CommandText =
                        "SELECT `braco`.`id`, " +
                            "`braco`.`descricao` " +
                        "FROM `eletrocad`.`braco`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.bracoRow uRow;
                        uRow = eletrocadDataSet.braco.NewbracoRow();
                        uRow.id = reader.GetInt32("id");
                        uRow.descricao = reader.GetString("descricao");

                        eletrocadDataSet.braco.Rows.Add(uRow);

                    }
                    bracoTableAdapter.Update(eletrocadDataSet.braco);
                    eletrocadDataSet.braco.AcceptChanges();
                    bracoTableAdapter.Fill(eletrocadDataSet.braco);

                    reader.Close();

                    label1.Text = "Braço importado com sucesso!";
                    Application.DoEvents();

                    //inserir fase
                    //mycommand = myconn.CreateCommand();                
                    mycommand.CommandText =
                        "SELECT `fase`.`id`, " +
                            "`fase`.`descricao` " +
                        "FROM `eletrocad`.`fase`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.faseRow uRow;
                        uRow = eletrocadDataSet.fase.NewfaseRow();
                        uRow.id = reader.GetInt32("id");
                        uRow.descricao = reader.GetString("descricao");

                        eletrocadDataSet.fase.Rows.Add(uRow);

                    }
                    faseTableAdapter.Update(eletrocadDataSet.fase);
                    eletrocadDataSet.fase.AcceptChanges();
                    faseTableAdapter.Fill(eletrocadDataSet.fase);

                    reader.Close();

                    label1.Text = "Fase importada com sucesso!";
                    Application.DoEvents();


                    //inserir ativacao
                    //mycommand = myconn.CreateCommand();                
                    mycommand.CommandText =
                        "SELECT `ativacao`.`id`, " +
                            "`ativacao`.`descricao` " +
                        "FROM `eletrocad`.`ativacao`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.ativacaoRow uRow;
                        uRow = eletrocadDataSet.ativacao.NewativacaoRow();
                        uRow.id = reader.GetInt32("id");
                        uRow.descricao = reader.GetString("descricao");

                        eletrocadDataSet.ativacao.Rows.Add(uRow);

                    }
                    ativacaoTableAdapter.Update(eletrocadDataSet.ativacao);
                    eletrocadDataSet.ativacao.AcceptChanges();
                    ativacaoTableAdapter.Fill(eletrocadDataSet.ativacao);

                    reader.Close();

                    label1.Text = "Ativação importada com sucesso!";
                    Application.DoEvents();

                    //inserir ativacao
                    //mycommand = myconn.CreateCommand();                
                    mycommand.CommandText =
                        "SELECT `condicao_risco`.`id`, " +
                            "`condicao_risco`.`descricao` " +
                        "FROM `eletrocad`.`condicao_risco`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.condicao_riscoRow uRow;
                        uRow = eletrocadDataSet.condicao_risco.Newcondicao_riscoRow();
                        uRow.id = reader.GetInt32("id");
                        uRow.descricao = reader.GetString("descricao");

                        eletrocadDataSet.condicao_risco.Rows.Add(uRow);

                    }

                    condicao_riscoTableAdapter.Update(eletrocadDataSet.condicao_risco);
                    eletrocadDataSet.condicao_risco.AcceptChanges();
                    condicao_riscoTableAdapter.Fill(eletrocadDataSet.condicao_risco);

                    reader.Close();

                    label1.Text = "Condição de Risco importada com sucesso!";
                    Application.DoEvents();


                    //tipo de lampada primeiro
                    mycommand.CommandText =
                                "SELECT `tipo_lampada`.`id`," +
                                "`tipo_lampada`.`descricao` " +
                                "FROM `eletrocad`.`tipo_lampada`";

                    reader = mycommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.tipo_lampadaRow pipRow;
                        pipRow = eletrocadDataSet.tipo_lampada.Newtipo_lampadaRow();
                        pipRow.id = reader.GetInt32("id");
                        pipRow.descricao = reader.GetString("descricao");
                        eletrocadDataSet.tipo_lampada.Rows.Add(pipRow);

                    }
                    tipo_lampadaTableAdapter.Update(eletrocadDataSet.tipo_lampada);
                    eletrocadDataSet.tipo_lampada.AcceptChanges();
                    tipo_lampadaTableAdapter.Fill(eletrocadDataSet.tipo_lampada);

                    reader.Close();

                    label1.Text = "Tipo de lâmpadas importado com sucesso!";
                    Application.DoEvents();

                    mycommand.CommandText =
                        "SELECT `lampada`.`id`," +
                        "`lampada`.`descricao`," +
                        "`lampada`.`potencia`," +
                        "`lampada`.`perda`," +
                        "`lampada`.`tipo_lampada_id` " +
                    "FROM `eletrocad`.`lampada`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.lampadaRow pipRow;
                        pipRow = eletrocadDataSet.lampada.NewlampadaRow();
                        pipRow.id = reader.GetInt32("id");
                        pipRow.descricao = reader.GetString("descricao");
                        pipRow.perda = reader.GetDouble("perda");
                        pipRow.potencia = reader.GetDouble("potencia");
                        pipRow.tipo_lampada_id = reader.GetInt32("tipo_lampada_id");

                        eletrocadDataSet.lampada.Rows.Add(pipRow);

                    }
                    lampadaTableAdapter.Update(eletrocadDataSet.lampada);
                    eletrocadDataSet.lampada.AcceptChanges();
                    lampadaTableAdapter.Fill(eletrocadDataSet.lampada);

                    reader.Close();

                    label1.Text = "Lâmpadas importadas com sucesso!";
                    Application.DoEvents();


                    mycommand.CommandText =
                        "SELECT `reator`.`id`," +
                        "`reator`.`descricao`," +
                        "`reator`.`potencia`," +
                        "`reator`.`perda`," +
                        "`reator`.`tipo_lampada_id` " +
                    "FROM `eletrocad`.`reator`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.reatorRow pipRow;
                        pipRow = eletrocadDataSet.reator.NewreatorRow();
                        pipRow.id = reader.GetInt32("id");
                        pipRow.descricao = reader.GetString("descricao");
                        pipRow.perda = reader.GetDouble("perda");
                        pipRow.potencia = reader.GetDouble("potencia");
                        pipRow.tipo_lampada_id = reader.GetInt32("tipo_lampada_id");

                        eletrocadDataSet.reator.Rows.Add(pipRow);

                    }
                    reatorTableAdapter.Update(eletrocadDataSet.reator);
                    eletrocadDataSet.reator.AcceptChanges();
                    reatorTableAdapter.Fill(eletrocadDataSet.reator);

                    reader.Close();

                    label1.Text = "Reator importado com sucesso!";
                    Application.DoEvents();

                    mycommand.CommandText =
                        "SELECT `uso_mutuo`.`id`," +
                        "`uso_mutuo`.`descricao` " +
                    "FROM `eletrocad`.`uso_mutuo`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.uso_mutuoRow pipRow;
                        pipRow = eletrocadDataSet.uso_mutuo.Newuso_mutuoRow();
                        pipRow.id = reader.GetInt32("id");
                        pipRow.descricao = reader.GetString("descricao");

                        eletrocadDataSet.uso_mutuo.Rows.Add(pipRow);

                    }
                    uso_mutuoTableAdapter.Update(eletrocadDataSet.uso_mutuo);
                    eletrocadDataSet.uso_mutuo.AcceptChanges();
                    uso_mutuoTableAdapter.Fill(eletrocadDataSet.uso_mutuo);

                    reader.Close();

                    label1.Text = "Uso Mútuo importado com sucesso!";
                    Application.DoEvents();

                    mycommand.CommandText =
                        "SELECT `tipo_luminaria`.`id`,"+
                        "`tipo_luminaria`.`descricao` "+
                        "FROM `eletrocad`.`tipo_luminaria`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.tipo_luminariaRow pipRow;
                        pipRow = eletrocadDataSet.tipo_luminaria.Newtipo_luminariaRow();
                        pipRow.id = reader.GetInt32("id");
                        pipRow.descricao = reader.GetString("descricao");

                        eletrocadDataSet.tipo_luminaria.Rows.Add(pipRow);

                    }
                    tipo_luminariaTableAdapter.Update(eletrocadDataSet.tipo_luminaria);
                    eletrocadDataSet.tipo_luminaria.AcceptChanges();
                    tipo_luminariaTableAdapter.Fill(eletrocadDataSet.tipo_luminaria);

                    reader.Close();

                    label1.Text = "Luminária importada com sucesso!";
                    Application.DoEvents();

                    //MSG FINAL
                    label1.Text = "Dados importados com sucesso!";
                    Application.DoEvents();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível importar todos os dados: " + ex.Message);
                }
                finally
                {
                    myconn.Close();
                }
            }

            //MessageBox.Show("Informações recuperadas com sucesso");
            label1.Visible = false;
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.tipo_luminaria' table. You can move, or remove it, as needed.
            this.tipo_luminariaTableAdapter.Fill(this.eletrocadDataSet.tipo_luminaria);
            // TODO: This line of code loads data into the 'eletrocadDataSet.uso_mutuo' table. You can move, or remove it, as needed.
            this.uso_mutuoTableAdapter.Fill(this.eletrocadDataSet.uso_mutuo);
            // TODO: This line of code loads data into the 'eletrocadDataSet.programacao_ip' table. You can move, or remove it, as needed.
            this.programacao_ipTableAdapter.Fill(this.eletrocadDataSet.programacao_ip);
            // TODO: This line of code loads data into the 'eletrocadDataSet.reator' table. You can move, or remove it, as needed.
            this.reatorTableAdapter.Fill(this.eletrocadDataSet.reator);
            // TODO: This line of code loads data into the 'eletrocadDataSet.trafo' table. You can move, or remove it, as needed.
            this.trafoTableAdapter.Fill(this.eletrocadDataSet.trafo);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste' table. You can move, or remove it, as needed.
            this.posteTableAdapter.Fill(this.eletrocadDataSet.poste);
            // TODO: This line of code loads data into the 'eletrocadDataSet.tipo_lampada' table. You can move, or remove it, as needed.
            this.tipo_lampadaTableAdapter.Fill(this.eletrocadDataSet.tipo_lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.lampada' table. You can move, or remove it, as needed.
            this.lampadaTableAdapter.Fill(this.eletrocadDataSet.lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.condicao_risco' table. You can move, or remove it, as needed.
            this.condicao_riscoTableAdapter.Fill(this.eletrocadDataSet.condicao_risco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.fase' table. You can move, or remove it, as needed.
            this.faseTableAdapter.Fill(this.eletrocadDataSet.fase);
            // TODO: This line of code loads data into the 'eletrocadDataSet.braco' table. You can move, or remove it, as needed.
            this.bracoTableAdapter.Fill(this.eletrocadDataSet.braco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.ativacao' table. You can move, or remove it, as needed.
            this.ativacaoTableAdapter.Fill(this.eletrocadDataSet.ativacao);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_tipo_luminaria' table. You can move, or remove it, as needed.
            this.poste_has_tipo_luminariaTableAdapter.Fill(this.eletrocadDataSet.poste_has_tipo_luminaria);
            // TODO: This line of code loads data into the 'eletrocadDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.eletrocadDataSet.usuario);

            myconn = new  MySql.Data.MySqlClient.MySqlConnection(strconn);
            myconn.StateChange += new StateChangeEventHandler(myconn_StateChange);

            conectarGps();
            
            /* APENAS PARA TESTE, APAGAR QUANDO FOR COMPILADO
             * FUNÇÃO PARA CLICAR NO BOTAO APÓS ALGUNS SEGUNDOS
             * EVITANDO QUE O PROGRAMADOR TENHA QUE CLICAR SEMPRE
             * NO MESMO BOTÃO PARA TESTAR O APLICATIVO
             */
            //System.Threading.Thread.Sleep(1000);
            //menuItem6_Click(sender, e);
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

        private void cadastrar(object sender, EventArgs e)
        {
            if (!gpsOk)
            {
                MessageBox.Show("GPS ainda não está com boa acurácia para o serviço. Aguarde melhorar o sinal");
                return;
            }

            if (nomeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione seu usuário");
                return;
            }

            Usuario.nMaxBarramento =
                Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["nmax_barramento"]);
            Usuario.nMinBarramento =
                Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["nmin_barramento"]);
            Usuario.id =
                Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["id"]);

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            StopTrimble();
            CadastroProgramacao ip = new CadastroProgramacao();
            ip.ShowDialog();
            gpsOk = false;
            GPS.accuracy = 200;
            StartTraking();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Informações podem ser apagadas ao importar dados externos. Deseja continuar?",
                "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                importar();
                this.usuarioTableAdapter.Fill(this.eletrocadDataSet.usuario);
            }
        }

        private void timerVerificarGps_Tick(object sender, EventArgs e)
        {
            if (GPS.gpsTime != null && (GPS.gpsOldTime.Equals(GPS.gpsTime)))
            {
                //DesconectarTrimble();
                GPS.msg = "GPS não esta funcionando";
                listGPS.Items.Clear();
                listGPS.Items.Add(GPS.msg);
                GPS.accuracy = 200;
                Application.DoEvents();                
            }

            GPS.gpsOldTime = GPS.gpsTime;
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            StopTrimble();
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            EnviarDados p = new EnviarDados();
            p.ShowDialog();
            GPS.accuracy = 200;
            StartTraking();
        }
    }
}