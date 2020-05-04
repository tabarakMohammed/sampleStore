using FluentNHibernate.Mapping;
using sellsTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sellsTask.Mappings
{
	public class costomerMap : ClassMap<costumer>
	{
		public costomerMap()
		{

			Id(x => x.costumerID);
			Map(x => x.name);
			Map(x => x.phoneNumber);
			Table("costumer");
		}
	}
}