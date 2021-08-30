using DevFramwork.Core.Entiites;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramwork.Core.DataAcses.Nhbirnate
{
	public class NhQureblaRepository<T> : IQuareble<T> where T : class, IEntity, new()
	{
		NhibernateHelper _nhibernateHelper;
		IQuareble<T> _entites;
		public NhQureblaRepository(NhibernateHelper nhibernateHelper)
		{
			_nhibernateHelper = nhibernateHelper;
		}


		public IQuareble<T> Table => this.Entities;

		public virtual IQuareble<T> Entities
		{
			get
			{
				return _entites ?? (_entites = (IQuareble<T>)_nhibernateHelper.OpenSesion().Query<T>());
			}
		}

	}
}
