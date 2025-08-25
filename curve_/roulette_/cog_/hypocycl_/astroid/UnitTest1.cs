using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs.folder.be_.link_;

namespace nilnul.geometry.planar.curve_.cog_.hypocycl_.astroid
{
	/// <summary>
	/// <see cref="geometry.planar.curve_.cog_.hypocycl_."/>
	/// </summary>
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
				,

			};


			const double outerRadius = 512*.9;
			const double outerPerInner = 3;	// or 1.5
			var model =  nilnul.geometry.planar.curve_.roulette_.cog_.hypo_.Hypocycloid.OfRadii(
				outerRadius
				,
				outerRadius /4d 
			);

			var basises = new List<Point>();
			var finals = new List<Point>();

			var period = Math.PI * 2;///(outerPerInner - 1) ;


			for (double i = 0; i < period; i += nilnul.geometry.planar._rotation.unit_.Deg4dbl.MAGNITUDE)
			{

				const int Width = 1024;
				var img = new Bitmap(
					Width, Height
				);

				///learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap.maketransparent?view=windowsdesktop-9.0
				///When you call MakeTransparent, the bitmap will be converted to the Format32bppArgb format, as this format supports an alpha channel.
				///The system palette defines one color as the default transparent, or alpha, color. This method makes the default transparent color transparent for this Bitmap. If no transparent color is specified by the system, LightGray is the transparent color.

				img.MakeTransparent(Color.Black);
				


				using (var g = Graphics.FromImage(img))
				{
					g.Clear(Color.Black);
					g.Clear(Color.Transparent);
					
					g.TranslateTransform(Width / 2, Height / 2);

					var skid = model._Sweep_0nil2pi(i);

					const int ScaleX = 512;

					Point pt1 = nilnul.geometry.planar.PointX.ToPoint8int(
							skid
						);

					basises.Add(pt1);



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
	




				}

				//img.MakeTransparent(Color.Black);
				gif.AddFrame(img);


			}




			gif.save(address2save);
			nilnul.fs.file.explore_._SelX.Vod(address2save);

			nilnul.fs.file._ExeX.Exe(address2save);




		}
	}
}
