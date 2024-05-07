using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.geometry.planar._test._area.unit
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void Sqft()
		{
			Debug.WriteLine(
				nilnul.num.real.to_._RadixX._ClampAsQuotient2DigitsAftDot(
					nilnul.geometry.planar._area.unit_.eng_.SquareFt.Singleton.asSqMeters
					,4
				)
			);
		}
	}
}
