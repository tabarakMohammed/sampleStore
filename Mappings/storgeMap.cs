using FluentNHibernate.Mapping;
using sellsTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Mappings
{
	public class storgeMap : ClassMap<storge>
	{
		public storgeMap()
		{
			//Table("storge");
			Id(x=> x.storgeID);
			Map(x => x.itemID);
			Map(x => x.Quantity);
			Map(x => x.storeName);
		}
	}
}