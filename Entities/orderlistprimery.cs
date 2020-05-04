using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Entities
{
    public class orderlistprimery
    {
        public virtual int orderlistprimeryID { get; }
        public virtual int orderID { get; set; }
        public virtual int costumerID { get; set; }
    }

}