using System;
using System.Net.Mime;
using HelloWorld1.DifferentialEquations;
using HelloWorld1.NumericalMethods;

namespace HelloWorld1.Main
{
	public class Solution
	{
		public static void Main(string[] args)
		{
			Mono.
			Console.WriteLine("Hello World!");
			var equation = new Equation();
			if (EulerMethod.Solve(equation, 0.1, 10, 0, 1))
			{
				equation.ShowInConsole();
			}
		}		
	}
}