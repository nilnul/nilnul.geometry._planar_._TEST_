using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.geometry._planar_._TEST_.grad.trigonize.parlgrm.range.lateral
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{


			var v1 = new nilnul.geometry.planar.Vect4dbl(
				61
				,
				13
			);

			var v2 = new nilnul.geometry.planar.Vect4dbl(24, 53)

				;

			var sum = v1 + v2;


			var sweepByVerticalBar = geometry.planar.grad.shade.rect._SurroundX.ByChangeOfEksSmaller(
				v1,v2
			);

			var stokesDouble = geometry.planar.grad.shade.rect._SurroundX.Surround(
				v1,v2
			);

			Debug.Assert(

				num.real.re_.approx_.ByInjected.Singleton.re(
					stokesDouble
					,
					sweepByVerticalBar
				)
			);

			var sweepByHorizonBar = geometry.planar.grad.trigonize.parlgrm.diag_.originated.drag.belt_._MiddleX.ByChangeOfWaiBigger(
				v1,v2
			);

			var sweepByHorizonBarByArith = geometry.planar.grad.trigonize.parlgrm.diag_.originated.drag.belt_._MiddleX.ByWai2biggerArithmetic(
				v1,v2
			);

			Debug.Assert(

				num.real.re_.approx_.ByInjected.Singleton.re(
					sweepByHorizonBar
					,
					sweepByHorizonBarByArith
				)
			);


		}
	}
}
