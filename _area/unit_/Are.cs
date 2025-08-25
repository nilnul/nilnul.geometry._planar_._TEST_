using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.geometry.planar._test.area._measures
{
	[TestClass]
	public class Are
	{
		[TestMethod]
		public void AreToSqMeters()
		{
			Debug.WriteLine(nilnul.geometry.planar._area.unit_.Are.AsSqMeters);
		}
	}
}
