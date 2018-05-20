Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim n = Integer.Parse(Console.ReadLine())
        dim s = Console.ReadLine().Split()
        dim l = new List(of Integer)
        for each i as String In s : l.Add(Integer.Parse(i)) : next
        dim t = New List(Of Integer)
        for each i as Integer In l : t.Add(i) : next
        t.sort()
        dim x = CInt(n / 2) - 1
        for i as Integer = 0 to n-1
            if l(i) <= t(x) then
                Console.WriteLine(t(x+1))
            else
                Console.WriteLine(t(x))
            end if
        next i
    end sub
end class

