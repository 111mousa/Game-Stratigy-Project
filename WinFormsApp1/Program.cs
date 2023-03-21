using System.Numerics;
using System.Runtime.CompilerServices;
namespace WinFormsApp1
{
    public struct Pair
        {
            public int first, second, pick;
        }
    public class NPotGold
    {
        
        public Pair[,] findMoves(int[] pots)
        {
            int n = pots.Length;
            Pair[,] moves = new Pair [n,n];

            for (int i = 0; i < n; i++)
            {
                moves[i,i].first = pots[i];
                //to track the sequence of moves 
                moves[i,i].pick = i;
            }

            for (int l = 2; l <= n; l++)
            {
                for (int i = 0; i <= n - l; i++)
                {
                    int j = i + l - 1;
                    if (pots[i] + moves[i + 1,j].second > moves[i,j - 1].second + pots[j])
                    {
                        moves[i,j].first = pots[i] + moves[i + 1,j].second;
                        moves[i,j].second = moves[i + 1,j].first;
                        moves[i,j].pick = i;
                    }
                    else
                    {
                        moves[i,j].first = pots[j] + moves[i,j - 1].second;
                        moves[i,j].second = moves[i,j - 1].first;
                        moves[i,j].pick = j;
                    }
                }
            }

            return moves;
        }
        //prints the sequence of values and indexes
        public void printSequence(int[] pots, Pair[,] moves)
        {
            int i = 0, n = pots.Length;
            int j = pots.Length - 1;
            int step,p1=0,p2=0;
            bool flage = false;
            for (int k = 0; k < n; k++)
            {
                step = moves[i,j].pick; 
                //this is the value of pick and its index
                if (flage == false)
                {
                    Program.player1.Add(step);
                    Program.pl1.Enqueue(step);
                    flage = true;
                }
                else
                {
                    Program.player2.Add(step);
                    Program.pl2.Enqueue(step);
                    flage = false;
                }
                if (step <= i)
                {
                    i = i + 1;
                }
                else
                {
                    j = j - 1;
                }
            }
        }
    };
    public static class Program
    {
        public static HashSet<int> player1 = new HashSet<int>();
        public static HashSet<int> player2 = new HashSet<int>();
        public static Queue<int> pl1 = new Queue<int>();
        public static Queue<int> pl2=new Queue<int>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form3());
            
        }
    }
}