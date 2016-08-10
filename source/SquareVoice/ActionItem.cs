using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareVoice
{
    public class ActionItem
    {
        //TODO: remove ActionName;
        public virtual string ActionName { get { return "Base Action"; } }
        public virtual void Trigger(object sender, EventArgs e) { }
        public virtual void Edit() { throw new NotImplementedException(); }
        public override string ToString()
        {
            return ActionName;
        }

    }

    public class ActionItemFactory
    {
        public virtual ActionItem getActionItem() { return null; }
        public virtual string getActionName {get {return null;}}
    }
}
