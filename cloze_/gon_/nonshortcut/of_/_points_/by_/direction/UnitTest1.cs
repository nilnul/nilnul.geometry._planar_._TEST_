using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.cloze_.gon_.nonshortcut.of_._points_.by_.direciton
{
	public class UnitTest1
	{
		static public System.Collections.Generic.IEnumerable<Complex> TestMethod1()
		{

			Random rnd = nilnul._stat._RndX.RANDOM;
			var total = unchecked(rnd.Next(100) + 1 );


			var ps = Enumerable.Range(0, total).Select(
				i=>
				new Complex(
					rnd.NextDouble() * rnd.Next(1000)
					,
					rnd.NextDouble() * rnd.Next(1000)

				)
			);

			var gon = planar.cloze_.gon_.nonshortcut.of_._points_.by_._ByDirectionX._OfPoints_0dwelt(
				ps
			);

			return gon;


		}

	}
}
