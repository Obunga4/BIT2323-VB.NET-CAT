' Question I
Public Class Form1 
    Private WithEvents btnShowTime As New Button() 
    Private lblDateTime As New Label() 
 
    Private Sub btnShowTime_Click(sender As Object, e As EventArgs) _ 
        Handles btnShowTime.Click 
 
        lblDateTime.Text = DateTime.Now.ToString() 
    End Sub 
End Class 

Explanation

This code creates a button and a label on a Windows Form. 
When the user clicks the Show Time button, the program gets the current date and time and displays it on the label.

* `btnShowTime` = the button.
* `lblDateTime` = the label.
* `DateTime.Now` = gets the current date and time.
* `lblDateTime.Text` = displays the date and time.

