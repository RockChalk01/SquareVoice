using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareVoice
{
    public class ActionLoadPage : ActionItem
    {
        public ActionLoadPage(string page)
        {
            PageName = page;
        }
        public const string staticActionName = "Load Page";
        public override string ActionName { get { return staticActionName; } }
        public string PageName;
        public override void Trigger(object sender, EventArgs e)
        {
            var arg = e as System.Windows.Forms.MouseEventArgs;
            if (null == arg || arg.Button != System.Windows.Forms.MouseButtons.Left)
            {
                return;
            }
            
            GridPage gp = GridPage.GetInstance();
            gp.load(PageName);
        }
        public override void Edit() 
        {
            LoadPage loadPageDialog = new LoadPage(GridPage.GetInstance().mHelpers, this.PageName);
            loadPageDialog.ShowDialog();
            if (null != loadPageDialog.PageToLoad)
            {
                this.PageName = loadPageDialog.PageToLoad;
            }
        }

        public override string ToString()
        {
            return ActionName + " (" + PageName + ")";
        }
    }

    public class ActionLoadPageFactory: ActionItemFactory
    {
        public override ActionItem getActionItem() { return new ActionLoadPage("<none>"); }
        public override string getActionName { get {return ActionLoadPage.staticActionName;}}
        public override string ToString()
        {
            return getActionName;
        }
    }

}
