using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZZFront2LayerGoRight : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZFront2LayerGoRight"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Front Two-layer Go Right"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);

        }
    }
}B
