' Question B
Public Structure Point 
    Public X As Integer 
    Public Y As Integer 
End Structure 
 
Public Class Student 
    Public Name As String 
    Public Age As Integer 
End Class 
 
'Structure suitable for a small value such as a coordinate 
Dim p As New Point With {.X = 10, .Y = 20} 
 
'Class suitable for an object with identity and behavior 
Dim student1 As New Student With {.Name = "John", .Age = 20} 

    ' This VB.NET code demonstrates the difference between a Structure
    and a **Class**. The `Point` structure is created to store two integer values
     `X` and `Y`, which represent a coordinate. The code then creates
      a `Point` object with the values `X = 10` and `Y = 20`, representing the coordinate
          (10, 20) The `Student` class is created to represent a student and contains two 
            properties: `Name` and `Age`. A student object called `student1` is then created
            with the name **John** and age **20**. In simple terms, the code shows that a **
              Structure** is suitable for storing small related values, such as coordinates,
                while a **Class** is suitable for representing objects with their own data and identity, such as a student.

