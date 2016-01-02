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
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.ZoomCentreCheckBox = new System.Windows.Forms.CheckBox();
            this.ZoomTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProviderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.OverlayListBox = new System.Windows.Forms.ListBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.StatusStrip.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoordsLabel,
            this.StatusMessageLabel,
            this.GMapVersionLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 407);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(486, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // CoordsLabel
            // 
            this.CoordsLabel.Name = "CoordsLabel";
            this.CoordsLabel.Size = new System.Drawing.Size(90, 17);
            this.CoordsLabel.Text = "[mouse coords]";
            // 
            // StatusMessageLabel
            // 
            this.StatusMessageLabel.Name = "StatusMessageLabel";
            this.StatusMessageLabel.Size = new System.Drawing.Size(95, 17);
            this.StatusMessageLabel.Text = "[status message]";
            // 
            // GMapVersionLabel
            // 
            this.GMapVersionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.GMapVersionLabel.Name = "GMapVersionLabel";
            this.GMapVersionLabel.Size = new System.Drawing.Size(286, 17);
            this.GMapVersionLabel.Spring = true;
            this.GMapVersionLabel.Text = "GMap.NET 1.7.1";
            this.GMapVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OptionsPanel.Controls.Add(this.ZoomCentreCheckBox);
            this.OptionsPanel.Controls.Add(this.ZoomTextBox);
            this.OptionsPanel.Controls.Add(this.label2);
            this.OptionsPanel.Controls.Add(this.ProviderComboBox);
            this.OptionsPanel.Controls.Add(this.label1);
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(486, 27);
            this.OptionsPanel.TabIndex = 4;
            // 
            // ZoomCentreCheckBox
            // 
            this.ZoomCentreCheckBox.AutoSize = true;
            this.ZoomCentreCheckBox.Location = new System.Drawing.Point(309, 5);
            this.ZoomCentreCheckBox.Name = "ZoomCentreCheckBox";
            this.ZoomCentreCheckBox.Size = new System.Drawing.Size(107, 17);
            this.ZoomCentreCheckBox.TabIndex = 4;
            this.ZoomCentreCheckBox.Text = "Zoom and centre";
            this.ZoomCentreCheckBox.UseVisualStyleBackColor = true;
            // 
            // ZoomTextBox
            // 
            this.ZoomTextBox.Location = new System.Drawing.Point(284, 3);
            this.ZoomTextBox.Name = "ZoomTextBox";
            this.ZoomTextBox.Size = new System.Drawing.Size(19, 20);
            this.ZoomTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zoom level";
            // 
            // ProviderComboBox
            // 
            this.ProviderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ProviderComboBox.FormattingEnabled = true;
            this.ProviderComboBox.Location = new System.Drawing.Point(50, 3);
            this.ProviderComboBox.Name = "ProviderComboBox";
            this.ProviderComboBox.Size = new System.Drawing.Size(169, 21);
            this.ProviderComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provider";
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(62, 39);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.OverlayListBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gMap);
            this.splitContainer.Size = new System.Drawing.Size(363, 351);
            this.splitContainer.SplitterDistance = 120;
            this.splitContainer.TabIndex = 5;
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
            // 
            // GMapUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.StatusStrip);
            this.Name = "GMapUserControl";
            this.Size = new System.Drawing.Size(486, 429);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CoordsLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessageLabel;
        private System.Windows.Forms.ToolStripStatusLabel GMapVersionLabel;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.CheckBox ZoomCentreCheckBox;
        private System.Windows.Forms.TextBox ZoomTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProviderComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox OverlayListBox;
        private GMap.NET.WindowsForms.GMapControl gMap;
    }
}
