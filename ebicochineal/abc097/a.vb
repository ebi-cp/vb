' module m
'     sub main()
'         dim l = Console.ReadLine().Split()
'         dim a = Integer.Parse(l(0)), b = Integer.Parse(l(1)), c = Integer.Parse(l(2)), d = Integer.Parse(l(3))
'         dim x = System.Math.Abs(b-a) <= d and System.Math.Abs(c-b) <= l(3)
'         dim y = System.Math.Abs(c-a) <= d
'         if x or y = True then
'             Console.WriteLine("Yes")
'         else
'             Console.WriteLine("No")
'         end if
'     end sub
' end module

' module m
'     sub main()
'         dim l = Console.ReadLine().Split().Select(Function(s) Integer.Parse(s)).ToList()
'         dim a = l(0), b = l(1), c = l(2), d = l(3)
'         dim x = System.Math.Abs(b-a) <= d and System.Math.Abs(c-b) <= l(3)
'         dim y = System.Math.Abs(c-a) <= d
'         if x or y = True then
'             Console.WriteLine("Yes")
'         else
'             Console.WriteLine("No")
'         end if
'     end sub
' end module

Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        ' dim l = Console.ReadLine().Split().Select(Function(s) Integer.Parse(s)).ToList()
        dim l as new List(of String)
        
        for each i as Integer in Console.ReadLine().Split().Select(Function(s as String) Integer.Parse(s))
            l.add(i)
        next
        
        dim a = l(0), b = l(1), c = l(2), d = l(3)
        dim x = System.Math.Abs(b-a) <= d and System.Math.Abs(c-b) <= l(3)
        dim y = System.Math.Abs(c-a) <= d
        if x or y = True then
            Console.WriteLine("Yes")
        else
            Console.WriteLine("No")
        end if
    end sub
end class