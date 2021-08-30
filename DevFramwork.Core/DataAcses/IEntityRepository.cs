﻿using DevFramwork.Core.Entiites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DevFramwork.Core.DataAcses
{
	public interface IEntityRepository<T> where T:class ,IEntity,new()
	{
		List<T> Getlist(Expression<Func<T,bool>> filter=null);

		T Get(Expression<Func<T, bool>> filter);

		T Add(T entity);

		T Update(T entity);

		void Delete(T entity);
	}
}
