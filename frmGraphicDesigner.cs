using Microsoft.MSDN.Samples.GraphicObjects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//has code needed if missing
//C:\Users\dwain\OneDrive\Desktop\DesignSurface Old\DesignSurface\DesignSurfaceTest.sln

namespace GraphicsWorkshop
{
    public partial class frmGraphicDesigner : Form
    {

        //frmArched Text Variables
        public static Image ArchedImage { get; internal set; }

        //Graphic Designer Form Variables
        public int intObjectCount { get; set; }
        // private Font addFont = Font;
        private Color addFontColor = Color.Black;
        // 'Holds the object selected
        //private GraphicObjects objSelected;
        // 'Holds the images path 
        public string strImagePath;
        //private Boolean m_ShowGrid = true;
        // 'Holds Total Images added
        //private int intObjectCount;
        //private int NewHeight, NewWidth, ImageObjectWith, ImageOjectHeight;
        //private string P_Orientation;
        //// 'Hold the Page width and Height etc
        //private double P_Width, P_Height, M_Left, M_Right, M_Top, M_Bottom;
        private string ImgPath;
        List<string> RecentFilepaths = new List<string>();
        private RibbonButton ribbonButton;
        int RecentButtonNumber = 1;


        //private string strFileName;
        //private bool blnLandscape, CanCutObject;
        //private GraphicObjects ImgRedone = null/* TODO Change to default(_) if this is not a reference type */;
        public Font addFont { get; set; }


        public frmGraphicDesigner()
        {
            InitializeComponent();
        }

        #region Display Orientation

        private void btnPortrait_Click(object sender, EventArgs e)
        {
            //920, 825
            this.Height = 853;
            this.Width = 915;
            dsSurface.Orientation = Microsoft.Msdn.Samples.DesignSurface.DesignSurface.SurfaceOrientation.Portrait;
            this.Invalidate();
        }

        private void btnLandscape_Click(object sender, EventArgs e)
        {
            //1060, 680
            this.Height = 708;
            this.Width = 1060;
            dsSurface.Orientation = Microsoft.Msdn.Samples.DesignSurface.DesignSurface.SurfaceOrientation.LandScape;
            this.Invalidate();
        }

        private void btnShowGrid_Click(object sender, EventArgs e)
        {
            dsSurface.ShowGrid = true;
            this.Invalidate();
        }

        private void btnHideGrid_Click(object sender, EventArgs e)
        {
            dsSurface.ShowGrid = true;
            this.Invalidate();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            //designSurface1.
        }

        #endregion
        #region Ribbon Button Related

        #region Quick Access Bar click Events

        private void btnQuickPrintQA_Click(object sender, EventArgs e)
        {
            dsSurface.PrintGraphics();
        }

        private void btnQuickSaveQA_Click(object sender, EventArgs e)
        {
            dsSurface.SaveGraphics();
        }

        private void btnquickExitQA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion
        #region Orb Click Procedures

        private void ClearGridObjects()
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to remove all the graphic elements from the design surface?", "Confirm Clear All Elements", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                dsSurface.DeleteAllObjects();
                dsSurface.SelectedObject = null;
                // Reset ImageCount to 0
                this.intObjectCount = 0;
                sbObjectCount.Text = intObjectCount.ToString() + "  Images Loaded";
                Invalidate();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void BbtnOpenImage_Click(object sender, EventArgs e)
        {
            dsSurface.OpenGraphic();
        }

        private void btnSaveAsImage_Click(object sender, EventArgs e)
        {
            dsSurface.SaveGraphics();
        }

        private void btnSaveObjects_Click(object sender, EventArgs e)
        {

        }

        private void btnPrinterSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnQuickPrint_CanvasChanged(object sender, EventArgs e)
        {
            dsSurface.PrintGraphics();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            dsSurface.PrintPreview();
        }
        #endregion
        #region Main Toolbar Click Events

        private void btnClearGrid_Click_1(object sender, EventArgs e)
        {
            ClearGridObjects();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            dsSurface.OpenGraphic();
        }

        private void btnOpenSavedObjects_Click(object sender, EventArgs e)
        {

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            //dsSurface.PasteGraphicImage;
            //dsSurface.AddImageObject();
            //dsSurface.SelectedObjectChanged();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (dsSurface.SelectedObject == null)
                return;
            dsSurface.DeleteSelectedObject(dsSurface.SelectedObject);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dsSurface.SelectedObject != null)
                ImgPath = dsSurface.SelectedObject.ImagePath;
        }

        private void btnSendToBack_Click(object sender, EventArgs e)
        {
            if (dsSurface.SelectedObject != null)
                dsSurface.SelectedObject.SendToBack(this.dsSurface.SelectedObject);
            dsSurface.Invalidate();
        }

        private void btnBringToFront_Click(object sender, EventArgs e)
        {
            if (dsSurface.SelectedObject != null)
                dsSurface.SelectedObject.BringToFront(this.dsSurface.SelectedObject);
            dsSurface.Invalidate();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            dsSurface.Redo();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            dsSurface.Undo();
        }

        private void btnFillBackground_Click(object sender, EventArgs e)
        {
            AddObject("Fill", false);
        }

        private void btnBacgroundImage_Click(object sender, EventArgs e)
        {
            AddObject("BackgroundImage",false);
        }

        private void SendObjectToBack()
        {
            if (dsSurface.SelectedObject != null)
                dsSurface.SelectedObject.SendToBack(this.dsSurface.SelectedObject);
            dsSurface.Invalidate();
        }

        private void BringObjectToFront()
        {
            if (dsSurface.SelectedObject != null)
                dsSurface.SelectedObject.BringToFront(this.dsSurface.SelectedObject);
            dsSurface.Invalidate();
        }


        #endregion

        #endregion
        #region Stantard text Tab
        private void AddObject(string ObjectType, bool Redo, string ImagePath = null, string LabelText = null)
        {
            this.Cursor = Cursors.WaitCursor;
            // Create a new graphic object
            GraphicObjects gObj = null/* TODO Change to default(_) if this is not a reference type */;
            // Add 1 To image count to track images
            this.intObjectCount += 1;

            if (ImagePath != null)
                strImagePath = ImagePath;

            switch (ObjectType)
            {
                case "Linked":
                    {
                        LinkedImageGraphic myLinkedImage = new LinkedImageGraphic(0, 0, strImagePath);
                        gObj = myLinkedImage;
                        gObj.AutoSize = true;
                        break;
                    }

                case "Text":
                    {
                        TextGraphic myTextObject = new TextGraphic(new Point(0, 0), Properties.Settings.Default.TheText, Properties.Settings.Default.TheFont, Properties.Settings.Default.TheFontColor);
                        gObj = myTextObject;
                        gObj.AutoSize = true;
                        break;
                    }

                case "Fill":// Allow the background to be colored
                    {
                        RectangleGraphic myRectangle = new RectangleGraphic(dsSurface.SurfaceMargins.X, dsSurface.SurfaceMargins.Y, dsSurface.SurfaceMargins.Width, dsSurface.SurfaceMargins.Height);
                        myRectangle.Fill = true;
                        colorPicker.ShowDialog();
                        myRectangle.FillColor = colorPicker.Color;
                        gObj = myRectangle;
                        break;
                    }

                case "BackGroundImage" // Allow the background to have an image fit to Surface
         :
                    {
                        this.ofdImage.ShowDialog();

                        if (ofdImage.FileName != null)
                        {
                            strImagePath = ofdImage.FileName;
                            BackGroundImageGraphic myBackgroundImage = new BackGroundImageGraphic(0, 0, strImagePath); // (CInt(Me.coordX.Value), _
                            gObj = myBackgroundImage;

                            // This sets the new image Size
                            gObj.Height = dsSurface.SurfaceBounds.Height;
                            gObj.Width = dsSurface.SurfaceBounds.Width;
                            gObj.AutoSize = false;
                        }

                        break;
                    }

                default:
                    {
                        Interaction.MsgBox("Program Error");
                        break;
                    }
            }

            if (gObj != null)
            {
                // Add the object to the designer
                dsSurface.drawingObjects.Add(gObj);
                dsSurface.Update();
                dsSurface.SelectedObject = gObj;
                //dsSurface.SelectedObject.ImageType = ObjectType;
                //dsSurface.SelectedObject.ImageName = ObjectType + intObjectCount.ToString();
                //dsSurface.SelectedObject.ImageNumber = intObjectCount;
                dsSurface.SelectedObject.ImagePath = strImagePath;
                //dsSurface.addGraphic(gObj);
                dsSurface.Invalidate();
            }

            if (intObjectCount > 0)
            {
                btnCut.Enabled = true;
                mnuCut.Enabled = true;
            }
            else
            {
                btnCut.Enabled = false;
                mnuCut.Enabled = false;
            }
            // PropertyGrid1.SelectedObject = dsSurface.SelectedObject
            this.Cursor = Cursors.Default;
        }

        private void frmGraphicDesigner_Load(object sender, EventArgs e)
        {
            //ribbonMain.OrbDropDown.RecentItems.Add()
            RecentFilepaths.Add("FilesPath 1");
            RecentFilepaths.Add("FilesPath 2");
            RecentFilepaths.Add("FilesPath 3");

            foreach (var item in RecentFilepaths)
            {
                ADDRecentFilePath(item);
            }
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                Interaction.MsgBox("Please enter the message and try again.", MsgBoxStyle.Critical, "Text Error");
                return;
            }
            {
                var withBlock = fontChooser;
                withBlock.ShowDialog();
                {
                    var withBlock1 = this.fontChooser;
                    lblSample.Font = withBlock1.Font;
                    addFont = withBlock1.Font;
                    addFontColor = pnlFontColor.BackColor;
                    lblSample.ForeColor = pnlFontColor.BackColor;
                    lblFontDetails.Text = lblSample.Font.Name + ", " + withBlock1.Font.SizeInPoints.ToString() + " pts";
                    Properties.Settings.Default.TheFont = lblSample.Font;
                }
                // txtMessage.Invalidate()
                lblSample.Text = txtMessage.Text;
                lblSample.Invalidate();

            }

        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            var withBlock = colorPicker;
            withBlock.ShowDialog();
            addFontColor = withBlock.Color;
            lblSample.ForeColor = withBlock.Color;
            pnlFontColor.BackColor = lblSample.ForeColor;
            pnlFontColor.Invalidate();
            Properties.Settings.Default.TheFontColor = pnlFontColor.BackColor;
            lblSample.Invalidate();

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToDesigner_Click(object sender, EventArgs e)
        {
            AddObject("Text", false);
        }
        #endregion
        #region RecentFiles for Ribbon
        void ADDRecentFilePath(string FilePath)
        {
            string buttonName = "ribbonButton";
            this.ribbonButton = new System.Windows.Forms.RibbonButton();
            ribbonButton.Name = buttonName + RecentButtonNumber.ToString();
            RecentButtonNumber++;
            ribbonButton.SmallImage = ((System.Drawing.Image)(Properties.Resources.AddimageSmall));
            ribbonButton.Text = FilePath;
            this.ribbonButton.Click += new System.EventHandler(this.RecentsFilesPath_Click);
            ribbonMain.OrbDropDown.RecentItems.Add(ribbonButton);
            this.Invalidate();
        }

        private void RecentsFilesPath_Click(object sender, EventArgs e)
        {
            var result = sender as RibbonButton;
            MessageBox.Show(result.Text);

        }
        #endregion
        /// <summary>
        /// Takes the label converts it to image and displays it on surface
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public Bitmap TextToImage(Label label)
        {
            Bitmap BM = new Bitmap(label.Width, label.Height);
            SolidBrush brush1 = new SolidBrush(label.ForeColor);

            using (Graphics gr = Graphics.FromImage(BM))
            {
                gr.DrawImage(BM, 0, 0, new Rectangle(label.Location.X, label.Location.Y, label.Width, label.Height), GraphicsUnit.Pixel);
                BM.MakeTransparent();
                gr.DrawString(label.Text, label.Font, brush1, new Point(0, 0));
            }

            //dsSurface.AddObject(GraphicObject.ObjectTypes.EmbeddedImageGraphic);
            return BM;
        }

        public static Image ResizeImage(Image InputImage, int Width, int Height)
        {
            return new Bitmap(InputImage, new Size(Width, Height));
        }


    }
}

