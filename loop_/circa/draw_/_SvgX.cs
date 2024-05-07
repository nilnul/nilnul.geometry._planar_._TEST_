using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;

namespace nilnul.geometry.planar.loop_.circa.draw_
{
	static public class _SvgX
	{
		static public XElement Draw2el(
			this nilnul.geometry.planar.loop_.Circ0point4Dbl circa
		)
		{

			return new XElement(
				"circle"
				,
				new XAttribute("cx", circa.center.x)
				,
				new XAttribute("cy", circa.center.y)
				,
				new XAttribute("r", circa.radius)
			);

		}
	}
}
