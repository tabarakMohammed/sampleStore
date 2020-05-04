using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Entities
{
    public class orderlist
    {
        public virtual int orderlistID { get; }
        public virtual int orderID { get; set; }
        public virtual int costumerID { get; set; }
       
    }

}