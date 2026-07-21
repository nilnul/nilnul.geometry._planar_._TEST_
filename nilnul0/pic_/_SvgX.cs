using nilnul.geometry.planar.tope_;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.pic_
{
	static public class _SvgX
	{
		static public XDocument GenDoc(nilnul.obj.mesh.Tile viewBox)
		{
			var xDoc = new XDocument(

	);
			XNamespace xn = "http://www.w3.org/2000/svg";

			var svgRtEle = new XElement(
xn + "svg"
				);

			xDoc.Add(
				svgRtEle
			);

	//		svgRtEle.Add(
	//	new XAttribute("stroke-width", strokeWidth)
	//);
			
			svgRtEle.Add(
	new XAttribute("viewBox", $"{viewBox.point.row} {viewBox.point.col} {viewBox.size.width} {viewBox.size.height}")
);

			return xDoc;

			#region remove empty xmlns

			foreach (var node in xDoc.Root.Descendants())
			{
				// If we have an empty namespace...
				if (node.Name.NamespaceName == "")
				{
					// Remove the xmlns='' attribute. Note the use of
					// Attributes rather than Attribute, in case the
					// attribute doesn't exist (which it might not if we'd
					// created the document "manually" instead of loading
					// it from a file.)
					node.Attributes("xmlns").Remove();
					// Inherit the parent namespace instead
					node.Name = node.Parent.Name.Namespace + node.Name.LocalName;
				}
			}

			#endregion

		}

		static public void  RemoveEmptyNs(this XDocument xDoc)
		{
			

			#region remove empty xmlns

			foreach (var node in xDoc.Root.Descendants())
			{
				// If we have an empty namespace...
				if (node.Name.NamespaceName == "")
				{
					// Remove the xmlns='' attribute. Note the use of
					// Attributes rather than Attribute, in case the
					// attribute doesn't exist (which it might not if we'd
					// created the document "manually" instead of loading
					// it from a file.)
					node.Attributes("xmlns").Remove();
					// Inherit the parent namespace instead
					node.Name = node.Parent.Name.Namespace + node.Name.LocalName;
				}
			}

			#endregion

		}

		public static XDocument GenDoc(Bloc4dbl_byBounds box)
		{
			return GenDoc(
				box.anchor.x
				,box.anchor.y
				,
				box.size1.width
				,
				box.size1.height
				
			);
		}

		public static XDocument GenDoc(double x, double y, NonnegOfDoubleI width, NonnegOfDoubleI height)
		{
			return GenDoc(
				(int) x, (int)y, (int) width.realee.ee, (int) height.realee.ee
			);
		}
		public static XDocument GenDoc(double x, double y, double width, double height)
		{
			return GenDoc(
				(int) x, (int)y, (int) width, (int) height
			);
		}


		public static XDocument GenDoc(int x, int y, int ee1, int ee2)
		{
			return GenDoc(
				new obj.mesh.Tile(x,y,ee1,ee2) 
			);
		}

		internal static XDocument GenDoc(double v1, double v2)
		{

			return GenDoc(0,0,v1,v2);
		}
	}
}
