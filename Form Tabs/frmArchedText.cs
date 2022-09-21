using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicsWorkshop.Form_Tabs
{
    public partial class frmArchedText : Form
    {
        public frmArchedText()
        {
            InitializeComponent();
        }

        private Font TheFont;
        private float font_height;
        private int TheWidth = 0;
        private bool FillCircleColor = false;
        private bool RotateText = false;

        public bool DrawBorder { get; private set; }

        private bool DrawCenterCircle = false;
        private bool Draw3DCircle = false;
        private bool DrawRoundImage = false;
        private int BorderThickness = 5;
        private PictureBox pb = new PictureBox();
        private bool showBorder = false;
        private static Image CircleImage;

        private void frmArchedText_Load(object sender, EventArgs e)
        {
            font_height = 24;
            TheFont = new Font("Times New Roman", font_height, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFontSample.Font = TheFont;
            lblFontSample.ForeColor = Color.Blue;
            cmbArchText.SelectedIndex = 0;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            string FontString = TheFont.Name + ", " + TheFont.Size + ", " + TheFont.Style.ToString();
            lblSelectedFont.Text = FontString;
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = TheFont;
            DialogResult result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                TheFont = fontDialog1.Font;
                font_height = TheFont.Size;
                lblFontSample.Font = font;
                string FontString = TheFont.Name + ", " + TheFont.Size + ", " + TheFont.Style.ToString();
                lblSelectedFont.Text = FontString;

                if (picArchedText.Image == null)
                    return;

                if (picArchedText.Width > 100)
                    picArchedText.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            btnDrawText.PerformClick();
        }

        private void btnFontColor1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pnlFontColor.BackColor = colorDialog1.Color;
                // TextColor = colorDialog1.Color
                lblFontSample.ForeColor = colorDialog1.Color;
            }
        }

        private void btnCircleBorderColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
                pnlBorderColor.BackColor = colorDialog1.Color;

            if (picArchedText.Image == null)
                return;

            btnDrawText.PerformClick();
        }

        private void btnCenterCircleColor1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
                pnlCircleColor1.BackColor = colorDialog1.Color;

            if (picArchedText.Image == null)
                return;

            btnDrawText.PerformClick();
        }

        private void btnCenterCircleColor2_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
                pnlCircleColor2.BackColor = colorDialog1.Color;

            if (picArchedText.Image == null)
                return;

            btnDrawText.PerformClick();
        }

        private void btnCenterCircleColor3_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
                pnlCircleColor3.BackColor = colorDialog1.Color;

            if (picArchedText.Image == null)
                return;

            btnDrawText.PerformClick();
        }

        private void nudBorderThickness_ValueChanged(object sender, EventArgs e)
        {
            BorderThickness = (int)nudBorderThickness.Value;
        }

        // Private Sub ckbShowBorderColor_CheckedChanged(sender As Object, e As EventArgs)
        // btnCircleBorderColor.Enabled = ckbShowBorderColor.Checked
        // End Sub

        // Private Sub ckb3D_CheckedChanged(sender As Object, e As EventArgs)
        // btnCenterCircleColor2.Enabled = ckb3D.Checked
        // btnCenterCircleColor3.Enabled = ckb3D.Checked
        // End Sub

        private void btnDrawText_Click(object sender, EventArgs e)
        {
            picArchedText.SizeMode = PictureBoxSizeMode.AutoSize;

            switch (cmbArchText.SelectedIndex)
            {
                case 0:
                    {
                        picArchedText.Image = DrawFullCircle();
                        break;
                    }

                case 1:
                    {
                        picArchedText.Image = DrawFullCircle();
                        break;
                    }

                case 2:
                    {
                        picArchedText.Image = DrawFullCircle();
                        break;
                    }

                case 3:
                    {
                        picArchedText.Image = DrawFullCircle();
                        break;
                    }

                case 4:
                    {
                        picArchedText.Image = DrawTopText(false);
                        break;
                    }

                case 5:
                    {
                        picArchedText.Image = DrawBottomText(false);
                        break;
                    }

                case 6:
                    {
                        picArchedText.Image = DrawBottomText(true);
                        break;
                    }

                case 7:
                    {
                        picArchedText.Image = DrawTopText(true);
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        private void btnAddTextToDesinger_Click(object sender, EventArgs e)
        {
            if (picArchedText.Image != null)
                frmGraphicDesigner.ArchedImage = picArchedText.Image;

            this.Close();
        }

        private void cmbArchText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArchText.SelectedIndex == -1)
                return;

            grpBorder.Enabled = false;
            grp3dCircle.Enabled = false;
            CkbRotateText.Checked = false;
            DrawBorder = false;
            DrawCenterCircle = false;
            Draw3DCircle = false;
            DrawRoundImage = false;
            showBorder = false;
            FillCircleColor = false;

            switch (cmbArchText.SelectedIndex)
            {
                case 0 // Full Circle Text Only
               :
                    {
                        grpBorder.Enabled = false;
                        grp3dCircle.Enabled = false;
                        return;
                    }

                case 1 // Full Circle Text With Center Circle Only
               :
                    {
                        DrawCenterCircle = true;
                        return;
                    }

                case 2 // Full Circle Text With Image
               :
                    {
                        DialogResult result = ofd.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            CircleImage = Image.FromFile(ofd.FileName);
                            DrawRoundImage = true;
                        }

                        return;
                    }

                case 3 // Full Circle With Border Color And 3d Center
               :
                    {
                        DrawCenterCircle = true;
                        DrawBorder = true;
                        Draw3DCircle = true;
                        FillCircleColor = true;
                        showBorder = true;

                        grpBorder.Enabled = true;
                        grp3dCircle.Enabled = true;
                        return;
                    }

                case 4 // Arch Text Top Down
               :
                    {
                        grpBorder.Enabled = false;
                        grp3dCircle.Enabled = false;
                        return;
                    }

                case 5 // Arch Text Bottom UP
               :
                    {
                        grpBorder.Enabled = false;
                        grp3dCircle.Enabled = false;
                        return;
                    }

                case 6 // Arch Text Left Side
               :
                    {
                        grpBorder.Enabled = false;
                        grp3dCircle.Enabled = false;
                        return;
                    }

                case 7 // Arch Text Right Side
               :
                    {
                        grpBorder.Enabled = false;
                        grp3dCircle.Enabled = false;
                        return;
                    }
            }
        }

        private Bitmap DrawFullCircle()
        {
            PictureBox pb = new PictureBox();
            Graphics g = pb.CreateGraphics();
            string s = txtTop.Text;

            if (txtTop.Text.Length > txtTop.Text.Length)
                s = txtTop.Text;

            MeasureCharacters(g, TheFont, s);
            float radius = (float)(Math.Min(TheWidth, TheWidth) / (double)2 - font_height * 2);
            float cx = (float)(TheWidth / (double)2 - 10);
            float cy = (float)(TheWidth / (double)2 - 10);
            int Size = System.Convert.ToInt32((TheWidth - TheFont.Height));
            Bitmap bm = new Bitmap(Size, Size);
            // Dim SmallestRectangle As Rectangle = New Rectangle(0, 0, Size, Size)

            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(Color.White);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.TextRenderingHint = TextRenderingHint.AntiAlias;
                gr.CompositingQuality = CompositingQuality.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (TheFont)
                {
                    DrawTextOnCircle(gr, TheFont, new SolidBrush(pnlFontColor.BackColor), radius, cx, cy, txtTop.Text, txtTop.Text);

                    if (RotateText)
                        bm = RotateBitmap(bm, 90);

                    if (DrawCenterCircle)
                        gr.DrawEllipse(new Pen(new SolidBrush(pnlFontColor.BackColor)), cx - radius, cy - radius, 2 * radius, 2 * radius);

                    if (FillCircleColor)
                    {
                        if (showBorder)
                        {
                            RectangleF rectF = new RectangleF(cx - radius, cy - radius, 2 * radius, 2 * radius);
                            gr.FillEllipse(new SolidBrush(pnlBorderColor.BackColor), rectF);

                            RectangleF rectF1 = new RectangleF(cx - radius + BorderThickness, cy - radius + BorderThickness, 2 * radius - BorderThickness * 2, 2 * radius - BorderThickness * 2);

                            if (Draw3DCircle)
                            {
                                gr.FillEllipse(new SolidBrush(pnlBorderColor.BackColor), rectF);
                                Point pt1 = new Point(System.Convert.ToInt32(rectF1.X), System.Convert.ToInt32(rectF1.Y));
                                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectF1, pnlCircleColor1.BackColor, pnlCircleColor3.BackColor, LinearGradientMode.Vertical);
                                ColorBlend cblend = new ColorBlend(3);
                                cblend.Colors = new Color[3] { pnlCircleColor1.BackColor, pnlCircleColor2.BackColor, pnlCircleColor3.BackColor };
                                cblend.Positions = new float[3] { 0F, 0.5F, 1.0F };
                                linearGradientBrush.InterpolationColors = cblend;
                                gr.FillEllipse(linearGradientBrush, rectF1);
                            }
                            else
                                gr.FillEllipse(new SolidBrush(pnlCircleColor1.BackColor), rectF1);
                        }
                        else
                            gr.FillEllipse(new SolidBrush(pnlCircleColor1.BackColor), cx - radius, cy - radius, 2 * radius, 2 * radius);
                    }
                    else if (DrawRoundImage)
                    {
                        Bitmap RoundBM = (Bitmap)CropToCircle(CircleImage);
                        gr.DrawImage(RoundBM, cx - radius, cy - radius, 2 * radius, 2 * radius);
                    }
                }
            }

            bm.MakeTransparent(Color.Transparent);
            g.Dispose();

            return bm;
        }

        private Bitmap DrawCenterImage(Bitmap img, RectangleF CircRect)
        {
            Bitmap BM = new Bitmap(img);
            Int16 x = (short)(CircRect.X + 6);
            Int16 y = (short)(CircRect.Y + 6);
            using (Graphics GraphicsObject = Graphics.FromImage(img))
            {
                CircleImage = ResizeImage((Bitmap)CircleImage, 200, 200);
                GraphicsObject.DrawImage(CircleImage, x, y);
            }
            return BM;
        }

        private Bitmap DrawTopText(bool right)
        {
            Graphics g = pb.CreateGraphics();
            MeasureCharacters(g, TheFont, txtTop.Text);
            float radius = (float)(Math.Min(TheWidth, TheWidth) / (double)2 - font_height * 2);
            float cx = (float)(TheWidth / (double)2 - 10);
            float cy = (float)(TheWidth / (double)2 - 10);
            int Size = System.Convert.ToInt32((TheWidth - TheFont.Height));
            int Width = Convert.ToInt16(Size);
            int Height = Convert.ToInt16(Size / (double)2 + TheFont.Height);

            Bitmap bm = new Bitmap(Width, Height);

            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(Color.White);
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.TextRenderingHint = TextRenderingHint.AntiAlias;

                using (TheFont)
                    DrawTextOnCircle(gr, TheFont, new SolidBrush(pnlFontColor.BackColor), radius, cx, cy, txtTop.Text, string.Empty);
            }

            g.Dispose();
            bm.MakeTransparent(Color.Transparent);

            if (right)
                bm = RotateBitmap(bm, 90);

            return bm;
        }

        private Bitmap DrawBottomText(bool Left)
        {
            Graphics g = pb.CreateGraphics();
            MeasureCharacters(g, TheFont, txtTop.Text);
            float radius = (float)(Math.Min(TheWidth, TheWidth) / (double)2 - font_height * 2);
            float cx = (float)(TheWidth / (double)2 - 10);
            float cy = (float)(TheWidth / (double)2 - 10);
            int Size = System.Convert.ToInt32((TheWidth - TheFont.Height));
            int Width = Convert.ToInt16(Size);
            int Height = Convert.ToInt16(Size / (double)2);
            Bitmap bm = new Bitmap(Width, Height);

            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(Color.White);
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.TextRenderingHint = TextRenderingHint.AntiAlias;

                using (TheFont)
                    DrawTextOnCircle(gr, TheFont, new SolidBrush(pnlFontColor.BackColor), radius, cx, (float)(cy / (double)2 - TheFont.Height * 2 - TheFont.Height / (double)2), string.Empty, txtTop.Text);
            }

            bm.MakeTransparent(Color.Transparent);
            g.Dispose();

            if (Left)
                bm = RotateBitmap(bm, 90);

            return bm;
        }

        private void DrawTextOnCircle(Graphics gr, Font font, Brush brush, float radius, float cx, float cy, string top_text, string bottom_text)
        {
            using (StringFormat string_format = new StringFormat())
            {
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Far;
                double radians_to_degrees = 180.0 / Math.PI;
                List<RectangleF> rects = MeasureCharacters(gr, font, top_text);
                // Dim width_query As Single = From rect In rects Select rect.Width

                float width_query = 0;
                //RectangleF Rect;

                foreach (RectangleF Rect in rects)
                    width_query += Rect.Width;

                float text_width = width_query;
                double width_to_angle = 1 / (double)radius;
                double start_angle = -Math.PI / 2 - text_width / (double)2 * width_to_angle;
                double theta = start_angle;

                for (int i = 0; i <= top_text.Length - 1; i++)
                {
                    theta += rects[i].Width / (double)2 * width_to_angle;
                    double x = cx + radius * Math.Cos(theta);
                    double y = cy + radius * Math.Sin(theta);
                    gr.RotateTransform(System.Convert.ToSingle((radians_to_degrees * (theta + Math.PI / 2))));
                    gr.TranslateTransform(System.Convert.ToSingle(x), System.Convert.ToSingle(y), MatrixOrder.Append);
                    gr.DrawString(top_text[i].ToString(), font, brush, 0, 0, string_format);
                    gr.ResetTransform();
                    theta += rects[i].Width / (double)2 * width_to_angle;
                }

                width_query = 0;

                rects = MeasureCharacters(gr, font, bottom_text);

                foreach (var Rect in rects)
                    width_query += Rect.Width;

                // width_query = From rect In rects Select rect.Width
                text_width = width_query;
                width_to_angle = 1 / (double)radius;
                start_angle = Math.PI / 2 + text_width / (double)2 * width_to_angle;
                theta = start_angle;
                string_format.LineAlignment = StringAlignment.Near;

                for (int i = 0; i <= bottom_text.Length - 1; i++)
                {
                    theta -= rects[i].Width / (double)2 * width_to_angle;
                    double x = cx + radius * Math.Cos(theta);
                    double y = cy + radius * Math.Sin(theta);
                    gr.RotateTransform(System.Convert.ToSingle((radians_to_degrees * (theta - Math.PI / 2))));
                    gr.TranslateTransform(System.Convert.ToSingle(x), System.Convert.ToSingle(y), MatrixOrder.Append);
                    gr.DrawString(bottom_text[i].ToString(), font, brush, 0, 0, string_format);
                    gr.ResetTransform();
                    theta -= rects[i].Width / (double)2 * width_to_angle;
                }
            }
        }

        private List<RectangleF> MeasureCharacters(Graphics gr, Font font, string text)
        {
            List<RectangleF> results = new List<RectangleF>();
            float x = 0;

            for (int start = 0; start <= text.Length - 1; start += 32)
            {
                int len = 32;
                if (start + len >= text.Length)
                    len = text.Length - start;
                string substring = text.Substring(start, len);
                List<RectangleF> rects = MeasureCharactersInWord(gr, substring);
                if (start == 0)
                    x += rects[0].Left;

                for (int i = 0; i <= rects.Count + 1 - 1 - 1; i++)
                {
                    RectangleF new_rect = new RectangleF(x, rects[i].Top, rects[i].Width, rects[i].Height);
                    results.Add(new_rect);
                    x += rects[i].Width;
                    TheWidth = System.Convert.ToInt32(rects[i].X);
                }
            }

            return results;
        }

        private List<RectangleF> MeasureCharactersInWord(Graphics gr, string text)
        {
            List<RectangleF> result = new List<RectangleF>();

            using (StringFormat string_format = new StringFormat())
            {
                string_format.Alignment = StringAlignment.Near;
                string_format.LineAlignment = StringAlignment.Near;
                string_format.Trimming = StringTrimming.None;
                string_format.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;
                CharacterRange[] ranges = new CharacterRange[text.Length - 1 + 1];

                for (int i = 0; i <= text.Length - 1; i++)
                    ranges[i] = new CharacterRange(i, 1);

                string_format.SetMeasurableCharacterRanges(ranges);
                TheFont = new Font(TheFont.Name, font_height, TheFont.Style, GraphicsUnit.Pixel);
                RectangleF rect = new RectangleF(0, 0, 10000, 100);
                Region[] regions = gr.MeasureCharacterRanges(text, TheFont, this.ClientRectangle, string_format);

                foreach (Region region in regions)
                    result.Add(region.GetBounds(gr));
            }

            return result;
        }

        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            Matrix rotate_at_origin = new Matrix();
            rotate_at_origin.Rotate(angle);
            PointF[] points = new[] { new PointF(0, 0), new PointF(bm.Width, 0), new PointF(bm.Width, bm.Height), new PointF(0, bm.Height) };
            rotate_at_origin.TransformPoints(points);
            float xmin = 0, xmax = 0, ymin = 0, ymax = 0;
            GetPointBounds(points, ref xmin, ref xmax, ref ymin, ref ymax);
            int wid = System.Convert.ToInt32(Math.Round(xmax - xmin));
            int hgt = System.Convert.ToInt32(Math.Round(ymax - ymin));
            Bitmap result = new Bitmap(wid, hgt);
            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle, new PointF((float)(wid / (double)2.0F), (float)(hgt / (double)2.0F)));

            using (Graphics gr = Graphics.FromImage(result))
            {
                gr.InterpolationMode = InterpolationMode.High;
                gr.Clear(bm.GetPixel(0, 0));
                gr.Transform = rotate_at_center;
                int x = (int)((wid - bm.Width) / (double)2);
                int y = (int)((hgt - bm.Height) / (double)2);
                gr.DrawImage(bm, x, y);
            }

            return result;
        }

        private void GetPointBounds(PointF[] points, ref float xmin, ref float xmax, ref float ymin, ref float ymax)
        {
            xmin = points[0].X;
            xmax = xmin;
            ymin = points[0].Y;
            ymax = ymin;

            foreach (PointF point in points)
            {
                if (xmin > point.X)
                    xmin = point.X;
                if (xmax < point.X)
                    xmax = point.X;
                if (ymin > point.Y)
                    ymin = point.Y;
                if (ymax < point.Y)
                    ymax = point.Y;
            }
        }

        public static Color medianColor(List<Color> cols)
        {
            int c = cols.Count;
            return Color.FromArgb((int)(cols.Sum(x => x.A) / (double)c), (int)(cols.Sum(x => x.R) / (double)c), (int)(cols.Sum(x => x.G) / (double)c), (int)(cols.Sum(x => x.B) / (double)c));
        }

        public List<PointF> getCorners(RectangleF r)
        {
            return new List<PointF>() { r.Location, new PointF(r.Right, r.Top), new PointF(r.Right, r.Bottom), new PointF(r.Left, r.Bottom) };
        }

        public Image CropToCircle(Image srcImage)
        {

            // Determine if with is larger than height
            Size SquaredImage = new Size(srcImage.Width, srcImage.Height);
            int SmallestSize = srcImage.Width;

            if (srcImage.Width > srcImage.Height)
                SmallestSize = srcImage.Height;

            // Get the original image. Resize to sqaure for perfect circle
            Image originalImage = ResizeImage((Bitmap)srcImage, SmallestSize, SmallestSize);

            // Create a new, blank image with the same dimensions.
            Bitmap croppedImage = new Bitmap(originalImage.Width, originalImage.Height);


            // draw the image into the target bitmap

            // Graphics.DrawImage(Image, 0, 0, result.Width, result.Height);

            // Prepare to draw on the new image.
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                GraphicsPath path = new GraphicsPath();

                // Create an ellipse that fills the image in both directions.
                path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height);

                Region reg = new Region(path);

                // Draw only within the specified ellipse.
                g.Clip = reg;
                g.DrawImage(originalImage, Point.Empty);
            }
            // croppedImage.SetResolution = 
            // Display the new image.
            // PictureBox2.Image = croppedImage
            // Dim SquaredImage As Size = New Size(srcImage.Width, srcImage.Height)

            // If srcImage.Width > srcImage.Height Then
            // SquaredImage.Height = srcImage.Width
            // End If

            // If srcImage.Height > srcImage.Width Then
            // SquaredImage.Width = srcImage.Height
            // 'Create a new, blank image with the same dimensions.
            // End If

            // Dim dstImage As Image = New Bitmap(SquaredImage.Width, SquaredImage.Height, srcImage.PixelFormat)
            // Dim g As Graphics = Graphics.FromImage(dstImage)

            // Using br As Brush = New SolidBrush(Color.Transparent)
            // g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height)
            // End Using

            // Dim path As GraphicsPath = New GraphicsPath()
            // path.AddEllipse(0, 0, dstImage.Width, dstImage.Height)
            // g.SetClip(path)
            // g.DrawImage(srcImage, 0, 0)
            return croppedImage;
        }

        public static Bitmap ResizeImage(Bitmap InputBitmap, int width, int height)
        {
            return new Bitmap(InputBitmap, new Size(width, height));
        }

        //private void CkbRotateText_CheckedChanged(object sender, EventArgs e)
        //{
        //    RotateText = CkbRotateText.Checked;
        //}

        //private void ckbCircleText_CheckedChanged(object sender, EventArgs e)
        //{
        //    DrawCenterCircle = ckbCircleText.Checked;
        //}
    }
}

