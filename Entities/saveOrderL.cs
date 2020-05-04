using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Entities
{
    public class saveOrderL
    {

     
        public virtual int orderID { get; }
        public virtual int costId { get; set; }
        public virtual int itemId { get; set; }
        public virtual int quntity { get; set; }
        public virtual DateTime orderdate { get; set; }
        public virtual int storgeId { get; set; }
        // public virtual string costmerName { get; set; }
        // public virtual string itemName { get; set; }

    }
}