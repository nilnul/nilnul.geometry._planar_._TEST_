using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.geometry.planar.morph_.remat_.rotate.eigen_.unique_.eg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var shear = new double[,] {
				{ 1,0}
				,
				{ 1,1}
			};

			/// to compute the eigen val:
			///		(1-x)^2 =1
			///	, so x0=x1=1.
			///

			var shear1 = new double[,] {
				{ -2,0}
				,
				{ 1,-2}
			};


		}
	}
}
