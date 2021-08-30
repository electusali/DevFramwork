using DevFramwork.Core.DataAcses.Nhbirnate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace DevFramwork.Northwind.DataAcses.Concrete.Helpers
{
	public class SqlServerHelpers : NhibernateHelper
	{
		protected override ISessionFactory InitalizeFactory()
		{
			return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012

				.ConnectionString(c => c.Database("Northwind")))
				.Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
				.BuildSessionFactory();
		}
	}
}
