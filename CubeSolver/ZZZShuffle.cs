using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZZZShuffle : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZZZShuffle"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Shuffle"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            int rgr = 1;

            do
            {
                rgr++;

                {
                    cube.Shuffle();
                    cube.Run("ZZAutomatic");
                }
            } while (rgr < 5);
        }
    }
}
