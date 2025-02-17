# Calculator Library

## 📖 Overview
This project is a simple **Calculator Library** written in C# that provides basic arithmetic operations such as addition, subtraction, multiplication, and division. It also includes unit tests using the **xUnit** framework to verify the correctness of the methods.

---

## 🛠 Features
- ✅ **Addition (`Add`)** - Returns the sum of two numbers.
- ✅ **Subtraction (`Subtract`)** - Returns the difference between two numbers.
- ✅ **Multiplication (`Multiply`)** - Returns the product of two numbers.
- ✅ **Division (`Divide`)** - Returns the quotient of two numbers (throws an exception if divided by zero).

---

## 📂 Project Structure
```
CalculatorLib/
│── Calculator.cs           # The main calculator class
│── CalculatorLib.csproj    # The project file for CalculatorLib
│
└── CalculatorLib.Tests/    # Unit tests for the calculator
    │── CalculatorTests.cs  # Test cases for Calculator methods
    │── CalculatorLib.Tests.csproj # The project file for unit tests
```

---

## 🚀 Getting Started

### 1️⃣ **Clone the Repository**
```sh
git clone https://github.com/yourusername/CalculatorLib.git
cd CalculatorLib
```

### 2️⃣ **Build the Project**
```sh
dotnet build
```

### 3️⃣ **Run Tests**
```sh
dotnet test
```

### 4️⃣ **Use the Calculator in a Console Application**
If you want to **run the calculator and see the results**, create a `Program.cs` file in `CalculatorLib` and use this code:

```csharp
using System;
using CalculatorLib;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Calculator Operations:");
        Console.WriteLine($"Addition: 10 + 5 = {calculator.Add(10, 5)}");
        Console.WriteLine($"Subtraction: 10 - 5 = {calculator.Subtract(10, 5)}");
        Console.WriteLine($"Multiplication: 10 * 5 = {calculator.Multiply(10, 5)}");
        Console.WriteLine($"Division: 10 / 5 = {calculator.Divide(10, 5)}");

        Console.ReadLine(); // Keeps the console open
    }
}
```

Then run:
```sh
dotnet run
```

---

## 🧩 Explanation of the Code

### 📌 `Calculator.cs` (Main Calculator Logic)
- **Defines a `Calculator` class** with basic arithmetic operations.
- **Methods:**
  - `Add(int a, int b)`: Returns the sum of `a` and `b`.
  - `Subtract(int a, int b)`: Returns the difference of `a` and `b`.
  - `Multiply(int a, int b)`: Returns the product of `a` and `b`.
  - `Divide(int a, int b)`: Returns `a` divided by `b`, and throws an exception if `b` is 0.

### 📌 `CalculatorTests.cs` (Unit Tests)
- **Tests the correctness of each method in `Calculator.cs` using xUnit.**
- **Important test cases:**
  - `Add_ShouldReturnCorrectSum()`: Checks if `Add` returns the correct sum.
  - `Subtract_ShouldReturnCorrectDifference()`: Checks if `Subtract` returns the correct difference.
  - `Multiply_ShouldReturnCorrectProduct()`: Checks if `Multiply` returns the correct product.
  - `Divide_ShouldReturnCorrectQuotient()`: Checks if `Divide` returns the correct quotient.
  - `Divide_ByZero_ShouldThrowException()`: Ensures division by zero throws an exception.

---

## 🧪 Unit Tests
This project includes unit tests using the **xUnit** framework to ensure that all operations work correctly.

### **Example Test:**
```csharp
[Fact]
public void Add_ShouldReturnCorrectSum()
{
    var calculator = new Calculator();
    int result = calculator.Add(2, 3);
    Assert.Equal(5, result);
}
```

### **Run All Tests:**
```sh
dotnet test
```

✅ If all tests pass, you will see:
```
Test Run Successful.
Total tests: 5
Passed: 5
Failed: 0
Skipped: 0
```

---

## 📜 License
This project is open-source and available under the **MIT License**.









