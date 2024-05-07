using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.geometry._planar_._TEST_.bloc
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var b = new geometry.planar.tope_._bloc.SpreadDbl(
				300, 600
			);

			var area = new planar.Area4dbl(b.area()*66, planar._area.unit_.SqMm4Dbl.Singleton);


			var whole = area.toStd();

			Debug.WriteLine(whole);

		}
	}
}
