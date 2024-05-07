using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon_.conduit_._trihole.disord_
{
	[TestClass]
	public class UnitTest11
	{
		

		static public System.Collections.Generic.IEnumerable<Point4dblI> Conduit()
		{
		

			var facet = nilnul.geometry.planar.facet_.gon_.trihole_.UnitTest1.Facet();

			var conduit = nilnul.geometry.planar.facet_.gon_._conduit.disord.of_._Coerce4dblX.Of(facet);

			return conduit;
		}

	}
}
