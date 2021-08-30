using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramwork.Core.DataAcses.Nhbirnate
{
	public abstract class NhibernateHelper : IDisposable
	{
		static ISessionFactory _sessionFactory;

		public virtual ISessionFactory SessionFactory
		{
			get { return _sessionFactory ?? (_sessionFactory = InitalizeFactory()); }
		}

		protected abstract ISessionFactory InitalizeFactory();

		public virtual ISession OpenSesion()
		{
			return SessionFactory.OpenSession();
		}
	

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
