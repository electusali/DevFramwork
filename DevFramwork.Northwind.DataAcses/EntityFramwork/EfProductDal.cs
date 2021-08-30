using DevFramwork.Core.DataAcses.EntityFramwork;
using DevFramwork.Northwind.DataAcses.Abscreat;
using DevFramwork.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DevFramwork.Northwind.DataAcses.EntityFramwork
{
	public class EfProductDal :EfEntityRepostoryBase<Product,NorthwindContext>, IProductDal		
	{
		
	}
}
