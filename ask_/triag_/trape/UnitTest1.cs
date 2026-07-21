using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.seq.phrase_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace nilnul.geometry.planar.ask_.triag_.trape
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			f();
			void f(
				//geometry.planar.Point4dbl a
				//,
				//geometry.planar.Point4dbl b
				//,
				//geometry.planar.Point4dbl c
				//,
				//geometry.planar.Point4dbl d
			)
			{
				/// angle:bac = 40deg
				/// angle: 
				/// 
				/// establish coord at <see cref="c"/>
				/// 
				/// 

				/// generate a drawable
				/// 

				var c0 = new C(); /// the central point

				var d0 = c0 +1;	// right most

				/// calculate b0
				///  cb / sin(30deg) = 1/ sin(180-30-40 deg)
				///  
				var b0 = c0 - nilnul.geometry.planar.rotation_.deg.to_._TrigonometricX.Sin_0deg(30)/ nilnul.geometry.planar.rotation_.deg.to_._TrigonometricX.Sin_0deg(180-30-40);	/// left most

				var ba = C.FromPolarCoordinates(
					1
					,
					rotation_.Degree4dbl.ToRadian(40)
				); 

				var a0 = b0 +ba; /// highest

				/// ca/ sin(40deg) = ba/ sin(110deg)
				/// =>
				/// ca = sin(40deg) / sin(110deg)
				///		= sin(40deg) / sin(70deg)
				/// 
				/// da **2 = 1+ ( sin(40deg) / sin(110deg) ) **2 -2  ( sin(40deg) / sin(110deg) ) cos(70deg)
				/// 
				/// da/ sin(70deg) = sin(40deg)/sin(70deg) / sin(x)
				/// so,
				///		da = sin(40) sin(x)
				///		
				///  sin(x) **2  sin(40deg)**2 = 1+ ( sin(40deg) / sin(110deg) ) **2 -2  ( sin(40deg) / sin(110deg) ) cos(70deg)
				///  = 1+ ( sin(40deg) / sin(70deg) ) **2 -2  ( sin(40deg) / sin(70deg) ) cos(70deg)
				///  = 1+ ( sin(40deg) / sin(70deg) ) **2 -2  ( sin(40deg) / sin(70deg) ) sin(20deg)
				///  = 1+ ( sin(40deg) / sin(70deg) ) **2 -2  ( sin(40deg)sin(20deg) / sin(70deg) ) 
				///  = (
				///		sin(70deg)**2 +  sin(40deg)**2 -2 sin(40) sin(20) sin(70) 
				///  ) / sin(70deg)  **2  sin(40)**2
				///   


				/// 
				var tendAb = new geometry.planar.Tend4dbl(a0, b0);
				var tend8bc = new geometry.planar.Tend4dbl(b0, c0);
				var tend8ca = new geometry.planar.Tend4dbl(c0, a0);

				var tend8cd = new geometry.planar.Tend4dbl(c0, d0);

				var tend8da = new geometry.planar.Tend4dbl(d0, a0);

				var da = a0-d0;
				var dc = -d0;

				var angle =
					//Math.Abs
					( 
					dc.Phase -da.Phase 
					);

				var angleNormlized = nilnul.geometry.planar.rotation_.DirectionDbl._OfRotation(angle);

				var angleAligned= nilnul.geometry.planar.rotation_._AlignmentX.OfRotation(angle);

				var angleInDeg = geometry.planar.rotation_.Degree4dbl.FroRadian(
					//angleNormlized
				angleAligned
					);


				var e = c0+ba;

				var tendCe = new Tend4dbl(c0, e);

				var tendAe= new Tend4dbl(a0, e);
				var tendDe= new Tend4dbl(d0, e);


				Assert.IsTrue(
					nilnul.num.real.re_.approx_.Hundredth4dbl.Singleton.re(angleInDeg, 40)
				);

				IEnumerable<Tend4dbl> tends = (IEnumerable<Tend4dbl>)[tendAb, tend8bc, tend8ca, tend8cd, tend8da
					,tendCe
					,tendAe
					,tendDe
					];



				var box = points_.dwelt._BoundaryX._Boundary_0dwelt(

					tends.SelectMany(
						x => (IEnumerable<Point4dblI>)[x.Item1, x.Item2]
					)
				);


				


				var container = nilnul.geometry._planar_._TEST_._this.data.dir_.exclave.dnt_.next.UnitTest1.Address(
					"t", ".svg"
				);


				const int scale = 1000;
				double vHeight = box.size1.height.realee *scale;
				var svgDoc = nilnul.pic_._SvgX.GenDoc(
					box.size1.width.realee*scale
					,
					vHeight
				);


				;
				var g = new XElement(
					"g"
					,
					new XAttribute(
						"transform"
						,
						//"translate(-50,-50) scale(-1,1) translate(50,50)"

						//$"translate({-box.anchor.x},{-box.anchor.y}) scale({scale},{-scale}) translate({0},{-scale})"
						$"translate({0},{vHeight}) scale({scale},{-scale}) translate({-box.anchor.x},{-box.anchor.y})"

						//"scale(-1,1) scale(1,-1)"
						//"scale(-1,1) "
						//" scale(1,-1) "
						)
					,
					new XAttribute(
						"stroke-width"
						,"0.002"
					)
				);

				svgDoc.Root.Add(g);

				//g.Add(
				//	new XElement(
				//		"text"
				//		,

				//	)
				//);

				tends.Each(
					t => g.Add(
						geometry.planar.tend._DrawX.Draw(t)
					)
				);

			nilnul.pic_._SvgX.RemoveEmptyNs(svgDoc);

			System.IO.File.WriteAllText(container.ToString(), svgDoc.ToString());

			//nilnul.fs.file.explore_._SelX.Vod(tgtFile);

			nilnul.fs.file._ExeX.Exe(container);
			nilnul.win.prog_.notepad.run_.shell_.NewWin.Singleton.run(container.ToString());



			}
		}
		[TestMethod]
		public void TestMethodZhu()
		{
			f();
			void f(
				//geometry.planar.Point4dbl a
				//,
				//geometry.planar.Point4dbl b
				//,
				//geometry.planar.Point4dbl c
				//,
				//geometry.planar.Point4dbl d
			)
			{
				/// angle:bac = 40deg
				/// angle: 
				/// 
				/// establish coord at <see cref="c"/>
				/// 
				/// 

				/// generate a drawable
				/// 

				var c0 = new C(); /// the central point

				var d0 = c0 +1; // right most

				/// calculate b0
				///  cb / sin(30deg) = 1/ sin(180-30-40 deg)
				///  
				double cbLenght = nilnul.geometry.planar.rotation_.deg.to_._TrigonometricX.Sin_0deg(30)/ nilnul.geometry.planar.rotation_.deg.to_._TrigonometricX.Sin_0deg(180-30-40);
				/// calculate b0
				///  cb / sin(30deg) = 1/ sin(180-30-40 deg)
				///  
				var b0 = c0 - cbLenght;	/// left most

				var ba = C.FromPolarCoordinates(
					1
					,
					rotation_.Degree4dbl.ToRadian(40)
				); 

				var a0 = b0 +ba; /// highest

				/// ca/ sin(40deg) = ba/ sin(110deg)
				/// =>
				/// ca = sin(40deg) / sin(110deg)
				///		= sin(40deg) / sin(70deg)
				/// 
				/// da **2 = 1+ ( sin(40deg) / sin(110deg) ) **2 -2  ( sin(40deg) / sin(110deg) ) cos(70deg)
				/// 
				/// da/ sin(70deg) = sin(40deg)/sin(70deg) / sin(x)
				/// so,
				///		da = sin(40) sin(x)
				///		
				///  sin(x) **2  sin(40deg)**2 = 1+ ( sin(40deg) / sin(110deg) ) **2 -2  ( sin(40deg) / sin(110deg) ) cos(70deg)
				///  = 1+ ( sin(40deg) / sin(70deg) ) **2 -2  ( sin(40deg) / sin(70deg) ) cos(70deg)
				///  = 1+ ( sin(40deg) / sin(70deg) ) **2 -2  ( sin(40deg) / sin(70deg) ) sin(20deg)
				///  = 1+ ( sin(40deg) / sin(70deg) ) **2 -2  ( sin(40deg)sin(20deg) / sin(70deg) ) 
				///  = (
				///		sin(70deg)**2 +  sin(40deg)**2 -2 sin(40) sin(20) sin(70) 
				///  ) / sin(70deg)  **2  sin(40)**2
				///   


				/// 
				var tendAb = new geometry.planar.Tend4dbl(a0, b0);
				var tend8bc = new geometry.planar.Tend4dbl(b0, c0);
				var tend8ca = new geometry.planar.Tend4dbl(c0, a0);

				var tend8cd = new geometry.planar.Tend4dbl(c0, d0);

				var tend8da = new geometry.planar.Tend4dbl(d0, a0);

				var da = a0-d0;
				var dc = -d0;

				var angle =
					//Math.Abs
					( 
					dc.Phase -da.Phase 
					);

				var angleNormlized = nilnul.geometry.planar.rotation_.DirectionDbl._OfRotation(angle);

				var angleAligned= nilnul.geometry.planar.rotation_._AlignmentX.OfRotation(angle);

				var angleInDeg = geometry.planar.rotation_.Degree4dbl.FroRadian(
					//angleNormlized
				angleAligned
					);


				var e = c0+C.FromPolarCoordinates(
					cbLenght
					,
					nilnul.geometry.planar.rotation_.Degree4dbl.ToRadian(-40)
				);

				var tendCe = new Tend4dbl(c0, e);

				//var tendAe= new Tend4dbl(a0, e);
				var tendDe= new Tend4dbl(d0, e);


				Assert.IsTrue(
					nilnul.num.real.re_.approx_.Hundredth4dbl.Singleton.re(angleInDeg, 40)
				);

				Assert.IsTrue(
					nilnul.num.real.re_.approx_.Hundredth4dbl.Singleton.re(
						a0.Magnitude
					, 
						(d0-e).Magnitude
					)
				);


				IEnumerable<Tend4dbl> tends = (IEnumerable<Tend4dbl>)[tendAb, tend8bc, tend8ca, tend8cd, tend8da
					,tendCe
					//,tendAe
					,tendDe
					];



				var box = points_.dwelt._BoundaryX._Boundary_0dwelt(

					tends.SelectMany(
						x => (IEnumerable<Point4dblI>)[x.Item1, x.Item2]
					)
				);


				


				var container = nilnul.geometry._planar_._TEST_._this.data.dir_.exclave.dnt_.next.UnitTest1.Address(
					"t", ".svg"
				);


				const int scale = 1000;
				double vHeight = box.size1.height.realee *scale;
				var svgDoc = nilnul.pic_._SvgX.GenDoc(
					box.size1.width.realee*scale
					,
					vHeight
				);


				;
				var g = new XElement(
					"g"
					,
					new XAttribute(
						"transform"
						,
						//"translate(-50,-50) scale(-1,1) translate(50,50)"

						//$"translate({-box.anchor.x},{-box.anchor.y}) scale({scale},{-scale}) translate({0},{-scale})"
						$"translate({0},{vHeight}) scale({scale},{-scale}) translate({-box.anchor.x},{-box.anchor.y})"

						//"scale(-1,1) scale(1,-1)"
						//"scale(-1,1) "
						//" scale(1,-1) "
						)
					,
					new XAttribute(
						"stroke-width"
						,"0.002"
					)
				);

				svgDoc.Root.Add(g);

				//g.Add(
				//	new XElement(
				//		"text"
				//		,

				//	)
				//);

				tends.Each(
					t => g.Add(
						geometry.planar.tend._DrawX.Draw(t)
					)
				);

			nilnul.pic_._SvgX.RemoveEmptyNs(svgDoc);

			System.IO.File.WriteAllText(container.ToString(), svgDoc.ToString());

			//nilnul.fs.file.explore_._SelX.Vod(tgtFile);

			nilnul.fs.file._ExeX.Exe(container);
			nilnul.win.prog_.notepad.run_.shell_.NewWin.Singleton.run(container.ToString());



			}
		}

	}
}
