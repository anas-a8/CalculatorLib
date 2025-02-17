using Xunit; // Import the xUnit testing framework
using CalculatorLib; // Import the Calculator library

namespace CalculatorLib.Tests
{
    // This class contains test cases to check if the Calculator methods work correctly
    public class CalculatorTests
    {
        // Test to check if the Add method returns the correct sum
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calculator = new Calculator(); // Create an instance of the Calculator
            int result = calculator.Add(2, 3); // Call the Add method with 2 and 3
            Assert.Equal(5, result); // Verify if the result is 5
        }

        // Test to check if the Subtract method returns the correct difference
        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            var calculator = new Calculator();
            int result = calculator.Subtract(5, 3); // Call Subtract method with 5 and 3
            Assert.Equal(2, result); // Verify if the result is 2
        }

        // Test to check if the Multiply method returns the correct product
        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            var calculator = new Calculator();
            int result = calculator.Multiply(3, 4); // Call Multiply method with 3 and 4
            Assert.Equal(12, result); // Verify if the result is 12
        }

        // Test to check if the Divide method returns the correct quotient
        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            var calculator = new Calculator();
            double result = calculator.Divide(10, 2); // Call Divide method with 10 and 2
            Assert.Equal(5, result); // Verify if the result is 5
        }

        // Test to check if the Divide method throws an exception when dividing by zero
        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0)); // Verify that dividing by zero throws an exception
        }
    }
}
