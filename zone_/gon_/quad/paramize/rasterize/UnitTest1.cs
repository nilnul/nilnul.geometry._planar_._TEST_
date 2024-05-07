using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar;
using System;
using System.Drawing;
using System.Linq;

namespace nilnul.geometry._planar_._TEST_.zone_.gon_.quad.paramize
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var length = 500;
			using (var img=new Bitmap(length,length))
			{
				//var img = new Bitmap(length, length);
				var vertex0 = new Point4dbl(length *0.1, length * 0.17);
				var vertex1 = new Point4dbl(length *0.9, length * 0.13);
				var vertex2 = new Point4dbl(length *0.8, length * 0.82);
				var vertex3 = new Point4dbl(length * 0.15, length * 0.7);

				var quad = new nilnul.geometry.planar.zone_.gon_.Quod4dbl(
					vertex0
					,
					vertex1
					,
					vertex2
					,
					vertex3
				);

				var morph = new nilnul.geometry.planar.zone_.gon_.quad.Parameterize(
					quad
				);


				var colSizeInUnitSq = 1d / 12;
				for (int i = 0; i < length; i++)
				{
					for (int j = 0; j < length; j++)
					{
						var proportionX = 1d * i / length;
						var proportionY = 1d * j / length;


						var newPoint = morph.toCoordInUnitSquareAsPointClass(i, j);

						var indexX = (int) Math.Floor ( newPoint.x /colSizeInUnitSq);
						var indexY = (int) Math.Floor(newPoint.y / colSizeInUnitSq);

						var indexer = nilnul.num.integer.op_.unary_.polyn._BaseNegOneX.OfNegOneAsBool(
							indexX+indexY
						);

						img.SetPixel(
							i,j
							,
							indexer? Color.White:Color.Black
						);



					}

				}

				using (var g=Graphics.FromImage(img))
				{
					g.DrawPolygon(
						new Pen( Color.Red,2)
						,
						quad.vertexes.Select(v=> geometry.planar.PointX.ToPointF(v)).ToArray()
					);
				}

				var file = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".jpg");

				img.Save(
					file

				);

				nilnul.fs.file._ExeX.Exe(file);
				//return img;



			}

		}
	}
}
