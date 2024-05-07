using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon_.nonhole_.big_
{
	[TestClass]
	public class UnitTest11
	{
		

		static public Gon4dbl Facet()
		{
		

			var facet = nilnul.geometry.planar.zone_.gon_.concave_.big_.UnitTest1.Zone();

			var conduit = new  nilnul.geometry.planar.facet_.Gon4dbl(facet);


			return conduit;
		}

	}
}
