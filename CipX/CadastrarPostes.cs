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
            this.posteTableAdapter.Fill(this.eletrocadDataSet.poste);
            // TODO: This line of code loads data into the 'eletrocadDataSet.condicao_risco' table. You can move, or remove it, as needed.
            this.condicao_riscoTableAdapter.Fill(this.eletrocadDataSet.condicao_risco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.ativacao' table. You can move, or remove it, as needed.
            this.ativacaoTableAdapter.Fill(this.eletrocadDataSet.ativacao);
            // TODO: This line of code loads data into the 'eletrocadDataSet.fase' table. You can move, or remove it, as needed.
            this.faseTableAdapter.Fill(this.eletrocadDataSet.fase);
            // TODO: This line of code loads data into the 'eletrocadDataSet.braco' table. You can move, or remove it, as needed.
            this.bracoTableAdapter.Fill(this.eletrocadDataSet.braco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste' table. You can move, or remove it, as needed.
            this.posteTableAdapter.Fill(this.eletrocadDataSet.poste);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste' table. You can move, or remove it, as needed.
            this.posteTableAdapter.Fill(this.eletrocadDataSet.poste);

            medidorTextBox.Enabled = checkBox1.Checked;

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
            //timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //listGPS.Items.Clear();

            //listGPS.Items.Add("Situação do GPS: " + GPS.status);
            //listGPS.Items.Add("Latitude: " + GPS.lat);
            //listGPS.Items.Add("Longitude: " + GPS.lon);
            //listGPS.Items.Add("Satélites: " + GPS.numberOfSatellites);
            //listGPS.Items.Add("Acurácia: " + GPS.accuracy + "m");
            //listGPS.Items.Add("Data/Hora do GPS: " + GPS.gpsTtime.ToString("dd/MM/yyyy - HH:mm"));
            gps_timeTextBox.Text = GPS.gpsTtime.ToString();
            latTextBox.Text = GPS.lat.ToString();
            lonTextBox.Text = GPS.lon.ToString();

            //if (GPS.accuracy > 15 && GPS.status.Contains("corretamente"))
            //{
            //    listGPS.Items.Add("Baixa acurácia!");
            //    listGPS.ForeColor = Color.Orange;
            //}
            //if (GPS.accuracy < 15 && GPS.status.Contains("corretamente"))
            //{
            //    listGPS.Items.Add("Boa acurácia!");
            //    listGPS.ForeColor = Color.Lime;
            //}
        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                posteBindingSource.CancelEdit();
                posteBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            timer1.Enabled = true;
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            //chaveTextBox.Focus();
            bairroTextBox.Focus();
            tabControl1.SelectedIndex = 1;
            //usuario_idTextBox.Text = "" + 1;
            //programacao_ip_idTextBox.Text = CadastroProgramacao.programacaoId.ToString();
            trafo_idTextBox.Text = CadastrarTrafo.trafoId.ToString();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void salvar(object sender, EventArgs e)
        {
            timer1.Enabled = false;
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

        private void lampadas(object sender, EventArgs e)
        {
            posteId = Convert.ToInt32(labelPosteID.Text);

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarLampadas p = new CadastrarLampadas();
            p.ShowDialog();
        }

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

        private void menuItem8_Click(object sender, EventArgs e)
        {
            posteId = Convert.ToInt32(labelPosteID.Text);
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarReator p = new CadastrarReator();
            p.ShowDialog();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            medidorTextBox.Enabled = checkBox1.Checked;
        }
    }
}