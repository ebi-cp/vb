Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim a = Console.ReadLine()
        dim b = Console.ReadLine()
        dim s = 0
        For i As Integer = 0 To a.Length-1
            if a(i) <> b(i)
                if a(i) = "@" and "atcoder".IndexOf(b(i)) < 0 : s -= 1 : end if
                if b(i) = "@" and "atcoder".IndexOf(a(i)) < 0 : s -= 1 : end if
                if a(i) <> "@" and b(i) <> "@" : s -= 1 : end if
            end if
        Next i
        
        if s < 0 then
            Console.WriteLine("You will lose")
        else
            Console.WriteLine("You can win")
        end if
    end sub
end class