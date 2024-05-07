using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.geometry._planar_._TEST_.lead.vsArrow.layout
{
	//[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var arr = nilnul.geometry.planar.lead.vsArrow._LayoutX.Result(
				new nilnul.geometry.planar.Lead(
					new nilnul.geometry.planar.Point1(0,0)
					,
					new nilnul.geometry.planar.Point1(4,4)
					
				)
				,
				new nilnul.geometry.planar.grad_.Arrow(
					new nilnul.geometry.planar.Point1(2, 1)
					,
					new nilnul.geometry.planar.Point1(1, 3)
				)
			);

			Debug.Assert(
				arr is nilnul.geometry.planar.lead.vsArrow._layout.ret_.fork_.FroRestrict2Between
			);
		}
	}
}
