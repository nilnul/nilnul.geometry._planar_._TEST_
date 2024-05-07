using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.geometry._planar_._TEST_.curve_.cloze_.trigon.proj.theorem_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var projLength = nilnul.geometry.planar.curve_.cloze_.trigon.proj.therorem_.ColsWithCtg.LengthOfProjection(
				3,4,
				nilnul.geometry.planar.rotation_.Degree4dbl.ToRadian(
				60
				)
				,
				nilnul.geometry.planar.rotation_.Degree4dbl.ToRadian(
				45
				)

			);
			var expected = 3 + 4 / Math.Sqrt(3);

			var reApproximate =  nilnul.num.real.re_.approx_.Ratio.OfThousandth().re(
				projLength
				,
				expected
			);

			Debug.Assert(reApproximate);
		}
	}
}
