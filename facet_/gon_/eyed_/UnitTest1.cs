using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon_.eyed_
{
	[TestClass]
	public class UnitTest1
	{
		


		static public nilnul.geometry.planar.facet_.Gon4dbl Facet()
		{

			var hull = zone_.gon_.concave_.big_.UnitTest1.Zone();

			var hole = hole_.gon_.concave_.UnitTest1.Hole();

			var holeOther = hole_.gon_.eg_.UnitTest1.Hole();
		

			var facet = new nilnul.geometry.planar.facet_.Gon4dbl(hull,hole,holeOther);

			return facet; ;
		}
	}
}
