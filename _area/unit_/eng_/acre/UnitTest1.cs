using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using nilnul.bit.expr_._capsule_.vars_;
using nilnul.num.quotient_.denomNonnil;

namespace nilnul.geometry.planar._test._area.unit
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Acre()
		{
			Debug.WriteLine(
				nilnul.num.quotient_.radix_.Dec1.FroQuotient(
					nilnul.geometry.planar._area.unit_.eng_.Acre.Singleton._magInQuotient
					,
					4
				)	
			);

			Debug.WriteLine(
				nilnul.num.quotient_.radix.recur_.Dec.FroQuotient(
					nilnul.geometry.planar._area.unit_.eng_.Acre.Singleton._magInQuotient
					
				)	
			);

			num.Quotient1 quotient1 = 116 * nilnul.geometry.planar._area.unit_.eng_.Acre.Singleton._magInQuotient;
			num.Quotient1 quotient11 = 47 * nilnul.geometry.planar._area.unit_.Hectare.Singleton._magInQuotient;

			var dec = nilnul.num.quotient_.radix_.dec.of_.quotienty_._PerPrecisionX.ToDec(quotient1.ToDenomNonnil(), 1000);

			var dec1= nilnul.num.quotient_.radix_.dec.of_.quotienty_._PerPrecisionX.ToDec(quotient11.ToDenomNonnil(), 1000);

			//Assert.IsTrue(
			//	nilnul.num.quotient.re_.approx_.PerKilo.Singleton.re(
			//	dec , dec1
			//	)
			//);



			Assert.IsTrue(
				nilnul.num.quotient.re_.approx_.ratio_.Hundredth.Singleton.re(
				quotient1.ToDenomNonnil() , quotient11.ToDenomNonnil()
				)
			);

		}

	
	}
}
