using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul.geometry._planar_._TEST_.zone_.gon_.nontri.chord.byElbow
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			(double,double)[] gon = [
				(0d,0d)
				,
				(2,0)
				,
				(1,1)
				,
				(0,2)
			];

			var expected = (s:(0, 0),  (1, 1) );
		

			v(gon, expected);

			v(
				[ (0,0),(1,0),(1,1),(0,1) ]
				,
				( (0,0), (1,1) )

			);

			v(
				[ (0,1) ,(0,0),(1,0),(1,1),]
				,
				( (0,1), (1,0) )

			);

			v(
				[ (0,0),(1,0),(10,-1),(0,100) ]
				,
				( (1,0), (0,100) )

			);
			v(
				[ (0,0),(1,0),(10,-1), (10,1),(0,1) ]
				,
				( (1,0), (10,1) )
			);

			v(
				[ (0,0),(10,0),(8,7), (5,5)  ,(7,8),(0,10) ]
				,
				( (0,0), (8,7 ))
			);


			v(
				[ (0,0),(10,0),(8,7), (2,2)  ,(7,8),(0,10) ]
				,
				( (0,0), (8,7 ))
			);

			v(
				[ (0,0),(10,0),(8,7), (0.1,.1)  ,(7,8),(0,10) ]
				,
				( (0,0), (8,7 ))
			);


			v(
				[ (0,0),(10,0),(8,12), (2,.1)  ,(7,8),(0,10) ]
				,
				( (10,0), (2,.1 ))
			);


		}

		private void v((double, double)[] gon, ((double, double) s, (double, double)) expected)
		{
			var actual = planar.zone_.gon_.nontri.chord._find_.by_._ByElbowX._FindChord_0nontriZone(
				gon.Select( t=> new System.Numerics.Complex(t.Item1,t.Item2))
			);

			var t=nilnul.geometry.planar.tend.re_.Eq4dbl.Unison.re(
				actual,
				(
				new(				expected.Item1.Item1,expected.s.Item2)
				,
				new(				expected.Item2.Item1,expected.Item2.Item2)

				)
			);
			Assert.IsTrue (t);


		}
	}
}
