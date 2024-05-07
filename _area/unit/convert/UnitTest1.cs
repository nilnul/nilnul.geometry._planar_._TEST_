
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using nilnul.geometry.planar;
using nilnul.geometry.planar._area.unit;

namespace nilnul.geometry.planar._test._area.unit.convert
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Acre2SqYards()
		{

			Debug.WriteLine(
				planar._area.unit.op_._UnaryX.Acre2SqYards
				
			);

		}

		[TestMethod]
		public void Sqft2sqm()
		{
			Debug.WriteLine(
				nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(
					planar._area.unit_.eng_.SquareFt.ToSqMeters(1)
					,20
				)
			);

			Debug.WriteLine(
				nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(
					planar._area.unit_.eng_.SquareFt.ToSqMeters(3000)
					,20	
				)
			);


		}
		[TestMethod]
		public void Acre2Hectare()
		{

			

			Debug.WriteLine(


					nilnul.geometry.planar._area.unit.op_._UnaryX.Acre2Hectare.boxed



			);

			Debug.WriteLine(
				nilnul.num.quotient_.radix_.Dec1.FroQuotient(

					nilnul.geometry.planar._area.unit.op_._UnaryX.Acre2Hectare.boxed
					, 4

				)
			);

			Debug.WriteLine(
				nilnul.num.quotient_.radix.recur_.Dec.FroQuotient(

					nilnul.geometry.planar._area.unit.op_._UnaryX.Acre2Hectare.boxed

				)
			);


		}
	}
}
