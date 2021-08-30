using DevFramwork.Core.Entiites;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramwork.Core.DataAcses
{
	public interface IQuareble<T> where T:class,IEntity,new()
	{
		IQuareble<T> Table { get; }
	}
}
