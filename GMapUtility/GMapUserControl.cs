using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Catfood.Shapefile;

namespace GMapUtility
{
    public partial class GMapUserControl : UserControl
    {
        //public properties
        #region properties
        public Exception ErrorMessage { get; private set; }

        public bool TopPanelVisible { get; private set; }
        public bool StatusStripVisible { get; private set; }
        public bool LegendPanelVisible { get; private set; }

        public string CurrentProvider { get; set; }
        public string PositionKeyword { get; set; }
        public int CurrentZoomLevel { get; set; }

        public List<string> GMapProvidersList { get; private set; }  //TODO: make  provider list 
        public List<string> OverlayList { get; private set; }
        public List<string> MarkerList { get; private set; }

        #endregion properties

        //TODO: generalise for multiple overlays and markers; lines and polygons
        #region declarations/private properties
        private List<GMapOverlay> gMapOverlayList = new List<GMapOverlay>();

        public int MarkerSize { get; set; }
        public Color MarkerColour { get; set; }


        GMapOverlay overlay;
        GMarkerGoogle marker;
        Bitmap bitmap;
        Color markerColour = Color.Red;
        int markerSize = 2;

        Shapefile myShapefile;
        List<ShapePoint> shapePoint;

        DataTable myDataTable;
        #endregion declarations/private properties

        //constructor
        #region constructor
        public GMapUserControl()
        {
            InitializeComponent();

            DoFormLayout();

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            SetProvidersList();
            SetDefaults();
        }

        private void DoFormLayout()
        {
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Panel1Collapsed = true;
            gMap.Dock = DockStyle.Fill;

            OverlayListBox.Dock = DockStyle.Fill;

        }

        private void SetDefaults()
        {

            //set position
            if (string.IsNullOrEmpty(PositionKeyword))
                PositionKeyword = "Western Australia";

            gMap.SetPositionByKeywords(PositionKeyword);

            //zoomlevel
            if (CurrentZoomLevel == 0)
                CurrentZoomLevel = 4;

            gMap.Zoom = CurrentZoomLevel;
            gMap_OnMapZoomChanged();

            //provider
            ProviderComboBox.SelectedIndex = ProviderComboBox.FindStringExact(CurrentProvider);

            StatusMessageLabel.Text = "";

            gMap.ShowCenter = false;
            gMap.DragButton = MouseButtons.Left;

            //overlay
            OverlayList = new List<string>();
            overlay = new GMapOverlay("markers");


            //markers
            MarkerColour = markerColour;
            MarkerSize = markerSize;
            bitmap = CreateBitmap(MarkerSize, MarkerColour);

            ShowTopPanel(true);
            ShowStatusStrip(true);


            //data
            myShapefile = new Shapefile();
            myDataTable = new DataTable();
        }

        private void SetProvidersList()
        {
            ProviderComboBox.SelectedIndexChanged -= ProviderComboBox_SelectedIndexChanged;
            ProviderComboBox.DataSource = GMapProviders.List;
            ProviderComboBox.SelectedIndexChanged += ProviderComboBox_SelectedIndexChanged;

            if (string.IsNullOrEmpty(CurrentProvider))
                CurrentProvider = "BingSatelliteMap";

        }
        #endregion constructor

        //public methods
        #region public methods

        //overlays
        public void AddOverlay(string name)
        {
            if (OverlayList.Any(str => str.Equals(name)))       //name already in list
                return;

            var overlay = new GMapOverlay(name);
            gMapOverlayList.Add(overlay);
            OverlayList.Add(name);

            //OverlayListBox.DataSource = null;
            OverlayListBox.DataSource = OverlayList;
        }

        public void DeleteOverlay(string name)
        {
            gMapOverlayList.Remove(TheGMapOverlay(name));
            OverlayList.Remove(name);
        }

        public void ShowOverlay(string name)
        {
            TheGMapOverlay(name).IsVisibile = true;
            this.Refresh();
        }

        public void HideOverlay(string name)
        {
            //int ndx = OverlayList.IndexOf(name);
            //gMapOverlayList[ndx].Clear();
            TheGMapOverlay(name).IsVisibile = false;
            this.Refresh();

        }

        public void ResetOverlays()
        {
            gMap.Overlays.Clear();
            foreach (GMapOverlay overlay in gMapOverlayList)
                overlay.Clear();
        }

        //status
        public void ShowTopPanel(bool on)
        {
            OptionsPanel.Visible = on;
            TopPanelVisible = on;
            //this.Refresh();
        }

        public void ShowStatusStrip(bool on)
        {
            StatusStrip.Visible = on;
            StatusStripVisible = on;
        }

        public void ShowLegendPanel(bool on)
        {
            splitContainer.Panel1Collapsed = !on;
            LegendPanelVisible = on;
        }

        //plotting markers
        public void PlotShapefile(string shapeFile, string overlay, string marker, Color markerColour)
        {
            ErrorMessage = null;
            myShapefile = ReadShapefile(shapeFile);

            //ReadShapefile(shapeFile);
            if (ErrorMessage != null)
                return;

            StatusMessageLabel.Text = myShapefile.Count.ToString() + " " + myShapefile.Type.ToString() + "s";


            MarkerColour = markerColour;

            if (myShapefile.Type == ShapeType.Point)
                ShowShapePoints(TheGMapOverlay(overlay));

            this.Refresh();
        }

        public void PlotDataTable(DataTable dataTable, string overlay, string marker, Color markerColour)
        {
            ErrorMessage = null;
            MarkerColour = markerColour;

            PlotDataPoints();
            gMap.Refresh();

        }


        #endregion public methods

        //events
        private void ProviderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMap.MapProvider = (GMapProvider)ProviderComboBox.SelectedItem;
            gMap.Refresh();
        }

        private void gMap_MouseMove(object sender, MouseEventArgs e)
        {
            //http://stackoverflow.com/questions/18874868/how-to-return-lat-long-with-mousemove-in-gmap-net

            base.OnMouseMove(e);

            double X = gMap.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = gMap.FromLocalToLatLng(e.X, e.Y).Lat;

            string longitude = X.ToString(@"#.##0");
            string latitude = Y.ToString(@"#.##0");
            CoordsLabel.Text = "Coords: [" + longitude + ", " + latitude + "]";
        }

        private void gMap_OnMapZoomChanged()
        {
            ZoomTextBox.Text = gMap.Zoom.ToString();
            Size size = new System.Drawing.Size(splitContainer.Panel2.Width, splitContainer.Panel2.Height);
            gMap.ClientSize = size;
            this.Refresh();
        }

        private void ZoomCentreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gMap.MouseWheelZoomType = (ZoomCentreCheckBox.Checked) ? MouseWheelZoomType.MousePositionAndCenter :
                                                                            MouseWheelZoomType.MousePositionWithoutCenter;
        }

        private void gMap_MouseLeave(object sender, EventArgs e)
        {
            CoordsLabel.Text = "";
        }

        //utility methods
        private Bitmap CreateBitmap(int side, Color colour)
        {
            //http://www.techotopia.com/index.php/Using_Bitmaps_for_Persistent_Graphics_in_C_Sharp

            var myBitmap = new Bitmap(side, side);
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                using (Brush b = new SolidBrush(colour))
                {
                    g.FillRectangle(b, 0, 0, side, side);
                }
            }

            return myBitmap;
        }

        private GMapOverlay TheGMapOverlay(string overlay)
        {
            int ndx = OverlayList.IndexOf(overlay);
            return gMapOverlayList[ndx];
        }

        private Shapefile ReadShapefile(string shapefile)
        {
            var catfoodShapefile = new Shapefile();
            try
            {
                catfoodShapefile.Open(shapefile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error : " + ex.Message);
                ErrorMessage = ex;
            }
            return catfoodShapefile;
        }

        private void ShowShapePoints(GMapOverlay overlay)
        {
            Cursor.Current = Cursors.WaitCursor;
            ShapePoint shapePoint;

            myShapefile.Reset();
            gMap.Overlays.Clear();
            //overlay.Clear();

            //ResetOverlay();

            for (int i = 0; i < myShapefile.Count; i++)
            {
                if (myShapefile.MoveNext())
                {
                    shapePoint = (ShapePoint)myShapefile.Current;

                    marker = new GMarkerGoogle(new GMap.NET.PointLatLng(shapePoint.Point.Y, shapePoint.Point.X),
                                    bitmap);

                    overlay.Markers.Add(marker);
                }
            }

            gMap.Overlays.Add(overlay);
            gMap.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private void PlotDataPoints()
        {
            MessageBox.Show("not available");
        }



    }
}
