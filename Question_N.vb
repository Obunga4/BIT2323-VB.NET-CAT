' Question N
Public Class TemperatureEventArgs 
    Inherits EventArgs 
 
    Public ReadOnly Property CurrentTemperature As Double 
    Public ReadOnly Property Threshold As Double 
 
    Public Sub New(currentTemp As Double, thresholdValue As Double) 
        CurrentTemperature = currentTemp 
        Threshold = thresholdValue 
    End Sub 
End Class 
 
Public Class TemperatureSensor 
    Public Event TemperatureExceeded As EventHandler(Of TemperatureEventArgs) 
 
    Public Sub CheckTemperature(currentTemp As Double, threshold As Double) 
        If currentTemp > threshold Then 
            RaiseEvent TemperatureExceeded( 
                Me, 
                New TemperatureEventArgs(currentTemp, threshold) 
            ) 
        End If 
    End Sub 
End Class 
 
'Windows Form 
Public Class Form1 
    Private sensor As New TemperatureSensor() 
 
    Private Sub Form1_Load(sender As Object, e As EventArgs) _ 
        Handles MyBase.Load 
 
        AddHandler sensor.TemperatureExceeded, AddressOf TemperatureWarning 
    End Sub 
 
    Private Sub TemperatureWarning(sender As Object, e As TemperatureEventArgs) 
        MessageBox.Show( 
            "Warning! Temperature is " & 
            e.CurrentTemperature & "°C, above the threshold of " & 
            e.Threshold & "°C." 
        ) 
    End Sub 
End Class 

    'This code creates a temperature sensor that gives a warning when the temperature is too high.

TemperatureEventArgs stores the current temperature and the allowed limit.
TemperatureSensor checks whether the temperature is above the limit.
If it is too high, it raises an event called TemperatureExceeded.
The Windows Form listens for this event.
When the event happens, a warning message box is displayed showing the current temperature and the threshold.
    
