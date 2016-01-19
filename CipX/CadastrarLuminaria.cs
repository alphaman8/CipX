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
    public partial class CadastrarLuminaria : Form
    {
        public CadastrarLuminaria()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarLuminaria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.braco' table. You can move, or remove it, as needed.
            this.bracoTableAdapter.Fill(this.eletrocadDataSet.braco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.reator' table. You can move, or remove it, as needed.
            this.reatorTableAdapter.Fill(this.eletrocadDataSet.reator);
            // TODO: This line of code loads data into the 'eletrocadDataSet.lampada' table. You can move, or remove it, as needed.
            this.lampadaTableAdapter.Fill(this.eletrocadDataSet.lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.tipo_luminaria' table. You can move, or remove it, as needed.
            this.tipo_luminariaTableAdapter.Fill(this.eletrocadDataSet.tipo_luminaria);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_tipo_luminaria' table. You can move, or remove it, as needed.
            this.poste_has_tipo_luminariaTableAdapter.FillByPoste(this.eletrocadDataSet.poste_has_tipo_luminaria, CadastrarPostes.posteId);

            Cursor.Current = Cursors.Default;
            Application.DoEvents();

        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                postehastipoluminariaBindingSource.CancelEdit();
                postehastipoluminariaBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            //chaveTextBox.Focus();
            comboBox1.Focus();
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
                this.postehastipoluminariaBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["poste_has_tipo_luminaria"];
                db.eletrocadDataSet.poste_has_tipo_luminariaRow r = (db.eletrocadDataSet.poste_has_tipo_luminariaRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = poste_has_tipo_luminariaTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    poste_has_tipo_luminariaTableAdapter.FillByPoste(eletrocadDataSet.poste_has_tipo_luminaria, CadastrarPostes.posteId);
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
                while (eletrocadDataSet.tipo_luminaria.Count > 0)
                {
                    eletrocadDataSet.tipo_luminaria.Rows[0].Delete();
                    tipo_luminariaTableAdapter.Update(eletrocadDataSet.tipo_luminaria);
                    eletrocadDataSet.tipo_luminaria.AcceptChanges();
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
                    "SELECT `tipo_luminaria`.`id`, "+
                    "`tipo_luminaria`.`descricao` "+
                    "FROM `eletrocad`.`tipo_luminaria`";
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
            if ((MessageBox.Show("Atualizar as Luminárias", "atualizar",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)) == DialogResult.OK)
            {
                importar();
            }
        }
    }
}