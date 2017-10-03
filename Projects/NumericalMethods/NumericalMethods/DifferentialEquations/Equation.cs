using System;
using System.Collections;
using System.Collections.Generic;
using HelloWorld1.Grafics;

namespace HelloWorld1.DifferentialEquations
{
	public class Equation
	{
		private List<Point> _list = new List<Point>();

		public Equation()
		{
		}
		
		public double MakeFunction(double x, double y)
		{ 
			//return 6 * x * x + 5 * x * y;
			return x * x - 2 * y;
		}

		public Point GetPoint(int x)
		{
			return _list[x];
		}

		public void SetPoint(double x, double y) 
		{
			_list.Add(new Point(x, y));	
		}

		public void ShowInConsole()
		{
			foreach (var i in _list)
			{
				Console.WriteLine(i);
			}
		}
	}
}