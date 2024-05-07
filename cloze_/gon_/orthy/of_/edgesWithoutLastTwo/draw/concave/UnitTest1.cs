using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;

namespace nilnul.geometry._planar_._TEST_.cloze_.gon_.orthy.of_.edgesNoLastTwo.draw.concave
{
	[TestClass]
	public class UnitTest1
	{
		private const int WallHeight = 2900;

		[TestMethod]
		public void TestMethod1()
		{
			var doorLeft = 450;
			var doorBroadth = 980;
			var doorHigh = 2080;
			double[] steps = [
				doorLeft
				,
				doorHigh
				,
				-doorBroadth
				 ,
				- doorHigh

				,
				(1700 - doorLeft - doorBroadth)
				 ,
				WallHeight
				 ,

			];

			

			var gon = new planar.cloze_.Polygon4dbl(
nilnul.geometry.planar.cloze_.gon_.orthy.of_.steps_._DeriveLastX._Vertices_0stepsWithoutLastTwo(
				steps
			));

			var builder = new geometry.planar.drawable.draw_._svg.Builder(4000,4000);



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
