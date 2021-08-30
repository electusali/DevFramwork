using DevFramwork.Core.Entiites;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramwork.Northwind.Entities.Concreate
{
	public class Product : IEntity
	{
		public virtual int ProductId { get; set; }
		public virtual string ProdcutName { get; set; }
		public virtual int CartegoryId { get; set; }
		public virtual string QuantityPerUnit { get; set; }
		public virtual decimal UnitPrice { get; set; }

	}
}
