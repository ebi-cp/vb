Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim s = Console.ReadLine().Split()
        dim N = Integer.Parse(s(0))
        dim M = Integer.Parse(s(1))
        dim X = Integer.Parse(s(2))
        s = Console.ReadLine().Split()
        dim a = 0
        dim b = 0
        for each i as string In s
            if Integer.Parse(i) >= X then
                a += 1
            end if
            if Integer.Parse(i) <= X then
                b += 1
            end if
        next
        Console.WriteLine(Math.Min(a, b))
    end sub
end class

