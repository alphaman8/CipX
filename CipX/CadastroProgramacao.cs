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


        private void CadastroProgramacao_Load(object sender, EventArgs e)
        {
            this.programacao_ipTableAdapter.Fill(this.eletrocadDataSet.programacao_ip);

            myconn = new MySql.Data.MySqlClient.MySqlConnection(strconn);
            myconn.StateChange += new StateChangeEventHandler(myconn_StateChange);

            Cursor.Current = Cursors.Default;
            Application.DoEvents();

            /* APENAS PARA TESTE, APAGAR QUANDO FOR COMPILADO
             * FUNÇÃO PARA CLICAR NO BOTAO APÓS ALGUNS SEGUNDOS
             * EVITANDO QUE O PROGRAMADOR TENHA QUE CLICAR SEMPRE
             * NO MESMO BOTÃO PARA TESTAR O APLICATIVO
             */
            //System.Threading.Thread.Sleep(1000);
            //menuItem5_Click(sender, e);
        } 

        private void menuItem4_Click(object sender, EventArgs e)
        {

        }

        public static int programacaoId;

        

        private void menuItem5_Click(object sender, EventArgs e)
        {
            programacaoId = Convert.ToInt32(label2.Text);
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarTrafo t = new CadastrarTrafo();
            try
            {
                t.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpaTabelas()
        {
            try
            {
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

        private MySql.Data.MySqlClient.MySqlConnection myconn;
        string strconn =
            "Server=cipweb.com.br;Database=eletrocad;Uid=marcelo;Pwd=0830@rnmf;pooling=false;";

        private void importar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dados locais serão apagados. Confirma?", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                return;
            }

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
                //inicia a transacao
                //inserir programacao IP
                MySql.Data.MySqlClient.MySqlCommand mycommand = myconn.CreateCommand();
                mycommand.Connection = myconn;
                mycommand.CommandText =
                    "SELECT `programacao_ip`.`id`, " +
                        "`programacao_ip`.`regional`, " +
                        "`programacao_ip`.`cod_local`, " +
                        "`programacao_ip`.`ultimo_levantamento`, " +
                        "`programacao_ip`.`inicio_programado`, " +
                        "`programacao_ip`.`termino_programado`, " +
                        "`programacao_ip`.`pontos_projetado`, " +
                        "`programacao_ip`.`cliente_id`, " +
                        "`programacao_ip`.`data_faturamento`, " +
                        "`programacao_ip`.`pr_situacao_base_id`, " +
                        "`programacao_ip`.`total_pt_levantado`, " +
                        "`programacao_ip`.`inicio`, " +
                        "`programacao_ip`.`fim`, " +
                        "`programacao_ip`.`relatorios_entregue`, " +
                        "`programacao_ip`.`cd_entregue`, " +
                        "`programacao_ip`.`shape_entregue`, " +
                        "`programacao_ip`.`shape_atualiza_inico`, " +
                        "`programacao_ip`.`shape_atualiza_fim`, " +
                        "`programacao_ip`.`pr_ip_situacao_id`, " +
                        "`programacao_ip`.`carta_apresentacao`, " +
                        "`programacao_ip`.`oficio_prefeitura`, " +
                        "`programacao_ip`.`carta_conclusao`, " +
                        "`programacao_ip`.`ativo`, " +
                        "`programacao_ip`.`valor_faturado` " +
                    "FROM `eletrocad`.`programacao_ip` " +
                    "inner join programacao_ip_has_usuario phu " +
                    "on phu.programacao_ip_id = `eletrocad`.`programacao_ip`.id " +
                    "inner join usuario u " +
                    "on u.id = phu.usuario_id " +
                    "and u.id = @usuarioId " +
                    "and `eletrocad`.`programacao_ip`.ativo = 1";
                mycommand.Parameters.Clear();
                mycommand.Parameters.AddWithValue("usuarioId", Usuario.id);

                try
                {
                    MySql.Data.MySqlClient.MySqlDataReader reader = mycommand.ExecuteReader();
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
        //fim
    }
}