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
    public partial class Croqui : Form
    {
        private GpsViewNET.Map map1;
        private GpsViewNET.MapData objMapData;

        public Croqui()
        {
            InitializeComponent();

            GpsToolsNET.License objLicense = new GpsToolsNET.License();
            objLicense.LicenseKey = "F849EF1B603ECB8458D9";

            map1 = new GpsViewNET.Map();
            map1.Location = new Point(2, 2);
            //map1.Open(Library.appDir + "\\map\\bahia.MapLib");
            map1.Size = new Size(panel1.ClientRectangle.Width - 4,
                panel1.ClientRectangle.Height - 4);

            //map1.OnMouseDown += new GpsViewNET.OnMouseDown(map1_OnMouseDown);
            //map1.OnObjectDown += new GpsViewNET.OnObjectDown(map1_OnObjectDown);
            this.panel1.Controls.Add(map1);
            //lInfo.BringToFront();
        }


        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Croqui_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste' table. You can move, or remove it, as needed.
            this.posteTableAdapter.Fill(this.eletrocadDataSet.poste);

            GpsToolsNET.Position p1 = new GpsToolsNET.Position();
            GpsToolsNET.Position p2 = new GpsToolsNET.Position();
            //GpsViewNET.Point point1 = new GpsViewNET.Point();
            //GpsViewNET.Point point2 = new GpsViewNET.Point();

            p1.Latitude = GPS.lat;
            p1.Longitude = GPS.lon;
            p2.Latitude = GPS.lat;
            p2.Longitude = GPS.lon;

            p1.Move(300, 45, GpsToolsNET.DistanceMethod.GREAT_CIRCLE_DISTANCE);
            p2.Move(300, 225, GpsToolsNET.DistanceMethod.GREAT_CIRCLE_DISTANCE);

            create_blank_map(p1, p2);

            nodeDatumGrid.Datum = GpsToolsNET.Datum.WGS_84;

            objShapeTrack = new GpsShapeNET.Shape();
            objShapePostes = new GpsShapeNET.Shape();
            objShapeTrack.DatumGridTemplate = nodeDatumGrid;
            objShapePostes.DatumGridTemplate = nodeDatumGrid;

            mapShapeTrack = map1.NewMapShape(objShapeTrack);
            mapShapePoste = map1.NewMapShape(objShapePostes);

            //track
            objTrack = map1.NewRectangle();
            objTrack.Brush.Blue = 200;
            objTrack.Brush.Transparent = false;
            objTrack.Width = 4;
            objTrack.Height = 4;
            mapShapeTrack.NodeTemplate = objTrack;

            //poste
            objPoste = map1.NewEllipse();
            objPoste.Brush.Red = 200;
            objPoste.Brush.Transparent = false;
            objPoste.Width = 6;
            objPoste.Height = 6;
            mapShapePoste.NodeTemplate = objPoste;

            marcarPostes();

            map1.Update();


            timer1.Enabled = true;

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private GpsViewNET.MapShape mapShapeTrack = null;
        private GpsViewNET.MapShape mapShapePoste = null;
        private bool buildBlankMap = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////criar mapa de acordo com as primeiras coordenada

            if (!panel1.Visible)
            {
                panel1.Visible = true;
            }

            marcarOndeEstou(GPS.lat, GPS.lon);
 
        }

        int partIndex = -1;

        private void marcarPostes()
        {
            foreach (db.eletrocadDataSet.posteRow row in eletrocadDataSet.poste.Rows)
            {
                GpsToolsNET.Position objPosition = new GpsToolsNET.Position();
                objPosition.Datum = GpsToolsNET.Datum.WGS_84;
                objPosition.Latitude =  row.lat;
                objPosition.Longitude = row.lon;

                //map1.Position = objPosition;

                objPoste.Position = objPosition;
                                
                objShapePostes.DatumGridTemplate = nodeDatumGrid;
                objShapePostes.NewPart(partIndex);
                objShapePostes.NewNode(nodeIndex);
                objShapePostes.SetNode(objPosition);


            }

            map1.Update();
        }

        private void marcarOndeEstou(double lat, double lon)
        {
            GpsToolsNET.Position objPosition = new GpsToolsNET.Position();
            objPosition.Latitude = lat;
            objPosition.Longitude = lon;

            objTrack.Position = objPosition;
            
            objShapeTrack.DatumGridTemplate = objPosition;
            //objShapeTrack.DatumGridTemplate = pos1;
            //objShapeTrack.NewPart(partIndex);
            objShapeTrack.ClearShape();
            objShapeTrack.NewNode(nodeIndex);
            objShapeTrack.SetNode(objPosition);

            if (!chkNavegacao.Checked)
            {
                map1.Position = objPosition;
            }
            map1.Update();
        }


        private int nodeIndex = -1;
        private GpsToolsNET.Position nodeDatumGrid = new GpsToolsNET.Position();
        private GpsShapeNET.Shape objShapeTrack;
        private GpsShapeNET.Shape objShapePostes;
        private GpsViewNET.Rectangle objTrack;
        private GpsViewNET.Ellipse objPoste;
        private GpsToolsNET.Position map_pos;
        //private GpsToolsNET.Position pos1 = new GpsToolsNET.Position();

        private void create_blank_map(GpsToolsNET.Position p1, GpsToolsNET.Position p2)
        {
            // Create a blank map named "blank"	
            GpsViewNET.Point point1, point2, point3;
            GpsToolsNET.Position position1, position2, position3;

            position1 = p1;
            position2 = p2;

            this.map_pos = new GpsToolsNET.Position();

            position1.Datum = GpsToolsNET.Datum.WGS_84;
            position2.Datum = GpsToolsNET.Datum.WGS_84;

            map_pos.Datum = GpsToolsNET.Datum.WGS_84;
            map_pos.Longitude = p1.Longitude + (p2.Longitude - p1.Longitude) / 2;
            map_pos.Latitude = p2.Latitude + (p1.Latitude - p2.Latitude) / 2;

            int width = map1.Width;
            int height = map1.Height;

            point1 = new GpsViewNET.Point();
            point1.X = 0;
            point1.Y = 0;

            point2 = new GpsViewNET.Point();
            point2.X = width;
            point2.Y = height;

            // Creates and activates map, MapLib.NewMapData can also be used
            GpsViewNET.MapData objMapData = map1.ActiveMapData("blank");


            // Scales blank Map
            objMapData.SetScale(position1, point1, position2, point2, null, null);

            // Center map in middle of shape
            map1.Position = map_pos;
        }

        private void Croqui_Closing(object sender, CancelEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void zoomUpDown_ValueChanged(object sender, EventArgs e)
        {
            map1.Zoom = Convert.ToDouble(zoomUpDown.Value);
            GpsToolsNET.Position p = new GpsToolsNET.Position();
            p.Datum = GpsToolsNET.Datum.WGS_84;
            p.Latitude = GPS.lat;
            p.Longitude = GPS.lon;
            map1.Position = p;
            map1.Update();
        }
    }
}