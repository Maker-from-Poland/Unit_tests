using Xunit;
using System;
using System.Collections.Generic;

namespace TestyJednostkowe
{
    public class QuadraticEquationSolverTests
    {
        [Fact]
        public void ShouldReturnNoRealRoots()
        {
            // Arrange
            double a = 1;
            double b = 0;
            double c = 1;

            // Act
            var result = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ShouldReturnOneRealRoot()
        {
            // Arrange
            double a = 1;
            double b = -2;
            double c = 1;

            // Act
            var result = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Single(result);
            Assert.Equal(1, result[0]);
        }

        [Fact]
        public void ShouldReturnTwoRealRoots()
        {
            // Arrange
            double a = 1;
            double b = -3;
            double c = 2;

            // Act
            var result = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
        }
    }

    public class QuadraticEquationSolver
    {
        public static List<double> Solve(double a, double b, double c)
        {
            List<double> roots = new List<double>();

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

                roots.Add(root1);
                roots.Add(root2);
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                roots.Add(root);
            }

            return roots;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            

          
            double a = 1;
            double b = -3;
            double c = 2;

            var roots = QuadraticEquationSolver.Solve(a, b, c);
            Console.WriteLine("Pierwiastki równania kwadratowego:");
            foreach (var root in roots)
            {
                Console.WriteLine(root);
            }

       
            Console.ReadKey();
        }
    }
}
