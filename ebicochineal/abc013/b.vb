Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim a = Integer.Parse(Console.ReadLine())
        dim b = Integer.Parse(Console.ReadLine())
        Console.WriteLine(math.min(math.min(a, b) + 10 - math.max(a, b), math.abs(a - b)))
    end sub
end class