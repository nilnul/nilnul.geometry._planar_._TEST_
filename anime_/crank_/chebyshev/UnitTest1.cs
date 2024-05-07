using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.geometry._planar_._TEST_.anime_.crank_.chebyshev
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			///this is the output of power, by, say, a driving motor;
			var center = new nilnul.geometry.planar.lop_.Circle4dbl(
				1
			);

			/// the output bar's near end is at the motor circle. and at about the center of the bar is one point of the other circle.
			/// the center of the other cirlce is some distance from the main cirlce center:
			var otherCenterDistance = 1.99;

			var otherRadius = 2.5;

			///the total length of the bar:
			var barLength = 5.02;

			/// the other circle's intersection point is some distant from the first circle's intersection point.
			var barTangent2otherCircle = 2.5;

			// the intended trail is the further end of the bar.
			/// the intended trail is move a straight line, then goes up thru a semi-ellipse.

		}
	}
}
