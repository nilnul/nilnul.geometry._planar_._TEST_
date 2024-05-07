using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;

namespace nilnul.geometry._planar_._TEST_.cloze_.gon_.orthy.of_.edgesNoLastTwo.draw
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var gon = new planar.cloze_.Polygon4dbl(
nilnul.geometry.planar.cloze_.gon_.orthy.of_.steps_._DeriveLastX._Vertices_0stepsWithoutLastTwo(
				[0, -13.5, -13.5, 20, 20, -3, 0, 0, -3, 0, 5, 0]
			));

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
				nilnul.geometry.planar.cloze_.gon._DrawX.El(gon)
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
