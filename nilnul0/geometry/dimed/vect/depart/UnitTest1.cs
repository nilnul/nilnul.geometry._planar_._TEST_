using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._geometry_._TEST_.nilnul0.geometry.dimed.vect.depart
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Debug.WriteLine(
				1+
				nilnul.geometry.dimed.vect.co._DistanceX.DistanceFroOrigin(
					2.4
					,
					1.2
					,
					2.2
				)
				+0.5

			);
		}
	}
}
