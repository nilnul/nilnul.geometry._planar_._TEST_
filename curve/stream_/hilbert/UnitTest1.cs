using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar;
using System;
using System.Drawing;

namespace nilnul.geometry._planar_._TEST_.curve.stream_.hilbert
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var size = 1024;
			var img = new Bitmap(size, size);

			using (var g= Graphics.FromImage(img) )
			{

				geometry.planar.curve.stream_.fractal_.Hilbert.Draw(
					g,

					0
					+1+2
					//+ 1
					,
					new planar.bloc_.Square4dbl(
						new Point4dbl(0, 0)
						,
						size
					)
					,
					new Pen(Color.Red,1)
				);

			}
			var file = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".jpg");
			img.Save(
				file

			);

			nilnul.fs.file._ExeX.Exe(file);
		}
	}
}
