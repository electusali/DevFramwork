using DevFramwork.Northwind.DataAcses.EntityFramwork.Mapping;
using DevFramwork.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DevFramwork.Northwind.DataAcses.EntityFramwork
{
	public class NorthwindContext:DbContext
	{
		public NorthwindContext()
		{
			Database.SetInitializer<NorthwindContext>(null);
		}
		public DbSet<Product> products { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new ProductMap());
		}
	}
}
