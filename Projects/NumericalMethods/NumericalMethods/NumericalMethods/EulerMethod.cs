using System;
using HelloWorld1.DifferentialEquations;

namespace HelloWorld1.NumericalMethods
{
	public static class EulerMethod
	{
		
		
		//private Equation _equation;
		//private double step, countIteration;

//		public EulerMethod(Equation equation, double step, double count)
//		{
//			this._equation = equation;
//			this.step = step;
//			this.countIteration = count;
//		}

		public static bool Solve(Equation equation, double step, double countIter, double x0, double y0)
		{
			try
			{
				double x = x0, y = y0;
				for (var i = 0; i <= countIter; i++)
				{
					equation.SetPoint(x, y);
					y += step * equation.MakeFunction(x, y);
					x += step;
				}
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine("EulerMethod fail");
				Console.WriteLine(e);
				throw;
			}
		}
		
	}
}