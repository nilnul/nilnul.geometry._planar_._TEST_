using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;

namespace nilnul.geometry._planar_._TEST_.curve_.convex
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var origin = new nilnul.geometry.planar.Point4dbl(); //left neaer

			var width = 39.5  //the width with edges. the edge is round
				-
				0.4  //0.5	// narrower than the edge

				;

			var furtherness=
				60.5 /*60.4*/  //with the holder base
				-
				0.3		//allowance for the holder base
				*2		//we have two sides, each of which has a holder base 
						;

			var rightNeaer = new planar.Point4dbl(
				width,

				0
			);

			var rightFurther = new planar.Point4dbl(
				width,furtherness
			);

			var leftFurther = new planar.Point4dbl(
				0
				,
				furtherness
			);

			var radius = width / 2;

			var semicircleLeft = new planar.Point4dbl(
				0
				,
				radius

			);

			var semicircleRight = new planar.Point4dbl(
				width
				,
				radius
			);

			//draw on svg

			var xDoc = new XDocument(

		);
			XNamespace xn = "http://www.w3.org/2000/svg";

			var rtEle = new XElement(
xn + "svg"
				);

			xDoc.Add(
				rtEle
			);


			var leftVertical = nilnul.geometry.planar.tend._DrawX.Draw(
				semicircleLeft
				,
				leftFurther
			);

			rtEle.Add(
				leftVertical
			);

			var furtherHorizon=nilnul.geometry.planar.tend._DrawX.Draw(
				semicircleRight
				,
				rightFurther
			);




			var x = 0;
			var y = 0;
			var w = width;
			var h = furtherness;
			rtEle.Add(
				new XAttribute("viewBox", $"{x} {y} {w} {h}")
			);

			
		}
	}
}
