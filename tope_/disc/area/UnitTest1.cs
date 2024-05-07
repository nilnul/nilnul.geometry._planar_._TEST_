using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.geometry._planar_._TEST_.shape_.disk.area
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			t(1.38,1.78,2.25,2.76);
			r(1.33, 1.7);
		}

		void t(params double[] diameeter) {
			diameeter.ForEach(x=>

			Debug.WriteLine(
				nilnul.geometry.planar.crux_.disk.area_.doubl_._DiameterX.Exe(x)
			));
		}

		void r(params double[] diameeter) {
			diameeter.ForEach(x =>

			Debug.WriteLine(
				nilnul.geometry.planar.crux_.disk.area_.doubl_._DiameterX.Exe(x) * 7
			));

		}

	}
}
