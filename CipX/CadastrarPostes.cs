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

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listGPS.Items.Clear();

            listGPS.Items.Add("Situação do GPS: " + GPS.status);
            listGPS.Items.Add("Latitude: " + GPS.lat);
            listGPS.Items.Add("Longitude: " + GPS.lon);
            listGPS.Items.Add("Satélites: " + GPS.numberOfSatellites);
            listGPS.Items.Add("Acurácia: " + GPS.accuracy + "m");
            listGPS.Items.Add("Data/Hora do GPS: " + GPS.gpsTtime.ToString("dd/MM/yyyy - HH:mm"));
            gps_timeTextBox.Text = GPS.gpsTtime.ToString();
            latTextBox.Text = GPS.lat.ToString();
            lonTextBox.Text = GPS.lon.ToString();

            if (GPS.accuracy > 15 && GPS.status.Contains("corretamente"))
            {
                listGPS.Items.Add("Baixa acurácia!");
                listGPS.ForeColor = Color.Orange;
            }
            if (GPS.accuracy < 15 && GPS.status.Contains("corretamente"))
            {
                listGPS.Items.Add("Boa acurácia!");
                listGPS.ForeColor = Color.Lime;
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
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
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            //chaveTextBox.Focus();
            //tabControl1.SelectedIndex = 1;
            //usuario_idTextBox.Text = "" + 1;
            //programacao_ip_idTextBox.Text = CadastroProgramacao.programacaoId.ToString();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
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
                db.eletrocadDataSet.trafoRow r = (db.eletrocadDataSet.trafoRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = posteTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    posteTableAdapter.FillByPip(eletrocadDataSet.trafo, CadastroProgramacao.programacaoId);
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