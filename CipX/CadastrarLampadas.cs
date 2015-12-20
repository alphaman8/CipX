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
    public partial class CadastrarLampadas : Form
    {
        public CadastrarLampadas()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarLampadas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.lampada' table. You can move, or remove it, as needed.
            this.lampadaTableAdapter.Fill(this.eletrocadDataSet.lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.tipo_lampada' table. You can move, or remove it, as needed.
            this.tipo_lampadaTableAdapter.Fill(this.eletrocadDataSet.tipo_lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_lampada' table. You can move, or remove it, as needed.
            this.poste_has_lampadaTableAdapter.FillByPoste(this.eletrocadDataSet.poste_has_lampada, CadastrarPostes.posteId);

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                postehaslampadaBindingSource.CancelEdit();
                postehaslampadaBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            //chaveTextBox.Focus();
            lampadaCb.Focus();
            poste_idTextBox.Text = CadastrarPostes.posteId.ToString();

            //tabControl1.SelectedIndex = 1;
            //usuario_idTextBox.Text = "" + 1;
            //programacao_ip_idTextBox.Text = CadastroProgramacao.programacaoId.ToString();
            //trafo_idTextBox.Text = CadastrarTrafo.trafoId.ToString();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void salvar(object sender, EventArgs e)
        {
            try
            {
                this.postehaslampadaBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["poste_has_lampada"];
                db.eletrocadDataSet.poste_has_lampadaRow r = (db.eletrocadDataSet.poste_has_lampadaRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = poste_has_lampadaTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    poste_has_lampadaTableAdapter.FillByPoste(eletrocadDataSet.poste_has_lampada, CadastrarPostes.posteId);
                    MessageBox.Show("Informações salvas com sucesso! ");
                }
                else
                {
                    string errorMsg = null;
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg += row.GetColumnError(col) + "\n";
                        }
                    }
                    MessageBox.Show("Erros nos dados: " + errorMsg, "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //citeluz2DataSet.RejectChanges();
            }
        }

        private void limpaTabelas()
        {
            try
            {
                while (eletrocadDataSet.lampada.Count > 0)
                {
                    eletrocadDataSet.lampada.Rows[0].Delete();
                    lampadaTableAdapter.Update(eletrocadDataSet.lampada);
                    eletrocadDataSet.lampada.AcceptChanges();
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
                myconn = new MySql.Data.MySqlClient.MySqlConnection(strconn);
                myconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao servidor, verifique a sua conexão com a internet.");
                return;
            }

            if (myconn.State == ConnectionState.Open)
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                //inicia a transacao
                MySql.Data.MySqlClient.MySqlCommand mycommand = myconn.CreateCommand();
                mycommand.Connection = myconn;
                mycommand.CommandText =
                    "SELECT `lampada`.`id`,"+
                    "`lampada`.`descricao`,"+
                    "`lampada`.`potencia`,"+
                    "`lampada`.`perda`,"+
                    "`lampada`.`tipo_lampada_id` "+
                "FROM `eletrocad`.`lampada`";
                //mycommand.Parameters.Clear();
                //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                try
                {
                    MySql.Data.MySqlClient.MySqlDataReader reader = mycommand.ExecuteReader();
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

        private MySql.Data.MySqlClient.MySqlConnection myconn;
        string strconn =
            "Server=cipweb.com.br;Database=eletrocad;Uid=marcelo;Pwd=0830@rnmf;pooling=false;";

        private void menuItem6_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Atualizar as Lâmpadas", "atualizar",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)) == DialogResult.OK)
            {
                importar();
            }
        }
    }
}