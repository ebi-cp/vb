Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim x = Integer.Parse(Console.ReadLine())
        dim s = 0.0
        For i As Integer = 1 To x
            s += i / x
        Next i
    Console.WriteLine(s * 10000)
    end sub
end class