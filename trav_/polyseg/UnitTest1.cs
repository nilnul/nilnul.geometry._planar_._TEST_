using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.trav_.polyseg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var steps = new double[0];

			v(
				steps, new[] { new Complex()}
			);
			v(
				[0], [ new Complex(),new Complex() ]
			);

			v(
				[2.5], [ new Complex(),new Complex(2.5,0) ]
			);
			v(
				[-12.5], [ new Complex(),new Complex(-12.5,0) ]
			);

			v(
				[0,0], [ new Complex(),new Complex(),Complex.Zero ]
			);
			v(
				[0,10], [ new Complex(),new Complex(),new Complex(10,0) ]
			);
			v(
				[0,-10], [ new Complex(),new Complex(),new Complex(-10,0) ]
			);

			v(
				[10,0], [ new Complex(),new Complex(10,0),new Complex(10,0) ]
			);
			v(
				[-10,0], [ new Complex(),new Complex(-10,0),new Complex(-10,0) ]
			);
			v(
				[10,10], [ new Complex(),new Complex(10,0),new Complex(10,10) ]
			);
			v(
				[10,-10], [ new Complex(),new Complex(10,0),new Complex(10,-10) ]
			);
			v(
				[-10,10], [ new Complex(),new Complex(-10,0),new Complex(-10,-10) ]
			);
			v(
				[-10,-10], [ new Complex(),new Complex(-10,0),new Complex(-10,10) ]
			);

			v(
				[0,0,0], [ new Complex(),new Complex(),new Complex() ,new Complex()]
			);
			v(
				[0,0,13.5], [ new Complex(),new Complex(),new Complex() ,new Complex(13.5,0)]
			);

			v(
				[0,13.5,13.5], [ new Complex(),new Complex(),new Complex(13.5,0) ,new Complex(13.5,13.5)]
			);

			v(
				[0,13.5,-13.5], [ new Complex(),new Complex(),new Complex(13.5,0) ,new Complex(13.5,-13.5)]
			);
			v(
				[0,-13.5,13.5], [ new Complex(),new Complex(),new Complex(-13.5,0) ,new Complex(-13.5,-13.5)]
			);

			v(
				[0,-13.5,-13.5], [ new Complex(),new Complex(),new Complex(-13.5,0) ,new Complex(-13.5,13.5)]
			);

			v(
				[0,-13.5,-13.5,20,20,-3,0,0,-3,0,5,0], [
					new Complex()
					,new Complex()	//0
					,new Complex(-13.5,0)
					,new Complex(-13.5,13.5) //-13.5
					,
					new Complex(-13.5-20,13.5 )	//20
					,
					new Complex(-13.5-20,13.5 -20) //20
					,
					new Complex(-13.5-20-3,13.5 -20) //-3
					,
					new Complex(-13.5-20-3,13.5 -20) //0
					,
					new Complex(-13.5-20-3,13.5 -20) //0
					,
					new Complex(-13.5-20-3,13.5 -20 +3) //-3
					,
					new Complex(-13.5-20-3,13.5 -20 +3) //0
					,
					new Complex(-13.5-20-3-5,13.5 -20 +3) //5
					,
					new Complex(-13.5-20-3-5,13.5 -20 +3) //0

				]
			);


		}


		void v(IEnumerable<double> steps, IEnumerable<Complex> pointsExpected) {
			var a = geometry.planar.trav_.polyseg_._OrthogonalX.Points(steps).ToArray();

			Assert.IsTrue(
			nilnul.num.complex.str.re_.every_.approx_.PerKilo4Dbl.Unison.re(
				a
				,
				pointsExpected
			));
		}
	}
}
