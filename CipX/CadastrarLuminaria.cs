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
    }
}