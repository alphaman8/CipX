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
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_uso_mutuo' table. You can move, or remove it, as needed.
            this.poste_has_uso_mutuoTableAdapter.Fill(this.eletrocadDataSet.poste_has_uso_mutuo);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_reator' table. You can move, or remove it, as needed.
            this.poste_has_reatorTableAdapter.Fill(this.eletrocadDataSet.poste_has_reator);
            // TODO: This line of code loads data into the 'eletrocadDataSet.uso_mutuo' table. You can move, or remove it, as needed.
            this.uso_mutuoTableAdapter.Fill(this.eletrocadDataSet.uso_mutuo);
            // TODO: This line of code loads data into the 'eletrocadDataSet.reator' table. You can move, or remove it, as needed.
            this.reatorTableAdapter.Fill(this.eletrocadDataSet.reator);
            // TODO: This line of code loads data into the 'eletrocadDataSet.tipo_lampada' table. You can move, or remove it, as needed.
            this.tipo_lampadaTableAdapter.Fill(this.eletrocadDataSet.tipo_lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.lampada' table. You can move, or remove it, as needed.
            this.lampadaTableAdapter.Fill(this.eletrocadDataSet.lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.condicao_risco' table. You can move, or remove it, as needed.
            this.condicao_riscoTableAdapter.Fill(this.eletrocadDataSet.condicao_risco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.ativacao' table. You can move, or remove it, as needed.
            this.ativacaoTableAdapter.Fill(this.eletrocadDataSet.ativacao);
            // TODO: This line of code loads data into the 'eletrocadDataSet.fase' table. You can move, or remove it, as needed.
            this.faseTableAdapter.Fill(this.eletrocadDataSet.fase);
            // TODO: This line of code loads data into the 'eletrocadDataSet.braco' table. You can move, or remove it, as needed.
            this.bracoTableAdapter.Fill(this.eletrocadDataSet.braco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.eletrocadDataSet.usuario);
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

                while (eletrocadDataSet.poste_has_uso_mutuo.Count > 0)
                {
                    eletrocadDataSet.poste_has_uso_mutuo.Rows[0].Delete();
                    poste_has_uso_mutuoTableAdapter.Update(eletrocadDataSet.poste_has_uso_mutuo);
                    eletrocadDataSet.poste_has_uso_mutuo.AcceptChanges();
                }

                while (eletrocadDataSet.poste_has_reator.Count > 0)
                {
                    eletrocadDataSet.poste_has_reator.Rows[0].Delete();
                    poste_has_reatorTableAdapter.Update(eletrocadDataSet.poste_has_reator);
                    eletrocadDataSet.poste_has_reator.AcceptChanges();
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

                while (eletrocadDataSet.lampada.Count > 0)
                {
                    eletrocadDataSet.lampada.Rows[0].Delete();
                    lampadaTableAdapter.Update(eletrocadDataSet.lampada);
                    eletrocadDataSet.lampada.AcceptChanges();
                }

                while (eletrocadDataSet.tipo_lampada.Count > 0)
                {
                    eletrocadDataSet.tipo_lampada.Rows[0].Delete();
                    tipo_lampadaTableAdapter.Update(eletrocadDataSet.tipo_lampada);
                    eletrocadDataSet.tipo_lampada.AcceptChanges();
                }

                while (eletrocadDataSet.reator.Count > 0)
                {
                    eletrocadDataSet.reator.Rows[0].Delete();
                    reatorTableAdapter.Update(eletrocadDataSet.reator);
                    eletrocadDataSet.reator.AcceptChanges();
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

        private void menuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Informações podem ser apagadas ao importar dados externos. Deseja continuar?",
                "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                importar();
            }
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
                //inserir programacao IP
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

                    label1.Text = "Programação IP importada com sucesso!";
                    Application.DoEvents();

                    //inserir usuarios
                    //mycommand = myconn.CreateCommand();                
                    mycommand.CommandText =
                        "SELECT `usuario`.`id`, "+
                            "`usuario`.`nome`, "+
                            "`usuario`.`senha`, "+
                            "`usuario`.`email` "+
                        "FROM `eletrocad`.`usuario`";
                    //mycommand.Parameters.Clear();
                    //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                    //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                    reader = mycommand.ExecuteReader();

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