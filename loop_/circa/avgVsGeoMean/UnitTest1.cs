using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs.folder.be_.link_;
using nilnul.geometry.planar.loop_.circa.draw_;
using System;
using System.Xml.Linq;

namespace nilnul.geometry.planar.loop_.circa.avgVsGeoMean.draw
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var canvasWidth = 100;
			var canvasHeight = 100;
			var strokeWidth = 2;
			var sum = 1*100;
			var a = 0.3*100;

			var b = sum - a;

			var radius = (a + b) / 2;

			var footX = radius - a;

			var footY = 0d;

			var height =Math.Sqrt(
				nilnul.num.real.op_.Square.Singleton.op(radius)
				-
				nilnul.num.real.op_.Square.Singleton.op(footX)
			);

			var circ = nilnul.geometry.planar.loop_.Circ0point4Dbl.OfRadius(radius);

			var apex = new nilnul.geometry.planar.Point4dbl(
				radius-a
				,
				height
			);

			var builder =  geometry.planar.drawable.draw_._svg.Builder.OfCentered(canvasWidth,canvasHeight,strokeWidth);



			var g = new XElement("g"
				,
new XAttribute("stroke-width", strokeWidth)
,
new XAttribute("stroke", "red")
,
new XAttribute("fill", "none")


			);

			

			var xDoc = builder.document;
			xDoc.Root.Add(g);
			var gGreen = new XElement("g"
				,
new XAttribute("stroke-width", strokeWidth)
,
new XAttribute("stroke", "green")
,
new XAttribute("fill", "none")


			);

			gGreen.Add(

				nilnul.geometry.planar.grad.draw_._SvgX.Draw2el(0, 0, apex.x, apex.y)
				//,

			);

			g.Add(

				circ.Draw2el()
				,
				nilnul.geometry.planar.grad.draw_._SvgX.Draw2el(footX,footY,apex.x,apex.y)
				,
				gGreen

				//,
				//nilnul.geometry.planar.grad.draw_._SvgX.Draw2el(radius,0,apex.x,apex.y)
				//,
				//nilnul.geometry.planar.grad.draw_._SvgX.Draw2el(-radius,0,apex.x,apex.y)
				,
				nilnul.geometry.planar.grad.draw_._SvgX.Draw2el(-radius,0,radius,0)


			);

			builder.removeEmptyNs();


			var tgtFile = nilnul.geometry._planar_._TEST_._this.data.dir_.exclave.dnt_.next.UnitTest1.Address ("a",".svg");

			System.IO.File.WriteAllText(tgtFile, xDoc.ToString());

			nilnul.fs.file.explore_._SelX.Vod(tgtFile);

			nilnul.fs.file._ExeX.Exe(tgtFile);
			nilnul.win.prog_.notepad.run_.shell_.NewWin.Singleton.run(tgtFile);



		}
	}
}
