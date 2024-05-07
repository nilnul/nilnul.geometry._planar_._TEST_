using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.zone_.gon_.concave_
{
	public class UnitTest1
	{
		


		static public System.Collections.Generic.IEnumerable<(double, double)> Zone()
		{


			var hole = new (double,double)[] {
				(20,20)
				,
				(50,15)
				,
				(70,-1)
				,
				(60,60)
				,
				(40, 20)
				,
				(30,40)
	

			};

			return hole;
		}
	}
}
