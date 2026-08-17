' Question H
Public Class BankAccount 
    Private _balance As Decimal 
 
    Public Property Balance As Decimal 
        Get 
            Return _balance 
        End Get 
        Set(value As Decimal) 
            If value < 0 Then 
                Throw New ArgumentException("Balance cannot be negative.") 
            End If 
            _balance = value 
        End Set 
    End Property 
 
    Public Sub Deposit(amount As Decimal) 
        If amount <= 0 Then 
            Throw New ArgumentException("Deposit must be greater than zero.") 
        End If 
 
        Balance = Balance + amount 
    End Sub 
 
    Public Function Withdraw(amount As Decimal) As Boolean 
        If amount <= 0 OrElse amount > Balance Then 
            Return False 
        End If 
 
        Balance = Balance - amount 
        Return True 
    End Function 
End Class 


Explanation

This code creates a **BankAccount class** that manages a bank balance.

* `Balance` stores the amount of money in the account.
* It **does not allow a negative balance**.
* `Deposit()` adds money to the account, but the amount must be greater than zero.
* `Withdraw()` removes money if the amount is valid and there is enough money in the account.
* The code uses **encapsulation** to protect and control how the balance is changed.

