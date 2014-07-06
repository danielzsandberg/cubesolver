using RubiksCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TotalMove;

namespace CubeSolver.SystemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int successCount = 0;
            int failureCount = 0;
            
            int trials = 1000;
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < trials; i++)
            {
                tasks.Add(Task.Factory.StartNew((obj) => 
                {
                    RubiksCube cube = new RubiksCube();
                    cube.Shuffle();
                    cube.Run("ZPhaseOne1");
                    bool wasCubeSolved = cube.IsSolved;
                    if (wasCubeSolved)
                    {
                        Interlocked.Increment(ref successCount);
                    }
                    else
                    {
                        Interlocked.Increment(ref failureCount);
                    }
                    int trialNumber = (int)obj;
                    Console.WriteLine("Attempt {0}. Solved: {1}", trialNumber, wasCubeSolved);
                }, i));
            }
            Task.WaitAll(tasks.ToArray(), 90000);

            Console.WriteLine("Success Count: {0} ({1}%)", successCount, ((double)successCount/trials) * 100);
            Console.WriteLine("Failure Count: {0} ({1}%)", failureCount, ((double)failureCount/trials) * 100);
            int inconclusiveCount = trials - successCount - failureCount;
            Console.WriteLine("Didn't Finish: {0} ({1}%)", inconclusiveCount, ((double)inconclusiveCount/trials) * 100);
            Console.WriteLine("Trials: {0}", trials);
            Console.ReadLine();
        }


    }
}
