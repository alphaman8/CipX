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

    }
}