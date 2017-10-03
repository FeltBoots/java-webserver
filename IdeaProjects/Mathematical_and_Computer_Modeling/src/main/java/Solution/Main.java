package Solution;

import DifferentialEquations.Equation;
import NumericalMethods.Runge_KuttaMethod;
import org.knowm.xchart.QuickChart;
import org.knowm.xchart.SwingWrapper;
import org.knowm.xchart.XYChart;

public class Main {
    public static void main(String[] args) {
        Equation equation = new Equation();
        if (Runge_KuttaMethod.Solve(equation, 0.1, 10, 0, 1)) {
            XYChart chart = QuickChart.getChart("Runge_KuttaMethod", "X", "Y", "y(x)", Equation.getX(), Equation.getY());
            new SwingWrapper(chart).displayChart();
        }
    }
}
