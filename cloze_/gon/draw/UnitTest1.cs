using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;

namespace nilnul.geometry._planar_._TEST_.cloze_.gon.draw
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var gon = new nilnul.geometry.planar.facet_.holed_.Bloc4dbl(
				new planar.zone_.bloc_.Originated4dbl(30, 50)
							,
							new planar.loop_.circ_.Nontrivia4dbl(
								new planar.Point4dbl(15, 25)
								,
								5
							)

				);

			var builder = new geometry.planar.drawable.draw_._svg.Builder(100,100);



			var  strokeWidth = 2;
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


			g.Add(
				gon.draw()
			);

			builder.removeEmptyNs();


			var tgtFile = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".svg");
			System.IO.File.WriteAllText(tgtFile, xDoc.ToString());

			nilnul.fs.file.explore_._SelX.Vod(tgtFile);

			nilnul.fs.file._ExeX.Exe(tgtFile);
			nilnul.win.prog_.notepad.run_.shell_.NewWin.Singleton.run(tgtFile);



		}
	}
}
