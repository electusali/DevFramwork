using DevFramwork.Core.DataAcses.EntityFramwork;
using DevFramwork.Core.Entiites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DevFramwork.Core.DataAcses.Nhbirnate
{
	public class NhEntityRepositoryBase <Tentity>:IEntityRepository<Tentity>
		where Tentity:class,IEntity,new()
	{
		NhibernateHelper _nhibernateHelper;

		public NhEntityRepositoryBase(NhibernateHelper nhibernateHelper)
		{
			_nhibernateHelper = nhibernateHelper;
		}

		public Tentity Add(Tentity entity)
		{
			using (var session=_nhibernateHelper.OpenSesion())
			{
				session.Save(entity);
				return entity;
			}
		}

		public void Delete(Tentity entity)
		{
			using (var session = _nhibernateHelper.OpenSesion())
			{
				session.Delete(entity);
			}
		}

		public Tentity Get(Expression<Func<Tentity, bool>> filter)
		{
			using (var session = _nhibernateHelper.OpenSesion())
			{
				return session.Query<Tentity>().SingleOrDefault(filter);			
			}
		}

		public List<Tentity> Getlist(Expression<Func<Tentity, bool>> filter = null)
		{
			using (var session = _nhibernateHelper.OpenSesion())
			{
				return filter == null
					? session.Query<Tentity>().ToList()
					: session.Query<Tentity>().Where(filter).ToList();
			}
		}

		public Tentity Update(Tentity entity)
		{
			using (var session = _nhibernateHelper.OpenSesion())
			{
				session.Update(entity);
				return entity;
			}
		}
	}
}
