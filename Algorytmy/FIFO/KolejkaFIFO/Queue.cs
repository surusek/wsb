using System;
using Biblioteka;

namespace KolejkaFIFO
{
    public struct Queue
    {
        public Osoba[] Kolejka;
        public int First;
        public int Last;

        public static void Create(out Queue q, int liczbaElementow)
        {
            q.First = q.Last = -1;
            q.Kolejka = new Osoba[liczbaElementow];
        }

        public static bool IsFull(Queue q)
        {
            return ((q.First == 0 && q.Last == q.Kolejka.Length - 1) || q.First == q.Last + 1);
        }

        public static void Enqueue(ref Queue q, Osoba os)
        {
            if (Queue.IsFull(q)) {
                // Jeśli kolejka jest pełna (użyj funkcji IsFull) to wyrzuć wyjątek InvalidOperationException("Kolejka jest pełna");
                throw new InvalidOperationException("The queue is full");
            }
            else if (q.Last == q.Kolejka.Length - 1) {
                // Jeśli indeks osoby na końcu kolejki(q.Last) jest równy indeksowi końca tablicy(9) to…
                q.Last = 0;
                q.Kolejka[0] = os;
            } 
            else if (q.Last == -1) {
                // Jeśli indeks osoby na końcu kolejki(q.Last) jest równy -1
                q.First = q.Last = 0;
                q.Kolejka[0] = os;
            }
            else {
                ++q.Last;
                q.Kolejka[q.Last] = os;
            }
        }

        public static bool IsEmpty(Queue q)
        {
            return q.First == -1;
        }

        public static Osoba Dequeue(ref Queue q) {
            if (Queue.IsEmpty(q)) 
                throw new InvalidOperationException("The queue is empty");
            
            int idx = q.First;
            if (idx == q.Last)
                q.First = q.Last = -1;
            else if (idx == q.Kolejka.Length - 1)
                q.First = 0;
            else
                ++q.First;

            return q.Kolejka[idx];
        }

        public static void Clear(ref Queue q)
        {
            Queue.Create(out q, q.Kolejka.Length);
        }

        public static Osoba Peek(Queue q)
        {
            if (Queue.IsEmpty(q))
                throw new InvalidOperationException("Kolejka jest pusta");
            return q.Kolejka[q.First];
        }

        public static int GetLength(Queue q)
        {
            if (q.First == -1)
                return 0;
            if (q.First <= q.Last)
                return q.Last - q.First + 1;
            return q.Kolejka.Length - q.First + q.Last + 1;
        }
    }
}
