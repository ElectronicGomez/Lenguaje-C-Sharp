using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*agregar*/
using System.Collections;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace Navegacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GMapOverlay overlayOne;
        GMapRoute rutaX;
        GMapMarker newmarca;
        ArrayList lsMarcas = new ArrayList();
        PointLatLng Global_plg;
        GMapPolygon polygon;

        List<PointLatLng> rutapoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            rutapoint = new List<PointLatLng>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleMap;
            //gmap.MapProvider = GMapProviders.OpenStreetMap; 
            gmap.MinZoom = 3;
            gmap.MaxZoom = 17;
            gmap.Zoom = 17;
            gmap.CanDragMap = true;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
            overlayOne = new GMapOverlay(gmap, "OverlayOne");
            lsMarcas.Add("-12.104876, -76.962306");
            lsMarcas.Add("-12.104176, -76.962106");
            lsMarcas.Add("-12.101876, -76.961306");
            gmap.Position = new PointLatLng(-12.104776, -76.962906);
            foreach (string cad in lsMarcas)
            {
                Double lat, lon;
                string[] aCad = cad.Split(',');
                lat = Convert.ToDouble(aCad[0]);
                lon = Convert.ToDouble(aCad[1]);
                overlayOne.Markers.Add(new GMapMarkerGoogleGreen(new PointLatLng(lat, lon)));
                gmap.Overlays.Add(overlayOne);
            }
            gmap.Width = gmap.Width + 1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            overlayOne.Markers.Add(new GMapMarkerGoogleGreen(new PointLatLng(-12.104793, -76.965678)));

        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }

        private void gmap_Click(object sender, EventArgs e)
        {
           // RECUPERAR UNA COORDENADA
            //************************************************************************
            GMapControl gm = (GMapControl)sender;
            MouseEventArgs hj = (MouseEventArgs)e;
            Global_plg = gm.FromLocalToLatLng(hj.X, hj.Y);
            textBox1.Text = "Lat: " + Global_plg.Lat;
            textBox2.Text = "Lon: " + Global_plg.Lng;
        }

        private void gmap_DoubleClick(object sender, EventArgs e)
        {
            //CREAR UNA COORDENADA
            //************************************************************************
            GMapControl gm = (GMapControl)sender;
            MouseEventArgs hj = (MouseEventArgs)e;
            Global_plg = gm.FromLocalToLatLng(hj.X, hj.Y);
            rutapoint.Add(Global_plg);//añadir coordenada
            newmarca = new GMapMarkerGoogleRed(Global_plg);      //ROJO
            //newmarca = new GMapMarkerGoogleGreen(Global_plg);  //VERDE

            overlayOne.Markers.Add(newmarca);
        }

        private void button3_Click(object sender, EventArgs e)
        {//MARCAR LINEAS Y CALCULAR DISTACIAS, RUTAS

            //PointLatLng[] puntos = new PointLatLng[3];
            //puntos[0] = new PointLatLng(-12.104776, -76.962906);
            //puntos[1] = new PointLatLng(-12.104010, -76.964076);
            //puntos[2] = new PointLatLng(-12.105639, -76.964997);

            // List<PointLatLng> rutapoint = new List<PointLatLng>();
            // rutapoint.Add(puntos[0]);
            // rutapoint.Add(puntos[1]);
             //rutapoint.Add(puntos[2]);
             rutaX = new GMapRoute(rutapoint, "ruta1");
             overlayOne.Routes.Add(rutaX);
             MessageBox.Show(((rutaX.Distance)*1000).ToString()+ " mts");
        }



        private void button4_Click(object sender, EventArgs e)
        {
            //borrar todos los marcadores
            overlayOne.Markers.Clear();
            //borrar ruta
            overlayOne.Routes.Remove(rutaX);
            rutapoint = new List<PointLatLng>(); //reiniciar

            //borrar poligono
            overlayOne.Polygons.Remove(polygon);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            overlayOne.Markers.Remove(newmarca); //borrar la ultima marca
        }

        private void button7_Click(object sender, EventArgs e)
        {
            polygon = new GMapPolygon(rutapoint, "poligono");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            overlayOne.Polygons.Add(polygon); 
            gmap.Overlays.Add(overlayOne);


        }
    }
}
