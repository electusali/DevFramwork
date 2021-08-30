using System;
using DevFramwork.Northwind.DataAcses.EntityFramwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramwork.DataAcsess.Text
{
	[TestClass]
	public class EntityFramworkText
	{
		public class EntityFrameworkText
		{
			[TestMethod]

			public void Get_all_returns_all_produts()
			{
				EfProductDal productDal = new EfProductDal();
				var result = productDal.Getlist();

				Assert.AreEqual(79, result.Count);
			}
		}
		[TestMethod]

		public void Get_all_parameters_filterd_produts()
		{
			EfProductDal productDal = new EfProductDal();
			var result = productDal.Getlist(p=>p.ProdcutName.Contains("ab"));

			Assert.AreEqual(4, result.Count);
		}
	}

}