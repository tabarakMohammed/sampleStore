using FluentNHibernate.Mapping;
using sellsTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Mappings
{
	public class centerorderMap : ClassMap<centerorder>
	{
		public centerorderMap()
		{
			//Table("storge");
			Id(x=> x.orderID);
			Map(x => x.itemID);
			Map(x => x.Quantity);
			Map(x => x.orderdate);
		}
	}
}