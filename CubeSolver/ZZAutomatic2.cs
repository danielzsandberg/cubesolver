using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZZAutomatic2 : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZZAutomatic2"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Two Codes"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.Run("ZPhaseOne1");
            cube.Run("ZPhasePTwo2");

        }
    }
}
