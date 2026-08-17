# BIT2323-VB.NET CAT
VB.NET Application Programming II CAT 
# VB.NET Code Explanations

## 1. Structure and Class

This code demonstrates the difference between a Structure and a Class. The `Point` structure stores coordinates such as X and Y. The `Student` class stores information about a student, such as their name and age. In simple terms, a Structure is useful for storing small related values, while a Class is useful for representing objects such as students.

## 2. Reading a Text File

This code opens a file called `data.txt`, reads all the information inside it, and displays the contents in a message box. `StreamReader` is used to read the file, while `ReadToEnd()` reads everything in it. The `Using` statement automatically closes the file after reading.

## 3. Bank Account

This code creates a **BankAccount class** that manages a bank balance. It prevents the balance from becoming negative. The `Deposit()` method adds money to the account, while the `Withdraw()` method removes money when there is enough balance. It demonstrates encapsulation, where the balance is controlled through specific methods and properties.

## 4. Date and Time

This code creates a button and a label on a Windows Form. When the user clicks the button, the program gets the current date and time using `DateTime.Now` and displays it on the label.

## 5. Shapes, Inheritance and Abstraction

This code demonstrates inheritance and abstraction. The `Shape` class defines methods for calculating area and perimeter. The `Rectangle` and `Circle` classes inherit from `Shape` and provide their own calculations. In simple terms, different shapes can calculate their area and perimeter in their own way.

## 6. File Error Handling

This code reads information from a file called `data.txt` and displays it. The `Try` block attempts to read the file, while `Catch` handles errors such as the file not being found or other input/output problems. The `Finally` block runs at the end. In simple terms, it reads a file safely while handling possible errors.

## 7. Library Management System

This code creates a simple library management system. The `Book` class stores book information, the `Member` class stores member information, and the `Loan` class stores information about borrowed books. The program creates a book, a member, and a loan, then displays their information in a ListBox. In simple terms, it keeps track of books, members, and borrowed books.

## 8. Delegates

This code demonstrates delegates in VB.NET. A delegate allows a variable to call different functions. The program has `Add`, `Subtract`, and `Multiply` functions. The delegate is used to call each function. A multicast delegate can call more than one function, such as `Add` and `Multiply`. In simple terms, a delegate allows the program to choose which function to run.

## 9. Temperature Sensor and Events

This code creates a temperature sensor that checks whether the temperature is above a specified limit. If the temperature is too high, it raises an event called `TemperatureExceeded`. The Windows Form responds to the event by displaying a warning message containing the current temperature and the allowed threshold. In simple terms, the program checks the temperature and alerts the user when it becomes too high.
