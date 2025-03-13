using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
//using C = System.Numerics.Complex;

namespace nilnul.geometry.planar.cycle_.circ.inscribe_.gon_.regular_.hepta
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var pRight = nilnul.num.complex.of_.polar_._CisX.Cis_0degrees(
				60
			);

			var pLeft = new C(-pRight.Real, pRight.Imaginary);

			var pPositive = new C(1, 0);



			var pMid = (pLeft + pPositive) / 2;

			var scribe = nilnul.geometry.planar.cycle_.circ.co_._JointX._Intersected_0originatedRadius_1radius2nd_2distance4joint(
				1
				,

				(pMid - pPositive).Magnitude
				,
				1
			);

			/// not exact.
			/// 
			nilnul.num.real.re.vow_.Re8default4dbl<num.real.re_.approx_.Hundredth4dbl>.Unison.vow(

			scribe.Phase
			,
			nilnul.num.real_.eg_.tau._DegreeX.Radians_0degrees(
			360d / 7)
			);





		}
	}
}
