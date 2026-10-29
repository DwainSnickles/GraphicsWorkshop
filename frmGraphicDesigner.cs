using Microsoft.MSDN.Samples.GraphicObjects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
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
        // The object the Copy button took, kept so Paste can add a duplicate of it
        private GraphicObjects copiedObject;
        List<string> RecentFilepaths = new List<string>();
        private RibbonButton ribbonButton;
        int RecentButtonNumber = 1;


        //private string strFileName;
        //private bool blnLandscape, CanCutObject;
        //private GraphicObjects ImgRedone = null/* TODO Change to default(_) if this is not a reference type */;
        public Font addFont { get; set; }


        // Saving frmGraphicDesigner from the Visual Studio designer drops the ribbon's tab and
        // panel captions, which leaves the ribbon collapsed to a 27px caption bar with no labels.
        // These are the captions the designer should be holding; they are put back when missing.
        private static readonly Dictionary<string, string> RibbonCaptions = new Dictionary<string, string>
        {
            { "ribbonTab1", "Design Surface Toolbar" },
            { "ribbonTab2", "Start" },
            { "ribbonPanel1", "Clipboard" },
            { "ribbonPanel2", "Files" },
            { "ribbonPanel3", "Edits" },
            { "ribbonPanel4", "Object Orientation" },
            { "ribbonPanel5", "Background" },
            { "ribbonPanel6", "Grid Orientation" },
            { "ribbonPanel7", "Files" },
            { "ribbonPanel8", "Clipboard" },
            { "ribbonPanel9", "Object Orientation" },
            { "ribbonPanel10", "Edits" },
            { "ribbonPanel11", "Background" },
            { "ribbonPanel12", "Grid Orientation" }
        };

        // The Start tab's own artwork is a set of fully transparent 32x32 placeholders, so its
        // panels come up with no icons at all. Each of its buttons borrows the art of the button
        // that does the same job on the Design Surface Toolbar tab.
        private static readonly Dictionary<string, string> StartTabIcons = new Dictionary<string, string>
        {
            { "ribbonButton20", "ribbonButton8" },          // Files
            { "ribbonButton21", "btnOpenImage" },           // Files > Open Images
            { "ribbonButton22", "btnOpenSavedObjects" },    // Files > Open Saved Objects
            { "ribbonButton23", "ribbonButton1" },          // Paste
            { "ribbonButton24", "ribbonButton1" },          // Paste, drop down entry
            { "ribbonButton26", "btnCut" },
            { "ribbonButton27", "btnCopy" },
            { "ribbonButton28", "btnPaste" },
            { "ribbonButton29", "btnBringToFront" },        // Front
            { "ribbonButton30", "btnSendToBack" },          // Back
            { "ribbonButton31", "btnRedo" },
            { "ribbonButton32", "btnUndo" },
            { "ribbonButton33", "btnFillBackground" },      // Fill
            { "ribbonButton34", "btnBacgroundImage" },      // Image
            { "ribbonButton35", "btnPortrait" },
            { "ribbonButton16", "btnLandscape" },
            { "ribbonButton13", "btnClearGrid" },
            { "ribbonButton14", "btnShowGrid" },
            { "ribbonButton15", "btnHideGrid" }
        };

        public frmGraphicDesigner()
        {
            InitializeComponent();
            RestoreRibbonCaptions();
            CopyStartTabIcons();
            RestoreRibbonLargeImages();
            RestoreRibbonSmallImages();
            AlignRibbonButtonText();
            FitRibbonCaptions();
        }

        // Only fills in captions that are missing, so a panel renamed on purpose is left alone
        private void RestoreRibbonCaptions()
        {
            foreach (RibbonTab tab in ribbonMain.Tabs)
            {
                if (string.IsNullOrEmpty(tab.Text))
                    tab.Text = CaptionFor(tab.Name);

                foreach (RibbonPanel panel in tab.Panels)
                {
                    if (string.IsNullOrEmpty(panel.Text))
                        panel.Text = CaptionFor(panel.Name);
                }
            }
        }

        private static string CaptionFor(string name)
        {
            string caption;
            return name != null && RibbonCaptions.TryGetValue(name, out caption) ? caption : null;
        }

        private void CopyStartTabIcons()
        {
            var buttons = new Dictionary<string, RibbonButton>();
            foreach (RibbonTab tab in ribbonMain.Tabs)
            {
                foreach (RibbonPanel panel in tab.Panels)
                    CollectButtons(panel.Items, buttons);
            }

            foreach (var pair in StartTabIcons)
            {
                RibbonButton target, source;
                if (!buttons.TryGetValue(pair.Key, out target) || !buttons.TryGetValue(pair.Value, out source))
                    continue;

                if (source.Image == null)
                    continue;

                target.LargeImage = source.Image;
                target.SmallImage = IsBlankImage(source.SmallImage) ? null : source.SmallImage;
            }
        }

        // Cut, Copy, Paste, Front and Back carry their real artwork in the 16x16 small image and
        // have a blank 32x32 placeholder for the large one, so Large size mode draws nothing at
        // all. Blow the small icon up to fill the large slot instead.
        private void RestoreRibbonLargeImages()
        {
            foreach (RibbonTab tab in ribbonMain.Tabs)
            {
                foreach (RibbonPanel panel in tab.Panels)
                {
                    foreach (RibbonItem item in panel.Items)
                    {
                        var button = item as RibbonButton;
                        if (button == null || !IsBlankImage(button.Image) || IsBlankImage(button.SmallImage))
                            continue;

                        button.LargeImage = FitToIcon(button.SmallImage, 32);
                    }
                }
            }
        }

        private static void CollectButtons(RibbonItemCollection items, Dictionary<string, RibbonButton> into)
        {
            foreach (RibbonItem item in items)
            {
                var button = item as RibbonButton;
                if (button == null)
                    continue;

                into[button.Name] = button;

                if (button.DropDownItems != null)
                    CollectButtons(button.DropDownItems, into);
            }
        }

        // A button only paints LargeImage in Large size mode. Once the ribbon runs out of width it
        // squeezes items to Medium or Compact, which paint SmallImage instead - and several of the
        // buttons in the designer file carry a blank 16x16 placeholder there, so they lose their
        // icon entirely. Derive a small image from the large one for any that are blank.
        private void RestoreRibbonSmallImages()
        {
            foreach (RibbonTab tab in ribbonMain.Tabs)
            {
                foreach (RibbonPanel panel in tab.Panels)
                    ShrinkBlankSmallImages(panel.Items);
            }
        }

        private static void ShrinkBlankSmallImages(RibbonItemCollection items)
        {
            foreach (RibbonItem item in items)
            {
                var button = item as RibbonButton;
                if (button == null)
                    continue;

                if (IsBlankImage(button.SmallImage) && button.Image != null)
                    button.SmallImage = FitToIcon(button.Image, 16);

                if (button.DropDownItems != null)
                    ShrinkBlankSmallImages(button.DropDownItems);
            }
        }

        private static bool IsBlankImage(Image image)
        {
            if (image == null)
                return true;

            using (var pixels = new Bitmap(image))
            {
                for (int y = 0; y < pixels.Height; y++)
                {
                    for (int x = 0; x < pixels.Width; x++)
                    {
                        if (pixels.GetPixel(x, y).A > 8)
                            return false;
                    }
                }
            }

            return true;
        }

        private static Image FitToIcon(Image image, int side)
        {
            double scale = Math.Min(side / (double)image.Width, side / (double)image.Height);
            int width = Math.Max(1, (int)Math.Round(image.Width * scale));
            int height = Math.Max(1, (int)Math.Round(image.Height * scale));

            var icon = new Bitmap(side, side, PixelFormat.Format32bppArgb);
            using (var g = Graphics.FromImage(icon))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(image, (side - width) / 2, (side - height) / 2, width, height);
            }

            return icon;
        }

        // A caption made of more than one word is broken onto a second line when the button is
        // narrower than the text, which is what happened to Clear Grid, Show Grid and Hide Grid.
        // Give those buttons a minimum width that fits their caption on one line.
        private void FitRibbonCaptions()
        {
            foreach (RibbonTab tab in ribbonMain.Tabs)
            {
                foreach (RibbonPanel panel in tab.Panels)
                {
                    foreach (RibbonItem item in panel.Items)
                    {
                        var button = item as RibbonButton;
                        if (button == null || string.IsNullOrEmpty(button.Text) || button.Text.IndexOf(' ') < 0)
                            continue;

                        int textWidth = TextRenderer.MeasureText(button.Text, ribbonMain.Font).Width;
                        button.MinimumSize = new Size(textWidth + 12, 0);
                    }
                }
            }
        }

        #region Display Orientation

        private void btnPortrait_Click(object sender, EventArgs e)
        {
            //920, 825
            this.Height = 853;
            this.Width = 915;
            graphicsSurface.GridPortrait();
            this.Invalidate();
        }

        private void btnLandscape_Click(object sender, EventArgs e)
        {
            //1060, 680
            this.Height = 708;
            this.Width = 1060;
            graphicsSurface.GridLandscape();
            this.Invalidate();
        }

        private void btnShowGrid_Click(object sender, EventArgs e)
        {
            graphicsSurface.GridShown = true;
            this.Invalidate();
        }

        private void btnHideGrid_Click(object sender, EventArgs e)
        {
            graphicsSurface.GridShown = false;
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
            graphicsSurface.PrintGraphics();
        }

        private void btnQuickSaveQA_Click(object sender, EventArgs e)
        {
            graphicsSurface.SaveGraphics();
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
                graphicsSurface.DeleteAllObjects();
                graphicsSurface.SelectedObject = null;
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
            graphicsSurface.OpenGraphic();
        }

        private void btnSaveAsImage_Click(object sender, EventArgs e)
        {
            graphicsSurface.SaveGraphics();
        }

        private void btnSaveObjects_Click(object sender, EventArgs e)
        {

        }

        private void btnPrinterSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnQuickPrint_CanvasChanged(object sender, EventArgs e)
        {
            graphicsSurface.PrintGraphics();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            graphicsSurface.PrintPreview();
        }
        #endregion
        #region Main Toolbar Click Events

        private void btnClearGrid_Click_1(object sender, EventArgs e)
        {
            ClearGridObjects();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            graphicsSurface.OpenGraphic();
        }

        // Saved objects are the files the surface writes with SaveGraphics (one .dat holding a
        // whole object collection). Opening one adds its objects to the current surface instead of
        // replacing what is already drawn, so the work on the surface is never thrown away.
        private void btnOpenSavedObjects_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Open Saved Objects";
                dialog.Filter = "Saved objects (*.dat)|*.dat|All files (*.*)|*.*";
                dialog.DefaultExt = "dat";
                dialog.InitialDirectory = Application.StartupPath;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                GraphicObjectCollection savedObjects;
                try
                {
                    var formatter = new BinaryFormatter();
                    using (var stream = File.OpenRead(dialog.FileName))
                        savedObjects = (GraphicObjectCollection)formatter.Deserialize(stream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The objects in this file could not be opened." + Environment.NewLine + ex.Message,
                        "Open Saved Objects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (savedObjects == null || savedObjects.Count == 0)
                    return;

                graphicsSurface.drawingObjects.AddRange(savedObjects);
                graphicsSurface.SelectedObject = null;

                this.intObjectCount += savedObjects.Count;
                sbObjectCount.Text = intObjectCount.ToString() + "  Images Loaded";
                btnCut.Enabled = true;
                mnuCut.Enabled = true;

                graphicsSurface.Invalidate();
            }
        }

        // Paste duplicates the object Copy took, offset a little so it does not land exactly on
        // top of the original. If the copy only had an image path, add that image instead.
        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (copiedObject == null)
            {
                if (!string.IsNullOrEmpty(ImgPath))
                    AddObject("Linked", false, ImgPath);

                return;
            }

            GraphicObjects pasted = CloneObject(copiedObject);
            if (pasted == null)
                return;

            pasted.SetPosition(new Point(pasted.X + 20, pasted.Y + 20));
            graphicsSurface.drawingObjects.Add(pasted);
            graphicsSurface.SelectedObject = pasted;

            this.intObjectCount += 1;
            sbObjectCount.Text = intObjectCount.ToString() + "  Images Loaded";
            btnCut.Enabled = true;
            mnuCut.Enabled = true;

            graphicsSurface.Invalidate();
        }

        // A shallow copy keeps the position, size, rotation and picture, and works for every
        // object type on the surface. The cached Graphics must not be shared with the original.
        private static GraphicObjects CloneObject(GraphicObjects source)
        {
            var clone = (GraphicObjects)typeof(GraphicObjects)
                .GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic)
                .Invoke(source, null);

            var cachedGraphics = typeof(GraphicObjects).GetField("m_Graphics", BindingFlags.Instance | BindingFlags.NonPublic);
            if (cachedGraphics != null)
                cachedGraphics.SetValue(clone, null);

            return clone;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (graphicsSurface.SelectedObject == null)
                return;
            graphicsSurface.DeleteSelectedObject();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (graphicsSurface.SelectedObject == null)
                return;

            ImgPath = graphicsSurface.SelectedObject.ImagePath;
            copiedObject = graphicsSurface.SelectedObject;
        }

        private void btnSendToBack_Click(object sender, EventArgs e)
        {
            if (graphicsSurface.SelectedObject != null)
                graphicsSurface.SelectedObject.SendToBack(this.graphicsSurface.SelectedObject);
            graphicsSurface.Invalidate();
        }

        private void btnBringToFront_Click(object sender, EventArgs e)
        {
            if (graphicsSurface.SelectedObject != null)
                graphicsSurface.SelectedObject.BringToFront(this.graphicsSurface.SelectedObject);
            graphicsSurface.Invalidate();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            graphicsSurface.Redo();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            graphicsSurface.Undo();
        }

        private void btnFillBackground_Click(object sender, EventArgs e)
        {
            AddObject("Fill", false);
        }

        private void btnBacgroundImage_Click(object sender, EventArgs e)
        {
            AddObject("BackGroundImage",false);
        }

        private void SendObjectToBack()
        {
            if (graphicsSurface.SelectedObject != null)
                graphicsSurface.SelectedObject.SendToBack(this.graphicsSurface.SelectedObject);
            graphicsSurface.Invalidate();
        }

        private void BringObjectToFront()
        {
            if (graphicsSurface.SelectedObject != null)
                graphicsSurface.SelectedObject.BringToFront(this.graphicsSurface.SelectedObject);
            graphicsSurface.Invalidate();
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

                case "CircularTextImage":// Arched or circular text rendered in the tab, held in memory
                    {
                        EmbeddedImageGraphic myCircularText = new EmbeddedImageGraphic(0, 0, ArchedImage);
                        gObj = myCircularText;
                        gObj.AutoSize = true;
                        // The image is embedded, so it must not inherit the path of an image opened earlier
                        strImagePath = null;
                        break;
                    }

                case "Fill":// Allow the background to be colored
                    {
                        RectangleGraphic myRectangle = new RectangleGraphic(graphicsSurface.SurfaceMargins.X, graphicsSurface.SurfaceMargins.Y, graphicsSurface.SurfaceMargins.Width, graphicsSurface.SurfaceMargins.Height);
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
                            gObj.Height = graphicsSurface.SurfaceBounds.Height;
                            gObj.Width = graphicsSurface.SurfaceBounds.Width;
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
                graphicsSurface.drawingObjects.Add(gObj);
                graphicsSurface.Update();
                graphicsSurface.SelectedObject = gObj;
                //graphicsSurface.SelectedObject.ImageType = ObjectType;
                //graphicsSurface.SelectedObject.ImageName = ObjectType + intObjectCount.ToString();
                //graphicsSurface.SelectedObject.ImageNumber = intObjectCount;
                graphicsSurface.SelectedObject.ImagePath = strImagePath;
                //graphicsSurface.addGraphic(gObj);
                graphicsSurface.Invalidate();
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
            // PropertyGrid1.SelectedObject = graphicsSurface.SelectedObject
            this.Cursor = Cursors.Default;
        }

        private void frmGraphicDesigner_Load(object sender, EventArgs e)
        {
            archedTextTab.AddToDesigner += ArchedText_AddToDesigner;

            //ribbonMain.OrbDropDown.RecentItems.Add()
            RecentFilepaths.Add("FilesPath 1");
            RecentFilepaths.Add("FilesPath 2");
            RecentFilepaths.Add("FilesPath 3");

            foreach (var item in RecentFilepaths)
            {
                ADDRecentFilePath(item);
            }
        }

        // A ribbon button draws its caption directly under its image, so a shorter icon pulls its
        // caption up out of line with the buttons beside it. Pad every large image to the tallest
        // one in the ribbon, which puts all of the captions on the same line.
        private void AlignRibbonButtonText()
        {
            var buttons = new List<RibbonButton>();
            int tallest = 0;

            foreach (RibbonTab tab in ribbonMain.Tabs)
            {
                foreach (RibbonPanel panel in tab.Panels)
                {
                    foreach (RibbonItem item in panel.Items)
                    {
                        var button = item as RibbonButton;
                        if (button == null || button.Image == null)
                            continue;

                        buttons.Add(button);
                        tallest = Math.Max(tallest, button.Image.Height);
                    }
                }
            }

            foreach (var button in buttons)
            {
                if (button.Image.Height < tallest)
                    button.LargeImage = PadImageToHeight(button.Image, tallest);
            }
        }

        private static Image PadImageToHeight(Image image, int height)
        {
            var padded = new Bitmap(image.Width, height, PixelFormat.Format32bppArgb);
            using (var g = Graphics.FromImage(padded))
            {
                g.Clear(Color.Transparent);
                g.DrawImageUnscaled(image, 0, (height - image.Height) / 2);
            }
            return padded;
        }

        private void ArchedText_AddToDesigner(object sender, EventArgs e)
        {
            AddObject("CircularTextImage", false);
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

            //graphicsSurface.AddObject(GraphicObject.ObjectTypes.EmbeddedImageGraphic);
            return BM;
        }

        public static Image ResizeImage(Image InputImage, int Width, int Height)
        {
            return new Bitmap(InputImage, new Size(Width, Height));
        }


    }
}

