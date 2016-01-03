namespace GMapUtility
{
    partial class GMapUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CoordsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GMapVersionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.OverlayListBox = new System.Windows.Forms.ListBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuProviderComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LegendMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoordsLabel,
            this.ZoomStatusLabel,
            this.StatusMessageLabel,
            this.GMapVersionLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 425);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(503, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // CoordsLabel
            // 
            this.CoordsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CoordsLabel.ForeColor = System.Drawing.Color.Blue;
            this.CoordsLabel.Name = "CoordsLabel";
            this.CoordsLabel.Size = new System.Drawing.Size(85, 17);
            this.CoordsLabel.Text = "[mouse coords]";
            // 
            // StatusMessageLabel
            // 
            this.StatusMessageLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StatusMessageLabel.Name = "StatusMessageLabel";
            this.StatusMessageLabel.Size = new System.Drawing.Size(91, 17);
            this.StatusMessageLabel.Text = "[status message]";
            // 
            // GMapVersionLabel
            // 
            this.GMapVersionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.GMapVersionLabel.Name = "GMapVersionLabel";
            this.GMapVersionLabel.Size = new System.Drawing.Size(271, 17);
            this.GMapVersionLabel.Spring = true;
            this.GMapVersionLabel.Text = "GMap.NET 1.7.1";
            this.GMapVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(36, 50);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.OverlayListBox);
            this.splitContainer.Panel1MinSize = 1;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gMap);
            this.splitContainer.Size = new System.Drawing.Size(363, 302);
            this.splitContainer.SplitterDistance = 120;
            this.splitContainer.TabIndex = 5;
            this.splitContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer_Paint);
            // 
            // OverlayListBox
            // 
            this.OverlayListBox.FormattingEnabled = true;
            this.OverlayListBox.Location = new System.Drawing.Point(14, 53);
            this.OverlayListBox.Name = "OverlayListBox";
            this.OverlayListBox.Size = new System.Drawing.Size(88, 108);
            this.OverlayListBox.TabIndex = 0;
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(49, 83);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 40;
            this.gMap.MinZoom = 1;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(129, 101);
            this.gMap.TabIndex = 2;
            this.gMap.Zoom = 0D;
            this.gMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMap_OnMapZoomChanged);
            this.gMap.MouseLeave += new System.EventHandler(this.gMap_MouseLeave);
            this.gMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProviderComboBox,
            this.optionsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(503, 27);
            this.MenuStrip.TabIndex = 6;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuProviderComboBox
            // 
            this.MenuProviderComboBox.Name = "MenuProviderComboBox";
            this.MenuProviderComboBox.Size = new System.Drawing.Size(170, 23);
            this.MenuProviderComboBox.SelectedIndexChanged += new System.EventHandler(this.ProviderComboBox_SelectedIndexChanged);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LegendMenuItem,
            this.StatusStripMenuItem,
            this.ZoomMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // LegendMenuItem
            // 
            this.LegendMenuItem.Name = "LegendMenuItem";
            this.LegendMenuItem.Size = new System.Drawing.Size(214, 22);
            this.LegendMenuItem.Text = "Show/Hide legend";
            this.LegendMenuItem.Click += new System.EventHandler(this.LegendMenuItem_Click);
            // 
            // StatusStripMenuItem
            // 
            this.StatusStripMenuItem.Name = "StatusStripMenuItem";
            this.StatusStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.StatusStripMenuItem.Text = "Show/Hide status strip";
            this.StatusStripMenuItem.Click += new System.EventHandler(this.StatusStripMenuItem_Click);
            // 
            // ZoomMenuItem
            // 
            this.ZoomMenuItem.Name = "ZoomMenuItem";
            this.ZoomMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ZoomMenuItem.Text = "Zoom with/without centre";
            this.ZoomMenuItem.Click += new System.EventHandler(this.ZoomMenuItem_Click);
            // 
            // ZoomStatusLabel
            // 
            this.ZoomStatusLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ZoomStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ZoomStatusLabel.Name = "ZoomStatusLabel";
            this.ZoomStatusLabel.Size = new System.Drawing.Size(41, 17);
            this.ZoomStatusLabel.Text = "[zoom]";
            // 
            // GMapUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.StatusStrip);
            this.Name = "GMapUserControl";
            this.Size = new System.Drawing.Size(503, 447);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CoordsLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessageLabel;
        private System.Windows.Forms.ToolStripStatusLabel GMapVersionLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox OverlayListBox;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripComboBox MenuProviderComboBox;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LegendMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ZoomStatusLabel;
    }
}
