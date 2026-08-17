' Question J
Public MustInherit Class Shape 
    Public MustOverride Function CalculateArea() As Double 
    Public MustOverride Function CalculatePerimeter() As Double 
End Class 
 
Public Class Rectangle 
    Inherits Shape 
 
    Private Width As Double 
    Private Height As Double 
 
    Public Sub New(w As Double, h As Double) 
        Width = w 
        Height = h 
    End Sub 
 
    Public Overrides Function CalculateArea() As Double 
        Return Width * Height 
    End Function 
 
    Public Overrides Function CalculatePerimeter() As Double 
        Return 2 * (Width + Height) 
    End Function 
End Class 
 
Public Class Circle 
    Inherits Shape 
 
    Private Radius As Double 
 
    Public Sub New(r As Double) 
        Radius = r 
    End Sub 
 
    Public Overrides Function CalculateArea() As Double 
        Return Math.PI * Radius * Radius 
    End Function 
 
    Public Overrides Function CalculatePerimeter() As Double 
        Return 2 * Math.PI * Radius 
    End Function 
End Class

    This code shows inheritance and abstraction in VB.NET.

Shape is an abstract class that defines how to calculate area and perimeter.
Rectangle inherits from Shape and calculates the area and perimeter of a rectangle.
Circle also inherits from Shape and calculates the area and perimeter of a circle.
In simple terms, the code allows different shapes to calculate their area and perimeter in their own way.
