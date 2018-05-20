Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim s = Console.ReadLine().Split()
        dim a = Integer.Parse(s(0))
        dim b = Integer.Parse(s(1))
        dim x = Integer.Parse(s(2))
        
        if a + b >= x and a <= x then
            Console.WriteLine("YES")
        else
            Console.WriteLine("NO")
        end if
    end sub
end class

