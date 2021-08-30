using DevFramwork.Northwind.Entities.Concreate;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DevFramwork.Northwind.DataAcses.Concrete.Helpers.Mapping
{
	public class ProdutMap:ClassMap<Product>
	{
		public ProdutMap()
		{
			Table(@"Products");

			LazyLoad();

			Id(x => x.ProductId).Column("ProductID");

			Map(x => x.CartegoryId).Column("CategoryID");
			Map(x => x.ProdcutName).Column("ProdcutName");
			Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
			Map(x => x.UnitPrice).Column("UnitPrice");


		}
	
	}
}
