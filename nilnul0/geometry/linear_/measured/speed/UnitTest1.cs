using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

#if TRIAL

namespace nilnul.geometry._planar_._TEST_.nilnul0.geometry.linear_.measured.speed
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var speed = new nilnul.geometry.linear_.measured.Speed4dbl(
				new nilnul.geometry.linear_.measured.span.Distance4dbl(
					31000, nilnul.geometry.linear_._measured.unit_.eng_.inches_.Foot4dbl.Singleton
				)
				,
				nilnul.time.span._measure.unit_.Minute4dbl.Singleton
			);

			var kPerH = nilnul.geometry.linear_.measured.speed_.KmPerHour.Of(speed);

			Debug.WriteLine(kPerH);
		}
	}
}
#endif
