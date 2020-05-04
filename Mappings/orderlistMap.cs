using FluentNHibernate.Mapping;
using sellsTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Mappings
{
	public class orderlistMap : ClassMap<orderlist>
	{
		public orderlistMap()
		{
			Id(x=> x.orderlistID);
			Map(x => x.orderID);
			Map(x => x.costumerID);
		
		}
	}
}