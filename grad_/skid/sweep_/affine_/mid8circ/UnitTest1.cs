using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs.folder.be_.link_;

namespace nilnul.geometry.planar.grad_.skid.sweep_.affine_.mid8circ
{
	[TestClass]
	public class UnitTest1
	{
		private const int Height = 1024;

		[TestMethod]
		public void TestMethod1()
		{
			var container = nilnul.geometry._planar_._TEST_._this.data.dir_.exclave.UnitTest1.Address();

			var address2save = nilnul.fs.folder.dnt_.mainVered_.minVer_.Next.OvAddress(container).address("a.gif");

			var gif = new nilnul.img.Gif_1_()
			{
				DefaultFrameDelay = 1000 / 24

			};


			var model = new nilnul.geometry.planar.grad_.skid.sweep_.affine_.InscribeTriangle();

			var basises = new List<Point>();
			var finals = new List<Point>();


			for (double i = 0; i < nilnul.num.real_.eg_._Tau4dblX.FULL; i += nilnul.geometry.planar._rotation.unit_.Deg4dbl.MAGNITUDE)
			{

				const int Width = 1024;
				var img = new Bitmap(
					Width, Height
				);


				using (var g = Graphics.FromImage(img))
				{
					g.TranslateTransform(Width / 2, Height / 2);
					var skid = model._Sweep_0nil2pi(i);

					const int ScaleX = 512;
					var morph = nilnul.geometry.planar.morph_.Scale.CreateMatrix(ScaleX, ScaleX);

					var matrix = nilnul.geometry.planar.morph_.affine_._RebaseX._Augment2float_0rebase(morph);

					Point pt1 = nilnul.geometry.planar.PointX.ToPoint8int(
							skid.basis * ScaleX
						);

					basises.Add(pt1);
					Point pt2 = nilnul.geometry.planar.PointX.ToPoint8int(
							skid.final * ScaleX
						);
					finals.Add(pt2);


					g.DrawLine(
						new Pen(Color.Red, 2)
						,

						pt1
						,
						pt2

					);

					foreach (var item in basises)
					{
						g.DrawEllipse(
							new Pen(Color.Green, 2)
							,

							item.X - 1
							,
							item.Y - 1
							,
							2
							,
							2

						);

					}
					foreach (var item in finals)
					{
						g.DrawEllipse(
							new Pen(Color.Blue, 2)
							,

							item.X - 1
							,
							item.Y - 1
							,
							2
							,
							2

						);

					}




				}

				gif.AddFrame(img);


			}




			gif.save(address2save);
			nilnul.fs.file.explore_._SelX.Vod(address2save);

			nilnul.fs.file._ExeX.Exe(address2save);




		}
	}
}
