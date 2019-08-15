Imports System.Drawing
Module Main

    Sub Main()
        Dim sw As New Stopwatch
        Dim avgtime As UInteger
        For i = 1 To 5
            Dim bp As Bitmap = Image.FromFile("test" & i & ".png")
            sw.Reset()
            sw.Start()
            bp = RTCPGray(bp)
            sw.Stop()
            avgtime += sw.ElapsedMilliseconds
            bp.Save("rtcpgray_" & i & ".png")
            Console.WriteLine("Pic #" & i & ": " & sw.ElapsedMilliseconds.ToString)
        Next
        avgtime /= 5
        Console.WriteLine("Average time: " & sw.ElapsedMilliseconds.ToString)
        Console.ReadKey()
    End Sub

End Module
