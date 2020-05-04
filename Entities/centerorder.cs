using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Entities
{
    public class centerorder
    {
        public virtual int orderID { get; }
        public virtual int itemID { get; set; }
        public virtual Int64 Quantity { get; set; }
        public virtual DateTime orderdate { get; set; }
    }

}