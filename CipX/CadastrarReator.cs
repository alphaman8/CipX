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
    public partial class CadastrarReator : Form
    {
        public CadastrarReator()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarReator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.reator' table. You can move, or remove it, as needed.
            this.reatorTableAdapter.Fill(this.eletrocadDataSet.reator);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_reator' table. You can move, or remove it, as needed.
            this.poste_has_reatorTableAdapter.FillByPoste(this.eletrocadDataSet.poste_has_reator, CadastrarPostes.posteId);

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                postehasreatorBindingSource.CancelEdit();
                postehasreatorBindingSource.AddNew();
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
                this.postehasreatorBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["poste_has_reator"];
                db.eletrocadDataSet.poste_has_reatorRow r = (db.eletrocadDataSet.poste_has_reatorRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = poste_has_reatorTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    poste_has_reatorTableAdapter.FillByPoste(eletrocadDataSet.poste_has_reator, CadastrarPostes.posteId);
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

    }
}