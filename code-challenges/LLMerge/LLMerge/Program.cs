using System;

namespace LLMerge.Classes
{
    public class Program
    {
        static -void Main(string[] args)
        {
            LinkedList ll1 = new LinkedList();
            LinkedList ll2 = new LinkedList();

            for(int i=2; i<6; i++)
            {
                ll1.Append(i);
                ll2.Append(Convert.ToInt32(Math.Pow(i, 2)));
            }

            LinkedList result = MergeLists(ll1, ll2);
        }

        public static LinkedList MergeLists(LinkedList a, LinkedList b)
        {
            LinkedList mergedLL = new LinkedList();
            a.Current = a.Head;
            b.Current = b.Head;
            while(a.Current != null && b.Current != null)
            {
                mergedLL.Append(a.Current.Value);
                mergedLL.Append(b.Current.Value);
                a.Current = a.Current.Next;
                b.Current = b.Current.Next;
            }
            while(a.Current != null)
            {
                mergedLL.Append(a.Current.Value);
                a.Current = a.Current.Next;
            }
            while(b.Current != null)
            {
                mergedLL.Append(b.Current.Value);
                b.Current = b.Current.Next;
            }

            return mergedLL;
        }
    }
}
