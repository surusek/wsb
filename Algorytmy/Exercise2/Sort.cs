using System;

class CQuickSort {
    public static void
    Swap(int[] tab, int l, int r)
    {
        int tmp = tab[l];
        tab[l] = tab[r];
        tab[r] = tmp;

        Console.WriteLine(String.Format("tab[{0}] <=> tab[{1}]", l, r));
    }

    public static int 
    Partition(int[] a, int p, int r)
    {
        int x = a[p];
        int i = p - 1, j = r + 1;

        for (;;) {
            while (a[--j] > x) 
                ;
            while (a[++i] < x) 
                ;
            if (i < j)
                Swap(a, i, j);
            else
                return j;
        }
    }


    public static void 
    QuickSort(int[] a, int p, int r) 
    {
        if (p < r) {
            int q = Partition(a, p, r);
            QuickSort(a, p, q);
            QuickSort(a, q + 1, r);
        }
    }

    public static void 
    Main() 
    {
        int[] a = { 6, 5, 4, 3, 2, 1, 9, 8, 7 };
        QuickSort(a, 0, 8);
    }
}