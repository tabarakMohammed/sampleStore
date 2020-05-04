using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Entities
{
    public class items
    {
        public virtual int itemID { get;}
        public virtual string itemName { get; set; }
        public virtual string itemType { get; set; }
    }

}