Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim d = Console.ReadLine().ToCharArray()
        dim c = Console.ReadLine().ToCharArray()
        dim b = Console.ReadLine().ToCharArray()
        dim a = Console.ReadLine().ToCharArray()
        for i as Integer = 0 to a.Length - 1 : Console.Write(a(a.Length - i - 1)) : next i : Console.WriteLine()
        for i as Integer = 0 to b.Length - 1 : Console.Write(b(b.Length - i - 1)) : next i : Console.WriteLine()
        for i as Integer = 0 to c.Length - 1 : Console.Write(c(c.Length - i - 1)) : next i : Console.WriteLine()
        for i as Integer = 0 to d.Length - 1 : Console.Write(d(d.Length - i - 1)) : next i : Console.WriteLine()
    end sub
end class