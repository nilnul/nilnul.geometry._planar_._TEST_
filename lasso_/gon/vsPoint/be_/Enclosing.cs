using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P = System.Numerics.Complex;

namespace nilnul.geometry.planar.lasso_.gon.vsPoint.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		confine
	///			,by treach or wall
	///		enclosing
	///		imprison
	///		constrict
	///
	///geeksforgeeks.org/how-to-check-if-a-given-point-lies-inside-a-polygon/
	static public  class _ConfineX
	{
		// Function to check if a point is inside a polygon
		static bool PointInPolygon(P point, List<P> polygon)
		{
			int numVertices = polygon.Count;
			double x = point.Real, y = point.Imaginary;
			bool inside = false;

			// Store the first point in the polygon and initialize the second point
			P p1 = polygon[0], p2;

			// Loop through each edge in the polygon
			for (int i = 1; i <= numVertices; i++)
			{
				// Get the next point in the polygon
				p2 = polygon[i % numVertices];

				// Check if the point is above the minimum y coordinate of the edge
				if (y > Math.Min(p1.Imaginary, p2.Imaginary))
				{
					// Check if the point is below the maximum y coordinate of the edge
					if (y <= Math.Max(p1.Imaginary, p2.Imaginary))
					{
						// Check if the point is to the left of the maximum x coordinate of the edge
						if (x <= Math.Max(p1.Real, p2.Real))
						{
							// Calculate the x-intersection of the line connecting the point to the edge
							double xIntersection = (y - p1.Real) * (p2.Real - p1.Real) / (p2.Imaginary - p1.Imaginary) + p1.Real;

							// Check if the point is on the same line as the edge or to the left of the x-intersection
							if (
								//p1.Real == p2.Real ||
								x <= xIntersection
							)
							{
								// Flip the inside flag
								inside = !inside;
							}
						}
					}
				}

				// Store the current point as the first point for the next iteration
				p1 = p2;
			}

			// Return the value of the inside flag
			return inside;
		}

		// Driver code

		static void Main(string[] args)
		{
			// Define a point to test
			P point = new P (  150,   85 );

			// Define a polygon
			List<P> polygon = new List<P>
		{
			new P (186, 14),
			new P (186, 44),
			new P (175, 115),
			new P (175, 85)
		};

			// Check if the point is inside the polygon
			if (PointInPolygon(point, polygon))
			{
				Console.WriteLine("Point is inside the polygon");
			}
			else
			{
				Console.WriteLine("Point is outside the polygon");
			}
		}
	}
}
