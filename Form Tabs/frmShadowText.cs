using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TextDesignerCSLibrary;

namespace GraphicsWorkshop.Form_Tabs
{
    public partial class frmShadowText : Form
    {
        public int ShadowThickness { get; set; } = 10;
        public GradientType gradientType { get; set; } = GradientType.Linear;
        public bool Reflection { get; set; } = false;
        public bool ShowShadow { get; set; } = true;


        public frmShadowText()
        {
            InitializeComponent();
        }
        public Rectangle rect { get; set; }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            SolidBrush brushBkgnd = new SolidBrush(Color.Transparent);
            e.Graphics.FillRectangle(brushBkgnd, 0, 0, this.ClientSize.Width, this.ClientSize.Width);

            PngOutlineText m_PngOutlineText = new PngOutlineText();
            m_PngOutlineText.SetPngImage(new Bitmap(ClientSize.Width, ClientSize.Height));
            m_PngOutlineText.TextGradOutline(pnlTextColor.BackColor, pnlTextOutLineColor1.BackColor, pnlTextOutLineColor2.BackColor, ShadowThickness, gradientType);
            m_PngOutlineText.EnableReflection(Reflection);

            m_PngOutlineText.EnableShadow(ShowShadow);
            //Rem to SetNullShadow() to release memory if a previous shadow has been set.
            m_PngOutlineText.SetNullShadow();
            m_PngOutlineText.Shadow(pnlShadowColor.BackColor, (int)nudShadowThickness.Value, new Point(4, 4));

            LOGFONT m_LogFont = new LOGFONT();
            m_LogFont.lfFaceName = "Arial Black";
            m_LogFont.lfHeight = -48;

            m_LogFont.lfOrientation = 0;
            m_LogFont.lfEscapement = 0;
            m_LogFont.lfItalic = false;
            float fStartX = 0.0f;
            float fStartY = 0.0f;
            float fDestWidth = 0.0f;
            float fDestHeight = 0.0f;
            m_PngOutlineText.GdiMeasureString(e.Graphics, m_LogFont, txtDisplayText.Text, new Point(10, 10),
                                               ref fStartX, ref fStartY, ref fDestWidth, ref fDestHeight);

            m_PngOutlineText.SetShadowBkgd(Color.White, (int)fDestWidth + 10, (int)fDestHeight + 10);

            LinearGradientBrush gradientBrush = new LinearGradientBrush(new RectangleF(fStartX, fStartY, fDestWidth - fStartX, fDestHeight - fStartY),
                   pnlTextGradient1.BackColor, pnlTextGradient2.BackColor, LinearGradientMode.Vertical);

            m_PngOutlineText.TextGradOutline(gradientBrush, pnlTextOutLineColor1.BackColor, pnlTextOutLineColor2.BackColor, ShadowThickness, gradientType);

            m_PngOutlineText.GdiDrawString(e.Graphics, m_LogFont, txtDisplayText.Text, new Point(10, 10));

            //e.Graphics.DrawImage(m_PngOutlineText.GetPngImage(), new Point(0, 0));
            this.BackColor = Color.White;

            Image bmp = new Bitmap((int)fDestWidth, (int)fDestHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //picText.BackColor = pnlBackgroundColor.BackColor;
                // draw in bmp using g
                g.DrawImage(m_PngOutlineText.GetPngImage(), new Point(-8, -15));
            }
            //bmp.Save(filename);
            picText.Image = bmp;
            brushBkgnd.Dispose();
            e.Graphics.Dispose();
        }


        private void nudShadowThickness_ValueChanged(object sender, EventArgs e)
        {
            ShadowThickness = (int)nudShadowThickness.Value;
            this.Invalidate();
        }

        private void btnDrawText_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnTextOutLineColor1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextOutLineColor1.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void btnTextOutLineColor2_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextOutLineColor2.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void btnTextGradient2_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextGradient2.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void btnTextGradient1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextGradient1.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void btnShawdowColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlShadowColor.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void rbShowShadow_CheckedChanged(object sender, EventArgs e)
        {
            ShowShadow = true;
            this.Invalidate();
        }

        private void rbHideShadow_CheckedChanged(object sender, EventArgs e)
        {
            ShowShadow = false;
            this.Invalidate();
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextGradient1.BackColor = colorDialog1.Color;
            this.Invalidate();
        }
    }
}
