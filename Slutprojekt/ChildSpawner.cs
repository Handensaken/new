using System;

namespace Slutprojekt
{
    public class ChildSpawner
    {
        static Random rand = new Random();
        static public Child SpawnChild()
        {
            int iq = rand.Next(40, 200);    // 110 normal | 150 gifted | 70 low
            int phy = rand.Next(10, 200);   //70 normal | 130 gifted | 30 low
            
            int iqGifted = 150;
            int iqLow = 70;

            int phyGifted = 130;
            int phyLow = 30;

            if (iq >= iqGifted && phy >= phyGifted)
            {
                System.Console.WriteLine("prodigy");
                return new ProdigousChild();
            }
            else if (iq >= iqGifted && phy <= phyGifted)
            {
                System.Console.WriteLine("intelligent");
                return new IntelligentChild();
            }
            else if (iq >= iqLow && iq <= iqGifted && phy >= phyLow && phy <= phyGifted)
            {
                System.Console.WriteLine("normal");
                return new NormalChild();
            }
            else if (phy >= phyGifted)
            {
                System.Console.WriteLine("chonky");
                return new ChonkyChild();
            }
            else{
                System.Console.WriteLine("lost cause");
                return new LostCauseChild();
            }
        }
    }
}
