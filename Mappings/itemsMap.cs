using FluentNHibernate.Mapping;
using sellsTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Mappings
{
    public class itemsMap : ClassMap<items>
	{
		public itemsMap()
		{
			//Table("items");
			Id(x => x.itemID);
			Map(x => x.itemName);
			Map(x => x.itemType);
		}
    
    }
}