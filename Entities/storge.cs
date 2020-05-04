using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

  namespace sellsTask.Entities
{
    public class storge
    {
        public virtual int storgeID { get; set; }
        public virtual int itemID { get; set; }
        public virtual Int64 Quantity { get; set; }
        public virtual string storeName { get; set; }
    }

}