using DevFramwork.Core.DataAcses.Nhbirnate;
using DevFramwork.Northwind.DataAcses.Abscreat;
using DevFramwork.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramwork.Northwind.DataAcses.Concrete.Nhbirnate
{
	public class NhProdutDal : NhEntityRepositoryBase<Product>, IProductDal
	{
		public NhProdutDal(NhibernateHelper nhibernateHelper ):base(nhibernateHelper)
		{

		}
	}
}
