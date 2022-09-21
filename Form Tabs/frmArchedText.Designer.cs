
namespace GraphicsWorkshop.Form_Tabs
{
    partial class frmArchedText
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchedText));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFontSample = new System.Windows.Forms.Label();
            this.txtBottom = new System.Windows.Forms.TextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.cmbArchText = new System.Windows.Forms.ComboBox();
            this.grp3dCircle = new CodeVendor.Controls.Grouper();
            this.btnCenterCircleColor3 = new CButtonLib.CButton();
            this.pnlCircleColor3 = new CSharpCustomPanelControl.CustomPanel();
            this.btnCenterCircleColor2 = new CButtonLib.CButton();
            this.pnlCircleColor2 = new CSharpCustomPanelControl.CustomPanel();
            this.btnCenterCircleColor1 = new CButtonLib.CButton();
            this.pnlCircleColor1 = new CSharpCustomPanelControl.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnAddTextToDesinger = new CButtonLib.CButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picArchedText = new System.Windows.Forms.PictureBox();
            this.CkbRotateText = new System.Windows.Forms.CheckBox();
            this.btnDrawText = new CButtonLib.CButton();
            this.grouper1 = new CodeVendor.Controls.Grouper();
            this.label6 = new System.Windows.Forms.Label();
            this.grouper4 = new CodeVendor.Controls.Grouper();
            this.ckbCircleText = new System.Windows.Forms.CheckBox();
            this.grpBorder = new CodeVendor.Controls.Grouper();
            this.nudBorderThickness = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBorderColor = new CSharpCustomPanelControl.CustomPanel();
            this.btnBorderColor = new CButtonLib.CButton();
            this.grouper2 = new CodeVendor.Controls.Grouper();
            this.lblSelectedFont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFontColor = new CSharpCustomPanelControl.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFont = new CButtonLib.CButton();
            this.panel2.SuspendLayout();
            this.grp3dCircle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArchedText)).BeginInit();
            this.grouper1.SuspendLayout();
            this.grouper4.SuspendLayout();
            this.grpBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderThickness)).BeginInit();
            this.grouper2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblFontSample);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 526);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 42);
            this.panel2.TabIndex = 34;
            // 
            // lblFontSample
            // 
            this.lblFontSample.AutoSize = true;
            this.lblFontSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSample.Location = new System.Drawing.Point(3, 5);
            this.lblFontSample.Name = "lblFontSample";
            this.lblFontSample.Size = new System.Drawing.Size(100, 20);
            this.lblFontSample.TabIndex = 10;
            this.lblFontSample.Text = "Font Sample";
            // 
            // txtBottom
            // 
            this.txtBottom.Location = new System.Drawing.Point(7, 127);
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(170, 20);
            this.txtBottom.TabIndex = 2;
            this.txtBottom.Text = "Bottom Circle Text";
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(7, 80);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(170, 20);
            this.txtTop.TabIndex = 1;
            this.txtTop.Text = "Top Circle Text";
            // 
            // cmbArchText
            // 
            this.cmbArchText.FormattingEnabled = true;
            this.cmbArchText.Items.AddRange(new object[] {
            "Full Circle Text Only",
            "Full Circle Text With Center Circle Only",
            "Full Circle With Circular Center Image",
            "Full Circle With Circle And Border And 3d Center",
            "Arch Text Top Down",
            "Arch Text Bottom UP",
            "Arch Text Left Side",
            "Arch Text Right Side"});
            this.cmbArchText.Location = new System.Drawing.Point(7, 34);
            this.cmbArchText.Name = "cmbArchText";
            this.cmbArchText.Size = new System.Drawing.Size(161, 21);
            this.cmbArchText.TabIndex = 0;
            this.cmbArchText.Text = "Select Arch Type";
            // 
            // grp3dCircle
            // 
            this.grp3dCircle.BackgroundColor = System.Drawing.Color.White;
            this.grp3dCircle.BackgroundGradientColor = System.Drawing.Color.White;
            this.grp3dCircle.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grp3dCircle.BorderColor = System.Drawing.Color.Gray;
            this.grp3dCircle.BorderThickness = 3F;
            this.grp3dCircle.Controls.Add(this.btnCenterCircleColor3);
            this.grp3dCircle.Controls.Add(this.pnlCircleColor3);
            this.grp3dCircle.Controls.Add(this.btnCenterCircleColor2);
            this.grp3dCircle.Controls.Add(this.pnlCircleColor2);
            this.grp3dCircle.Controls.Add(this.btnCenterCircleColor1);
            this.grp3dCircle.Controls.Add(this.pnlCircleColor1);
            this.grp3dCircle.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grp3dCircle.GroupImage = null;
            this.grp3dCircle.GroupTitle = "Center Circle Color Options";
            this.grp3dCircle.Location = new System.Drawing.Point(3, 240);
            this.grp3dCircle.Name = "grp3dCircle";
            this.grp3dCircle.Padding = new System.Windows.Forms.Padding(20);
            this.grp3dCircle.PaintGroupBox = false;
            this.grp3dCircle.RoundCorners = 10;
            this.grp3dCircle.ShadowColor = System.Drawing.Color.DarkGray;
            this.grp3dCircle.ShadowControl = false;
            this.grp3dCircle.ShadowThickness = 3;
            this.grp3dCircle.Size = new System.Drawing.Size(372, 81);
            this.grp3dCircle.TabIndex = 33;
            // 
            // btnCenterCircleColor3
            // 
            this.btnCenterCircleColor3.Corners.All = 10;
            this.btnCenterCircleColor3.Corners.LowerLeft = 10;
            this.btnCenterCircleColor3.Corners.LowerRight = 10;
            this.btnCenterCircleColor3.Corners.UpperLeft = 10;
            this.btnCenterCircleColor3.Corners.UpperRight = 10;
            this.btnCenterCircleColor3.DesignerSelected = false;
            this.btnCenterCircleColor3.ImageIndex = 0;
            this.btnCenterCircleColor3.Location = new System.Drawing.Point(261, 32);
            this.btnCenterCircleColor3.Name = "btnCenterCircleColor3";
            this.btnCenterCircleColor3.Size = new System.Drawing.Size(100, 25);
            this.btnCenterCircleColor3.TabIndex = 19;
            this.btnCenterCircleColor3.Text = "Circle Color 3";
            this.btnCenterCircleColor3.Click += new System.EventHandler(this.btnCenterCircleColor3_Click);
            // 
            // pnlCircleColor3
            // 
            this.pnlCircleColor3.BackColor = System.Drawing.Color.LightGray;
            this.pnlCircleColor3.Curvature = 10;
            this.pnlCircleColor3.Location = new System.Drawing.Point(271, 49);
            this.pnlCircleColor3.Name = "pnlCircleColor3";
            this.pnlCircleColor3.Size = new System.Drawing.Size(80, 23);
            this.pnlCircleColor3.TabIndex = 20;
            // 
            // btnCenterCircleColor2
            // 
            this.btnCenterCircleColor2.Corners.All = 10;
            this.btnCenterCircleColor2.Corners.LowerLeft = 10;
            this.btnCenterCircleColor2.Corners.LowerRight = 10;
            this.btnCenterCircleColor2.Corners.UpperLeft = 10;
            this.btnCenterCircleColor2.Corners.UpperRight = 10;
            this.btnCenterCircleColor2.DesignerSelected = false;
            this.btnCenterCircleColor2.ImageIndex = 0;
            this.btnCenterCircleColor2.Location = new System.Drawing.Point(135, 32);
            this.btnCenterCircleColor2.Name = "btnCenterCircleColor2";
            this.btnCenterCircleColor2.Size = new System.Drawing.Size(100, 25);
            this.btnCenterCircleColor2.TabIndex = 17;
            this.btnCenterCircleColor2.Text = "Circle Color 2";
            this.btnCenterCircleColor2.Click += new System.EventHandler(this.btnCenterCircleColor2_Click);
            // 
            // pnlCircleColor2
            // 
            this.pnlCircleColor2.BackColor = System.Drawing.Color.DimGray;
            this.pnlCircleColor2.Curvature = 10;
            this.pnlCircleColor2.Location = new System.Drawing.Point(145, 49);
            this.pnlCircleColor2.Name = "pnlCircleColor2";
            this.pnlCircleColor2.Size = new System.Drawing.Size(80, 23);
            this.pnlCircleColor2.TabIndex = 18;
            // 
            // btnCenterCircleColor1
            // 
            this.btnCenterCircleColor1.Corners.All = 10;
            this.btnCenterCircleColor1.Corners.LowerLeft = 10;
            this.btnCenterCircleColor1.Corners.LowerRight = 10;
            this.btnCenterCircleColor1.Corners.UpperLeft = 10;
            this.btnCenterCircleColor1.Corners.UpperRight = 10;
            this.btnCenterCircleColor1.DesignerSelected = false;
            this.btnCenterCircleColor1.ImageIndex = 0;
            this.btnCenterCircleColor1.Location = new System.Drawing.Point(12, 32);
            this.btnCenterCircleColor1.Name = "btnCenterCircleColor1";
            this.btnCenterCircleColor1.Size = new System.Drawing.Size(100, 25);
            this.btnCenterCircleColor1.TabIndex = 12;
            this.btnCenterCircleColor1.Text = "Circle Color 1";
            this.btnCenterCircleColor1.Click += new System.EventHandler(this.btnCenterCircleColor1_Click);
            // 
            // pnlCircleColor1
            // 
            this.pnlCircleColor1.BackColor = System.Drawing.Color.LightGray;
            this.pnlCircleColor1.Curvature = 10;
            this.pnlCircleColor1.Location = new System.Drawing.Point(22, 49);
            this.pnlCircleColor1.Name = "pnlCircleColor1";
            this.pnlCircleColor1.Size = new System.Drawing.Size(80, 23);
            this.pnlCircleColor1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "View Sample";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Top Text";
            // 
            // btnAddTextToDesinger
            // 
            this.btnAddTextToDesinger.Corners.All = 10;
            this.btnAddTextToDesinger.Corners.LowerLeft = 10;
            this.btnAddTextToDesinger.Corners.LowerRight = 10;
            this.btnAddTextToDesinger.Corners.UpperLeft = 10;
            this.btnAddTextToDesinger.Corners.UpperRight = 10;
            this.btnAddTextToDesinger.DesignerSelected = false;
            this.btnAddTextToDesinger.ImageIndex = 0;
            this.btnAddTextToDesinger.Location = new System.Drawing.Point(216, 490);
            this.btnAddTextToDesinger.Name = "btnAddTextToDesinger";
            this.btnAddTextToDesinger.Size = new System.Drawing.Size(159, 25);
            this.btnAddTextToDesinger.TabIndex = 31;
            this.btnAddTextToDesinger.Text = "Add Text To Designer";
            this.btnAddTextToDesinger.Click += new System.EventHandler(this.btnAddTextToDesinger_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picArchedText);
            this.panel1.Location = new System.Drawing.Point(8, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 114);
            this.panel1.TabIndex = 30;
            // 
            // picArchedText
            // 
            this.picArchedText.Location = new System.Drawing.Point(0, 0);
            this.picArchedText.Name = "picArchedText";
            this.picArchedText.Size = new System.Drawing.Size(50, 50);
            this.picArchedText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picArchedText.TabIndex = 0;
            this.picArchedText.TabStop = false;
            // 
            // CkbRotateText
            // 
            this.CkbRotateText.AutoSize = true;
            this.CkbRotateText.Location = new System.Drawing.Point(7, 327);
            this.CkbRotateText.Name = "CkbRotateText";
            this.CkbRotateText.Size = new System.Drawing.Size(140, 17);
            this.CkbRotateText.TabIndex = 35;
            this.CkbRotateText.Text = "Rotate Text 45 Degrees";
            this.CkbRotateText.UseVisualStyleBackColor = true;
            // 
            // btnDrawText
            // 
            this.btnDrawText.Corners.All = 10;
            this.btnDrawText.Corners.LowerLeft = 10;
            this.btnDrawText.Corners.LowerRight = 10;
            this.btnDrawText.Corners.UpperLeft = 10;
            this.btnDrawText.Corners.UpperRight = 10;
            this.btnDrawText.DesignerSelected = false;
            this.btnDrawText.ImageIndex = 0;
            this.btnDrawText.Location = new System.Drawing.Point(261, 327);
            this.btnDrawText.Name = "btnDrawText";
            this.btnDrawText.Size = new System.Drawing.Size(114, 25);
            this.btnDrawText.TabIndex = 29;
            this.btnDrawText.Text = "Draw Text";
            this.btnDrawText.Click += new System.EventHandler(this.btnDrawText_Click);
            // 
            // grouper1
            // 
            this.grouper1.BackgroundColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper1.BorderColor = System.Drawing.Color.Gray;
            this.grouper1.BorderThickness = 3F;
            this.grouper1.Controls.Add(this.label6);
            this.grouper1.Controls.Add(this.label5);
            this.grouper1.Controls.Add(this.txtBottom);
            this.grouper1.Controls.Add(this.txtTop);
            this.grouper1.Controls.Add(this.cmbArchText);
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "Text Design Option";
            this.grouper1.Location = new System.Drawing.Point(3, 4);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(20);
            this.grouper1.PaintGroupBox = false;
            this.grouper1.RoundCorners = 10;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 3;
            this.grouper1.Size = new System.Drawing.Size(184, 159);
            this.grouper1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "BottomText";
            // 
            // grouper4
            // 
            this.grouper4.BackgroundColor = System.Drawing.Color.White;
            this.grouper4.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper4.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper4.BorderColor = System.Drawing.Color.Gray;
            this.grouper4.BorderThickness = 3F;
            this.grouper4.Controls.Add(this.ckbCircleText);
            this.grouper4.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper4.GroupImage = null;
            this.grouper4.GroupTitle = "Display Center Circle";
            this.grouper4.Location = new System.Drawing.Point(3, 169);
            this.grouper4.Name = "grouper4";
            this.grouper4.Padding = new System.Windows.Forms.Padding(20);
            this.grouper4.PaintGroupBox = false;
            this.grouper4.RoundCorners = 10;
            this.grouper4.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper4.ShadowControl = false;
            this.grouper4.ShadowThickness = 3;
            this.grouper4.Size = new System.Drawing.Size(184, 65);
            this.grouper4.TabIndex = 28;
            // 
            // ckbCircleText
            // 
            this.ckbCircleText.AutoSize = true;
            this.ckbCircleText.Location = new System.Drawing.Point(12, 34);
            this.ckbCircleText.Name = "ckbCircleText";
            this.ckbCircleText.Size = new System.Drawing.Size(114, 17);
            this.ckbCircleText.TabIndex = 0;
            this.ckbCircleText.Text = "Add Circle To Text";
            this.ckbCircleText.UseVisualStyleBackColor = true;
            // 
            // grpBorder
            // 
            this.grpBorder.BackgroundColor = System.Drawing.Color.White;
            this.grpBorder.BackgroundGradientColor = System.Drawing.Color.White;
            this.grpBorder.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grpBorder.BorderColor = System.Drawing.Color.Gray;
            this.grpBorder.BorderThickness = 3F;
            this.grpBorder.Controls.Add(this.nudBorderThickness);
            this.grpBorder.Controls.Add(this.label3);
            this.grpBorder.Controls.Add(this.pnlBorderColor);
            this.grpBorder.Controls.Add(this.btnBorderColor);
            this.grpBorder.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grpBorder.GroupImage = null;
            this.grpBorder.GroupTitle = "Border Options";
            this.grpBorder.Location = new System.Drawing.Point(191, 138);
            this.grpBorder.Name = "grpBorder";
            this.grpBorder.Padding = new System.Windows.Forms.Padding(20);
            this.grpBorder.PaintGroupBox = false;
            this.grpBorder.RoundCorners = 10;
            this.grpBorder.ShadowColor = System.Drawing.Color.DarkGray;
            this.grpBorder.ShadowControl = false;
            this.grpBorder.ShadowThickness = 3;
            this.grpBorder.Size = new System.Drawing.Size(184, 97);
            this.grpBorder.TabIndex = 27;
            // 
            // nudBorderThickness
            // 
            this.nudBorderThickness.Location = new System.Drawing.Point(134, 66);
            this.nudBorderThickness.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBorderThickness.Name = "nudBorderThickness";
            this.nudBorderThickness.Size = new System.Drawing.Size(36, 20);
            this.nudBorderThickness.TabIndex = 17;
            this.nudBorderThickness.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Border Thickness";
            // 
            // pnlBorderColor
            // 
            this.pnlBorderColor.BackColor = System.Drawing.Color.Black;
            this.pnlBorderColor.Curvature = 15;
            this.pnlBorderColor.Location = new System.Drawing.Point(134, 31);
            this.pnlBorderColor.Name = "pnlBorderColor";
            this.pnlBorderColor.Size = new System.Drawing.Size(36, 25);
            this.pnlBorderColor.TabIndex = 15;
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.Corners.All = 10;
            this.btnBorderColor.Corners.LowerLeft = 10;
            this.btnBorderColor.Corners.LowerRight = 10;
            this.btnBorderColor.Corners.UpperLeft = 10;
            this.btnBorderColor.Corners.UpperRight = 10;
            this.btnBorderColor.DesignerSelected = false;
            this.btnBorderColor.ImageIndex = 0;
            this.btnBorderColor.Location = new System.Drawing.Point(9, 31);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(114, 25);
            this.btnBorderColor.TabIndex = 14;
            this.btnBorderColor.Text = "Border Color";
            this.btnBorderColor.Click += new System.EventHandler(this.btnCircleBorderColor_Click);
            // 
            // grouper2
            // 
            this.grouper2.BackgroundColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper2.BorderColor = System.Drawing.Color.Gray;
            this.grouper2.BorderThickness = 3F;
            this.grouper2.Controls.Add(this.lblSelectedFont);
            this.grouper2.Controls.Add(this.label1);
            this.grouper2.Controls.Add(this.pnlFontColor);
            this.grouper2.Controls.Add(this.label2);
            this.grouper2.Controls.Add(this.btnSelectFont);
            this.grouper2.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper2.GroupImage = null;
            this.grouper2.GroupTitle = "Font Options";
            this.grouper2.Location = new System.Drawing.Point(191, 4);
            this.grouper2.Name = "grouper2";
            this.grouper2.Padding = new System.Windows.Forms.Padding(20);
            this.grouper2.PaintGroupBox = false;
            this.grouper2.RoundCorners = 10;
            this.grouper2.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper2.ShadowControl = false;
            this.grouper2.ShadowThickness = 3;
            this.grouper2.Size = new System.Drawing.Size(184, 128);
            this.grouper2.TabIndex = 26;
            // 
            // lblSelectedFont
            // 
            this.lblSelectedFont.AutoSize = true;
            this.lblSelectedFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFont.Location = new System.Drawing.Point(4, 51);
            this.lblSelectedFont.Name = "lblSelectedFont";
            this.lblSelectedFont.Size = new System.Drawing.Size(180, 16);
            this.lblSelectedFont.TabIndex = 14;
            this.lblSelectedFont.Text = "Microsoft Sans Serif, 9.25 pts.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected Font";
            // 
            // pnlFontColor
            // 
            this.pnlFontColor.BackColor = System.Drawing.Color.Blue;
            this.pnlFontColor.Curvature = 15;
            this.pnlFontColor.Location = new System.Drawing.Point(137, 95);
            this.pnlFontColor.Name = "pnlFontColor";
            this.pnlFontColor.Size = new System.Drawing.Size(36, 25);
            this.pnlFontColor.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selected Font Color";
            // 
            // btnSelectFont
            // 
            this.btnSelectFont.Corners.All = 10;
            this.btnSelectFont.Corners.LowerLeft = 10;
            this.btnSelectFont.Corners.LowerRight = 10;
            this.btnSelectFont.Corners.UpperLeft = 10;
            this.btnSelectFont.Corners.UpperRight = 10;
            this.btnSelectFont.DesignerSelected = false;
            this.btnSelectFont.ImageIndex = 0;
            this.btnSelectFont.Location = new System.Drawing.Point(7, 70);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(102, 25);
            this.btnSelectFont.TabIndex = 11;
            this.btnSelectFont.Text = "Change Font";
            this.btnSelectFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // frmArchedText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grp3dCircle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddTextToDesinger);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CkbRotateText);
            this.Controls.Add(this.btnDrawText);
            this.Controls.Add(this.grouper1);
            this.Controls.Add(this.grouper4);
            this.Controls.Add(this.grpBorder);
            this.Controls.Add(this.grouper2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArchedText";
            this.Text = "frmArchedText";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grp3dCircle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArchedText)).EndInit();
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            this.grouper4.ResumeLayout(false);
            this.grouper4.PerformLayout();
            this.grpBorder.ResumeLayout(false);
            this.grpBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderThickness)).EndInit();
            this.grouper2.ResumeLayout(false);
            this.grouper2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFontSample;
        private System.Windows.Forms.TextBox txtBottom;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.ComboBox cmbArchText;
        private CodeVendor.Controls.Grouper grp3dCircle;
        private CButtonLib.CButton btnCenterCircleColor3;
        private CSharpCustomPanelControl.CustomPanel pnlCircleColor3;
        private CButtonLib.CButton btnCenterCircleColor2;
        private CSharpCustomPanelControl.CustomPanel pnlCircleColor2;
        private CButtonLib.CButton btnCenterCircleColor1;
        private CSharpCustomPanelControl.CustomPanel pnlCircleColor1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private CButtonLib.CButton btnAddTextToDesinger;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picArchedText;
        private System.Windows.Forms.CheckBox CkbRotateText;
        private CButtonLib.CButton btnDrawText;
        private CodeVendor.Controls.Grouper grouper1;
        private System.Windows.Forms.Label label6;
        private CodeVendor.Controls.Grouper grouper4;
        private System.Windows.Forms.CheckBox ckbCircleText;
        private CodeVendor.Controls.Grouper grpBorder;
        private System.Windows.Forms.NumericUpDown nudBorderThickness;
        private System.Windows.Forms.Label label3;
        private CSharpCustomPanelControl.CustomPanel pnlBorderColor;
        private CButtonLib.CButton btnBorderColor;
        private CodeVendor.Controls.Grouper grouper2;
        private System.Windows.Forms.Label lblSelectedFont;
        private System.Windows.Forms.Label label1;
        private CSharpCustomPanelControl.CustomPanel pnlFontColor;
        private System.Windows.Forms.Label label2;
        private CButtonLib.CButton btnSelectFont;
    }
}