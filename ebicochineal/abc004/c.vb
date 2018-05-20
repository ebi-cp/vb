Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim a = Integer.Parse(Console.ReadLine()) mod 30
        dim l() as Char = {"1", "2", "3", "4", "5", "6"}
        for i as Integer = 0 to a - 1
            dim j = i mod 5
            dim t = l(j)
            l(j) = l(j+1)
            l(j+1) = t
        next i
        Console.WriteLine(l(0)+l(1)+l(2)+l(3)+l(4)+l(5))
    end sub
end class