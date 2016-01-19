using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PFTGPSReceiver;
using PFTSSFWriter;

namespace CipX
{
    public partial class GPSForm : Form
    {
        public string displayString = "";
        public string quantSatelites = "0";
        public string gpgga = "";
        public string gprmc = "";
        public string txtSatelites = "";
        public bool conectado = false;

        [DllImport("coredll.dll", SetLastError = true)]
        public static extern void MessageBeep(int code);

        public static void MessageBeep()
        {
            MessageBeep(-1);  // Default beep code is -1
        }

        public GPSForm()
        {
            InitializeComponent();
            ControlBox = false;
        }

        public static GPSReceiver gpsTrimble;
        public SSFWriterErrorCode errorCode;
        public static SSFWriter ssfWriter;
        public static String gpsTrimbleStatus;

        public static void StopTrimble()
        {
            GPS.accuracy = 200;
            if (gpsTrimble != null)
            {
                gpsTrimble.StopTracking();
                //gpsTrimble.ResetGPSReceiver();
                //Usuario.UsandoTrimble = false;
            }
        }

        public static bool StartTraking()
        {
            GPS.accuracy = 200;
            if (gpsTrimble != null)
            {
                return gpsTrimble.StartTracking();
                //gpsTrimble.ResetGPSReceiver();
                //Usuario.UsandoTrimble = false;
            }
            return false;
        }

        public bool usarSSF = true;

        public void ConectarTrimbleSimulacao()
        {
            gpsTrimble = new GPSReceiver();
            gpsTrimble.CommPort = "COM4";
            //gpsTrimble.DGPSSettings.Source = DGPSSourceType.pfIntegratedSBASSource;
            //gpsTrimble.DGPSSettings.PositionMode = DGPSPositionMode.pfBestPositionsAvailable;
            gpsTrimble.PositionMinimumInterval = 1.0f;
            gpsTrimble.MinimumElevationAngleMask = 5.0f;
            gpsTrimble.MinimumSNRMask = 12.0f;
            //this.gpsTrimble.MinimumNumberOfSatellites = 4;
            gpsTrimble.DOPType = DOPTypeCode.pfDOPTypePDOP;
            gpsTrimble.MaximumPDOPMask = 8.0f;
            //this.gpsTrimble.MaximumHDOPMask = 3.9f;
            //this.gpsTrimble.VelocityFilter = false;

            gpsTrimble.NewError +=
                new IGPSReceiverEvents_NewErrorEventHandler(gpsTrimble_NewError);
            gpsTrimble.NewGPSStatus +=
                new IGPSReceiverEvents_NewGPSStatusEventHandler(gpsTrimble_NewGPSStatus);
            gpsTrimble.NewPosition +=
                new IGPSReceiverEvents_NewPositionEventHandler(gpsTrimble_NewPosition);

            //ativar simulação
            gpsTrimble.SimulationSettings.Latitude = -12.212848f;
            gpsTrimble.SimulationSettings.Longitude = -38.9580686f;
            gpsTrimble.SimulationSettings.Radius = 100;
            gpsTrimble.SimulationSettings.IsSimulationEnabled = true;


            bool started = gpsTrimble.StartTracking();
            if (started)
            {
                gpsTrimbleStatus = "Pesquisando Satélite";
                //Usuario.UsandoTrimble = true;
            }
            else
            {
                gpsTrimbleStatus = "Não foi possível conectar ao GPS";
            }
        }

        public string ConectarTrimble()
        {
            gpsTrimble = new GPSReceiver();
            gpsTrimble.CommPort = "COM4";
            //gpsTrimble.DGPSSettings.Source = DGPSSourceType.pfIntegratedSBASSource;
            //gpsTrimble.DGPSSettings.PositionMode = DGPSPositionMode.pfBestPositionsAvailable;
            gpsTrimble.PositionMinimumInterval = 3.0f;
            gpsTrimble.MinimumElevationAngleMask = 5.0f;
            gpsTrimble.MinimumSNRMask = 12.0f;
            //this.gpsTrimble.MinimumNumberOfSatellites = 4;
            gpsTrimble.DOPType = DOPTypeCode.pfDOPTypePDOP;
            gpsTrimble.MaximumPDOPMask = 8.0f;
            //this.gpsTrimble.MaximumHDOPMask = 3.9f;
            //this.gpsTrimble.VelocityFilter = false;

            gpsTrimble.NewError +=
                new IGPSReceiverEvents_NewErrorEventHandler(gpsTrimble_NewError);
            gpsTrimble.NewGPSStatus +=
                new IGPSReceiverEvents_NewGPSStatusEventHandler(gpsTrimble_NewGPSStatus);
            gpsTrimble.NewPosition +=
                new IGPSReceiverEvents_NewPositionEventHandler(gpsTrimble_NewPosition);

            //ativar simulação
            //gpsTrimble.SimulationSettings.Latitude = -12.212f;
            //gpsTrimble.SimulationSettings.Longitude = -38.958f;
            //gpsTrimble.SimulationSettings.Radius = 300;
            //gpsTrimble.SimulationSettings.IsSimulationEnabled = true;


            bool started = gpsTrimble.StartTracking();
            if (started)
            {
                gpsTrimbleStatus = "Pesquisando Satélite. Aguarde...";
                return gpsTrimbleStatus;
                //Usuario.UsandoTrimble = true;
            }
            else
            {
                gpsTrimbleStatus = "Não foi possível conectar ao GPS";
                return gpsTrimbleStatus;
            }
        }

        void gpsTrimble_NewError(GPSReceiverErrorCode ErrorCode, string ErrorString)
        {
            GPS.error = "" + ErrorCode.ToString() + " " + ErrorString;

            string fileText = "error.txt";
            if (!System.IO.File.Exists(fileText))
            {
                System.IO.File.CreateText(fileText);
            }

            using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(fileText, true))
            {
                writetext.WriteLine(GPS.error);
            }
        }

        public static GPSPosition pos;


        private void gpsTrimble_NewPosition(GPSPosition position)
        {
            pos = position;
            
            statusTrimble();
        }

        private void gpsTrimble_NewGPSStatus(GPSStatusCode code, String s)
        {
            gpsTrimbleStatus = s;
            statusTrimble();
        }

        public virtual void statusTrimble()
        {
        }

        //private void verificaConexao()
        //{
        //    if (Usuario.btClient != null && Usuario.btClient.Connected && timerCoordenada.Enabled == false)
        //    {
        //        timerCoordenada.Enabled = true;
        //        conectado = true;
        //    }
        //    else
        //    {
        //        timerCoordenada.Enabled = false;
        //        conectado = false;
        //    }
        //}
        private Queue<LatLon> filaLatLon = new Queue<LatLon>();
        public bool salvar = false;
        private string gpgll;

        public string Gpgll
        {
            get { return gpgll; }
            set { gpgll = value; }
        }

        public static double accuracy = 0;
        public static DateTime dataHora;

        private void timerCoordenada_Tick(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.DoEvents();

            //System.Net.Sockets.NetworkStream stream =
            //    Usuario.btClient.GetStream();

            ////primeiro pega a data e hora com GPZDA
            //while (!displayString.Contains("$GPRMC"))
            //{
            //    byte[] data = new byte[1];
            //    int numOfBytesRead = stream.Read(data, 0, data.Length);

            //    displayString = displayString + Encoding.ASCII.GetString(data, 0, numOfBytesRead);
            //}
            //displayString = "$GPRMC";
            //while (!displayString.Contains("\r"))
            //{
            //    byte[] data = new byte[1];
            //    int numOfBytesRead = stream.Read(data, 0, data.Length);
            //    displayString = displayString + Encoding.ASCII.GetString(data, 0, numOfBytesRead);
            //}
            //gprmc = displayString;
            //try
            //{
            //    GeoFramework.Gps.Nmea.GprmcSentence gprmcSetence =
            //        new GeoFramework.Gps.Nmea.GprmcSentence(gprmc);

            //    dataHora = gprmcSetence.UtcDateTime;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message, "gprmc sentença falhou", this.Name);
            //}


            ////GPGGA
            //displayString = "";
            //while (!displayString.Contains("$GPGGA"))
            //{
            //    byte[] data = new byte[1];
            //    int numOfBytesRead = stream.Read(data, 0, data.Length);

            //    displayString = displayString + Encoding.ASCII.GetString(data, 0, numOfBytesRead);
            //}

            //displayString = "$GPGGA";

            //while (!displayString.Contains("\r"))
            //{
            //    byte[] data = new byte[1];
            //    int numOfBytesRead = stream.Read(data, 0, data.Length);
            //    displayString = displayString + Encoding.ASCII.GetString(data, 0, numOfBytesRead);
            //}

            //gpgga = displayString;
            //try
            //{
            //    GeoFramework.Gps.Nmea.GpggaSentence gpggaSetence =
            //        new GeoFramework.Gps.Nmea.GpggaSentence(gpgga);

            //    accuracy = gpggaSetence.HorizontalDilutionOfPrecision.Value;
            //    lat = Math.Round(gpggaSetence.Position.Latitude.DecimalDegrees, 10).ToString();
            //    lon = Math.Round(gpggaSetence.Position.Longitude.DecimalDegrees, 10).ToString();

            //    LatLon latlon = new LatLon();
            //    latlon.Lat = lat;
            //    latlon.Lon = lon;

            //    filaLatLon.Enqueue(latlon);

            //    if (filaLatLon.Count == 4)
            //    {
            //        if ((filaLatLon.All(l => l.Lat == latlon.Lat)) &&
            //            (filaLatLon.All(l => l.Lon == latlon.Lon)))
            //        {
            //            salvar = true;
            //        }
            //        else
            //        {
            //            salvar = false;
            //        }

            //        filaLatLon.Dequeue();
            //    }

            //    //quantSatelites = nmea[7];
            //    quantSatelites = gpggaSetence.FixedSatelliteCount.ToString();
            //    if (Int32.Parse(quantSatelites) < 4)
            //    {
            //        txtSatelites = quantSatelites + " (Ruim)";
            //    }
            //    else
            //    {
            //        txtSatelites = quantSatelites + " (Bom)";
            //    }

            //    displayString = string.Empty;

            //    atualizaInfoGPS();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message, "gpgga sentença falhou", this.Name);
            //}
        }

        public virtual void atualizaInfoGPS()
        {
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GPSForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Name = "GPSForm";
            this.Click += new System.EventHandler(this.GPSForm_Click);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.GPSForm_Closing);
            this.ResumeLayout(false);

        }

        private void GPSForm_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void GPSForm_Closing(object sender, CancelEventArgs e)
        {
            //if (ssfWriter != null)
            //{
            //    if (ssfWriter.IsFeatureInProgress())
            //    {
            //        ssfWriter.CancelFeature();
            //    }

            //    if (ssfWriter.IsSSFFileInProgress())
            //    {
            //        ssfWriter.EndSSFFile();
            //    }

            //    ssfWriter = null;
            //}
            if (gpsTrimble != null)
            {
                if (gpsTrimble.IsTracking())
                {
                    gpsTrimble.StopTracking();
                }

                gpsTrimble = null;
            }
        }
    }
}