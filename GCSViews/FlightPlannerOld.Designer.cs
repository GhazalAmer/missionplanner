﻿namespace MissionPlanner.GCSViews
{
    partial class FlightPlanner
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

            if (currentMarker != null)
                currentMarker.Dispose();
            if (drawnpolygon != null)
                drawnpolygon.Dispose();
            if (kmlpolygonsoverlay != null)
                kmlpolygonsoverlay.Dispose();
            if (wppolygon != null)
                wppolygon.Dispose();
            if (top != null)
                top.Dispose();
            if (geofencepolygon != null)
                geofencepolygon.Dispose();
            if (geofenceoverlay != null)
                geofenceoverlay.Dispose();
            if (drawnpolygonsoverlay != null)
                drawnpolygonsoverlay.Dispose();
            if (center != null)
                center.Dispose(); 

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.splitter2 = new BSE.Windows.Forms.Splitter();
            this.panelMap = new System.Windows.Forms.Panel();
            this.zoom_out = new MissionPlanner.Controls.MyButton();
            this.zoom_in = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton22 = new MissionPlanner.Controls.MyButton();
            this.myButton21 = new MissionPlanner.Controls.MyButton();
            this.myButton18 = new MissionPlanner.Controls.MyButton();
            this.label19 = new System.Windows.Forms.Label();
            this.Cancel = new MissionPlanner.Controls.MyButton();
            this.FollowMePanel = new System.Windows.Forms.Panel();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.SavePolysBTN = new MissionPlanner.Controls.MyButton();
            this.ImportPolysBTN = new MissionPlanner.Controls.MyButton();
            this.label22 = new System.Windows.Forms.Label();
            this.NewDrawPoly = new MissionPlanner.Controls.MyButton();
            this.ApplyPoly = new MissionPlanner.Controls.MyButton();
            this.DeletePoly = new MissionPlanner.Controls.MyButton();
            this.label23 = new System.Windows.Forms.Label();
            this.PolyNameBox = new System.Windows.Forms.TextBox();
            this.ColorBTN = new System.Windows.Forms.Button();
            this.measurePanel = new System.Windows.Forms.Panel();
            this.UnitsMeasureBTN = new MissionPlanner.Controls.MyButton();
            this.measureLabel = new System.Windows.Forms.Label();
            this.ToolsTable = new System.Windows.Forms.TableLayoutPanel();
            this.DrawBTN = new MissionPlanner.Controls.MyButton();
            this.MeasureBTN = new MissionPlanner.Controls.MyButton();
            this.Joystick_Panel = new System.Windows.Forms.Panel();
            this.FormatPanel = new System.Windows.Forms.Panel();
            this.myButton17 = new MissionPlanner.Controls.MyButton();
            this.myButton16 = new MissionPlanner.Controls.MyButton();
            this.myButton15 = new MissionPlanner.Controls.MyButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.PlaceAfterPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton19 = new MissionPlanner.Controls.MyButton();
            this.myButton20 = new MissionPlanner.Controls.MyButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.SpeedPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton6 = new MissionPlanner.Controls.MyButton();
            this.myButton7 = new MissionPlanner.Controls.MyButton();
            this.WPTh = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.WPSp = new System.Windows.Forms.NumericUpDown();
            this.panel9 = new System.Windows.Forms.Panel();
            this.myButton11 = new MissionPlanner.Controls.MyButton();
            this.myButton10 = new MissionPlanner.Controls.MyButton();
            this.myButton9 = new MissionPlanner.Controls.MyButton();
            this.myButton8 = new MissionPlanner.Controls.MyButton();
            this.newhome = new MissionPlanner.Controls.MyButton();
            this.Commands = new System.Windows.Forms.DataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SwarmPanel = new System.Windows.Forms.Panel();
            this.Joystickbutton = new MissionPlanner.Controls.MyButton();
            this.myButton5 = new MissionPlanner.Controls.MyButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.label15 = new System.Windows.Forms.Label();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton13 = new MissionPlanner.Controls.MyButton();
            this.Deletebu = new MissionPlanner.Controls.MyButton();
            this.myButton14 = new MissionPlanner.Controls.MyButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BackWP = new System.Windows.Forms.Button();
            this.WPNumber = new System.Windows.Forms.NumericUpDown();
            this.NextWP = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton4 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton12 = new MissionPlanner.Controls.MyButton();
            this.EW = new System.Windows.Forms.Button();
            this.NS = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LongSec = new System.Windows.Forms.NumericUpDown();
            this.LongMin = new System.Windows.Forms.NumericUpDown();
            this.LongDeg = new System.Windows.Forms.NumericUpDown();
            this.LatSec = new System.Windows.Forms.NumericUpDown();
            this.LatMin = new System.Windows.Forms.NumericUpDown();
            this.LatDeg = new System.Windows.Forms.NumericUpDown();
            this.Joysticknutton = new MissionPlanner.Controls.myGMAP();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ToolsBTN = new MissionPlanner.Controls.MyButton();
            this.EditButton = new MissionPlanner.Controls.MyButton();
            this.Reversewpbutton = new MissionPlanner.Controls.MyButton();
            this.BUT_loadwpfile = new MissionPlanner.Controls.MyButton();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.BUT_write = new MissionPlanner.Controls.MyButton();
            this.HOLDQUICK = new MissionPlanner.Controls.MyButton();
            this.BUT_saveWPFile = new MissionPlanner.Controls.MyButton();
            this.ClearClick = new MissionPlanner.Controls.MyButton();
            this.AUTOQUICK = new MissionPlanner.Controls.MyButton();
            this.switchview = new MissionPlanner.Controls.MyButton();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.HOMECLICK = new System.Windows.Forms.Button();
            this.mytest = new MissionPlanner.Controls.MyButton();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.trackBar1 = new MissionPlanner.Controls.MyTrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.panelBASE = new System.Windows.Forms.Panel();
            this.panelWaypoints = new BSE.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAction = new BSE.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.lnk_kml = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_wpfile = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.LinkLabel();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.CHK_verifyheight = new System.Windows.Forms.CheckBox();
            this.BUT_Add = new MissionPlanner.Controls.MyButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.currentStateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelMap.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.DrawPanel.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.measurePanel.SuspendLayout();
            this.ToolsTable.SuspendLayout();
            this.FormatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.PlaceAfterPanel.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SpeedPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WPTh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPSp)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WPNumber)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LongSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatDeg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelBASE.SuspendLayout();
            this.panelWaypoints.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.zoom_out);
            this.panelMap.Controls.Add(this.zoom_in);
            this.panelMap.Controls.Add(this.tableLayoutPanel6);
            this.panelMap.Controls.Add(this.FollowMePanel);
            this.panelMap.Controls.Add(this.DrawPanel);
            this.panelMap.Controls.Add(this.measurePanel);
            this.panelMap.Controls.Add(this.ToolsTable);
            this.panelMap.Controls.Add(this.Joystick_Panel);
            this.panelMap.Controls.Add(this.FormatPanel);
            this.panelMap.Controls.Add(this.PlaceAfterPanel);
            this.panelMap.Controls.Add(this.SpeedPanel);
            this.panelMap.Controls.Add(this.panel9);
            this.panelMap.Controls.Add(this.newhome);
            this.panelMap.Controls.Add(this.Commands);
            this.panelMap.Controls.Add(this.SwarmPanel);
            this.panelMap.Controls.Add(this.Joystickbutton);
            this.panelMap.Controls.Add(this.myButton5);
            this.panelMap.Controls.Add(this.panel8);
            this.panelMap.Controls.Add(this.panel7);
            this.panelMap.Controls.Add(this.panel6);
            this.panelMap.Controls.Add(this.Joysticknutton);
            this.panelMap.Controls.Add(this.tableLayoutPanel1);
            this.panelMap.Controls.Add(this.button1);
            this.panelMap.Controls.Add(this.HOMECLICK);
            this.panelMap.Controls.Add(this.mytest);
            this.panelMap.Controls.Add(this.lbl_distance);
            this.panelMap.Controls.Add(this.lbl_homedist);
            this.panelMap.Controls.Add(this.lbl_prevdist);
            this.panelMap.Controls.Add(this.trackBar1);
            this.panelMap.Controls.Add(this.label11);
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            this.panelMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMap_Paint);
            this.panelMap.Resize += new System.EventHandler(this.panelMap_Resize);
            // 
            // zoom_out
            // 
            resources.ApplyResources(this.zoom_out, "zoom_out");
            this.zoom_out.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.zoom_out.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.zoom_out.Name = "zoom_out";
            this.zoom_out.Outline = System.Drawing.Color.Transparent;
            this.zoom_out.TextColor = System.Drawing.Color.White;
            this.zoom_out.UseVisualStyleBackColor = true;
            this.zoom_out.Click += new System.EventHandler(this.zoom_out_Click);
            // 
            // zoom_in
            // 
            resources.ApplyResources(this.zoom_in, "zoom_in");
            this.zoom_in.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.zoom_in.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.zoom_in.Name = "zoom_in";
            this.zoom_in.Outline = System.Drawing.Color.Transparent;
            this.zoom_in.TextColor = System.Drawing.Color.White;
            this.zoom_in.UseVisualStyleBackColor = true;
            this.zoom_in.Click += new System.EventHandler(this.zoom_in_Click);
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanel6.Controls.Add(this.myButton22, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.myButton21, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.myButton18, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Cancel, 3, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel6_Paint);
            // 
            // myButton22
            // 
            resources.ApplyResources(this.myButton22, "myButton22");
            this.myButton22.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton22.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton22.Name = "myButton22";
            this.myButton22.Outline = System.Drawing.Color.Black;
            this.myButton22.TextColor = System.Drawing.Color.White;
            this.myButton22.UseVisualStyleBackColor = true;
            this.myButton22.Click += new System.EventHandler(this.myButton22_Click);
            // 
            // myButton21
            // 
            resources.ApplyResources(this.myButton21, "myButton21");
            this.myButton21.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton21.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton21.Name = "myButton21";
            this.myButton21.Outline = System.Drawing.Color.Black;
            this.myButton21.TextColor = System.Drawing.Color.White;
            this.myButton21.UseVisualStyleBackColor = true;
            this.myButton21.Click += new System.EventHandler(this.myButton21_Click);
            // 
            // myButton18
            // 
            resources.ApplyResources(this.myButton18, "myButton18");
            this.myButton18.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton18.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton18.Name = "myButton18";
            this.myButton18.Outline = System.Drawing.Color.Black;
            this.myButton18.TextColor = System.Drawing.Color.White;
            this.myButton18.UseVisualStyleBackColor = true;
            this.myButton18.Click += new System.EventHandler(this.myButton18_Click);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.tableLayoutPanel6.SetColumnSpan(this.label19, 4);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Name = "label19";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Cancel.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Cancel.Name = "Cancel";
            this.Cancel.Outline = System.Drawing.Color.Black;
            this.Cancel.TextColor = System.Drawing.Color.White;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.myButton20_Click);
            // 
            // FollowMePanel
            // 
            resources.ApplyResources(this.FollowMePanel, "FollowMePanel");
            this.FollowMePanel.Name = "FollowMePanel";
            // 
            // DrawPanel
            // 
            resources.ApplyResources(this.DrawPanel, "DrawPanel");
            this.DrawPanel.Controls.Add(this.tableLayoutPanel8);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.SavePolysBTN, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.ImportPolysBTN, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.NewDrawPoly, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.ApplyPoly, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.DeletePoly, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.label23, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.PolyNameBox, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.ColorBTN, 1, 2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel8_Paint);
            // 
            // SavePolysBTN
            // 
            resources.ApplyResources(this.SavePolysBTN, "SavePolysBTN");
            this.SavePolysBTN.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SavePolysBTN.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SavePolysBTN.Name = "SavePolysBTN";
            this.SavePolysBTN.Outline = System.Drawing.Color.Black;
            this.SavePolysBTN.TabStop = false;
            this.SavePolysBTN.TextColor = System.Drawing.Color.White;
            this.SavePolysBTN.UseVisualStyleBackColor = true;
            this.SavePolysBTN.Click += new System.EventHandler(this.SavePolysBTN_Click);
            // 
            // ImportPolysBTN
            // 
            resources.ApplyResources(this.ImportPolysBTN, "ImportPolysBTN");
            this.ImportPolysBTN.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ImportPolysBTN.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImportPolysBTN.Name = "ImportPolysBTN";
            this.ImportPolysBTN.Outline = System.Drawing.Color.Black;
            this.ImportPolysBTN.TabStop = false;
            this.ImportPolysBTN.TextColor = System.Drawing.Color.White;
            this.ImportPolysBTN.UseVisualStyleBackColor = true;
            this.ImportPolysBTN.Click += new System.EventHandler(this.ImportPolysBTN_Click);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // NewDrawPoly
            // 
            resources.ApplyResources(this.NewDrawPoly, "NewDrawPoly");
            this.NewDrawPoly.BGGradBot = System.Drawing.Color.DarkGray;
            this.NewDrawPoly.BGGradTop = System.Drawing.Color.DimGray;
            this.tableLayoutPanel8.SetColumnSpan(this.NewDrawPoly, 2);
            this.NewDrawPoly.Name = "NewDrawPoly";
            this.NewDrawPoly.Outline = System.Drawing.Color.Black;
            this.NewDrawPoly.TabStop = false;
            this.NewDrawPoly.TextColor = System.Drawing.Color.Black;
            this.NewDrawPoly.UseVisualStyleBackColor = true;
            this.NewDrawPoly.Click += new System.EventHandler(this.NewDrawPoly_Click);
            // 
            // ApplyPoly
            // 
            resources.ApplyResources(this.ApplyPoly, "ApplyPoly");
            this.ApplyPoly.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ApplyPoly.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ApplyPoly.Name = "ApplyPoly";
            this.ApplyPoly.Outline = System.Drawing.Color.Black;
            this.ApplyPoly.TabStop = false;
            this.ApplyPoly.TextColor = System.Drawing.Color.White;
            this.ApplyPoly.UseVisualStyleBackColor = true;
            this.ApplyPoly.Click += new System.EventHandler(this.ApplyPoly_Click);
            // 
            // DeletePoly
            // 
            resources.ApplyResources(this.DeletePoly, "DeletePoly");
            this.DeletePoly.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DeletePoly.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeletePoly.Name = "DeletePoly";
            this.DeletePoly.Outline = System.Drawing.Color.Black;
            this.DeletePoly.TabStop = false;
            this.DeletePoly.TextColor = System.Drawing.Color.White;
            this.DeletePoly.UseVisualStyleBackColor = true;
            this.DeletePoly.Click += new System.EventHandler(this.DeletePoly_Click);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // PolyNameBox
            // 
            resources.ApplyResources(this.PolyNameBox, "PolyNameBox");
            this.PolyNameBox.Name = "PolyNameBox";
            // 
            // ColorBTN
            // 
            this.ColorBTN.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.ColorBTN, "ColorBTN");
            this.ColorBTN.Name = "ColorBTN";
            this.ColorBTN.UseVisualStyleBackColor = false;
            this.ColorBTN.Click += new System.EventHandler(this.ColorBTN_Click);
            // 
            // measurePanel
            // 
            resources.ApplyResources(this.measurePanel, "measurePanel");
            this.measurePanel.Controls.Add(this.UnitsMeasureBTN);
            this.measurePanel.Controls.Add(this.measureLabel);
            this.measurePanel.Name = "measurePanel";
            // 
            // UnitsMeasureBTN
            // 
            resources.ApplyResources(this.UnitsMeasureBTN, "UnitsMeasureBTN");
            this.UnitsMeasureBTN.BGGradBot = System.Drawing.Color.DarkGray;
            this.UnitsMeasureBTN.BGGradTop = System.Drawing.Color.DimGray;
            this.UnitsMeasureBTN.Name = "UnitsMeasureBTN";
            this.UnitsMeasureBTN.Outline = System.Drawing.Color.Black;
            this.UnitsMeasureBTN.TabStop = false;
            this.UnitsMeasureBTN.TextColor = System.Drawing.Color.Black;
            this.UnitsMeasureBTN.UseVisualStyleBackColor = true;
            this.UnitsMeasureBTN.Click += new System.EventHandler(this.UnitsMeasureBTN_Click);
            // 
            // measureLabel
            // 
            resources.ApplyResources(this.measureLabel, "measureLabel");
            this.measureLabel.BackColor = System.Drawing.Color.White;
            this.measureLabel.ForeColor = System.Drawing.Color.Black;
            this.measureLabel.Name = "measureLabel";
            // 
            // ToolsTable
            // 
            resources.ApplyResources(this.ToolsTable, "ToolsTable");
            this.ToolsTable.Controls.Add(this.DrawBTN, 0, 1);
            this.ToolsTable.Controls.Add(this.MeasureBTN, 0, 0);
            this.ToolsTable.Name = "ToolsTable";
            this.ToolsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolsTable_Paint);
            // 
            // DrawBTN
            // 
            resources.ApplyResources(this.DrawBTN, "DrawBTN");
            this.DrawBTN.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DrawBTN.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DrawBTN.Name = "DrawBTN";
            this.DrawBTN.Outline = System.Drawing.Color.Black;
            this.DrawBTN.TextColor = System.Drawing.Color.White;
            this.DrawBTN.UseVisualStyleBackColor = true;
            this.DrawBTN.Click += new System.EventHandler(this.DrawBTN_Click);
            // 
            // MeasureBTN
            // 
            resources.ApplyResources(this.MeasureBTN, "MeasureBTN");
            this.MeasureBTN.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MeasureBTN.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MeasureBTN.Name = "MeasureBTN";
            this.MeasureBTN.Outline = System.Drawing.Color.Black;
            this.MeasureBTN.TextColor = System.Drawing.Color.White;
            this.MeasureBTN.UseVisualStyleBackColor = true;
            this.MeasureBTN.Click += new System.EventHandler(this.MeasureBTN_Click);
            // 
            // Joystick_Panel
            // 
            resources.ApplyResources(this.Joystick_Panel, "Joystick_Panel");
            this.Joystick_Panel.Name = "Joystick_Panel";
            this.Joystick_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Joystick_Panel_Paint);
            // 
            // FormatPanel
            // 
            resources.ApplyResources(this.FormatPanel, "FormatPanel");
            this.FormatPanel.Controls.Add(this.myButton17);
            this.FormatPanel.Controls.Add(this.myButton16);
            this.FormatPanel.Controls.Add(this.myButton15);
            this.FormatPanel.Controls.Add(this.numericUpDown2);
            this.FormatPanel.Controls.Add(this.label18);
            this.FormatPanel.Name = "FormatPanel";
            // 
            // myButton17
            // 
            resources.ApplyResources(this.myButton17, "myButton17");
            this.myButton17.BGGradBot = System.Drawing.Color.DarkGray;
            this.myButton17.BGGradTop = System.Drawing.Color.DimGray;
            this.myButton17.Name = "myButton17";
            this.myButton17.Outline = System.Drawing.Color.Black;
            this.myButton17.TabStop = false;
            this.myButton17.TextColor = System.Drawing.Color.Black;
            this.myButton17.UseVisualStyleBackColor = true;
            this.myButton17.Click += new System.EventHandler(this.myButton17_Click);
            // 
            // myButton16
            // 
            resources.ApplyResources(this.myButton16, "myButton16");
            this.myButton16.BGGradBot = System.Drawing.Color.DarkGray;
            this.myButton16.BGGradTop = System.Drawing.Color.DimGray;
            this.myButton16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton16.Name = "myButton16";
            this.myButton16.Outline = System.Drawing.Color.Black;
            this.myButton16.TabStop = false;
            this.myButton16.TextColor = System.Drawing.Color.Black;
            this.myButton16.UseVisualStyleBackColor = true;
            this.myButton16.Click += new System.EventHandler(this.myButton16_Click);
            // 
            // myButton15
            // 
            resources.ApplyResources(this.myButton15, "myButton15");
            this.myButton15.BGGradBot = System.Drawing.Color.DarkGray;
            this.myButton15.BGGradTop = System.Drawing.Color.DimGray;
            this.myButton15.Name = "myButton15";
            this.myButton15.Outline = System.Drawing.Color.Black;
            this.myButton15.TabStop = false;
            this.myButton15.TextColor = System.Drawing.Color.Black;
            this.myButton15.UseVisualStyleBackColor = true;
            this.myButton15.Click += new System.EventHandler(this.myButton15_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // PlaceAfterPanel
            // 
            resources.ApplyResources(this.PlaceAfterPanel, "PlaceAfterPanel");
            this.PlaceAfterPanel.Controls.Add(this.tableLayoutPanel7);
            this.PlaceAfterPanel.Controls.Add(this.numericUpDown1);
            this.PlaceAfterPanel.Controls.Add(this.label20);
            this.PlaceAfterPanel.Controls.Add(this.label21);
            this.PlaceAfterPanel.Controls.Add(this.numericUpDown3);
            this.PlaceAfterPanel.Name = "PlaceAfterPanel";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.myButton19, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.myButton20, 1, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // myButton19
            // 
            resources.ApplyResources(this.myButton19, "myButton19");
            this.myButton19.BGGradBot = System.Drawing.Color.DarkGray;
            this.myButton19.BGGradTop = System.Drawing.Color.DimGray;
            this.myButton19.Name = "myButton19";
            this.myButton19.Outline = System.Drawing.Color.Black;
            this.myButton19.TabStop = false;
            this.myButton19.TextColor = System.Drawing.Color.Black;
            this.myButton19.UseVisualStyleBackColor = true;
            this.myButton19.Click += new System.EventHandler(this.myButton6_Click);
            // 
            // myButton20
            // 
            resources.ApplyResources(this.myButton20, "myButton20");
            this.myButton20.BGGradBot = System.Drawing.Color.DarkGray;
            this.myButton20.BGGradTop = System.Drawing.Color.DimGray;
            this.myButton20.Name = "myButton20";
            this.myButton20.Outline = System.Drawing.Color.Black;
            this.myButton20.TabStop = false;
            this.myButton20.TextColor = System.Drawing.Color.Black;
            this.myButton20.UseVisualStyleBackColor = true;
            this.myButton20.Click += new System.EventHandler(this.myButton7_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.Gray;
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDown3, "numericUpDown3");
            this.numericUpDown3.ForeColor = System.Drawing.Color.White;
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // SpeedPanel
            // 
            resources.ApplyResources(this.SpeedPanel, "SpeedPanel");
            this.SpeedPanel.Controls.Add(this.tableLayoutPanel3);
            this.SpeedPanel.Controls.Add(this.WPTh);
            this.SpeedPanel.Controls.Add(this.label16);
            this.SpeedPanel.Controls.Add(this.label14);
            this.SpeedPanel.Controls.Add(this.WPSp);
            this.SpeedPanel.Name = "SpeedPanel";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.myButton6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.myButton7, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // myButton6
            // 
            resources.ApplyResources(this.myButton6, "myButton6");
            this.myButton6.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton6.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton6.Name = "myButton6";
            this.myButton6.Outline = System.Drawing.Color.Black;
            this.myButton6.TabStop = false;
            this.myButton6.TextColor = System.Drawing.Color.White;
            this.myButton6.UseVisualStyleBackColor = true;
            this.myButton6.Click += new System.EventHandler(this.SetSpeedBTN);
            // 
            // myButton7
            // 
            resources.ApplyResources(this.myButton7, "myButton7");
            this.myButton7.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton7.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton7.Name = "myButton7";
            this.myButton7.Outline = System.Drawing.Color.Black;
            this.myButton7.TabStop = false;
            this.myButton7.TextColor = System.Drawing.Color.White;
            this.myButton7.UseVisualStyleBackColor = true;
            this.myButton7.Click += new System.EventHandler(this.BackSpeed_Click);
            // 
            // WPTh
            // 
            this.WPTh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.WPTh, "WPTh");
            this.WPTh.ForeColor = System.Drawing.Color.Black;
            this.WPTh.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.WPTh.Name = "WPTh";
            this.WPTh.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // WPSp
            // 
            this.WPSp.BackColor = System.Drawing.Color.Gray;
            this.WPSp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WPSp.DecimalPlaces = 1;
            resources.ApplyResources(this.WPSp, "WPSp");
            this.WPSp.ForeColor = System.Drawing.Color.White;
            this.WPSp.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.WPSp.Name = "WPSp";
            this.WPSp.ValueChanged += new System.EventHandler(this.WPSpeed_ValueChanged);
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Controls.Add(this.myButton11);
            this.panel9.Controls.Add(this.myButton10);
            this.panel9.Controls.Add(this.myButton9);
            this.panel9.Controls.Add(this.myButton8);
            this.panel9.Name = "panel9";
            // 
            // myButton11
            // 
            resources.ApplyResources(this.myButton11, "myButton11");
            this.myButton11.BGGradBot = System.Drawing.Color.Gainsboro;
            this.myButton11.BGGradTop = System.Drawing.Color.Gainsboro;
            this.myButton11.Name = "myButton11";
            this.myButton11.Outline = System.Drawing.Color.Black;
            this.myButton11.TextColor = System.Drawing.Color.Black;
            this.myButton11.UseVisualStyleBackColor = true;
            this.myButton11.Click += new System.EventHandler(this.myButton11_Click);
            // 
            // myButton10
            // 
            resources.ApplyResources(this.myButton10, "myButton10");
            this.myButton10.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton10.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton10.Name = "myButton10";
            this.myButton10.Outline = System.Drawing.Color.Black;
            this.myButton10.TextColor = System.Drawing.Color.White;
            this.myButton10.UseVisualStyleBackColor = true;
            this.myButton10.Click += new System.EventHandler(this.myButton10_Click);
            // 
            // myButton9
            // 
            resources.ApplyResources(this.myButton9, "myButton9");
            this.myButton9.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton9.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton9.Name = "myButton9";
            this.myButton9.Outline = System.Drawing.Color.Black;
            this.myButton9.TextColor = System.Drawing.Color.White;
            this.myButton9.UseVisualStyleBackColor = true;
            this.myButton9.Click += new System.EventHandler(this.myButton9_Click);
            // 
            // myButton8
            // 
            resources.ApplyResources(this.myButton8, "myButton8");
            this.myButton8.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton8.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton8.Name = "myButton8";
            this.myButton8.Outline = System.Drawing.Color.Black;
            this.myButton8.TextColor = System.Drawing.Color.White;
            this.myButton8.UseVisualStyleBackColor = true;
            this.myButton8.Click += new System.EventHandler(this.myButton8_Click);
            // 
            // newhome
            // 
            resources.ApplyResources(this.newhome, "newhome");
            this.newhome.BGGradBot = System.Drawing.Color.DarkGray;
            this.newhome.BGGradTop = System.Drawing.Color.DimGray;
            this.newhome.Name = "newhome";
            this.newhome.Outline = System.Drawing.Color.Black;
            this.newhome.TextColor = System.Drawing.Color.Black;
            this.newhome.UseVisualStyleBackColor = true;
            this.newhome.Click += new System.EventHandler(this.newhome_Click);
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            resources.ApplyResources(this.Commands, "Commands");
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Dist,
            this.AZ});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Commands.DefaultCellStyle = dataGridViewCellStyle7;
            this.Commands.Name = "Commands";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            this.Commands.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellEndEdit);
            this.Commands.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Commands_DataError);
            this.Commands.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Commands_DefaultValuesNeeded);
            this.Commands.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Commands_EditingControlShowing);
            this.Commands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_RowEnter);
            this.Commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Commands_RowsAdded);
            this.Commands.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Commands_RowValidating);
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle4;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.Command, "Command");
            this.Command.Name = "Command";
            // 
            // Param1
            // 
            this.Param1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param1, "Param1");
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            this.Param2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param2, "Param2");
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            this.Param3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param3, "Param3");
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            this.Param4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param4, "Param4");
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            this.Lat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Lat, "Lat");
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            this.Lon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Lon, "Lon");
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            this.Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Alt, "Alt");
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Up.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.Up, "Up");
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.Name = "Up";
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Down.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.Name = "Down";
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            this.Dist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Dist, "Dist");
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            this.AZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.AZ, "AZ");
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SwarmPanel
            // 
            resources.ApplyResources(this.SwarmPanel, "SwarmPanel");
            this.SwarmPanel.Name = "SwarmPanel";
            this.SwarmPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SwarmPanel_Paint);
            // 
            // Joystickbutton
            // 
            resources.ApplyResources(this.Joystickbutton, "Joystickbutton");
            this.Joystickbutton.BGGradBot = System.Drawing.Color.DarkGray;
            this.Joystickbutton.BGGradTop = System.Drawing.Color.DimGray;
            this.Joystickbutton.Name = "Joystickbutton";
            this.Joystickbutton.Outline = System.Drawing.Color.Black;
            this.Joystickbutton.TabStop = false;
            this.Joystickbutton.TextColor = System.Drawing.Color.Black;
            this.Joystickbutton.UseVisualStyleBackColor = true;
            this.Joystickbutton.Click += new System.EventHandler(this.Joystickbutton_Click);
            // 
            // myButton5
            // 
            resources.ApplyResources(this.myButton5, "myButton5");
            this.myButton5.BGGradBot = System.Drawing.Color.DarkGray;
            this.myButton5.BGGradTop = System.Drawing.Color.DimGray;
            this.myButton5.Name = "myButton5";
            this.myButton5.Outline = System.Drawing.Color.Black;
            this.myButton5.TabStop = false;
            this.myButton5.TextColor = System.Drawing.Color.Black;
            this.myButton5.UseVisualStyleBackColor = true;
            this.myButton5.Click += new System.EventHandler(this.myButton5_Click);
            // 
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Controls.Add(this.myButton3);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.TXT_WPRad);
            this.panel8.Name = "panel8";
            // 
            // myButton3
            // 
            resources.ApplyResources(this.myButton3, "myButton3");
            this.myButton3.BGGradBot = System.Drawing.Color.DarkGray;
            this.myButton3.BGGradTop = System.Drawing.Color.DimGray;
            this.myButton3.Name = "myButton3";
            this.myButton3.Outline = System.Drawing.Color.Black;
            this.myButton3.TabStop = false;
            this.myButton3.TextColor = System.Drawing.Color.Black;
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // TXT_WPRad
            // 
            resources.ApplyResources(this.TXT_WPRad, "TXT_WPRad");
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.TXT_WPRad.TextChanged += new System.EventHandler(this.TXT_WPRad_TextChanged);
            this.TXT_WPRad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_WPRad_KeyPress);
            this.TXT_WPRad.Leave += new System.EventHandler(this.TXT_WPRad_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Controls.Add(this.tableLayoutPanel4);
            this.panel6.Controls.Add(this.tableLayoutPanel5);
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Controls.Add(this.EW);
            this.panel6.Controls.Add(this.NS);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.LongSec);
            this.panel6.Controls.Add(this.LongMin);
            this.panel6.Controls.Add(this.LongDeg);
            this.panel6.Controls.Add(this.LatSec);
            this.panel6.Controls.Add(this.LatMin);
            this.panel6.Controls.Add(this.LatDeg);
            this.panel6.Name = "panel6";
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.myButton13, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Deletebu, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.myButton14, 2, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // myButton13
            // 
            resources.ApplyResources(this.myButton13, "myButton13");
            this.myButton13.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton13.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton13.Name = "myButton13";
            this.myButton13.Outline = System.Drawing.Color.Black;
            this.myButton13.TabStop = false;
            this.myButton13.TextColor = System.Drawing.Color.White;
            this.myButton13.UseVisualStyleBackColor = true;
            this.myButton13.Click += new System.EventHandler(this.myButton13_Click);
            // 
            // Deletebu
            // 
            resources.ApplyResources(this.Deletebu, "Deletebu");
            this.Deletebu.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Deletebu.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Deletebu.Name = "Deletebu";
            this.Deletebu.Outline = System.Drawing.Color.Black;
            this.Deletebu.TabStop = false;
            this.Deletebu.TextColor = System.Drawing.Color.White;
            this.Deletebu.UseVisualStyleBackColor = true;
            this.Deletebu.Click += new System.EventHandler(this.Deletebu_Click);
            // 
            // myButton14
            // 
            resources.ApplyResources(this.myButton14, "myButton14");
            this.myButton14.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton14.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton14.Name = "myButton14";
            this.myButton14.Outline = System.Drawing.Color.Black;
            this.myButton14.TabStop = false;
            this.myButton14.TextColor = System.Drawing.Color.White;
            this.myButton14.UseVisualStyleBackColor = true;
            this.myButton14.Click += new System.EventHandler(this.myButton14_Click);
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.BackWP, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.WPNumber, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.NextWP, 2, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // BackWP
            // 
            this.BackWP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.BackWP, "BackWP");
            this.BackWP.Name = "BackWP";
            this.BackWP.UseVisualStyleBackColor = false;
            this.BackWP.Click += new System.EventHandler(this.BackWP_Click);
            // 
            // WPNumber
            // 
            this.WPNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.WPNumber, "WPNumber");
            this.WPNumber.ForeColor = System.Drawing.Color.Black;
            this.WPNumber.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.WPNumber.Name = "WPNumber";
            this.WPNumber.ValueChanged += new System.EventHandler(this.WPNumber_ValueChanged);
            // 
            // NextWP
            // 
            this.NextWP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.NextWP, "NextWP");
            this.NextWP.Name = "NextWP";
            this.NextWP.UseVisualStyleBackColor = false;
            this.NextWP.Click += new System.EventHandler(this.NextWP_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.myButton4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.myButton2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.myButton12, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // myButton4
            // 
            resources.ApplyResources(this.myButton4, "myButton4");
            this.myButton4.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton4.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton4.Name = "myButton4";
            this.myButton4.Outline = System.Drawing.Color.Black;
            this.myButton4.TabStop = false;
            this.myButton4.TextColor = System.Drawing.Color.White;
            this.myButton4.UseVisualStyleBackColor = true;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // myButton2
            // 
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton2.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton2.Name = "myButton2";
            this.myButton2.Outline = System.Drawing.Color.Black;
            this.myButton2.TabStop = false;
            this.myButton2.TextColor = System.Drawing.Color.White;
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click_1);
            // 
            // myButton12
            // 
            resources.ApplyResources(this.myButton12, "myButton12");
            this.myButton12.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.myButton12.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.myButton12.Name = "myButton12";
            this.myButton12.Outline = System.Drawing.Color.Black;
            this.myButton12.TabStop = false;
            this.myButton12.TextColor = System.Drawing.Color.White;
            this.myButton12.UseVisualStyleBackColor = true;
            this.myButton12.Click += new System.EventHandler(this.myButton12_Click_1);
            // 
            // EW
            // 
            this.EW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.EW, "EW");
            this.EW.Name = "EW";
            this.EW.UseVisualStyleBackColor = false;
            this.EW.Click += new System.EventHandler(this.EW_Click);
            // 
            // NS
            // 
            this.NS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.NS, "NS");
            this.NS.Name = "NS";
            this.NS.UseVisualStyleBackColor = false;
            this.NS.Click += new System.EventHandler(this.NS_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LongSec
            // 
            this.LongSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LongSec.DecimalPlaces = 2;
            resources.ApplyResources(this.LongSec, "LongSec");
            this.LongSec.ForeColor = System.Drawing.Color.Black;
            this.LongSec.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.LongSec.Name = "LongSec";
            this.LongSec.ValueChanged += new System.EventHandler(this.LongSec_ValueChanged);
            // 
            // LongMin
            // 
            this.LongMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LongMin.DecimalPlaces = 3;
            resources.ApplyResources(this.LongMin, "LongMin");
            this.LongMin.ForeColor = System.Drawing.Color.Black;
            this.LongMin.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.LongMin.Name = "LongMin";
            this.LongMin.ValueChanged += new System.EventHandler(this.LongMin_ValueChanged);
            // 
            // LongDeg
            // 
            this.LongDeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LongDeg.DecimalPlaces = 5;
            resources.ApplyResources(this.LongDeg, "LongDeg");
            this.LongDeg.ForeColor = System.Drawing.Color.Black;
            this.LongDeg.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.LongDeg.Name = "LongDeg";
            this.LongDeg.ValueChanged += new System.EventHandler(this.LongDeg_ValueChanged);
            // 
            // LatSec
            // 
            this.LatSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LatSec.DecimalPlaces = 2;
            resources.ApplyResources(this.LatSec, "LatSec");
            this.LatSec.ForeColor = System.Drawing.Color.Black;
            this.LatSec.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.LatSec.Name = "LatSec";
            this.LatSec.ValueChanged += new System.EventHandler(this.LatSec_ValueChanged);
            // 
            // LatMin
            // 
            this.LatMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LatMin.DecimalPlaces = 3;
            resources.ApplyResources(this.LatMin, "LatMin");
            this.LatMin.ForeColor = System.Drawing.Color.Black;
            this.LatMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.LatMin.Name = "LatMin";
            this.LatMin.ValueChanged += new System.EventHandler(this.LatMin_ValueChanged);
            // 
            // LatDeg
            // 
            this.LatDeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LatDeg.DecimalPlaces = 5;
            resources.ApplyResources(this.LatDeg, "LatDeg");
            this.LatDeg.ForeColor = System.Drawing.Color.Black;
            this.LatDeg.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.LatDeg.Name = "LatDeg";
            this.LatDeg.ValueChanged += new System.EventHandler(this.LatDeg_ValueChanged);
            // 
            // Joysticknutton
            // 
            this.Joysticknutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Joysticknutton.Bearing = 0F;
            this.Joysticknutton.CanDragMap = true;
            this.Joysticknutton.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Joysticknutton, "Joysticknutton");
            this.Joysticknutton.EmptyTileColor = System.Drawing.Color.Gray;
            this.Joysticknutton.GrayScaleMode = false;
            this.Joysticknutton.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Joysticknutton.LevelsKeepInMemmory = 5;
            this.Joysticknutton.MarkersEnabled = true;
            this.Joysticknutton.MaxZoom = 19;
            this.Joysticknutton.MinZoom = 0;
            this.Joysticknutton.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Joysticknutton.Name = "Joysticknutton";
            this.Joysticknutton.NegativeMode = false;
            this.Joysticknutton.PolygonsEnabled = true;
            this.Joysticknutton.RetryLoadTile = 0;
            this.Joysticknutton.RoutesEnabled = false;
            this.Joysticknutton.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.Joysticknutton.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Joysticknutton.ShowTileGridLines = false;
            this.Joysticknutton.Zoom = 0D;
            this.Joysticknutton.Load += new System.EventHandler(this.MainMap_Load);
            this.Joysticknutton.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMap_Paint);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.Controls.Add(this.ToolsBTN, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditButton, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.Reversewpbutton, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUT_loadwpfile, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUT_read, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUT_write, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.HOLDQUICK, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUT_saveWPFile, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClearClick, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.AUTOQUICK, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.switchview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButton1, 5, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ToolsBTN
            // 
            resources.ApplyResources(this.ToolsBTN, "ToolsBTN");
            this.ToolsBTN.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ToolsBTN.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolsBTN.Name = "ToolsBTN";
            this.ToolsBTN.Outline = System.Drawing.Color.Black;
            this.ToolsBTN.TextColor = System.Drawing.Color.White;
            this.ToolsBTN.UseVisualStyleBackColor = true;
            this.ToolsBTN.Click += new System.EventHandler(this.ToolsBTN_Click);
            // 
            // EditButton
            // 
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EditButton.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EditButton.Name = "EditButton";
            this.EditButton.Outline = System.Drawing.Color.Black;
            this.EditButton.TabStop = false;
            this.EditButton.TextColor = System.Drawing.Color.White;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // Reversewpbutton
            // 
            resources.ApplyResources(this.Reversewpbutton, "Reversewpbutton");
            this.Reversewpbutton.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Reversewpbutton.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Reversewpbutton.Name = "Reversewpbutton";
            this.Reversewpbutton.Outline = System.Drawing.Color.Black;
            this.Reversewpbutton.TextColor = System.Drawing.Color.White;
            this.Reversewpbutton.UseVisualStyleBackColor = true;
            this.Reversewpbutton.Click += new System.EventHandler(this.Reversewpbutton_Click);
            // 
            // BUT_loadwpfile
            // 
            resources.ApplyResources(this.BUT_loadwpfile, "BUT_loadwpfile");
            this.BUT_loadwpfile.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BUT_loadwpfile.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.BUT_loadwpfile.Outline = System.Drawing.Color.Black;
            this.BUT_loadwpfile.TextColor = System.Drawing.Color.White;
            this.BUT_loadwpfile.UseVisualStyleBackColor = true;
            this.BUT_loadwpfile.Click += new System.EventHandler(this.BUT_loadwpfile_Click);
            // 
            // BUT_read
            // 
            resources.ApplyResources(this.BUT_read, "BUT_read");
            this.BUT_read.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BUT_read.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BUT_read.Name = "BUT_read";
            this.BUT_read.Outline = System.Drawing.Color.Black;
            this.BUT_read.TextColor = System.Drawing.Color.White;
            this.BUT_read.UseVisualStyleBackColor = true;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // BUT_write
            // 
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BUT_write.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BUT_write.Name = "BUT_write";
            this.BUT_write.Outline = System.Drawing.Color.Black;
            this.BUT_write.TextColor = System.Drawing.Color.White;
            this.BUT_write.UseVisualStyleBackColor = true;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // HOLDQUICK
            // 
            resources.ApplyResources(this.HOLDQUICK, "HOLDQUICK");
            this.HOLDQUICK.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.HOLDQUICK.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HOLDQUICK.Name = "HOLDQUICK";
            this.HOLDQUICK.Outline = System.Drawing.Color.Black;
            this.HOLDQUICK.TextColor = System.Drawing.Color.White;
            this.HOLDQUICK.UseVisualStyleBackColor = true;
            this.HOLDQUICK.Click += new System.EventHandler(this.HOLDQUICK_Click);
            // 
            // BUT_saveWPFile
            // 
            resources.ApplyResources(this.BUT_saveWPFile, "BUT_saveWPFile");
            this.BUT_saveWPFile.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BUT_saveWPFile.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.BUT_saveWPFile.Outline = System.Drawing.Color.Black;
            this.BUT_saveWPFile.TextColor = System.Drawing.Color.White;
            this.BUT_saveWPFile.UseVisualStyleBackColor = true;
            this.BUT_saveWPFile.Click += new System.EventHandler(this.BUT_saveWPFile_Click);
            // 
            // ClearClick
            // 
            this.ClearClick.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClearClick.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.ClearClick, "ClearClick");
            this.ClearClick.Name = "ClearClick";
            this.ClearClick.Outline = System.Drawing.Color.Black;
            this.ClearClick.TabStop = false;
            this.ClearClick.TextColor = System.Drawing.Color.White;
            this.ClearClick.UseVisualStyleBackColor = true;
            this.ClearClick.Click += new System.EventHandler(this.ClearClick_Click);
            // 
            // AUTOQUICK
            // 
            resources.ApplyResources(this.AUTOQUICK, "AUTOQUICK");
            this.AUTOQUICK.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AUTOQUICK.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AUTOQUICK.Name = "AUTOQUICK";
            this.AUTOQUICK.Outline = System.Drawing.Color.Black;
            this.AUTOQUICK.TextColor = System.Drawing.Color.White;
            this.AUTOQUICK.UseVisualStyleBackColor = true;
            this.AUTOQUICK.Click += new System.EventHandler(this.AUTOQUICK_Click);
            // 
            // switchview
            // 
            resources.ApplyResources(this.switchview, "switchview");
            this.switchview.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.switchview.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.switchview.Name = "switchview";
            this.switchview.Outline = System.Drawing.Color.Black;
            this.switchview.TextColor = System.Drawing.Color.White;
            this.switchview.UseVisualStyleBackColor = true;
            this.switchview.Click += new System.EventHandler(this.switchview_Click);
            // 
            // myButton1
            // 
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.BackColor = System.Drawing.Color.Transparent;
            this.myButton1.BGGradBot = System.Drawing.Color.White;
            this.myButton1.BGGradTop = System.Drawing.Color.White;
            this.myButton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentStateBindingSource, "mode", true));
            this.myButton1.DataBindings.Add(new System.Windows.Forms.Binding("TextColor", this.currentStateBindingSource, "link_color", true));
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.ForeColor = System.Drawing.Color.SteelBlue;
            this.myButton1.Name = "myButton1";
            this.myButton1.Outline = System.Drawing.Color.White;
            this.myButton1.TabStop = false;
            this.myButton1.TextColor = System.Drawing.Color.Black;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click_1);
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HOMECLICK
            // 
            resources.ApplyResources(this.HOMECLICK, "HOMECLICK");
            this.HOMECLICK.BackColor = System.Drawing.Color.DimGray;
            this.HOMECLICK.Name = "HOMECLICK";
            this.HOMECLICK.UseVisualStyleBackColor = false;
            this.HOMECLICK.Click += new System.EventHandler(this.HOMECLICK_Click);
            // 
            // mytest
            // 
            this.mytest.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.mytest.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(156)))), ((int)(((byte)(197)))));
            resources.ApplyResources(this.mytest, "mytest");
            this.mytest.Name = "mytest";
            this.mytest.TabStop = false;
            this.mytest.UseVisualStyleBackColor = true;
            this.mytest.Click += new System.EventHandler(this.mytest_Click);
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.Name = "lbl_distance";
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(this.lbl_homedist, "lbl_homedist");
            this.lbl_homedist.Name = "lbl_homedist";
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(this.lbl_prevdist, "lbl_prevdist");
            this.lbl_prevdist.Name = "lbl_prevdist";
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.LargeChange = 0.005F;
            this.trackBar1.Maximum = 24F;
            this.trackBar1.Minimum = 1F;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 0.001F;
            this.trackBar1.TickFrequency = 1F;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // panelBASE
            // 
            this.panelBASE.Controls.Add(this.splitter2);
            this.panelBASE.Controls.Add(this.splitter1);
            this.panelBASE.Controls.Add(this.panelMap);
            this.panelBASE.Controls.Add(this.panelWaypoints);
            this.panelBASE.Controls.Add(this.label6);
            resources.ApplyResources(this.panelBASE, "panelBASE");
            this.panelBASE.Name = "panelBASE";
            // 
            // panelWaypoints
            // 
            this.panelWaypoints.AssociatedSplitter = this.splitter1;
            this.panelWaypoints.BackColor = System.Drawing.Color.Transparent;
            this.panelWaypoints.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelWaypoints.CaptionHeight = 21;
            this.panelWaypoints.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.panelWaypoints.Controls.Add(this.panel1);
            this.panelWaypoints.Controls.Add(this.panelAction);
            this.panelWaypoints.Controls.Add(this.CMB_altmode);
            this.panelWaypoints.Controls.Add(this.CHK_splinedefault);
            this.panelWaypoints.Controls.Add(this.label17);
            this.panelWaypoints.Controls.Add(this.TXT_altwarn);
            this.panelWaypoints.Controls.Add(this.LBL_WPRad);
            this.panelWaypoints.Controls.Add(this.label5);
            this.panelWaypoints.Controls.Add(this.TXT_loiterrad);
            this.panelWaypoints.Controls.Add(this.LBL_defalutalt);
            this.panelWaypoints.Controls.Add(this.TXT_DefaultAlt);
            this.panelWaypoints.Controls.Add(this.CHK_verifyheight);
            this.panelWaypoints.Controls.Add(this.BUT_Add);
            this.panelWaypoints.CustomColors.BorderColor = System.Drawing.Color.Black;
            this.panelWaypoints.CustomColors.CaptionCloseIcon = System.Drawing.Color.White;
            this.panelWaypoints.CustomColors.CaptionExpandIcon = System.Drawing.Color.White;
            this.panelWaypoints.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.panelWaypoints.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(156)))), ((int)(((byte)(197)))));
            this.panelWaypoints.CustomColors.CaptionGradientMiddle = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelWaypoints.CustomColors.CollapsedCaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelWaypoints.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelWaypoints.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelWaypoints.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWaypoints.Image = null;
            this.panelWaypoints.Name = "panelWaypoints";
            this.panelWaypoints.ShowExpandIcon = true;
            this.panelWaypoints.ToolTipTextCloseIcon = null;
            this.panelWaypoints.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelWaypoints.ToolTipTextExpandIconPanelExpanded = null;
            this.panelWaypoints.CloseClick += new System.EventHandler<System.EventArgs>(this.panelWaypoints_CloseClick);
            this.panelWaypoints.ExpandClick += new System.EventHandler<System.EventArgs>(this.panelWaypoints_ExpandClick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelAction
            // 
            this.panelAction.AssociatedSplitter = this.splitter2;
            this.panelAction.BackColor = System.Drawing.Color.Transparent;
            this.panelAction.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelAction.CaptionHeight = 21;
            this.panelAction.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.panelAction.Controls.Add(this.flowLayoutPanel1);
            this.panelAction.CustomColors.BorderColor = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionCloseIcon = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionExpandIcon = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionGradientBegin = System.Drawing.Color.Empty;
            this.panelAction.CustomColors.CaptionGradientEnd = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionGradientMiddle = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelAction.CustomColors.CollapsedCaptionText = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelAction.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelAction.CustomColors.InnerBorderColor = System.Drawing.Color.Transparent;
            this.panelAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAction.Image = null;
            resources.ApplyResources(this.panelAction, "panelAction");
            this.panelAction.Name = "panelAction";
            this.panelAction.ShowExpandIcon = true;
            this.panelAction.ToolTipTextCloseIcon = null;
            this.panelAction.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelAction.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.TXT_homelat);
            this.flowLayoutPanel1.Controls.Add(this.TXT_homelng);
            this.flowLayoutPanel1.Controls.Add(this.TXT_homealt);
            this.flowLayoutPanel1.Controls.Add(this.Label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.coords1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltUnit = "m";
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Name = "coords1";
            this.coords1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chk_grid);
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Controls.Add(this.comboBoxMapType);
            this.panel3.Controls.Add(this.lnk_kml);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // chk_grid
            // 
            resources.ApplyResources(this.chk_grid, "chk_grid");
            this.chk_grid.Name = "chk_grid";
            this.chk_grid.UseVisualStyleBackColor = true;
            this.chk_grid.CheckedChanged += new System.EventHandler(this.chk_grid_CheckedChanged);
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMapType, "comboBoxMapType");
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.toolTip1.SetToolTip(this.comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            // 
            // lnk_kml
            // 
            resources.ApplyResources(this.lnk_kml, "lnk_kml");
            this.lnk_kml.Name = "lnk_kml";
            this.lnk_kml.TabStop = true;
            this.lnk_kml.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_kml_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_wpfile);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_wpfile
            // 
            resources.ApplyResources(this.lbl_wpfile, "lbl_wpfile");
            this.lbl_wpfile.Name = "lbl_wpfile";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.TabStop = true;
            this.label4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label4_LinkClicked);
            // 
            // TXT_homelat
            // 
            resources.ApplyResources(this.TXT_homelat, "TXT_homelat");
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            this.TXT_homelat.Enter += new System.EventHandler(this.TXT_homelat_Enter);
            // 
            // TXT_homelng
            // 
            resources.ApplyResources(this.TXT_homelng, "TXT_homelng");
            this.TXT_homelng.Name = "TXT_homelng";
            this.TXT_homelng.TextChanged += new System.EventHandler(this.TXT_homelng_TextChanged);
            // 
            // TXT_homealt
            // 
            resources.ApplyResources(this.TXT_homealt, "TXT_homealt");
            this.TXT_homealt.Name = "TXT_homealt";
            this.TXT_homealt.TextChanged += new System.EventHandler(this.TXT_homealt_TextChanged);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CMB_altmode
            // 
            this.CMB_altmode.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.Name = "CMB_altmode";
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.UseVisualStyleBackColor = true;
            this.CHK_splinedefault.CheckedChanged += new System.EventHandler(this.CHK_splinedefault_CheckedChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // TXT_altwarn
            // 
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.Name = "TXT_altwarn";
            // 
            // LBL_WPRad
            // 
            resources.ApplyResources(this.LBL_WPRad, "LBL_WPRad");
            this.LBL_WPRad.Name = "LBL_WPRad";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // TXT_loiterrad
            // 
            resources.ApplyResources(this.TXT_loiterrad, "TXT_loiterrad");
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            this.TXT_loiterrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_loiterrad_KeyPress);
            this.TXT_loiterrad.Leave += new System.EventHandler(this.TXT_loiterrad_Leave);
            // 
            // LBL_defalutalt
            // 
            resources.ApplyResources(this.LBL_defalutalt, "LBL_defalutalt");
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            // 
            // TXT_DefaultAlt
            // 
            resources.ApplyResources(this.TXT_DefaultAlt, "TXT_DefaultAlt");
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            this.TXT_DefaultAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DefaultAlt_KeyPress);
            this.TXT_DefaultAlt.Leave += new System.EventHandler(this.TXT_DefaultAlt_Leave);
            // 
            // CHK_verifyheight
            // 
            resources.ApplyResources(this.CHK_verifyheight, "CHK_verifyheight");
            this.CHK_verifyheight.Name = "CHK_verifyheight";
            this.CHK_verifyheight.UseVisualStyleBackColor = true;
            // 
            // BUT_Add
            // 
            this.BUT_Add.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.BUT_Add.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(156)))), ((int)(((byte)(197)))));
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // currentStateBindingSource1
            // 
            this.currentStateBindingSource1.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // FlightPlanner
            // 
        
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.DrawPanel.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.measurePanel.ResumeLayout(false);
            this.measurePanel.PerformLayout();
            this.ToolsTable.ResumeLayout(false);
            this.ToolsTable.PerformLayout();
            this.FormatPanel.ResumeLayout(false);
            this.FormatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.PlaceAfterPanel.ResumeLayout(false);
            this.PlaceAfterPanel.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.SpeedPanel.ResumeLayout(false);
            this.SpeedPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WPTh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPSp)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WPNumber)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LongSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatDeg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();            
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelMap;
        private Controls.myGMAP Joysticknutton;
        private Controls.MyTrackBar trackBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_prevdist;
        private BSE.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelBASE;
        private System.Windows.Forms.Label lbl_homedist;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private BSE.Windows.Forms.Splitter splitter2;
        private BSE.Windows.Forms.Panel panelWaypoints;
        private BSE.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TXT_homealt;
        private System.Windows.Forms.TextBox TXT_homelng;
        private System.Windows.Forms.TextBox TXT_homelat;
        private System.Windows.Forms.Panel panel4;
        private Controls.Coords coords1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chk_grid;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox comboBoxMapType;
        private System.Windows.Forms.LinkLabel lnk_kml;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_wpfile;
        private Controls.MyButton BUT_loadwpfile;
        private Controls.MyButton BUT_saveWPFile;
        private System.Windows.Forms.Panel panel5;
        private Controls.MyButton BUT_write;
        private Controls.MyButton BUT_read;
        private System.Windows.Forms.ComboBox CMB_altmode;
        private System.Windows.Forms.CheckBox CHK_splinedefault;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXT_altwarn;
        private System.Windows.Forms.Label LBL_WPRad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_loiterrad;
        private System.Windows.Forms.Label LBL_defalutalt;
        private System.Windows.Forms.DataGridView Commands;
        private System.Windows.Forms.DataGridViewComboBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Up;
        private System.Windows.Forms.DataGridViewImageColumn Down;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AZ;
        private System.Windows.Forms.TextBox TXT_DefaultAlt;
        private System.Windows.Forms.CheckBox CHK_verifyheight;
        private System.Windows.Forms.TextBox TXT_WPRad;
        private Controls.MyButton BUT_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HOMECLICK;
        private Controls.MyButton HOLDQUICK;
        private Controls.MyButton ClearClick;
        public Controls.MyButton Deletebu;
        public Controls.MyButton mytest;
        public Controls.MyButton myButton1;
        private Controls.MyButton switchview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.MyButton newhome;
        private Controls.MyButton Reversewpbutton;
        public Controls.MyButton EditButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown LatDeg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown LongSec;
        private System.Windows.Forms.NumericUpDown LongMin;
        private System.Windows.Forms.NumericUpDown LongDeg;
        private System.Windows.Forms.NumericUpDown LatSec;
        private System.Windows.Forms.NumericUpDown LatMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public Controls.MyButton myButton2;
        private System.Windows.Forms.Button EW;
        private System.Windows.Forms.Button NS;
        private System.Windows.Forms.NumericUpDown WPNumber;
        private System.Windows.Forms.Button BackWP;
        private System.Windows.Forms.Button NextWP;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel8;
        public Controls.MyButton myButton3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel SpeedPanel;
        public Controls.MyButton myButton4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public Controls.MyButton myButton6;
        public Controls.MyButton myButton7;
        private System.Windows.Forms.NumericUpDown WPTh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown WPSp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel SwarmPanel;
        private Controls.MyButton myButton5;
        private Controls.MyButton Joystickbutton;
        private System.Windows.Forms.Panel panel9;
        private Controls.MyButton myButton11;
        private Controls.MyButton myButton10;
        private Controls.MyButton myButton9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public Controls.MyButton myButton13;
        private System.Windows.Forms.BindingSource currentStateBindingSource;
        private System.Windows.Forms.BindingSource currentStateBindingSource1;
        private System.Windows.Forms.Panel FormatPanel;
        public Controls.MyButton myButton15;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label18;
        public Controls.MyButton myButton17;
        public Controls.MyButton myButton16;
        public Controls.MyButton myButton14;
        public Controls.MyButton myButton12;
        private Controls.MyButton myButton8;
        private Controls.MyButton AUTOQUICK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private Controls.MyButton myButton21;
        private Controls.MyButton Cancel;
        private Controls.MyButton myButton18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel PlaceAfterPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        public Controls.MyButton myButton19;
        public Controls.MyButton myButton20;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TableLayoutPanel ToolsTable;
        private Controls.MyButton MeasureBTN;
        private Controls.MyButton ToolsBTN;
        private Controls.MyButton DrawBTN;
        private System.Windows.Forms.Panel measurePanel;
        public Controls.MyButton UnitsMeasureBTN;
        private System.Windows.Forms.Label measureLabel;
        private System.Windows.Forms.Panel DrawPanel;
        public Controls.MyButton NewDrawPoly;
        public Controls.MyButton ApplyPoly;
        public Controls.MyButton DeletePoly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox PolyNameBox;
        private System.Windows.Forms.Button ColorBTN;
        public Controls.MyButton SavePolysBTN;
        public Controls.MyButton ImportPolysBTN;
        private Controls.MyButton myButton22;
        private System.Windows.Forms.Panel FollowMePanel;
        private System.Windows.Forms.Panel Joystick_Panel;
        private Controls.MyButton zoom_out;
        private Controls.MyButton zoom_in;
    }
}