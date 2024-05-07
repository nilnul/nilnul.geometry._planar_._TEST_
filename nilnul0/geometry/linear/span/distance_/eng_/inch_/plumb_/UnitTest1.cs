using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.linear.span.distance_.eng_.inches_;
using nilnul.num;
using System;
using System.Diagnostics;

namespace nilnul._geometry_._TEST_._linear.length_.en_.inch_.plumb_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var sixFrac = nilnul.num.real.to_.quotient_.radix_._DecX.ToDecRecur(
				_PlumbingX.SixFrac
				,
				4
			);

			Debug.WriteLine(
				sixFrac
			);

			var fourFrac = nilnul.num.real.to_.quotient_.radix_._DecX.ToDecRecur(
				_PlumbingX.FourFrac
				,
				4
			);

			Debug.WriteLine(
				fourFrac
			);

			t(8);


		}

		void t(int fracs) {

			var fourFrac = nilnul.num.real.to_.quotient_.radix_._DecX.ToDecRecur(
				_PlumbingX.OneFrac.ToReal() * fracs
				,
				4
			);

			Debug.WriteLine(
				fourFrac
			);



		}
	}
}
