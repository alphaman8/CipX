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
    public partial class TelaInicial : GPSForm
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastroProgramacao ip = new CadastroProgramacao();
            ip.ShowDialog();
        }

        private void conectarGps()
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            listGPS.Items.Clear();
            listGPS.Items.Add(ConectarTrimble());
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            conectarGps();
        }

        int quantPosicoes = 5;

        public override void statusTrimble()
        {
            listGPS.Items.Clear();
            string status = gpsTrimbleStatus;

            if (status.Contains("tracking"))
            {
                status = "Pesquisando por satélites";
                listGPS.ForeColor = Color.Red;
            }
            if (status.Contains("Calculating"))
            {
                status = "Trabalhando corretamente";
                listGPS.ForeColor = Color.Lime;
            }
            if (status.Contains("Waiting"))
            {
                status = "Esperando Satélites";
                listGPS.ForeColor = Color.Red;
            }

            if (pos == null)
            {
                if (menuItem3.Enabled)
                {
                    menuItem3.Enabled = false;
                }
                return;
            }

            GPS.status = status;
            GPS.gpsTtime = pos.GPSTime;
            GPS.lat = pos.Latitude;
            GPS.lon = pos.Longitude;
            GPS.numberOfSatellites = pos.NumberOfSatellites;
            GPS.accuracy = Math.Round(pos.EstimatedAccuracy, 2);

            listGPS.Items.Add("Situação do GPS: " + status);
            listGPS.Items.Add("Latitude: " + GPS.lat);
            listGPS.Items.Add("Longitude: " + GPS.lon);
            listGPS.Items.Add("Satélites: " + GPS.numberOfSatellites);
            listGPS.Items.Add("Acurácia: " + GPS.accuracy + "m");
            listGPS.Items.Add("Data/Hora do GPS: " + GPS.gpsTtime.ToString("dd/MM/yyyy - HH:mm"));

            if (GPS.accuracy > 15 && status.Contains("corretamente"))
            {
                listGPS.Items.Add("Baixa acurácia!");
                listGPS.ForeColor = Color.Orange;
            }
            if (GPS.accuracy < 15 && status.Contains("corretamente"))
            {
                listGPS.Items.Add("Boa acurácia!");
                listGPS.ForeColor = Color.Lime;
            }

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            conectarGps();
        }
    }
}