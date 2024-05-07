using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.geometry._planar_._TEST_._this.data.dir
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		}
		public static string GetAddress(string dir)
		{
			var appPath = _this.data.UnitTest1.Shield();
			return System.IO.Path.Combine(appPath.ToString(),dir);
		}
	}
}
