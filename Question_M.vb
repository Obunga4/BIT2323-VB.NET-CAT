' Question M
Delegate Function Calculation(a As Integer, b As Integer) As Integer 
 
Public Function Add(a As Integer, b As Integer) As Integer 
    Return a + b 
End Function 
 
Public Function Subtract(a As Integer, b As Integer) As Integer 
    Return a - b 
End Function 
 
Public Function Multiply(a As Integer, b As Integer) As Integer 
    Return a * b 
End Function 
 
Dim calc As Calculation 
 
calc = AddressOf Add 
Console.WriteLine(calc(10, 5)) 
 
calc = AddressOf Subtract 
Console.WriteLine(calc(10, 5)) 
 
calc = AddressOf Multiply 
Console.WriteLine(calc(10, 5)) 
 
'Multicast delegate 
Dim multiCalc As Calculation = AddressOf Add 
multiCalc = [Delegate].Combine(multiCalc, New Calculation(AddressOf Multiply)) 
 
'Invoke each method in the multicast delegate 
For Each d As Calculation In multiCalc.GetInvocationList() 
    Console.WriteLine(d(10, 5)) 
Next 

'This code demonstrates delegates in VB.NET. A delegate allows a variable to store and call different functions.

Add adds two numbers.
Subtract subtracts two numbers.
Multiply multiplies two numbers.
calc is used to call each function using the same delegate.
The multicast delegate allows more than one function (Add and Multiply) to be called.

For 10 and 5, the results are 15, 5, and 50.
