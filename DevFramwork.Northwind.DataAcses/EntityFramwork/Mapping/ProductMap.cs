using DevFramwork.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

using System.Text;

namespace DevFramwork.Northwind.DataAcses.EntityFramwork.Mapping
{
	public class ProductMap:EntityTypeConfiguration<Product>
	{
		public ProductMap()
		{
			ToTable(@"Products",@"dbo");
			HasKey(x => x.ProductId);

			Property(x => x.ProductId).HasColumnName("ProductId");
			Property(x => x.CartegoryId).HasColumnName("CategoryId");
			Property(x => x.ProdcutName).HasColumnName("ProdcutName");
			Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
			Property(x => x.UnitPrice).HasColumnName("UnitPrice");
		}
	}
}
