Imports System
Imports System.IO
Imports System.Math
Imports System.Collections.Generic
 
public class E512IO
    public separator as char = " "c
    private reads() as String
    private index as Int32
    public sub new (Optional ByVal autoflush as boolean = true)
        dim sw = new StreamWriter(Console.OpenStandardOutput())
        sw.AutoFlush = autoflush
        Console.SetOut(sw)
        me.reads = new String(){}
        me.index = 0
    end sub
    protected overrides sub Finalize ()
        Console.Out.Flush()
    end sub
    private function NextValue () as String
        me.index += 1
        if me.index > me.reads.Length - 1 then
            dim t() as String = Console.ReadLine().Split(separator)
            me.reads = t
            me.index = 0
        end if
        return me.reads(me.index)
    end function
    public function NextIntArray () as Int32()
        dim t() as String = Console.ReadLine().Split(separator) : me.index = t.Length
        dim r(t.Length-1) as Int32
        for i as Int32 = 0 to t.Length - 1 : r(i) = Int32.Parse(t(i)) : next i
        return r
    end function
    public function NextLongArray () as Int64()
        dim t() as String = Console.ReadLine().Split(separator) : me.index = t.Length
        dim r(t.Length-1) as Int64
        for i as Int32 = 0 to t.Length - 1 : r(i) = Int64.Parse(t(i)) : next i
        return r
    end function
    public function NextDoubleArray () as Double()
        dim t() as String = Console.ReadLine().Split(separator) : me.index = t.Length
        dim r(t.Length-1) as Double
        for i as Int32 = 0 to t.Length - 1 : r(i) = Double.Parse(t(i)) : next i
        return r
    end function
    public function NextStringArray () as String()
        dim t() as String = Console.ReadLine().Split(separator) : me.index = t.Length
        return t
    end function
    public function NextIntList () as List(of Int32)
        dim t() as String = Console.ReadLine().Split(separator) : me.index = t.Length
        dim r as new List(of Int32)
        for i as Int32 = 0 to t.Length - 1 : r.Add(Int32.Parse(t(i))) : next i
        return r
    end function
    public function NextLongList () as List(of Int64)
        dim t() as String = Console.ReadLine().Split(separator) : me.index = t.Length
        dim r as new List(of Int64)
        for i as Int32 = 0 to t.Length - 1 : r.Add(Int64.Parse(t(i))) : next i
        return r
    end function
    public function NextDoubleList () as List(of Double)
        dim t() as String = Console.ReadLine().Split(separator) : me.index = t.Length
        dim r as new List(of Double)
        for i as Int32 = 0 to t.Length - 1 : r.Add(Double.Parse(t(i))) : next i
        return r
    end function
    public function NextStringList () as List(of String)
        dim t() as String = Console.ReadLine().Split(separator) : me.index = t.Length
        dim r as new List(of String)
        for i as Int32 = 0 to t.Length - 1 : r.Add(t(i)) : next i
        return r
    end function
    public function NextInt () as Int32
        return Int32.Parse(me.NextValue())
    end function
    public function NextLong () as Int64
        return Int64.Parse(me.NextValue())
    end function
    public function NextDouble () as Double
        return Double.Parse(me.NextValue())
    end function
    public function NextString () as String
        return me.NextValue()
    end function
end class

class Program
    shared sub main ()
        dim io as new E512IO(false)' AutoFulsh
        dim n = io.NextInt()
        dim k = io.NextLong()
        dim l as new List(of Int64)
        for i as Int32 = 0 to n - 1
            l.Add(io.NextLong())
        next i
        
        for each i as Int64 in l
            if i = 0 then
                Console.WriteLine(n)
                return
            end if
        next
        
        
        dim left as Int32 = 0
        dim len as Int32  = 0
        
        
        for each i as Int64 in l
            if i <= k then
                len = 1
                exit for
            end if
        next
        
        dim t as Int64  = l(0)
        for i as Int32 = 1 to n - 1
            t *= l(i)
            if t <= k then
                len = Max(len, i-left+1)
            else
                for j as Int32 = left to i - 1
                    t /= l(j)
                    left = j + 1
                    if t <= k then
                        exit for
                    end if
                next j
            end if
        next i
        Console.WriteLine(len)
    end sub
end class

