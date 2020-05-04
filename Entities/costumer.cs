using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Entities
{
    public class costumer
    {
        public virtual int costumerID { get;}
        public virtual string name { get; set; }
        public virtual Int64 phoneNumber { get; set; }
    }

}