' Question C
Imports System.IO 
 
Dim filePath As String = "data.txt" 
 
Using reader As New StreamReader(filePath) 
    Dim contents As String = reader.ReadToEnd() 
    MessageBox.Show(contents) 
End Using 

'  Simple Explanation

This code opens a text file called `data.txt, reads all the information inside it, and then displays the contents in a message box.

* `StreamReader` is used to read the file.
* `ReadToEnd()` reads everything in the file.
* `MessageBox.Show()` displays the information.
* `Using` automatically closes the file after reading it.

