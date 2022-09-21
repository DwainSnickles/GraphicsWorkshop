
namespace GraphicsWorkshop.Form_Tabs
{
    partial class frmShadowText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShadowText));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.nudShadowThickness = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grouper3 = new CodeVendor.Controls.Grouper();
            this.rbHideShadow = new System.Windows.Forms.RadioButton();
            this.rbShowShadow = new System.Windows.Forms.RadioButton();
            this.cmbgradientType = new System.Windows.Forms.ComboBox();
            this.pnlTextColor = new System.Windows.Forms.Panel();
            this.pnlTextGradient1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.btnTextGradient2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTextGradient1 = new System.Windows.Forms.Button();
            this.btnTextOutLineColor2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cButton1 = new CButtonLib.CButton();
            this.btnDrawText = new CButtonLib.CButton();
            this.picText = new System.Windows.Forms.PictureBox();
            this.pnlTextOutLineColor1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTextOutLineColor1 = new System.Windows.Forms.Button();
            this.pnlShadowColor = new System.Windows.Forms.Panel();
            this.btnShawdowColor = new System.Windows.Forms.Button();
            this.pnlTextOutLineColor2 = new System.Windows.Forms.Panel();
            this.pnlTextGradient2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grouper2 = new CodeVendor.Controls.Grouper();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDisplayText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grouper1 = new CodeVendor.Controls.Grouper();
            ((System.ComponentModel.ISupportInitialize)(this.nudShadowThickness)).BeginInit();
            this.grouper3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).BeginInit();
            this.grouper2.SuspendLayout();
            this.grouper1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudShadowThickness
            // 
            this.nudShadowThickness.Location = new System.Drawing.Point(318, 32);
            this.nudShadowThickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudShadowThickness.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudShadowThickness.Name = "nudShadowThickness";
            this.nudShadowThickness.Size = new System.Drawing.Size(44, 20);
            this.nudShadowThickness.TabIndex = 22;
            this.nudShadowThickness.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ShadowThickness";
            // 
            // grouper3
            // 
            this.grouper3.BackgroundColor = System.Drawing.Color.White;
            this.grouper3.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper3.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper3.BorderColor = System.Drawing.Color.Gray;
            this.grouper3.BorderThickness = 3F;
            this.grouper3.Controls.Add(this.nudShadowThickness);
            this.grouper3.Controls.Add(this.label1);
            this.grouper3.Controls.Add(this.rbHideShadow);
            this.grouper3.Controls.Add(this.rbShowShadow);
            this.grouper3.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper3.GroupImage = null;
            this.grouper3.GroupTitle = "Shadow Options";
            this.grouper3.Location = new System.Drawing.Point(6, 80);
            this.grouper3.Name = "grouper3";
            this.grouper3.Padding = new System.Windows.Forms.Padding(20);
            this.grouper3.PaintGroupBox = false;
            this.grouper3.RoundCorners = 10;
            this.grouper3.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper3.ShadowControl = false;
            this.grouper3.ShadowThickness = 3;
            this.grouper3.Size = new System.Drawing.Size(379, 65);
            this.grouper3.TabIndex = 50;
            // 
            // rbHideShadow
            // 
            this.rbHideShadow.AutoSize = true;
            this.rbHideShadow.Location = new System.Drawing.Point(122, 34);
            this.rbHideShadow.Name = "rbHideShadow";
            this.rbHideShadow.Size = new System.Drawing.Size(89, 17);
            this.rbHideShadow.TabIndex = 3;
            this.rbHideShadow.TabStop = true;
            this.rbHideShadow.Text = "Hide Shadow";
            this.rbHideShadow.UseVisualStyleBackColor = true;
            // 
            // rbShowShadow
            // 
            this.rbShowShadow.AutoSize = true;
            this.rbShowShadow.Checked = true;
            this.rbShowShadow.Location = new System.Drawing.Point(20, 34);
            this.rbShowShadow.Name = "rbShowShadow";
            this.rbShowShadow.Size = new System.Drawing.Size(94, 17);
            this.rbShowShadow.TabIndex = 2;
            this.rbShowShadow.TabStop = true;
            this.rbShowShadow.Text = "Show Shadow";
            this.rbShowShadow.UseVisualStyleBackColor = true;
            // 
            // cmbgradientType
            // 
            this.cmbgradientType.FormattingEnabled = true;
            this.cmbgradientType.Items.AddRange(new object[] {
            "Linear",
            "Sinusoid"});
            this.cmbgradientType.Location = new System.Drawing.Point(262, 19);
            this.cmbgradientType.Name = "cmbgradientType";
            this.cmbgradientType.Size = new System.Drawing.Size(92, 21);
            this.cmbgradientType.TabIndex = 49;
            this.cmbgradientType.Text = "Linear";
            // 
            // pnlTextColor
            // 
            this.pnlTextColor.BackColor = System.Drawing.Color.Gold;
            this.pnlTextColor.Location = new System.Drawing.Point(26, 65);
            this.pnlTextColor.Name = "pnlTextColor";
            this.pnlTextColor.Size = new System.Drawing.Size(44, 20);
            this.pnlTextColor.TabIndex = 48;
            // 
            // pnlTextGradient1
            // 
            this.pnlTextGradient1.BackColor = System.Drawing.Color.Black;
            this.pnlTextGradient1.Location = new System.Drawing.Point(149, 111);
            this.pnlTextGradient1.Name = "pnlTextGradient1";
            this.pnlTextGradient1.Size = new System.Drawing.Size(44, 20);
            this.pnlTextGradient1.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Gradient Type";
            // 
            // btnTextColor
            // 
            this.btnTextColor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextColor.ImageIndex = 1;
            this.btnTextColor.ImageList = this.imageList1;
            this.btnTextColor.Location = new System.Drawing.Point(70, 63);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(24, 24);
            this.btnTextColor.TabIndex = 50;
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Fill.png");
            this.imageList1.Images.SetKeyName(1, "Color1.png");
            this.imageList1.Images.SetKeyName(2, "ColorCircle1.png");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "TextGradient1";
            // 
            // btnTextGradient2
            // 
            this.btnTextGradient2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextGradient2.ImageIndex = 0;
            this.btnTextGradient2.ImageList = this.imageList1;
            this.btnTextGradient2.Location = new System.Drawing.Point(320, 110);
            this.btnTextGradient2.Name = "btnTextGradient2";
            this.btnTextGradient2.Size = new System.Drawing.Size(24, 24);
            this.btnTextGradient2.TabIndex = 47;
            this.btnTextGradient2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(269, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "TextGradient2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "TextColor";
            // 
            // btnTextGradient1
            // 
            this.btnTextGradient1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextGradient1.ImageIndex = 2;
            this.btnTextGradient1.ImageList = this.imageList1;
            this.btnTextGradient1.Location = new System.Drawing.Point(193, 109);
            this.btnTextGradient1.Name = "btnTextGradient1";
            this.btnTextGradient1.Size = new System.Drawing.Size(24, 24);
            this.btnTextGradient1.TabIndex = 46;
            this.btnTextGradient1.UseVisualStyleBackColor = true;
            // 
            // btnTextOutLineColor2
            // 
            this.btnTextOutLineColor2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextOutLineColor2.ImageIndex = 0;
            this.btnTextOutLineColor2.ImageList = this.imageList1;
            this.btnTextOutLineColor2.Location = new System.Drawing.Point(318, 67);
            this.btnTextOutLineColor2.Name = "btnTextOutLineColor2";
            this.btnTextOutLineColor2.Size = new System.Drawing.Size(24, 24);
            this.btnTextOutLineColor2.TabIndex = 41;
            this.btnTextOutLineColor2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "TextOutLineColor2";
            // 
            // cButton1
            // 
            this.cButton1.Corners.All = 10;
            this.cButton1.Corners.LowerLeft = 10;
            this.cButton1.Corners.LowerRight = 10;
            this.cButton1.Corners.UpperLeft = 10;
            this.cButton1.Corners.UpperRight = 10;
            this.cButton1.DesignerSelected = false;
            this.cButton1.ImageIndex = 0;
            this.cButton1.Location = new System.Drawing.Point(231, 295);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(154, 25);
            this.cButton1.TabIndex = 54;
            this.cButton1.Text = "Send To Designer";
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
            this.btnDrawText.Location = new System.Drawing.Point(7, 295);
            this.btnDrawText.Name = "btnDrawText";
            this.btnDrawText.Size = new System.Drawing.Size(132, 25);
            this.btnDrawText.TabIndex = 53;
            this.btnDrawText.Text = "Draw Text";
            // 
            // picText
            // 
            this.picText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picText.Location = new System.Drawing.Point(10, 343);
            this.picText.Name = "picText";
            this.picText.Size = new System.Drawing.Size(25, 25);
            this.picText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picText.TabIndex = 51;
            this.picText.TabStop = false;
            // 
            // pnlTextOutLineColor1
            // 
            this.pnlTextOutLineColor1.BackColor = System.Drawing.Color.Maroon;
            this.pnlTextOutLineColor1.Location = new System.Drawing.Point(149, 67);
            this.pnlTextOutLineColor1.Name = "pnlTextOutLineColor1";
            this.pnlTextOutLineColor1.Size = new System.Drawing.Size(44, 20);
            this.pnlTextOutLineColor1.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "TextOutLineColor1";
            // 
            // btnTextOutLineColor1
            // 
            this.btnTextOutLineColor1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextOutLineColor1.ImageKey = "ColorCircle1.png";
            this.btnTextOutLineColor1.ImageList = this.imageList1;
            this.btnTextOutLineColor1.Location = new System.Drawing.Point(193, 65);
            this.btnTextOutLineColor1.Name = "btnTextOutLineColor1";
            this.btnTextOutLineColor1.Size = new System.Drawing.Size(24, 24);
            this.btnTextOutLineColor1.TabIndex = 38;
            this.btnTextOutLineColor1.UseVisualStyleBackColor = true;
            // 
            // pnlShadowColor
            // 
            this.pnlShadowColor.BackColor = System.Drawing.Color.Red;
            this.pnlShadowColor.Location = new System.Drawing.Point(26, 109);
            this.pnlShadowColor.Name = "pnlShadowColor";
            this.pnlShadowColor.Size = new System.Drawing.Size(44, 20);
            this.pnlShadowColor.TabIndex = 33;
            // 
            // btnShawdowColor
            // 
            this.btnShawdowColor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnShawdowColor.ImageIndex = 1;
            this.btnShawdowColor.ImageList = this.imageList1;
            this.btnShawdowColor.Location = new System.Drawing.Point(71, 106);
            this.btnShawdowColor.Name = "btnShawdowColor";
            this.btnShawdowColor.Size = new System.Drawing.Size(24, 24);
            this.btnShawdowColor.TabIndex = 34;
            this.btnShawdowColor.UseVisualStyleBackColor = true;
            // 
            // pnlTextOutLineColor2
            // 
            this.pnlTextOutLineColor2.BackColor = System.Drawing.Color.Yellow;
            this.pnlTextOutLineColor2.Location = new System.Drawing.Point(272, 69);
            this.pnlTextOutLineColor2.Name = "pnlTextOutLineColor2";
            this.pnlTextOutLineColor2.Size = new System.Drawing.Size(44, 20);
            this.pnlTextOutLineColor2.TabIndex = 40;
            // 
            // pnlTextGradient2
            // 
            this.pnlTextGradient2.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTextGradient2.Location = new System.Drawing.Point(272, 112);
            this.pnlTextGradient2.Name = "pnlTextGradient2";
            this.pnlTextGradient2.Size = new System.Drawing.Size(44, 20);
            this.pnlTextGradient2.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Sample Text Image Display.";
            // 
            // grouper2
            // 
            this.grouper2.BackgroundColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper2.BorderColor = System.Drawing.Color.Gray;
            this.grouper2.BorderThickness = 3F;
            this.grouper2.Controls.Add(this.cmbgradientType);
            this.grouper2.Controls.Add(this.pnlTextColor);
            this.grouper2.Controls.Add(this.pnlTextGradient1);
            this.grouper2.Controls.Add(this.label6);
            this.grouper2.Controls.Add(this.btnTextColor);
            this.grouper2.Controls.Add(this.label11);
            this.grouper2.Controls.Add(this.btnTextGradient2);
            this.grouper2.Controls.Add(this.label12);
            this.grouper2.Controls.Add(this.label8);
            this.grouper2.Controls.Add(this.btnTextGradient1);
            this.grouper2.Controls.Add(this.btnTextOutLineColor2);
            this.grouper2.Controls.Add(this.label10);
            this.grouper2.Controls.Add(this.pnlTextOutLineColor1);
            this.grouper2.Controls.Add(this.label9);
            this.grouper2.Controls.Add(this.btnTextOutLineColor1);
            this.grouper2.Controls.Add(this.pnlShadowColor);
            this.grouper2.Controls.Add(this.label7);
            this.grouper2.Controls.Add(this.btnShawdowColor);
            this.grouper2.Controls.Add(this.pnlTextOutLineColor2);
            this.grouper2.Controls.Add(this.pnlTextGradient2);
            this.grouper2.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper2.GroupImage = null;
            this.grouper2.GroupTitle = "Text Color Options";
            this.grouper2.Location = new System.Drawing.Point(6, 148);
            this.grouper2.Name = "grouper2";
            this.grouper2.Padding = new System.Windows.Forms.Padding(20);
            this.grouper2.PaintGroupBox = false;
            this.grouper2.RoundCorners = 10;
            this.grouper2.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper2.ShadowControl = false;
            this.grouper2.ShadowThickness = 3;
            this.grouper2.Size = new System.Drawing.Size(379, 141);
            this.grouper2.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Shadow Color";
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.Location = new System.Drawing.Point(125, 34);
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.Size = new System.Drawing.Size(237, 20);
            this.txtDisplayText.TabIndex = 25;
            this.txtDisplayText.Text = "Hello World";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Text to write.";
            // 
            // grouper1
            // 
            this.grouper1.BackgroundColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper1.BorderColor = System.Drawing.Color.Gray;
            this.grouper1.BorderThickness = 3F;
            this.grouper1.Controls.Add(this.txtDisplayText);
            this.grouper1.Controls.Add(this.label3);
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "Enter Text To Display";
            this.grouper1.Location = new System.Drawing.Point(6, 12);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(20);
            this.grouper1.PaintGroupBox = false;
            this.grouper1.RoundCorners = 10;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 3;
            this.grouper1.Size = new System.Drawing.Size(379, 64);
            this.grouper1.TabIndex = 48;
            // 
            // frmShadowText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 503);
            this.Controls.Add(this.grouper3);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.btnDrawText);
            this.Controls.Add(this.picText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grouper2);
            this.Controls.Add(this.grouper1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShadowText";
            this.Text = "frmShadowText";
            ((System.ComponentModel.ISupportInitialize)(this.nudShadowThickness)).EndInit();
            this.grouper3.ResumeLayout(false);
            this.grouper3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).EndInit();
            this.grouper2.ResumeLayout(false);
            this.grouper2.PerformLayout();
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown nudShadowThickness;
        private System.Windows.Forms.Label label1;
        private CodeVendor.Controls.Grouper grouper3;
        private System.Windows.Forms.RadioButton rbHideShadow;
        private System.Windows.Forms.RadioButton rbShowShadow;
        private System.Windows.Forms.ComboBox cmbgradientType;
        private System.Windows.Forms.Panel pnlTextColor;
        private System.Windows.Forms.Panel pnlTextGradient1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTextGradient2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTextGradient1;
        private System.Windows.Forms.Button btnTextOutLineColor2;
        private System.Windows.Forms.Label label10;
        private CButtonLib.CButton cButton1;
        private CButtonLib.CButton btnDrawText;
        private System.Windows.Forms.PictureBox picText;
        private System.Windows.Forms.Panel pnlTextOutLineColor1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTextOutLineColor1;
        private System.Windows.Forms.Panel pnlShadowColor;
        private System.Windows.Forms.Button btnShawdowColor;
        private System.Windows.Forms.Panel pnlTextOutLineColor2;
        private System.Windows.Forms.Panel pnlTextGradient2;
        private System.Windows.Forms.Label label2;
        private CodeVendor.Controls.Grouper grouper2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDisplayText;
        private System.Windows.Forms.Label label3;
        private CodeVendor.Controls.Grouper grouper1;
    }
}