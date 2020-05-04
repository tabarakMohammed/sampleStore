using FluentNHibernate.Mapping;
using sellsTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Mappings
{
	public class orderlistprimeryMap : ClassMap<orderlistprimery>
	{
		public orderlistprimeryMap()
		{
			//Table("storge");
			Id(x=> x.orderlistprimeryID);
			Map(x => x.orderID);
			Map(x => x.costumerID);
			
		}
	}
}