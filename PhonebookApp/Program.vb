Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        dim repeat as Boolean = true
        Do While repeat
            Console.WriteLine("How are you today?")
            Console.WriteLine("{0} I'm Doing Good")
            Console.WriteLine("[1] I've been better")
            Dim input as string = Console.ReadLine()
            Select Case input
                Case "0"
                    Console.WriteLine("Doing Good")
                Case "1"                    
                    Console.WriteLine("Been Better")
                    repeat = false
            End Select
        Loop
    End Sub
End Module