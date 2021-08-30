using DevFramwork.Core.Entiites;
using DevFramwork.Core.EntityFramworkText;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DevFramwork.Core.DataAcses.EntityFramwork
{
	public class EfEntityRepostoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{
		public TEntity Add(TEntity entity)
		{
		
			using (var context = new TContext())
			{
				var addEntity = context.Entry(entity);
				addEntity.State = EntityState.Added;
				context.SaveChanges();
				return Add(entity);
			}
		}

		public void Delete(TEntity entity)
		{
			using (var context = new TContext())
			{
				var deleteEntity = context.Entry(entity);
				deleteEntity.State = EntityState.Deleted;
				context.SaveChanges();

			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}

		public List<TEntity> Getlist(Expression<Func<TEntity, bool>> filter = null)
		{
			using (var context = new TContext())
			{
				return filter == null ? context.Set<TEntity>().ToList()
					: context.Set<TEntity>().Where(filter).ToList();
			}
		}

		public TEntity Update(TEntity entity)
		{
			using (var context = new TContext())
			{
				var updateEntity = context.Entry(entity);
				updateEntity.State = EntityState.Modified;
				context.SaveChanges();
				return Add(entity);
			}
			
		}
	}
}
