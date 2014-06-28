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
            get { return "ZFront2-LayerGoRight"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Two-layerA total move"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);

        }
    }
}
