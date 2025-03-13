using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using System.Xml.Linq;

namespace nilnul.geometry.planar.trac_.lune
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

				var builder = new geometry.planar.drawable.draw_._svg.Builder(2020, 2020);



				var strokeWidth = 2;

				var g = new XElement("g"
					,
	new XAttribute("stroke-width", strokeWidth)
	,
	new XAttribute("stroke", "red")
	,
	new XAttribute("fill-rule", "evenodd")
				//,
				//new XAttribute("fill", "none")


				);


			var sqrt2 = nilnul.num.real_.eg_.sqrt_._OfTwoX.DBL;
				var xDoc = builder.document;
				xDoc.Root.Add(g);


				g.Add(
					new XElement(
						"path"
						,
						new XAttribute(
							"d"
							,
							nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(

							""
							+
							cloze_.ellipse.arc.draw_._SvgX.AsMoveArc(
								new curve_.elliptic_.Arc8dbl(
									(1000,0),
									1000,1000,
									0
									,false
									, true
									,
									(0,1000)
								)
							)
							+
							cloze_.ellipse.arc.draw_._SvgX.AsArc(
								new curve_.elliptic_.Arc8dbl(
									(0,1000),
									1000 / sqrt2 ,1000 /sqrt2,
									Math.PI /4*3
									,false
									, false
									,
									(1000,0)
								)
							)
							)+ " z"
						)

					)
				);

			g.Add(
	new XElement(
		"path"
		,
		new XAttribute(
			"d"
			,
			nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(

			""
			+
			@"M0 0
L0,1000
L1000,0
" + " z"
		)

	)
));		/// the trigon

			/// the area of the trigon is equal to the area of the crescent.

			builder.removeEmptyNs();


				var tgtFile = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".svg");
				System.IO.File.WriteAllText(tgtFile, xDoc.ToString());

				nilnul.fs.file.explore_._SelX.Vod(tgtFile);

				nilnul.fs.file._ExeX.Exe(tgtFile);
				nilnul.win.prog_.notepad.run_.shell_.NewWin.Singleton.run(tgtFile);



			}
		}
	}
