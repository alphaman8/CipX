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
    public partial class CadastrarUsoMutuo : Form
    {
        public CadastrarUsoMutuo()
        {
            InitializeComponent();
        }

        private void CadastrarUsoMutuo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_uso_mutuo' table. You can move, or remove it, as needed.
            this.poste_has_uso_mutuoTableAdapter.FillByPoste(this.eletrocadDataSet.poste_has_uso_mutuo, CadastrarPostes.posteId);
            // TODO: This line of code loads data into the 'eletrocadDataSet.uso_mutuo' table. You can move, or remove it, as needed.
            this.uso_mutuoTableAdapter.Fill(this.eletrocadDataSet.uso_mutuo);


            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                postehasusomutuoBindingSource.CancelEdit();
                postehasusomutuoBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            //chaveTextBox.Focus();
            descricaoComboBox.Focus();
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
                this.postehasusomutuoBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["poste_has_uso_mutuo"];
                db.eletrocadDataSet.poste_has_uso_mutuoRow r = (db.eletrocadDataSet.poste_has_uso_mutuoRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = poste_has_uso_mutuoTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    poste_has_uso_mutuoTableAdapter.FillByPoste(eletrocadDataSet.poste_has_uso_mutuo, CadastrarPostes.posteId);
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
                while (eletrocadDataSet.uso_mutuo.Count > 0)
                {
                    eletrocadDataSet.uso_mutuo.Rows[0].Delete();
                    uso_mutuoTableAdapter.Update(eletrocadDataSet.uso_mutuo);
                    eletrocadDataSet.uso_mutuo.AcceptChanges();
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
                    "SELECT `uso_mutuo`.`id`,"+
                        "`uso_mutuo`.`descricao` "+
                    "FROM `eletrocad`.`uso_mutuo`";
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
            //if ((MessageBox.Show("Atualizar uso mútuo", "atualizar",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            //    MessageBoxDefaultButton.Button2)) == DialogResult.OK)
            //{
            //    importar();
            //}
        }



    }
}