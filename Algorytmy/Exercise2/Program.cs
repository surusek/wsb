using System;
using System.Collections.Generic;

class Prostokat: IComparable {
    private int m_x, m_y;

    public
    Prostokat(int x, int y) {
        m_x = x;
        m_y = y;
    }

    public int
    CompareTo(object uother) {
        Prostokat other = uother as Prostokat;
        if (other == null)
            throw new ArgumentException("Obiekt nie jest Prostokatem.");

        long f = m_x;
        f *= m_y;
        long of = other.m_x;
        of *= other.m_y;
        if (f < of)
            return 1;
        if (f > of)
            return -1;
        
        return 0;
    }

    public override string
    ToString() {
        return String.Format("{0}x{1}; ", m_x, m_y);
    }
}

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Uses ordered generic dynamic array
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            OrderedDynamicArray<Prostokat> ptab = new OrderedDynamicArray<Prostokat>();

            ptab.Add(new Prostokat(3,4));
            ptab.Add(new Prostokat(5,2));
            ptab.Add(new Prostokat(1, 11));
            ptab.Print();

            Console.ReadKey();
        }
    }
}
