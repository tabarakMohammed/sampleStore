using FluentNHibernate.Mapping;
using sellsTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Mappings
{
    public class saveOrderLmap : ClassMap<saveOrderL>
    {
        public  saveOrderLmap()
        {
            Id(x=> x.orderID);
            Map(x => x.storgeId);
            Map(x => x.costId);
            Map(x => x.itemId);
            Map(x => x.quntity);
            Map(x => x.orderdate);
        }
    }
}