' Question K
Imports System.IO 
 
Try 
    Dim filePath As String = "data.txt" 
 
    Using reader As New StreamReader(filePath) 
        Dim contents As String = reader.ReadToEnd() 
        MessageBox.Show(contents) 
    End Using 
 
Catch ex As FileNotFoundException 
    MessageBox.Show("The file was not found.") 
 
Catch ex As IOException 
    MessageBox.Show("A file input/output error occurred.") 
 
Finally 
    MessageBox.Show("File operation cleanup completed.") 
End Try 

'This code reads data from a file called data.txt and displays it in a message box.

Try attempts to read the file.
Catch handles errors if the file is missing or another file error occurs.
Finally runs at the end and shows that the file operation is complete.
