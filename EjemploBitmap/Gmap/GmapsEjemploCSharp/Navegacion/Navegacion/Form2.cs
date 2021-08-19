using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace Navegacion
{
    public partial class Form2 : Form
    {
        public Form2()
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
        private void gmap_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rutapoint = new List<PointLatLng>();

            //gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.MapProvider = GMapProviders.OpenStreetMap; 
            gmap.MinZoom = 3;
            gmap.MaxZoom = 17;
            gmap.Zoom = 17;
            gmap.CanDragMap = true;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
            overlayOne = new GMapOverlay(gmap, "OverlayOne");
            
            gmap.Position = new PointLatLng(-12.104776, -76.962906);
            
            gmap.Width = gmap.Width + 1;
        }

        private void Form2_DoubleClick(object sender, EventArgs e)
        {

           
        }

        private void gmap_DoubleClick(object sender, EventArgs e)
        {
            //CREAR UNA COORDENADA
            //************************************************************************
            GMapControl gm = (GMapControl)sender;
            MouseEventArgs hj = (MouseEventArgs)e;
            Global_plg = gm.FromLocalToLatLng(hj.X, hj.Y);
            rutapoint.Add(Global_plg);//añadir coordenada
            newmarca = new GMapMarkerGoogleGreen(Global_plg);      //ROJO
           
            overlayOne.Markers.Add(newmarca);
            
            dataGridView1.Rows.Add("x", Global_plg.Lat,Global_plg.Lng);
            gmap.Overlays.Add(overlayOne);
        }
    }
}
