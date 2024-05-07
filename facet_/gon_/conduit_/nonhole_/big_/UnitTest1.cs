using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon_.conduit_.nonhole_.big_
{
	[TestClass]
	public class UnitTest11
	{
		

		static public System.Collections.Generic.IEnumerable<Point4dblI> Conduit()
		{
		

			var facet = nilnul.geometry.planar.facet_.gon_.nonhole_.big_.UnitTest11.Facet();

			var conduit =   nilnul.geometry.planar.facet_.gon_.conduit.of_.coerce_._MinCuspX.Of(facet);


			return conduit;
		}

	}
}
