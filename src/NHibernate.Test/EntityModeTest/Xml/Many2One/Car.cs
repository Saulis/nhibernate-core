using System;
using Iesi.Collections.Generic;

namespace NHibernate.Test.EntityModeTest.Xml.Many2One
{
	[Serializable]
	public class Car
	{
		private ISet<CarPart> carParts = new HashedSet<CarPart>();

		public virtual long Id { get; set; }
		public virtual string Model { get; set; }
		public virtual CarType CarType { get; set; }

		public ISet<CarPart> CarParts
		{
			get { return carParts; }
			set { carParts = value; }
		}
	}
}