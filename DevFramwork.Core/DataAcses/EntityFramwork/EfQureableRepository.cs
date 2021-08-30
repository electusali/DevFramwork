using DevFramwork.Core.Entiites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DevFramwork.Core.DataAcses.EntityFramwork
{
	public class EfQureableRepository<T> : IQuareble<T> where T : class, IEntity, new()
	{
		DbContext _dbContext;
		IDbSet<T> _entites;
		public EfQureableRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IQuareble<T> Table => (IQuareble<T>)this.Entites;

		protected virtual IDbSet<T> Entites
		{
			get { return _entites ?? (_entites = _dbContext.Set<T>()); }
		}
	}
}
