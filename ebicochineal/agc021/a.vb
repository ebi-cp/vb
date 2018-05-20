Imports System
Imports System.Collections.Generic
class P
    shared sub main()
        dim c = Console.ReadLine()
        dim l = new List(of Integer)
        for i as Integer = 0 to c.Length - 1
            l.Add(Integer.Parse(c(i)))
        next i
        if l.count > 1 then
            dim b = false
            for j as Integer = 1 to l.count-1
                if l(j) < 9 then : b = true : end if
            next j
            
            if b then
                Console.WriteLine(l(0)-1 + (l.count-1) * 9)
            else
                Console.WriteLine(l(0) + (l.count-1) * 9)
            end if
        else
            Console.WriteLine(l(0))
        end if
    end sub
end class

