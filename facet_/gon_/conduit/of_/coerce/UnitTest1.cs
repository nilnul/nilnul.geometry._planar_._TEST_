using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul.geometry._planar_._TEST_.facet_.gon_.conduit.of_.coerce
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			const int windowBroad = 50;
			double underWindow = 120;
			double aboveWindow = 200;
			double WallHeight = 2900;
			double windowHeight = WallHeight - underWindow - aboveWindow;
			var windowFurther = 60;

			var win = new nilnul.geometry.planar.tope_.BlocDbl(windowBroad, windowHeight).vertexes.Select(
				p => new nilnul.geometry.planar.Point4dbl(
					nilnul.geometry.planar.morph_.affine_._ShiftX.Trans(
					(p.x, p.y), (windowFurther, underWindow)
					)
				)
			);

			var t = new nilnul.geometry.planar.facet_.Gon4dbl(
					//new nilnul.geometry.planar.cycle_.gon_.Facade4dbl(
					new nilnul.geometry.planar.tope_.BlocDbl(
						1680, 2900
					).vertexes.ToArray()
				//).vertexes
				,
					new[] {
								win.Reverse().ToArray()
				}

			);

			var c = geometry.planar.facet_.gon_.conduit.of_.coerce_._MinCuspX.Of(t);


		}
	}
}
