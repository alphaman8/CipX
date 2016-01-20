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
    public partial class CadastrarPostes : Form
    {
        public CadastrarPostes()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarPostes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste' table. You can move, or remove it, as needed.
            this.posteTableAdapter.FillByTrafo(this.eletrocadDataSet.poste, CadastrarTrafo.trafoId);
            // TODO: This line of code loads data into the 'eletrocadDataSet.condicao_risco' table. You can move, or remove it, as needed.
            this.condicao_riscoTableAdapter.Fill(this.eletrocadDataSet.condicao_risco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.ativacao' table. You can move, or remove it, as needed.

            medidorTextBox.Enabled = checkBox1.Checked;

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
            //timer1.Enabled = true;
        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            GPSForm.StartTraking();

            while (GPS.accuracy > GPS.accuracyIdeal)
            {
                label1.Text = "Precisão está baixa: " + GPS.accuracy + "m";
                //MessageBox.Show("Não é possível inserir pois a precisão está baixa");
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();
            }

            label1.Text = "lat: " + GPS.lat + " lon: " + GPS.lon + " acc: " + GPS.accuracy + "m";

            try
            {
                posteBindingSource.CancelEdit();
                posteBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            //chaveTextBox.Focus();
            bairroTextBox.Focus();
            tabControl1.SelectedIndex = 1;
            gps_timeTextBox.Text = GPS.gpsTime.ToString();
            latTextBox.Text = GPS.lat.ToString();
            lonTextBox.Text = GPS.lon.ToString();
            //usuario_idTextBox.Text = "" + 1;
            //programacao_ip_idTextBox.Text = CadastroProgramacao.programacaoId.ToString();
            trafo_idTextBox.Text = CadastrarTrafo.trafoId.ToString();

            GPSForm.StopTrimble();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void salvar(object sender, EventArgs e)
        {
            if (!verifica())
            {
                MessageBox.Show("Barramento deve ter entre "
                    + Usuario.nMinBarramento + " a " + Usuario.nMaxBarramento + " dígitos");
                return;
            }

            try
            {
                this.posteBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["poste"];
                db.eletrocadDataSet.posteRow r = (db.eletrocadDataSet.posteRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = posteTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    posteTableAdapter.FillByTrafo(eletrocadDataSet.poste, CadastrarTrafo.trafoId);
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

        private bool verifica()
        {
            int len = barramentoTextBox.Text.Length;
            if (Usuario.nMaxBarramento <= len && Usuario.nMinBarramento >= len)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            posteId = Convert.ToInt32(labelPosteID.Text);

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarUsoMutuo p = new CadastrarUsoMutuo();
            p.ShowDialog();
        }

        public static int posteId;



        private void menuItem5_Click(object sender, EventArgs e)
        {
            posteId = Convert.ToInt32(labelPosteID.Text);

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarLuminaria p = new CadastrarLuminaria();
            p.ShowDialog();
        }

        private void croqui(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            Croqui p = new Croqui();
            p.ShowDialog();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            medidorTextBox.Enabled = checkBox1.Checked;
        }
    }
}