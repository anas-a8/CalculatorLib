namespace CalculatorLib
{
    // This class represents a simple calculator with basic arithmetic operations
    public class Calculator
    {
        // This method adds two numbers and returns the sum
        public int Add(int a, int b)
        {
            return a + b;
        }

        // This method subtracts the second number from the first and returns the result
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // This method multiplies two numbers and returns the product
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // This method divides the first number by the second and returns the quotient
        // If the second number is 0, it throws an exception to prevent division by zero
        public double Divide(int a, int b)
        {
            if (b == 0) 
                throw new DivideByZeroException("Cannot divide by zero."); // Prevents division by zero error
            return (double)a / b; // Casts to double to get an accurate decimal result
        }
    }
}
