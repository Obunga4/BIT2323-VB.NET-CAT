' Question L
 Library.Books 
Namespace Library.Books 
    Public Class Book 
        Public Property BookID As Integer 
        Public Property Title As String 
        Public Property Author As String 
        Public Property ISBN As String 
        Public Property IsAvailable As Boolean 
    End Class 
End Namespace 
 
' Library.Members 
Namespace Library.Members 
    Public Class Member 
        Public Property MemberID As Integer 
        Public Property FullName As String 
        Public Property Email As String 
        Public Property Phone As String 
    End Class 
End Namespace 
 
' Library.Loans 
Namespace Library.Loans 
    Public Class Loan 
        Public Property LoanID As Integer 
        Public Property BookID As Integer 
        Public Property MemberID As Integer 
        Public Property LoanDate As Date 
        Public Property ReturnDate As Date? 
    End Class 
End Namespace 
 
' Windows Form 
Imports Library.Books 
Imports Library.Members 
Imports Library.Loans 
 
Dim book1 As New Book With { 
    .BookID = 1, .Title = "VB.NET Programming", 
    .Author = "John Smith", .ISBN = "123456789", 
    .IsAvailable = True 
} 
 
Dim member1 As New Member With { 
    .MemberID = 1, .FullName = "Mary Jane", 
    .Email = "mary@example.com", .Phone = "0712345678" 
} 
 
Dim loan1 As New Loan With { 
    .LoanID = 1, .BookID = book1.BookID, 
    .MemberID = member1.MemberID, 
    .LoanDate = Date.Today, .ReturnDate = Nothing 
} 
 
ListBox1.Items.Add("Book: " & book1.Title) 
ListBox1.Items.Add("Author: " & book1.Author) 
ListBox1.Items.Add("Member: " & member1.FullName) 
ListBox1.Items.Add("Email: " & member1.Email) 
ListBox1.Items.Add("Loan ID: " & loan1.LoanID) 
ListBox1.Items.Add("Loan Date: " & loan1.LoanDate.ToShortDateString()) 

'This code creates a simple library management system.

Book stores information about a book, such as its title, author, and ISBN.
Member stores information about a library member.
Loan stores information about a borrowed book and the member who borrowed it.
The code creates one book, one member, and one loan.
Finally, it displays their information in a ListBox on the Windows Form.
