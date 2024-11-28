using System;

namespace hedgehogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hedg = {100,10,7};
            int result = GetMinNumberOfMeeting(0, hedg);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int GetMinNumberOfMeeting(int color, int[] hedgehogs)
        {
            int zeroValue = 0;
            foreach(int hedgehog in hedgehogs)
            {
                if (hedgehog == 0) zeroValue++;
            }
            if (zeroValue > 1) return -1;
            int[] choice = new int[2];
            int j = 0;
            for (int i = 0; i < hedgehogs.Length; i++)
            {
                if (i == color) continue;
                else
                {
                    choice[j] = hedgehogs[i];
                    j++;
                }
            }

            return Math.Max(choice[0], choice[1]);
        }
    }
}
