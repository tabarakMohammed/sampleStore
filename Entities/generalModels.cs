using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Entities
{
    public class generalModels
    {
        public IList<costumer> allCostomer { get; set; }
        public costumer costomer { get; set; }
        public IList<storge> allStorge { get; set; }
        public storge myStorge { get; set; }
        public IList<items> allitem { get; set; }
        public items myItems { get; set; }
    }
}