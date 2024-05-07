using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar.zone_.trigon;
using nilnul.geometry.planar.zone_.gon;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.zone_.gon.vsLead.bisect
{
	//[TestClass]
	public class UnitTest1Real
	{

		[TestMethod]

		public void TestMethod1()
		{
			var approximate = new nilnul.num.real.re_.Approximate(0.0001);

			var sected = nilnul.geometry.planar.zone_.gon_.convex.vsLead._SectX.Eval(
				new planar.point.str_.Seq( GetTriangle.ee)
				,
				new planar.ray_.OnArrow(0, 0, 2, 2)
			);	///todo: too long time-consuming

			Debug.Assert(sected.Count()==3)	;;//  {(1.71428571428571,1.71428571428571)}
			Debug.Assert( approximate.re( sected.ElementAt(0).x , 1.71428571428571));
			Debug.Assert(approximate.re( sected.ElementAt(0).y ,1.71428571428571));
			Debug.Assert(approximate.re( sected.ElementAt(1).x,0));
			Debug.Assert(approximate.re( sected.ElementAt(1).y ,3));
			Debug.Assert(approximate.re( sected.ElementAt(2).x ,0) );
			Debug.Assert(approximate.re( sected.ElementAt(2).y ,0));



			var sected1 = nilnul.geometry.planar.zone_.gon_.convex.vsLead._SectX.Eval(

				new planar.point.str_.Seq(GetTriangle.ee), 
				
				new planar.ray_.OnArrow(0,0,0,4)
				
			);

			Debug.Assert(sected1.Count() <3);


			var sected2 = nilnul.geometry.planar.zone_.gon_.convex.vsLead._SectX.Eval(

				new planar.point.str_.Seq(GetTriangle.ee),

				new planar.ray_.OnArrow(0,4,0,0)
				
			);

			Debug.Assert(sected2.Count() == 3);

			var sected3 =nilnul.geometry.planar.zone_.gon_.convex.vsLead._SectX.Eval(

				new planar.point.str_.Seq(GetTriangle.ee),

				new planar.ray_.OnArrow(-1,-2,99,0)
				
			);

			Debug.Assert(sected3.Count() == 3);

			var sected4 =nilnul.geometry.planar.zone_.gon_.convex.vsLead._SectX.Eval(

				new planar.point.str_.Seq(GetTriangle.ee),

				new planar.ray_.OnArrow(99,0,-1,-2)
				
			);

			Debug.Assert(sected4.Count() == 0);




		}

		public planar.ray_.OnArrow GetDir {
			get {
				return new planar.ray_.OnArrow(0, 0, 2,2);
			}
		}

		public nilnul.geometry.planar.zone_.Triangle GetTriangle {
			get {

				return new nilnul.geometry.planar.zone_.Triangle(0,0, 4,0, 0,3);
			
			}
			
		}
	}
}
