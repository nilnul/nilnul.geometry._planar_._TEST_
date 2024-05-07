using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar;
using System;
using System.Drawing;

namespace nilnul.geometry._planar_._TEST_.curve.stream_.hilbert_.byPoints_.aroundOrigin
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			for (int i = 0; i < 7; i++)
			{
				TestMethod1(i);
			}
		}
		public void TestMethod1(int ord)
		{

			var size = 1024;
			var img = new Bitmap(size, size);

			using (var g= Graphics.FromImage(img) )
			{

				geometry.planar.curve.stream_.hilbert_.byPoints_._AroundOriginX.Draw(
					g,

					ord

					,
					new planar.tope_.bloc_.Square4dbl(
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
