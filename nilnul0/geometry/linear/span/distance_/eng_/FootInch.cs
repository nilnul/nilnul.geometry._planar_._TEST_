using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.geometry._test.length.meter.foot
{
	[TestClass]
	public class FootInch
	{
		[TestMethod]
		public void FootInch_ToMeter()
		{

			Debug.WriteLine(
				nilnul.geometry.length.meter.foot.FootInch.ToMeter(
					5,11
					)	
			);
		}
	}
}
