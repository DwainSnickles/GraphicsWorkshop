using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsWorkshop.Form_Tabs
{
    public partial class frmText : Form
    {
        private float font_height;
        public Font TheFont { get; set; }
        public Color TextColor { get; private set; }
        public SolidBrush Textbrush { get; private set; }

        //used for passing data to designer form
        private frmGraphicDesigner mainForm = null;

        public frmText(Form callingForm)
        {
            mainForm = callingForm as frmGraphicDesigner;
            InitializeComponent();
        }


        public frmText()
        {
            InitializeComponent();
            font_height = 24;
            TheFont = new Font("San Serif, ", font_height, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFontSample.Font = TheFont;
            lblFontDetails.Text = string.Format("{0}", TheFont.Name + " FontSize = " + TheFont.Size);
            lblFontSample.ForeColor = Color.Blue;
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TheFont = lblFontSample.Font;
            Properties.Settings.Default.TheFontColor = lblFontSample.ForeColor;
            Properties.Settings.Default.TheText = lblFontSample.Text;
            Properties.Settings.Default.TheLabel = lblFontSample;
            
            //mainForm.LabelText = txtMessage.Text;
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pnlFontColor.BackColor = colorDialog1.Color;
                TextColor = colorDialog1.Color;
                lblFontSample.ForeColor = TextColor;
                Textbrush = new SolidBrush(TextColor);
                Invalidate();
            }
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = TheFont;
            DialogResult result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                TheFont = fontDialog1.Font;
                font_height = TheFont.Size;
                lblFontSample.Font = font;
                lblFontDetails.Text = string.Format("{0}", font.Name + " " + font.Size);
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            lblFontSample.Text = txtMessage.Text;
        }

        private void frmText_Load(object sender, EventArgs e)
        {
            //mainForm = new frmGraphicDesigner();
            frmText frm = new frmText(this);
            //frmText(Form callingForm)
            //mainForm = callingForm as frmGraphicDesigner;
        }

        private void btnAddText_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            
        }
    }
}
