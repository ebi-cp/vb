Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim s = Console.ReadLine()
        dim k = Integer.Parse(Console.ReadLine())
        dim hs as new HashSet(of String)
        dim l as new List(of String)
        for i as Integer = 0 To s.Length
            for j as Integer = 0 To k + 1
                if s.Length > (i + j) then
                    hs.Add(s.Substring(i, j))
                else
                    hs.Add(s.Substring(i, j - ((i + j) - s.Length)))
                end if
            next
        next
        for each i as String in hs
            l.Add(i)
        next
        l.Sort()
        Console.WriteLine(l(k))
    end sub
end class

