using System;
using DevFramwork.Northwind.DataAcses.Concrete.Helpers;
using DevFramwork.Northwind.DataAcses.Concrete.Nhbirnate;
using DevFramwork.Northwind.DataAcses.EntityFramwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramwork.DataAcsess.Text
{
	[TestClass]
	public class NhbinateText
	{
		public class EntityFrameworkText
		{
			[TestMethod]

			public void Get_all_returns_all_produts()
			{
				NhProdutDal productDal = new NhProdutDal(new SqlServerHelpers());
				var result = productDal.Getlist();

				Assert.AreEqual(79, result.Count);
			}
		}
		[TestMethod]

		public void Get_all_parameters_filterd_produts()
		{
			NhProdutDal productDal = new NhProdutDal(new SqlServerHelpers());
			var result = productDal.Getlist(p=>p.ProdcutName.Contains("ab"));

			Assert.AreEqual(4, result.Count);
		}
	}

}