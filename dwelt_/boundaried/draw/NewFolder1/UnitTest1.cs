using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.integer;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace nilnul.geometry.planar.dwelt_.boundaried.draw.more2shrink
{
	[TestClass]
	public class UnitTest1
	{
		static public double arrow5bar = 0.33;
		[TestMethod]
		public void TestMethod1(
		)
		{

			nilnul.fs.file._ExeX.Exe(
				draw2file()
			);


		}
		public string draw2file(
		)
		{
			var img = draw2img();

			var dnt = nilnul.fs.folder.dnt_.mainVered_.minVer_.Next.OvAddress(
				nilnul.geometry._planar_._TEST_._this.data.dir_.my.child_.max.exclave.UnitTest1.Address()
			).address("less.jpg");

			img.Save(dnt);
			return dnt;


		}

		public Bitmap draw2img(
		)
		{
			var wide = 1000;
			int wideHalf = wide / 2;
			var high = wideHalf;

			var imgWide = (int)(wide * 1.1);
			var imgHigh = (int)(high * 1.1);

			var img = new Bitmap(imgWide, imgHigh);

			float padAsInt = (imgWide - wide) / 2;
			float padYAsInt = (imgHigh - high) / 2;


			using (var g = Graphics.FromImage(img))
			{


				g.TranslateTransform(
					padAsInt
					,
					padYAsInt
				//, MatrixOrder.Append
				);
				draw(g, wide);



			}
			return img;




		}

		public void draw(
			Graphics g
			,
			int wide = 1000

		)
		{


			int wideHalf = wide / 2;
			var high = wideHalf;

			double[] subs = [0.7, 0.6, 0.4, 0.9, 0.6];

			var heightOfBar = high / 5;


			IEnumerable<nilnul.geometry.planar.zone_.Bloc8dbl> t()
			{
				for (int i = 0; i < subs.Length; i++)
				{
					int y = i * heightOfBar;

					double barWidth = subs[i] * wide;

					yield return new nilnul.geometry.planar.zone_.Bloc8dbl(0, y, (double)barWidth, heightOfBar);

					yield return new nilnul.geometry.planar.zone_.Bloc8dbl(
						0 + barWidth, y
						, wide -barWidth, heightOfBar
					);



				}

			}
				Pen pen = new Pen(
										Color.Gray
										, 3
									);


			//var imgWide = wide * 1.1;
			//var imgHeigh = high * 1.1;

			var rects = t().ToArray();

			for (int i = 0; i < rects.Length; i++)
			{
				Rectangle rect = rects[i].toRect();

				g.FillRectangle(
					new SolidBrush(
						i.IsEven() ?
						Color.Green
						:
						Color.Gray
					)
					,
					rect
				);

				g.DrawRectangle(
					pen
					,
					rect
				);
				Rectangle rect1 = rects[++i].toRect();

				//g.FillRectangle(
				//	new SolidBrush(
				//		i.IsEven()?
				//		Color.Green
				//		:
				//		Color.Gray
				//	)
				//	,
				//	rect
				//);

				g.DrawRectangle(
					pen
					,
					rect1
				);

			}

			double halfArrowH = heightOfBar * arrow5bar / 2;

			int arrowLeft = wide / 4;
			var anchor = (arrowLeft
					,
					halfArrowH);

			var arrowWide = wideHalf;


			const double arrowTailPortion = .85;

			var pivot = new C(wideHalf,high/2);

			var morph = new nilnul.num.complex.morph_.Spiral(
				pivot,
				C.FromPolarCoordinates(1, Math.PI)
			);


			double arrowTailWide = arrowWide * arrowTailPortion;
			PointF[] arrow = new zone_.gon_.hepta_._arrow.triviable_.rightward_.HighAtHalf(
								new tope_._bloc.SpreadDbl(
									arrowTailWide
									,
									halfArrowH
								)
								,
								new tope_._bloc.SpreadDbl(
									arrowWide-arrowTailWide
									,
									halfArrowH* 0.618
								)
							).vertexes.Select(
								p => (p.ToComplex() + new System.Numerics.Complex(
									arrowLeft
									,
									high / 2
								))
							)
							.Select(c=> morph.op(c).ToPointFloat())
							.ToArray();

			g.DrawPolygon(
				new Pen(
					Color.Yellow
				)
				,

				arrow

			);

			g.FillPolygon(

					new SolidBrush(
						 Color.FromArgb(
							//128
							255
							,
						Color.Yellow
						)
					)

				,

				arrow

			);







		}




	}
}
