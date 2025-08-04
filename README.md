# DCIT318 Console Applications

This project contains three C# console applications developed as part of a Programming II assignment. Each app demonstrates core programming concepts including input validation, object-oriented design, and modularity.

## Applications Overview

### 1. Grade Calculator
**Functionality:**  
Prompts the user to input a numerical grade between 0 and 100 and outputs the corresponding letter grade based on a predefined scale.

**Key Concepts:**  
- Encapsulation via a `Grade` class  
- Input validation using `TryParse`  
- Conditional logic (`if-else`)  

### 2. Ticket Price Calculator
**Functionality:**  
Calculates movie ticket prices based on user age. Standard price is GHC10. Discounts apply for children (≤12) and senior citizens (≥65), who pay GHC7.

**Key Concepts:**  
- Use of a `Customer` class to encapsulate pricing logic  
- List collection to handle multiple customer entries  
- Summary display including grand total  

### 3. Triangle Type Identifier
**Functionality:**  
Determines the type of a triangle (Equilateral, Isosceles, Scalene) based on the three sides entered by the user.

**Key Concepts:**  
- Triangle inequality validation  
- `Triangle` class with constructor and methods  
- Input loop with numeric checks  

## Requirements

- [.NET 10.0 SDK (Preview)](https://aka.ms/dotnet-hello-world)
- Visual Studio Code or any text editor
- C# console runtime

## How to Run

1. Clone or navigate to each application's folder.
2. Initialize a console project if needed:
   ```bash
   dotnet new console
