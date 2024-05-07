﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.zone_.gon_.concave_.big_
{
	[TestClass]
	public class UnitTest1
	{


		static public (double, double)[] Zone()
		{

			var hull = new (double,double)[] {
				(0,0)
				,
				(50, 0)
				,
				(80,-10)
				,
				(100,11)
				,
				(110, 110)
				,
				(90,120)
				,
				(-1,90)

			};

			return hull;
		}
	}
}
