using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZZFront2LayerGoDouble : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZFront2LayerGoDouble"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Front Two-layer Double"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);

        }
    }
}
