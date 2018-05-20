class p
    shared sub main()
        dim n = Integer.Parse(Console.ReadLine())
        dim a = 1
        for i as Integer = 1 To 32
            for j as Integer = 2 To 32
                dim t = i ^ j
                if t <= n then
                    a = Math.Max(t, a)
                else
                    exit for
                end if
            next
        next
        Console.WriteLine(a)
    end sub
end class