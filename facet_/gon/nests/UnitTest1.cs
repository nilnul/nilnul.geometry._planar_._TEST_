using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Linq;

namespace nilnul.geometry._planar_._TEST_.facet_.gon.nests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var font = new Font("Times New Roman", 12);
			var nests = nilnul.geometry.planar.facet_.gon.nests.of_.cycles_.nonjoint_._ByForestX.Nesteds(
				//'A'

				'.'

				,font
			);

			var nestsAsArr = nests.ToArray();

		}
	}
}
