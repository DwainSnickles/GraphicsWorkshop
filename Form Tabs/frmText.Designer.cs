
namespace GraphicsWorkshop.Form_Tabs
{
    partial class frmText
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
            this.lblFontSample = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddText = new CButtonLib.CButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grouper1 = new CodeVendor.Controls.Grouper();
            this.btnSelectFont = new CButtonLib.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFontColor = new CButtonLib.CButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFontDetails = new System.Windows.Forms.Label();
            this.pnlFontColor = new CSharpCustomPanelControl.CustomPanel();
            this.grouper2 = new CodeVendor.Controls.Grouper();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grouper1.SuspendLayout();
            this.grouper2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFontSample
            // 
            this.lblFontSample.AutoSize = true;
            this.lblFontSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSample.Location = new System.Drawing.Point(11, 332);
            this.lblFontSample.Name = "lblFontSample";
            this.lblFontSample.Size = new System.Drawing.Size(55, 16);
            this.lblFontSample.TabIndex = 5;
            this.lblFontSample.Text = "Sample";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "View Sample";
            // 
            // btnAddText
            // 
            this.btnAddText.Corners.All = 10;
            this.btnAddText.Corners.LowerLeft = 10;
            this.btnAddText.Corners.LowerRight = 10;
            this.btnAddText.Corners.UpperLeft = 10;
            this.btnAddText.Corners.UpperRight = 10;
            this.btnAddText.DesignerSelected = true;
            this.btnAddText.ImageIndex = 0;
            this.btnAddText.Location = new System.Drawing.Point(206, 514);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(164, 25);
            this.btnAddText.TabIndex = 24;
            this.btnAddText.Text = "Add Text To Designer";
            this.btnAddText.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnAddText_ClickButtonArea);
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // grouper1
            // 
            this.grouper1.BackgroundColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper1.BorderColor = System.Drawing.Color.Gray;
            this.grouper1.BorderThickness = 3F;
            this.grouper1.Controls.Add(this.btnSelectFont);
            this.grouper1.Controls.Add(this.label1);
            this.grouper1.Controls.Add(this.btnFontColor);
            this.grouper1.Controls.Add(this.label2);
            this.grouper1.Controls.Add(this.lblFontDetails);
            this.grouper1.Controls.Add(this.pnlFontColor);
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "Font Options";
            this.grouper1.Location = new System.Drawing.Point(6, 13);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(20);
            this.grouper1.PaintGroupBox = false;
            this.grouper1.RoundCorners = 10;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 3;
            this.grouper1.Size = new System.Drawing.Size(368, 156);
            this.grouper1.TabIndex = 25;
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
            this.btnSelectFont.Location = new System.Drawing.Point(23, 96);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(102, 25);
            this.btnSelectFont.TabIndex = 2;
            this.btnSelectFont.Text = "Change Font";
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Font";
            // 
            // btnFontColor
            // 
            this.btnFontColor.Corners.All = 10;
            this.btnFontColor.Corners.LowerLeft = 10;
            this.btnFontColor.Corners.LowerRight = 10;
            this.btnFontColor.Corners.UpperLeft = 10;
            this.btnFontColor.Corners.UpperRight = 10;
            this.btnFontColor.DesignerSelected = false;
            this.btnFontColor.ImageIndex = 0;
            this.btnFontColor.Location = new System.Drawing.Point(219, 96);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(137, 25);
            this.btnFontColor.TabIndex = 8;
            this.btnFontColor.Text = "Change Font Color";
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected Font Color";
            // 
            // lblFontDetails
            // 
            this.lblFontDetails.AutoSize = true;
            this.lblFontDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontDetails.Location = new System.Drawing.Point(20, 68);
            this.lblFontDetails.Name = "lblFontDetails";
            this.lblFontDetails.Size = new System.Drawing.Size(180, 16);
            this.lblFontDetails.TabIndex = 1;
            this.lblFontDetails.Text = "Microsoft Sans Serif, 9.25 pts.";
            // 
            // pnlFontColor
            // 
            this.pnlFontColor.BackColor = System.Drawing.Color.Black;
            this.pnlFontColor.Curvature = 15;
            this.pnlFontColor.Location = new System.Drawing.Point(269, 61);
            this.pnlFontColor.Name = "pnlFontColor";
            this.pnlFontColor.Size = new System.Drawing.Size(36, 25);
            this.pnlFontColor.TabIndex = 6;
            // 
            // grouper2
            // 
            this.grouper2.BackgroundColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper2.BorderColor = System.Drawing.Color.Gray;
            this.grouper2.BorderThickness = 3F;
            this.grouper2.Controls.Add(this.label4);
            this.grouper2.Controls.Add(this.txtMessage);
            this.grouper2.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper2.GroupImage = null;
            this.grouper2.GroupTitle = "Text  Display Options";
            this.grouper2.Location = new System.Drawing.Point(6, 178);
            this.grouper2.Name = "grouper2";
            this.grouper2.Padding = new System.Windows.Forms.Padding(20);
            this.grouper2.PaintGroupBox = false;
            this.grouper2.RoundCorners = 10;
            this.grouper2.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper2.ShadowControl = false;
            this.grouper2.ShadowThickness = 3;
            this.grouper2.Size = new System.Drawing.Size(368, 108);
            this.grouper2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter Text To Display";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(23, 65);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(336, 22);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "Sample";
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // frmText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 568);
            this.Controls.Add(this.lblFontSample);
            this.Controls.Add(this.grouper1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grouper2);
            this.Controls.Add(this.btnAddText);
            this.Name = "frmText";
            this.Text = "frmText";
            this.Load += new System.EventHandler(this.frmText_Load);
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            this.grouper2.ResumeLayout(false);
            this.grouper2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFontSample;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFontDetails;
        private System.Windows.Forms.FontDialog fontDialog1;
        private CButtonLib.CButton btnSelectFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private CodeVendor.Controls.Grouper grouper1;
        private CButtonLib.CButton btnFontColor;
        private CSharpCustomPanelControl.CustomPanel pnlFontColor;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label3;
        private CodeVendor.Controls.Grouper grouper2;
        private CButtonLib.CButton btnAddText;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}