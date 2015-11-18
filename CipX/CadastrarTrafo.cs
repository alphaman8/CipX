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
    public partial class CadastrarTrafo : Form
    {
        public CadastrarTrafo()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarTrafo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.trafo' table. You can move, or remove it, as needed.
            this.trafoTableAdapter.Fill(this.eletrocadDataSet.trafo);

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
            timer1.Enabled = true;
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                trafoBindingSource.CancelEdit();
                trafoBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //cod_bracoComboBox.SelectedIndex = 0;
            //fasesComboBox.SelectedIndex = 0;
            //cod_luminariaComboBox.SelectedIndex = 0;
            //comandoComboBox.SelectedIndex = 0;
            //cod_lampadaComboBox.SelectedIndex = 0;
            //cod_reatorComboBox.SelectedIndex = 0;
            //plaqueta_fkTextBox.Text = Plaqueta.plaqueta;
            //observacaoTextBox.Text = "";
            chaveTextBox.Text = "";
            ciaTextBox.Text = "";
            alimentadorTextBox.Text = "";
            chaveTextBox.Focus();
            tabControl1.SelectedIndex = 1;

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                this.trafoBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["material"];
                db.eletrocadDataSet.trafoRow r = (db.eletrocadDataSet.trafoRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = trafoTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();

                    try
                    {
                        trafoBindingSource.CancelEdit();
                        trafoBindingSource.AddNew();

                        DataRowView drv = (DataRowView)trafoBindingSource.Current;
                        drv["alimentador"] = r.alimentador;
                        drv["chave"] = r.chave;
                        drv["cia"] = r.cia;
                        drv["gps_time"] = r.gps_time;

                        this.trafoBindingSource.EndEdit();
                        changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();
                        numRows = trafoTableAdapter.Update(changes);
                        this.eletrocadDataSet.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

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

        private void CadastrarTrafo_Closing(object sender, CancelEventArgs e)
        {
            timer1.Enabled = false;
            Application.DoEvents();
        }
    }
}