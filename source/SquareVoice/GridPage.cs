using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using EyeXFramework;
using System.Threading;


namespace SquareVoice
{


    public partial class GridPage : Form
    {
        public Helpers mHelpers;
        private GridPageObj mPage;
        //private System.ComponentModel.IContainer cellContainer;
        public Dictionary<PictureBox, GridItemObj> mGridItemLookupTable;
        private static GridPage mInstance;
        private EyeXFramework.Forms.BehaviorMap behaviorMap;
        private bool isEnableToggleDepressed = false;

        public static GridPage GetInstance()
        {
            return mInstance;
        }

        public void createNewPage(string pageName)
        {

            GridPageObj page = new GridPageObj();
            page.rows = 2;
            page.cols = 2;
            page.name = pageName + ".SquareVoice";

            mPage = page;

            fixCells();
            savePage();
            applyPage();
            return;
        }


        private void loadSamplePage()
        {

            GridPageObj page = new GridPageObj();
            page.rows = 2;
            page.cols = 2;
            page.name = "autogen.SquareVoice";
            

            GridItemObj gi1 = new GridItemObj();
            gi1.image = "1.png";
            gi1.text = "one";
            gi1.xPos = 0;
            gi1.yPos = 0;
            gi1.color = System.Drawing.Color.Beige;
            gi1.Actions.Add(new ActionSpeakText("Goodbye"));
            page.gridItems.Add(gi1);

            GridItemObj gi2 = new GridItemObj();
            gi2.image = "2.png";
            gi2.text = "two";
            gi2.xPos = 0;
            gi2.yPos = 1;
            page.gridItems.Add(gi2);

            GridItemObj gi3 = new GridItemObj();
            gi3.image = "3.png";
            gi3.text = "three";
            gi3.xPos = 1;
            gi3.yPos = 0;
            page.gridItems.Add(gi3);

            GridItemObj gi4 = new GridItemObj();
            gi4.image = "4.png";
            gi4.text = "four";
            gi4.xPos = 1;
            gi4.yPos = 1;
            page.gridItems.Add(gi4);

            mPage = page;
            return;
        }

        public GridPage(string pageConfiguration)
        {
            mInstance = this;

            //this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            InitializeComponent();

            var components = new System.ComponentModel.Container();

            behaviorMap = new EyeXFramework.Forms.BehaviorMap(components);
            Program.EyeXHost.Connect(behaviorMap);

            var components2 = new System.ComponentModel.Container();
            var behaviorMap2  = new EyeXFramework.Forms.BehaviorMap(components);
            Program.EyeXHost.Connect(behaviorMap2);

            mHelpers = new Helpers();
            loadSamplePage();
            savePage();
            load("PrcIndex.SquareVoice");



        }

        public void savePage()
        {
            //Base object1 = new Base() { name = "Object1" };
            //Derived object2 = new Derived() { something = "Some other thing" };
            //List<Base> inheritanceList = new List<Base>() { object1, object2 };

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
            string Serialized = JsonConvert.SerializeObject(mPage, settings);
            //List<Base> deserializedList = JsonConvert.DeserializeObject<List<Base>>(Serialized, settings);

            string pageFileName = Path.Combine(mHelpers.mPagesDir, mPage.name);
            //System.IO.File.Delete(pageFileName);
            System.IO.File.WriteAllText(pageFileName, Serialized);
            return;
        }
        public void load(string page)
        {
            loadPage(page);
            applyPage();
        }

        private void loadPage(string pageFileName)
        {
            //Base object1 = new Base() { name = "Object1" };
            //Derived object2 = new Derived() { something = "Some other thing" };
            //List<Base> inheritanceList = new List<Base>() { object1, object2 };

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            //string Serialized = JsonConvert.SerializeObject(mPage, settings);
            string pageFullFileName = Path.Combine(mHelpers.mPagesDir, pageFileName);

            string Serialized = System.IO.File.ReadAllText(pageFullFileName);

            mPage = JsonConvert.DeserializeObject<GridPageObj>(Serialized, settings);

            mPage.name = pageFileName;
            return;
        }


        private void applyPage()
        {


            this.Text = "SquareVoice (" + Helpers.pageNameToDisplayName(mPage.name) + ")";
            behaviorMap.Dispose();
            behaviorMap = null;
            var components = new System.ComponentModel.Container();
            behaviorMap = new EyeXFramework.Forms.BehaviorMap(components);

            

            this.SuspendLayout();
            this.tablePanel.SuspendLayout();

            tablePanel.ColumnCount = mPage.cols;
            tablePanel.RowCount = mPage.rows;

            tablePanel.RowStyles.Clear();
            mGridItemLookupTable = new Dictionary<PictureBox, GridItemObj>();

            for (int a = 0; a < tablePanel.RowCount; a++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / tablePanel.RowCount));
            }

            tablePanel.ColumnStyles.Clear();
            for (int a = 0; a < tablePanel.ColumnCount; a++)
            {
                tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tablePanel.ColumnCount));
            }

            this.tablePanel.Controls.Clear();

            foreach (var cell in mPage.gridItems)
            {
                applyCell(cell);
            }

            this.tablePanel.ResumeLayout();
            this.ResumeLayout(false);

            Program.EyeXHost.TriggerActivationModeOff();

            Task.Run(() => ReEnableEyeGaze(2000, behaviorMap));

        }

        private void populateBehaviorMap()
        {
            if (null != behaviorMap)
            {
                behaviorMap.Dispose();
                behaviorMap = null;
            }
            var components = new System.ComponentModel.Container();
            behaviorMap = new EyeXFramework.Forms.BehaviorMap(components);

            for (int col = 0; col < mPage.cols; col++)
            {
                for (int row = 0; row < mPage.rows; row++)
                {
                    var control = this.tablePanel.GetControlFromPosition(col, row);
                    if (null != control)
                    {
                        var cell = control.Tag as GridItemObj;
                        if (null != cell)
                        {
                            if (cell.isEnabled && !isEnableToggleDepressed)
                            {
                                behaviorMap.Add(control, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 400 });
                            }
                        }
                    }
                }
            }
        }

        private void applyCell(GridItemObj cell)
        {
            if (null != behaviorMap)
            {
                behaviorMap.Dispose(); // get rid of this before we start to modify a cell...
                behaviorMap = null;
            }

            // If there's already a control in this position, nuke it!
            var control = this.tablePanel.GetControlFromPosition(cell.xPos, cell.yPos);
            if (null != control)
            {
                this.tablePanel.Controls.Remove(control);
            }

            //var flp = new System.Windows.Forms.FlowLayoutPanel();
            var flp = new System.Windows.Forms.TableLayoutPanel();
            flp.ColumnCount = 1;
            flp.RowCount = 2;
            flp.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
            flp.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            flp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            flp.Margin = new System.Windows.Forms.Padding(0);

            flp.Anchor =
                ((System.Windows.Forms.AnchorStyles)((((
                System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));

            var cellPb = new System.Windows.Forms.PictureBox();
            flp.Controls.Add(cellPb, 0, 0);

            var cellTextPb = new System.Windows.Forms.PictureBox();

            cellTextPb.Margin = new System.Windows.Forms.Padding(0);

            Image i = new Bitmap(1200, 100);
            Graphics g = Graphics.FromImage(i);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(cell.text, new Font("Arial", 68), Brushes.Black, new PointF(i.Width / 2, i.Height / 2), stringFormat);
            if (cell.isEnabled)
            {
                cellTextPb.Image = i;
            }
            g.Dispose();
            cellTextPb.Dock = DockStyle.Fill;
            cellTextPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            cellTextPb.Tag = cell;

            flp.Controls.Add(cellTextPb, 0, 1);
            flp.Tag = cell;


            cellPb.Dock = DockStyle.Fill;
            cellPb.BackColor = System.Drawing.Color.Transparent;
            if (null != cell.image && cell.isEnabled)
            {
                //string imageFileName = Path.Combine(mHelpers.mImagesDir, cell.image);
                //cellPb.Image = Image.FromFile(imageFileName);
                cellPb.Image = mHelpers.imageNameToImage(cell.image);
            }
            else
            {
                cellPb.Image = null;
            }
            cellPb.TabStop = false;
            cellPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            cellPb.Tag = cell;

            mGridItemLookupTable.Add(cellPb, cell);

            string simplePageName = mPage.name;
            simplePageName = simplePageName.Replace(".SquareVoice", "");

            ContextMenu cm = new ContextMenu();
            cm.Tag = cell;
            //miImage
            MenuItem miEnabled = new MenuItem("&Enabled", new EventHandler(EnabledEventHandler));
            miEnabled.Checked = cell.isEnabled;
            miEnabled.Tag = cell;
            cm.MenuItems.Add(miEnabled);

            //cm.MenuItems.Add("Edit Cell", new EventHandler(EditCellEventHandler));
            MenuItem miEditCell = new MenuItem("Edit Cell", new EventHandler(EditCellEventHandler));
            miEditCell.Tag = cell;
            cm.MenuItems.Add(miEditCell);

            //cm.MenuItems.Add("-");
            MenuItem miPage = new MenuItem("&Page");
            cm.MenuItems.Add(miPage);
            MenuItem miPageName = new MenuItem("Page: " + simplePageName);
            miPageName.Enabled = false;
            miPage.MenuItems.Add(miPageName);
            miPage.MenuItems.Add("&New Page", new EventHandler(NewPageEventHandler));
            miPage.MenuItems.Add("&Load Page", new EventHandler(LoadPageEventHandler));
            miPage.MenuItems.Add("&Copy Page");
            miPage.MenuItems.Add("&Rename");
            miPage.MenuItems.Add("Add Column", new EventHandler(AddColumn));
            miPage.MenuItems.Add("Remove Column", new EventHandler(RemoveColumn));
            miPage.MenuItems.Add("Add Row", new EventHandler(AddRow));
            miPage.MenuItems.Add("Remove Row", new EventHandler(RemoveRow));


            //cellPb.ContextMenu = cm;
            flp.ContextMenu = cm;

            ActionHandler actHandler = new ActionHandler(this, cell);


            //if (cell.isEnabled || isEnableToggleDepressed)
            //{
                flp.Click += new System.EventHandler(actHandler.Trigger);
                cellTextPb.Click += new System.EventHandler(actHandler.Trigger);
                cellPb.Click += new System.EventHandler(actHandler.Trigger);

            //}

            populateBehaviorMap();

            flp.BackColor = System.Drawing.Color.Beige;
            //this.tablePanel.Controls.Add(cellPb, cell.xPos, cell.yPos);
            this.tablePanel.Controls.Add(flp, cell.xPos, cell.yPos);
        }

        public class ActionHandler
        {
            GridPage mPage;
            GridItemObj mCell;

            public ActionHandler(GridPage page, GridItemObj cell)
            {
                mPage = page;
                mCell = cell;
            }

            public void Trigger(object sender, EventArgs e)
            {
                if (mPage.isEnableToggleDepressed)
                {
                    mCell.isEnabled = !mCell.isEnabled;
                    mPage.applyCell(mCell);
                    //mPage.applyPage();
                }
                else
                {
                    if (mCell.isEnabled)
                    {
                        foreach (var action in mCell.Actions)
                        {
                            action.Trigger(sender, e);
                        }
                    }
                }
            }
        }

        private async Task ReEnableEyeGaze(int delayInMilliseconds, EyeXFramework.Forms.BehaviorMap behaviorMap)
        {
            //System.Media.SystemSounds.Beep.Play();

            await Task.Delay(delayInMilliseconds);
            //System.Media.SystemSounds.Beep.Play();
            Program.EyeXHost.Connect(behaviorMap);

            Program.EyeXHost.TriggerActivationModeOn();

        }

        private void GridPage_Load(object sender, EventArgs e)
        {

        }

        private void NullEventHandler(object sender, EventArgs e) { }
        private void AddRow(object sender, EventArgs e)
        {
            if (mPage.rows >= Helpers.MAX_ROWS)
                return;
            mPage.rows++;
            fixCells();
            this.applyPage();
            savePage();
        }
        private void RemoveRow(object sender, EventArgs e)
        {
            if (mPage.rows <= 1)
                return;
            mPage.rows--;
            fixCells();
            this.applyPage();
            savePage();
        }
        private void AddColumn(object sender, EventArgs e)
        {
            if (mPage.cols >= Helpers.MAX_COLUMNS)
                return;
            mPage.cols++;
            fixCells();
            this.applyPage();
            savePage();
        }
        private void RemoveColumn(object sender, EventArgs e)
        {
            if (mPage.cols <= 1)
                return;
            mPage.cols--;
            fixCells();
            this.applyPage();
            savePage();
        }
        private void SelectImage(object sender, EventArgs e) 
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = mHelpers.mImagesDir;
            openFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;

                string imageName = mHelpers.imagePathToName(fn);

                MenuItem mi = sender as MenuItem;
                if (null == mi)
                {
                    throw new Exception("sender is not a picturebox");
                }
                
                //var cell = mGridItemLookupTable[mi];

                GridItemObj cell = mi.Tag as GridItemObj;
                if (null == cell)
                {
                    throw new Exception ("cell not found");
                }

                cell.image = imageName;
                this.applyPage();
            }
            savePage();
        }
        private void SavePageHandler(object sender, EventArgs e) 
        {
            savePage();
        }

        private void EditCellEventHandler(object sender, EventArgs e) 
        {
            var mi = sender as MenuItem;
            if (mi != null)
            {
                GridItemObj cell = mi.Tag as GridItemObj;
                if (null == cell)
                {
                    throw new Exception("mi tag is not a cell!");
                }
                EditCell cellEditor = new EditCell(this, cell);

                cellEditor.ShowDialog();
                applyPage();
                savePage();
            }
        }
        private void NewPageEventHandler(object sender, EventArgs e)
        {
            NewPage newPage = new NewPage(this);
            newPage.ShowDialog();
        }
        private void LoadPageEventHandler(object sender, EventArgs e)
        {
            LoadPage loadPageDialog = new LoadPage(this.mHelpers);
            loadPageDialog.ShowDialog();
            if (null != loadPageDialog.PageToLoad)
            {
                this.loadPage(loadPageDialog.PageToLoad);
                this.applyPage();
            }
        }
        private void EnabledEventHandler(object sender, EventArgs e) 
        {
            var menuItem = sender as MenuItem;
            if (null == menuItem)
            {
                throw new Exception("sender isn't a menuitem.");
            }
            var cell = menuItem.Tag as GridItemObj;

            if (null == cell)
            {
                throw new Exception("cell is null!");
            }
            cell.isEnabled = !cell.isEnabled;
            savePage();
            applyPage();

        }
        //private void NullEventHandler(object sender, EventArgs e) { }
        //private void NullEventHandler(object sender, EventArgs e) { }
        private void fixCells()
        {
            for (int c = 0; c < mPage.cols; c++)
            {
                for (int r = 0; r < mPage.rows; r++)
                {
                    List<GridItemObj> cellsToDelete = new List<GridItemObj>();
                    bool foundCell = false;
                    foreach (var cell in mPage.gridItems)
                    {
                        if (cell.xPos == c && cell.yPos == r)
                        {
                            System.Diagnostics.Debug.Assert(foundCell == false, "duplicate cells found!");
                            foundCell = true;
                        }
                        if (cell.xPos >= mPage.cols || cell.yPos >= mPage.rows)
                        {
                            cellsToDelete.Add(cell);
                        }
                    }
                    foreach (var cell in cellsToDelete)
                    {
                        // this delete logic really doesn't need to be in the outer loops.
                        mPage.gridItems.Remove(cell);
                    }
                    if (false == foundCell)
                    {
                        // create a dummy cell
                        GridItemObj dummy = new GridItemObj();
                        dummy.image = null;
                        dummy.text = "blank";
                        dummy.xPos = c;
                        dummy.yPos = r;
                        dummy.color = System.Drawing.Color.Beige;
                        mPage.gridItems.Add(dummy);
                    }
                }
            }
        }
        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var control = sender as Control;
            if (control != null)
            {
            //    panel.BorderStyle = (e.HasGaze) ? BorderStyle.FixedSingle : BorderStyle.None;
            //}
            //var picBox = sender as PictureBox;
            //if (control != null)
            //{
                control.BackColor = (e.HasGaze) ? Color.Yellow : Color.Transparent;
                //control.BorderStyle = (e.HasGaze) ? BorderStyle.FixedSingle : BorderStyle.None;


                if (e.HasGaze)
                {
                    GridItemObj cell = control.Tag as GridItemObj;
                    if (null == cell)
                    {
                        throw new Exception("control tag is not a cell!");
                    }
                    List<ActionItem> actions = cell.Actions;

                    foreach (var action in actions)
                    {
                        action.Trigger(control, new System.Windows.Forms.MouseEventArgs(MouseButtons.Left,0,0,0,0)); 
                    }
                    //if (picBox == pictureBoxYes)
                    //{
                    //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"yes.wav");
                    //    player.Play();
                    //}
                    //if (picBox == pictureBoxNo)
                    //{
                    //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"no.wav");
                    //    player.Play();
                    //}
                }
            }
        }

        private void NavBackButton_SizeChanged(object sender, EventArgs e)
        {
            var button = sender as Control;
            if (null != button)
            {
                if (button.Width != button.Height)
                {
                    button.Width = button.Height;
                }
            }
        }

        private void NavBar_SizeChanged(object sender, EventArgs e)
        {
            for (int a=0; a < NavBar.ColumnStyles.Count-1; a++)
            {
                if (NavBar.ColumnStyles[a].Width != NavBar.Height*1.5f)
                {
                    NavBar.ColumnStyles[a].Width = NavBar.Height * 1.5f;
                }
            }
        }

        private void HomeButton_Click(object sender, System.EventArgs e)
        {
            load("PrcIndex.SquareVoice");
            applyPage();
        }

        private void HomeButton_MouseDown(object sender, MouseEventArgs e)
        {
            HomeButton.Image = global::SquareVoice.Properties.Resources.HouseDepressed;
        }

        private void HomeButton_MouseUp(object sender, MouseEventArgs e)
        {
            HomeButton.Image = global::SquareVoice.Properties.Resources.House;
        }

        private void EnableToggle_Click(object sender, System.EventArgs e)
        {
            // toggle the state
            isEnableToggleDepressed = !isEnableToggleDepressed;

            // now act on it.
            if (isEnableToggleDepressed)
            {
                EnableToggle.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                EnableToggle.BackColor = System.Drawing.Color.Transparent;                
            }

            // enable/ disable eye gaze
            if (isEnableToggleDepressed)
            {
                populateBehaviorMap();
            }
            else
            {
                applyPage(); // TODO: Why doesn't populateBehaviorMap work here?
                // ran into an issue where eyegaze isn't working properly
                // if we only call populateBehaviorMap here.  But, a full refresh
                // of the page does work.  It adds an unnecessary screen refresh.
            }

        }


    }

    public class PageObj
    {
        public string name;
        public float controlBarHeight = 5.0f;      

    }

    public class GridItemObj
    {
        public GridItemObj()
        {
            Actions = new List<ActionItem>();
            isEnabled = true;
        }
        public int xPos;
        public int yPos;
        public string image;
        public string text;
//        public string spokenText;
        public bool isEnabled;
        public Color color;
        public List<ActionItem> Actions;
    }

    public class GridPageObj : PageObj
    {
        public GridPageObj()
        {
            gridItems = new List<GridItemObj>();
        }
        public int cols;
        public int rows;
        public List<GridItemObj> gridItems;
    }




}
